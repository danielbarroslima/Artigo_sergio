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
    public partial class ListaRevisao : Form
    {
        public string aguarde = "Aguardando";
        public string UsuarioSelecionado = "";
        public ListaRevisao()
        {
            InitializeComponent();
        }



        private void ListaRevisao_Load(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;
            //Buscar todos artigos cadastrados
            string sql = "Select * from artigo where feedback ='" + aguarde + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dtgrdRev.DataSource = dt;
            }
        }

        private void dtgrdRev_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Recuperar a linha selecionadas.
            UsuarioSelecionado = dtgrdRev.Rows[e.RowIndex].Cells[0].Value.ToString();

            //Fechar a tela
            Hide();
        }
    }
}
