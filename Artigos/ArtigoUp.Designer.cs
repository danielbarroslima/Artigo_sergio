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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.rdioPostar = new System.Windows.Forms.RadioButton();
            this.rdioUploadRev = new System.Windows.Forms.RadioButton();
            this.btnCancela = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblNomelog = new System.Windows.Forms.Label();
            this.lblIdent = new System.Windows.Forms.Label();
            this.txtfeed = new System.Windows.Forms.TextBox();
            this.lblFeed = new System.Windows.Forms.Label();
            this.lblNArtigo = new System.Windows.Forms.Label();
            this.lblNumArt = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTopico1
            // 
            this.lblTopico1.AutoSize = true;
            this.lblTopico1.Location = new System.Drawing.Point(13, 13);
            this.lblTopico1.Name = "lblTopico1";
            this.lblTopico1.Size = new System.Drawing.Size(131, 13);
            this.lblTopico1.TabIndex = 0;
            this.lblTopico1.Text = "Insira aqui seu novo artigo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 287);
            this.textBox1.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(505, 308);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Submeter";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // rdioPostar
            // 
            this.rdioPostar.AutoSize = true;
            this.rdioPostar.Location = new System.Drawing.Point(168, 11);
            this.rdioPostar.Name = "rdioPostar";
            this.rdioPostar.Size = new System.Drawing.Size(55, 17);
            this.rdioPostar.TabIndex = 3;
            this.rdioPostar.TabStop = true;
            this.rdioPostar.Text = "Postar";
            this.rdioPostar.UseVisualStyleBackColor = true;
            // 
            // rdioUploadRev
            // 
            this.rdioUploadRev.AutoSize = true;
            this.rdioUploadRev.Location = new System.Drawing.Point(255, 11);
            this.rdioUploadRev.Name = "rdioUploadRev";
            this.rdioUploadRev.Size = new System.Drawing.Size(101, 17);
            this.rdioUploadRev.TabIndex = 4;
            this.rdioUploadRev.TabStop = true;
            this.rdioUploadRev.Text = "Upload Revisão";
            this.rdioUploadRev.UseVisualStyleBackColor = true;
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(389, 308);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 5;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(596, 44);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Atualizar meus dados ";
            // 
            // lblNomelog
            // 
            this.lblNomelog.AutoSize = true;
            this.lblNomelog.Location = new System.Drawing.Point(569, 13);
            this.lblNomelog.Name = "lblNomelog";
            this.lblNomelog.Size = new System.Drawing.Size(28, 13);
            this.lblNomelog.TabIndex = 7;
            this.lblNomelog.Text = ".......";
            // 
            // lblIdent
            // 
            this.lblIdent.AutoSize = true;
            this.lblIdent.Location = new System.Drawing.Point(501, 13);
            this.lblIdent.Name = "lblIdent";
            this.lblIdent.Size = new System.Drawing.Size(23, 13);
            this.lblIdent.TabIndex = 8;
            this.lblIdent.Text = "Olá";
            // 
            // txtfeed
            // 
            this.txtfeed.Location = new System.Drawing.Point(395, 126);
            this.txtfeed.Multiline = true;
            this.txtfeed.Name = "txtfeed";
            this.txtfeed.Size = new System.Drawing.Size(152, 154);
            this.txtfeed.TabIndex = 9;
            // 
            // lblFeed
            // 
            this.lblFeed.AutoSize = true;
            this.lblFeed.Location = new System.Drawing.Point(392, 98);
            this.lblFeed.Name = "lblFeed";
            this.lblFeed.Size = new System.Drawing.Size(56, 13);
            this.lblFeed.TabIndex = 10;
            this.lblFeed.Text = "FeedBack";
            // 
            // lblNArtigo
            // 
            this.lblNArtigo.AutoSize = true;
            this.lblNArtigo.Location = new System.Drawing.Point(580, 131);
            this.lblNArtigo.Name = "lblNArtigo";
            this.lblNArtigo.Size = new System.Drawing.Size(80, 13);
            this.lblNArtigo.TabIndex = 11;
            this.lblNArtigo.Text = "Nome do Artigo";
            this.lblNArtigo.Click += new System.EventHandler(this.lblNArtigo_Click);
            // 
            // lblNumArt
            // 
            this.lblNumArt.AutoSize = true;
            this.lblNumArt.Location = new System.Drawing.Point(580, 193);
            this.lblNumArt.Name = "lblNumArt";
            this.lblNumArt.Size = new System.Drawing.Size(89, 13);
            this.lblNumArt.TabIndex = 12;
            this.lblNumArt.Text = "Numero do Artigo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(583, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(583, 218);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // ArtigoUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 357);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNumArt);
            this.Controls.Add(this.lblNArtigo);
            this.Controls.Add(this.lblFeed);
            this.Controls.Add(this.txtfeed);
            this.Controls.Add(this.lblIdent);
            this.Controls.Add(this.lblNomelog);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.rdioUploadRev);
            this.Controls.Add(this.rdioPostar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTopico1);
            this.Name = "ArtigoUp";
            this.Text = "ArtigoUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopico1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rdioPostar;
        private System.Windows.Forms.RadioButton rdioUploadRev;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblNomelog;
        private System.Windows.Forms.Label lblIdent;
        private System.Windows.Forms.TextBox txtfeed;
        private System.Windows.Forms.Label lblFeed;
        private System.Windows.Forms.Label lblNArtigo;
        private System.Windows.Forms.Label lblNumArt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}