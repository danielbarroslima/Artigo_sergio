using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Artigos
{
    public partial class Dashboard : Form
    {
            //1 - Autores
            //2 - Revisores
            //3 - Gerente
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var frmLogin = new Login();
            frmLogin.ShowDialog();

            if (Login.perfilUsuario == 3)
            {

                button1.Enabled = true;
                button2.Enabled = true;

            }
            else if (Login.perfilUsuario == 2) {
                button2.Enabled = true;


            }

            if (frmLogin.logado == false) {
                Close();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cad = new Cadastrar();
            cad.ShowDialog();
        }

        private void btnCadastrarArtigo_Click(object sender, EventArgs e)
        {
            var artp = new ArtigoUp();
            artp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var artr = new RevisarArt();
            artr.ShowDialog();
        }
    }
}
