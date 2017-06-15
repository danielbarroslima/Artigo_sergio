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
    public partial class listaArtigo : Form
    {
        public string revisao = "A melhorar", visto="visto";
        public string UsuarioSelecionado = "";
        
        public listaArtigo()
        {
            InitializeComponent();
        }

        private void btnfeedar_Click(object sender, EventArgs e)
        {
            

            var conn = Login.ConnectOpen;
            //Buscar todos usuários cadastrados
            string sql = "Select * from artigo where aceito = '" + visto + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dtgridArt.DataSource = dt;
            }
        }

        private void dtgridArt_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Recuperar a linha selecionadas.
            UsuarioSelecionado = dtgridArt.Rows[e.RowIndex].Cells[0].Value.ToString();

            //Fechar a tela
            Hide();
        }



        private void listaArtigo_Load(object sender, EventArgs e)
        {

        }

        private void btnFeedArt_Click(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;
            //Buscar todos usuários cadastrados
            string sql = "Select * from artigo where feedback ='" + revisao + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dtgridArt.DataSource = dt;
            }
        }
    }
}
