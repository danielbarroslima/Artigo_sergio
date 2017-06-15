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
        public string UsuarioSelecionado = "";
        public ListaRevisao()
        {
            InitializeComponent();
        }



        private void ListaRevisao_Load(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;
            //Buscar todos usuários cadastrados
            string sql = "Select * from artigo ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dtgrdRev.DataSource = dt;
            }
        }
    }
}
