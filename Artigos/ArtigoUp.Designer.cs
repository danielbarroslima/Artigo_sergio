namespace Artigos
{
    partial class ArtigoUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTopico1 = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.rdioPostar = new System.Windows.Forms.RadioButton();
            this.rdioUploadRev = new System.Windows.Forms.RadioButton();
            this.btnCancela = new System.Windows.Forms.Button();
            this.lblNomelog = new System.Windows.Forms.Label();
            this.lblIdent = new System.Windows.Forms.Label();
            this.lblNArtigo = new System.Windows.Forms.Label();
            this.lblNumArt = new System.Windows.Forms.Label();
            this.txtNArt = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnfeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTopico1
            // 
            this.lblTopico1.AutoSize = true;
            this.lblTopico1.Location = new System.Drawing.Point(12, 13);
            this.lblTopico1.Name = "lblTopico1";
            this.lblTopico1.Size = new System.Drawing.Size(131, 13);
            this.lblTopico1.TabIndex = 0;
            this.lblTopico1.Text = "Insira aqui seu novo artigo";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(16, 78);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(517, 287);
            this.txtConteudo.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(631, 328);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Submeter";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rdioPostar
            // 
            this.rdioPostar.AutoSize = true;
            this.rdioPostar.Location = new System.Drawing.Point(157, 9);
            this.rdioPostar.Name = "rdioPostar";
            this.rdioPostar.Size = new System.Drawing.Size(55, 17);
            this.rdioPostar.TabIndex = 3;
            this.rdioPostar.TabStop = true;
            this.rdioPostar.Text = "Postar";
            this.rdioPostar.UseVisualStyleBackColor = true;
            this.rdioPostar.CheckedChanged += new System.EventHandler(this.rdioPostar_CheckedChanged);
            // 
            // rdioUploadRev
            // 
            this.rdioUploadRev.AutoSize = true;
            this.rdioUploadRev.Location = new System.Drawing.Point(250, 9);
            this.rdioUploadRev.Name = "rdioUploadRev";
            this.rdioUploadRev.Size = new System.Drawing.Size(101, 17);
            this.rdioUploadRev.TabIndex = 4;
            this.rdioUploadRev.TabStop = true;
            this.rdioUploadRev.Text = "Upload Revisão";
            this.rdioUploadRev.UseVisualStyleBackColor = true;
            this.rdioUploadRev.CheckedChanged += new System.EventHandler(this.rdioUploadRev_CheckedChanged);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(539, 328);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 5;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // lblNomelog
            // 
            this.lblNomelog.AutoSize = true;
            this.lblNomelog.Location = new System.Drawing.Point(653, 43);
            this.lblNomelog.Name = "lblNomelog";
            this.lblNomelog.Size = new System.Drawing.Size(28, 13);
            this.lblNomelog.TabIndex = 7;
            this.lblNomelog.Text = ".......";
            this.lblNomelog.Click += new System.EventHandler(this.lblNomelog_Click);
            // 
            // lblIdent
            // 
            this.lblIdent.AutoSize = true;
            this.lblIdent.Location = new System.Drawing.Point(585, 43);
            this.lblIdent.Name = "lblIdent";
            this.lblIdent.Size = new System.Drawing.Size(23, 13);
            this.lblIdent.TabIndex = 8;
            this.lblIdent.Text = "Olá";
            // 
            // lblNArtigo
            // 
            this.lblNArtigo.AutoSize = true;
            this.lblNArtigo.Location = new System.Drawing.Point(13, 39);
            this.lblNArtigo.Name = "lblNArtigo";
            this.lblNArtigo.Size = new System.Drawing.Size(80, 13);
            this.lblNArtigo.TabIndex = 11;
            this.lblNArtigo.Text = "Nome do Artigo";
            this.lblNArtigo.Click += new System.EventHandler(this.lblNArtigo_Click);
            // 
            // lblNumArt
            // 
            this.lblNumArt.AutoSize = true;
            this.lblNumArt.Location = new System.Drawing.Point(583, 159);
            this.lblNumArt.Name = "lblNumArt";
            this.lblNumArt.Size = new System.Drawing.Size(89, 13);
            this.lblNumArt.TabIndex = 12;
            this.lblNumArt.Text = "Numero do Artigo";
            // 
            // txtNArt
            // 
            this.txtNArt.Location = new System.Drawing.Point(572, 193);
            this.txtNArt.Name = "txtNArt";
            this.txtNArt.Size = new System.Drawing.Size(100, 20);
            this.txtNArt.TabIndex = 14;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(112, 36);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(336, 20);
            this.txtTitulo.TabIndex = 16;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pesquisa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnfeed
            // 
            this.btnfeed.Location = new System.Drawing.Point(572, 252);
            this.btnfeed.Name = "btnfeed";
            this.btnfeed.Size = new System.Drawing.Size(100, 23);
            this.btnfeed.TabIndex = 18;
            this.btnfeed.Text = "Feedback";
            this.btnfeed.UseVisualStyleBackColor = true;
            this.btnfeed.Click += new System.EventHandler(this.btnfeed_Click);
            // 
            // ArtigoUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 395);
            this.Controls.Add(this.btnfeed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNArt);
            this.Controls.Add(this.lblNumArt);
            this.Controls.Add(this.lblNArtigo);
            this.Controls.Add(this.lblIdent);
            this.Controls.Add(this.lblNomelog);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.rdioUploadRev);
            this.Controls.Add(this.rdioPostar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.lblTopico1);
            this.Name = "ArtigoUp";
            this.Text = "ArtigoUp";
            this.Load += new System.EventHandler(this.ArtigoUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopico1;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rdioPostar;
        private System.Windows.Forms.RadioButton rdioUploadRev;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Label lblNomelog;
        private System.Windows.Forms.Label lblIdent;
        private System.Windows.Forms.Label lblNArtigo;
        private System.Windows.Forms.Label lblNumArt;
        private System.Windows.Forms.TextBox txtNArt;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnfeed;
    }
}