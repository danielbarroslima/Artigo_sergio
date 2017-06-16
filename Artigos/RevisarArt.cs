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
        DateTime locaDate = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));

        public bool logado = false;
        private Conexao conn;
        private SqlConnection ConnectOpen;
        public static string seleccionado { get; set; }

        public int rec = 0, ac = 0, cont=0;
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

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
         

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
            if (lblIDart.Text=="...")
            {
                MessageBox.Show("Por favor escolha um artigo na lista acima !!");
                rdAceite.Checked = false;
                rdiorecusa.Checked = false;
                rdiorecusa.Visible = true;
                rdAceite.Visible = true;
                lblEscolha.Visible = true;
                lblaceitar.Visible = true;
                lblrecusar.Visible = true;
                rdio1.Checked = false;
                rdio2.Checked = false;
                rdio3.Checked = false;
            }
            else if (ac == 0 && rec == 0)
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
            else if (ac>0 && txttituloR.Text != "" && txtconteudoR.Text != "")
            {

                btnOks.Text = "Atualizar";
                lblMotivo.Text = "Feedback";
                MessageBox.Show("Insira um feedback por favor ");
                txtfeedMot.Visible = true;
                lblDe.Visible = true;
                lblMotivo.Visible = true;
                

                if (lblMotivo.Text == "Feedback" && txtfeedMot.Text != "" && nota != "")
                {
                    cont = 1;
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
            if (cont==1)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into revisores (art_revisado, revisor, motivo, dia)");
                sql.Append("Values (@art_revisado, @revisor, @motivo, @dia )");
                SqlCommand command = null;

                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@art_revisado", lblIDart.Text));
                    command.Parameters.Add(new SqlParameter("@revisor", lblidentRev.Text));
                    command.Parameters.Add(new SqlParameter("@motivo", txtfeedMot.Text));
                    command.Parameters.Add(new SqlParameter("@dia", locaDate));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Motivo informado com sucesso !!!");
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com seu motivo" + ex);

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
            if (rdiorecusa.Checked==true && lblIDart.Text!="...")
            {
                rdAceite.Checked = false;
                rdiorecusa.Checked = false;
                rdiorecusa.Visible = false;
                rdAceite.Visible = false;
                lblEscolha.Visible = false;
                lblaceitar.Visible = false;
                lblrecusar.Visible = false;
                rdio1.Visible = false;
                rdio2.Visible = false;
                rdio3.Visible = false;
                lblMotivo.Text = "Motivo";
                txtfeedMot.Visible = true;
                lblDe.Visible = true;
                lblMotivo.Visible = true;
                btnOks.Text = "inf.Motivo";


            }
            if (btnOks.Text=="inf.Motivo")
            {
                MessageBox.Show("Insira um motivo por favor ");

                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into revisores (art_revisado, revisor, motivo, dia)");
                sql.Append("Values (@art_revisado, @revisor, @motivo, @dia )");
                SqlCommand command = null;

                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@art_revisado", lblIDart.Text));
                    command.Parameters.Add(new SqlParameter("@revisor", lblidentRev.Text));
                    command.Parameters.Add(new SqlParameter("@motivo", txtfeedMot.Text));
                    command.Parameters.Add(new SqlParameter("@dia", locaDate));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Motivo informado com sucesso !!!");
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro com seu motivo" + ex);

                }

                saveFileDialog1.Filter = "Arquivo de texto | *txt";

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
