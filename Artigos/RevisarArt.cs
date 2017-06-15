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
        public int rec = 0, ac = 0;
        
        public RevisarArt()
        {
            InitializeComponent();
        }

        private void RevisarArt_Load(object sender, EventArgs e)
        {

        }

        private void lblaceitar_Click(object sender, EventArgs e)
        {

        }

        private void rdAceite_CheckedChanged(object sender, EventArgs e)
        {
            ac = 1;
            rec = 0;
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

            //Linha 0, coluna 0
            txttituloR.Text = dt.Rows[0][1].ToString();


            txtconteudoR.Text = dt.Rows[0][2].ToString();
        }

        private void btnOks_Click(object sender, EventArgs e)
        {
            if (ac==1)
            {
                lblMotivo.Text = "Feedback";
                MessageBox.Show("Insira um feedback por favor ");
                txtfeedMot.Visible = true;
            }
            if (rec==1)
            {
                lblMotivo.Text = "Motivo";
                MessageBox.Show("Insira um motivo por favor ");
                txtfeedMot.Visible = true;
            }
        }

        private void rdiorecusa_CheckedChanged(object sender, EventArgs e)
        {
            rec = 1;
            ac = 0;
        }
    }
}
