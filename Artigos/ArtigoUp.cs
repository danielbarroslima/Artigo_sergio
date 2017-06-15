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

namespace Artigos
{
    public partial class ArtigoUp : Form
    {
        public int rev = 0, rd = 0 ;
        public string txP, aguarde="Aguardando";
        public bool logado = false;
        private Conexao conn;
        private SqlConnection ConnectOpen;
        public static string seleccionado { get; set; }
        public ArtigoUp()
        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
        }

        private void lblNArtigo_Click(object sender, EventArgs e)
        {

        }

        private void ArtigoUp_Load(object sender, EventArgs e)
        {
            var identidade = Login.Usuario;
            lblNomelog.Text = identidade;

        }
        private void LimparTela()
        {
           
            txtConteudo.Text = "";
            txtTitulo.Text = "";
            lblNart.Text = "";

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rev == 1)
            {

                

                StringBuilder sql = new StringBuilder();
                sql.Append("update artigo set titulo = @titulo, conteudo = @conteudo, aceito = @aceito, feedback = @feedback, autor = @autor where id = @id");


                SqlCommand command = null;


                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@titulo", txtTitulo.Text));
                command.Parameters.Add(new SqlParameter("@conteudo", txtConteudo.Text));
                command.Parameters.Add(new SqlParameter("@aceito",aguarde));
                command.Parameters.Add(new SqlParameter("@feedback", aguarde));
                command.Parameters.Add(new SqlParameter("@autor", lblNomelog.Text));
                command.Parameters.Add(new SqlParameter("@id", lblNart.Text));
             
                command.ExecuteNonQuery();

                MessageBox.Show("Alterado com sucesso!");
                LimparTela();
             }
            else
            {
                //incluir o using System.Text
                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into artigo (titulo , conteudo, feedback, autor, aceito)");
                sql.Append("Values (@titulo, @conteudo, @feedback, @autor, @aceito )");
                SqlCommand command = null;

                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@titulo", txtTitulo.Text));
                    command.Parameters.Add(new SqlParameter("@conteudo", txtConteudo.Text));
                    command.Parameters.Add(new SqlParameter("@feedback", aguarde));
                    command.Parameters.Add(new SqlParameter("@autor", lblNomelog.Text));
                    command.Parameters.Add(new SqlParameter("@aceito",aguarde));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cadastrado com sucesso!");
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Inserir Artigo" + ex);

                }
            }
        }

        private void lblNomelog_Click(object sender, EventArgs e)
        {  

        }

        private void rdioPostar_CheckedChanged(object sender, EventArgs e)
        {
            rd = 1;
            rev = 0;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            txP = txtTitulo.Text;
        }



        private void btnfeed_Click(object sender, EventArgs e)
        {
            
            var artup = new listaArtigo();
            artup.ShowDialog();


            //Verificar se foi selecionado algum item
            if (artup.UsuarioSelecionado == "")
                return;

            var conn = Login.ConnectOpen;
            //Buscar usuário selecionado
            string sql = "Select * from artigo where Id = '" + artup.UsuarioSelecionado + "'";

            btnOk.Text = "update de artigo";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            lblNart.Text = dt.Rows[0][0].ToString();
            //Linha 0, coluna 1
           txtTitulo.Text = dt.Rows[0][1].ToString();

            //Linha 0, coluna 2
           txtConteudo.Text = dt.Rows[0][2].ToString();



        }



        private void rdioUploadRev_CheckedChanged(object sender, EventArgs e)
        {
            rev = 1;

            rd = 0;
        }
    }
}
