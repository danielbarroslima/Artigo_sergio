﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Artigos
{
    public partial class Login : Form
    {
        public bool logado = false;
        private Conexao conn;
        public static MySqlConnection ConnectOpen;
        public static int perfilUsuario;

        public Login()
        {
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string strCommand = "Select * from usuarios where usuario = '" + txtUsuario.Text + "' and " + "Senha = '" + txtSenha.Text + "'";
            DataTable dt = new DataTable();
            //MySqlDataAdapter da = new MySqlDataAdapter(strCommand, ConnectOpen);
            //da.Fill(dt);


            var _conn = ConnectOpen;
            var _cmd = new MySqlCommand
            {
                Connection = _conn,
                CommandText = strCommand
            };

            _cmd.ExecuteNonQuery();

            MySqlDataAdapter _da = new MySqlDataAdapter(_cmd);

            _da.Fill(dt);




            if (dt.Rows.Count > 0)
            {
                this.Hide();
                logado = true;
                perfilUsuario = Convert.ToInt16(dt.Rows[0][2]);
            }
            else
                MessageBox.Show("Usuário ou senha incorreto(s)!");

        }

        private void Focus(object sender, EventArgs e)
        {
            var btn = (TextBox)sender;
            btn.Text = string.Empty;
            btn.ForeColor = Color.Black;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.GotFocus += Focus;
            txtSenha.GotFocus += Focus;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Cadastrar();
            frm.ShowDialog();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
