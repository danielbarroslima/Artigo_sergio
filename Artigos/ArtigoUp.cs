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
        public int rev = 0, rd = 0;
        public string txP;
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
            btnOk.Text = "Submeter";
            txtConteudo.Text = "";
            txtNArt.Text = "";
            txtNArt.Text = "";
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == "alterar")
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" update usuarios set ");
                sql.Append(" senha = @senha, ");
                sql.Append(" perfil = @perfil "); //Não esqueçam de dar um espaço no final 
                sql.Append(" where usuario = @usuario");

                SqlCommand command = null;
                

                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@conteudo", txtConteudo.Text));
                command.Parameters.Add(new SqlParameter("@titulo", txtTitulo));
              //  command.Parameters.Add(new SqlParameter("@autor", lblNomelog.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Alterado com sucesso!");
                LimparTela();
            }
            else
            {
                //incluir o using System.Text
                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into artigo (titulo , conteudo, feedback, n_artigo)");
                sql.Append("Values (@titulo, @conteudo, @feedback, @n_artigo)");
                SqlCommand command = null;

                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@titulo", txtTitulo.Text));
                    command.Parameters.Add(new SqlParameter("@conteudo", txtConteudo.Text));
                    command.Parameters.Add(new SqlParameter("@feedback", Convert.ToString(cmbFeed.Text)));
                    command.Parameters.Add(new SqlParameter("@n_artigo", txtNArt.Text));
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
            //selecionar no banco 
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            txP = txtTitulo.Text;
        }

        private void cmbFeed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdioUploadRev_CheckedChanged(object sender, EventArgs e)
        {
            rev = 1;

            rd = 0;
        }
    }
}
