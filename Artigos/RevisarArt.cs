using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;



namespace Artigos
{
    public partial class RevisarArt : Form
    {
        public bool logado = false;
        private Conexao conn;
        private SqlConnection ConnectOpen;
        public static string seleccionado { get; set; }

        public int rec = 0, ac = 0;
        public string nota="", bom = "Bom", ruim = "A melhorar", mbom = "Muito bom" , aguarde="visto" ;
        public RevisarArt()
        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
        }

        private void RevisarArt_Load(object sender, EventArgs e)
        {
            var identidade = Login.Usuario;
            lblidentRev.Text = identidade;
        }

        private void lblaceitar_Click(object sender, EventArgs e)
        {

        }

        private void rdAceite_CheckedChanged(object sender, EventArgs e)
        {
            if (txttituloR.Text== "" || txtconteudoR.Text=="")
            {
                ac = 0;
                rdAceite.Checked = false;
                MessageBox.Show("Verifique se esqueceu titulo ou conteúdo por favor !!");
            }
            else
            {
                ac = 1;
                rec = 0;
                lblrecusar.Visible = false;
                lblEscolha.Visible = false;
                lblaceitar.Visible = false;
                rdAceite.Visible = false;
                rdiorecusa.Visible = false;
            }
          


        }

        private void btnListRev_Click(object sender, EventArgs e)
        {
            var listRevisao = new ListaRevisao();
           listRevisao.ShowDialog();

            //Verificar se foi selecionado algum item
            if (listRevisao.UsuarioSelecionado == "")
                return;

            var conn = Login.ConnectOpen;
            //Buscar usuário selecionado
            string sql = "Select * from artigo where Id = '" + listRevisao.UsuarioSelecionado + "'";


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

             lblIDart.Text = dt.Rows[0][0].ToString();
          
            txttituloR.Text = dt.Rows[0][1].ToString();


            txtconteudoR.Text = dt.Rows[0][2].ToString();
        }


        private void btnOks_Click(object sender, EventArgs e)
        {
            if (ac == 0 && rec == 0)
            {
                MessageBox.Show("É preciso fazer uma escolha!!");
            }
            else if (txttituloR.Text == "" || txtconteudoR.Text == "")
            {
                MessageBox.Show("É preciso algo para se avaliar ");
                txtfeedMot.Visible = false;
                lblDe.Visible = false;
                lblMotivo.Visible = false;
            }
            else if (ac > 0 && txttituloR.Text != "" && txtconteudoR.Text != "")
            {


                lblMotivo.Text = "Feedback";

                MessageBox.Show("Insira um feedback por favor ");
                txtfeedMot.Visible = true;
                lblDe.Visible = true;
                lblMotivo.Visible = true;
                btnOks.Text = "Atualizar";

                if (lblMotivo.Text == "Feedback" && txtfeedMot.Text != "" && nota != "")
                {
                    try
                    {
                        StringBuilder sql = new StringBuilder();
                        sql.Append("update artigo set titulo = @titulo, conteudo = @conteudo, feedback = @feedback, aceito = @aceito where id = @id");

                        SqlCommand command = null;


                        command = new SqlCommand(sql.ToString(), ConnectOpen);
                        command.Parameters.Add(new SqlParameter("@titulo", txttituloR.Text));
                        command.Parameters.Add(new SqlParameter("@conteudo", txtconteudoR.Text));
                        command.Parameters.Add(new SqlParameter("@feedback", nota));
                        command.Parameters.Add(new SqlParameter("@aceito", aguarde));
                        command.Parameters.Add(new SqlParameter("@id", Convert.ToInt16(lblIDart.Text)));

                        command.ExecuteNonQuery();

                        MessageBox.Show("Alterado com sucesso!");
                        // LimparTela();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao atualizar Artigo" + ex);
                    }



                }
            }
            else if (rec == 1)
            {
                lblMotivo.Text = "Motivo";
                MessageBox.Show("Insira um motivo por favor ");
                txtfeedMot.Visible = true;
                lblDe.Visible = true;
                lblMotivo.Visible = true;
            }
            if (lblMotivo.Text == "Feedback" && txtfeedMot.Text!="" )
            {
            
            }


   
           

            
  
        }

        private void rdio3_CheckedChanged(object sender, EventArgs e)
        {
            nota = ruim;
        }

        private void rdio2_CheckedChanged(object sender, EventArgs e)
        {
            nota = bom;
        }

        private void rdio1_CheckedChanged(object sender, EventArgs e)
        {
            nota = mbom;
        }

        private void rdiorecusa_CheckedChanged(object sender, EventArgs e)
        {
            if (txttituloR.Text == "" || txtconteudoR.Text == "")
            {
                if(ac==1){
                    rec = 0;
                    rdAceite.Checked = false;
                    MessageBox.Show("Verifique se esqueceu titulo ou conteúdo por favor !!");
                }
            }

            else
            {

                rec = 1;
                ac = 0;
                lblrecusar.Visible = false;
                lblEscolha.Visible = false;
                lblaceitar.Visible = false;
                rdAceite.Visible = false;
                rdiorecusa.Visible = false;
            }

        }
    }
}
