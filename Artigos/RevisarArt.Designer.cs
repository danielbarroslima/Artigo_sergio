namespace Artigos
{
    partial class RevisarArt
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
            this.lblRevise = new System.Windows.Forms.Label();
            this.txtconteudoR = new System.Windows.Forms.TextBox();
            this.rdio1 = new System.Windows.Forms.RadioButton();
            this.rdio2 = new System.Windows.Forms.RadioButton();
            this.rdio3 = new System.Windows.Forms.RadioButton();
            this.lblaceitar = new System.Windows.Forms.Label();
            this.lblrecusar = new System.Windows.Forms.Label();
            this.rdAceite = new System.Windows.Forms.RadioButton();
            this.rdiorecusa = new System.Windows.Forms.RadioButton();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtfeedMot = new System.Windows.Forms.TextBox();
            this.btnOks = new System.Windows.Forms.Button();
            this.btnListRev = new System.Windows.Forms.Button();
            this.txttituloR = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblideRev = new System.Windows.Forms.Label();
            this.lblidentRev = new System.Windows.Forms.Label();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblArti = new System.Windows.Forms.Label();
            this.lblIDart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRevise
            // 
            this.lblRevise.AutoSize = true;
            this.lblRevise.Location = new System.Drawing.Point(10, 9);
            this.lblRevise.Name = "lblRevise";
            this.lblRevise.Size = new System.Drawing.Size(136, 13);
            this.lblRevise.TabIndex = 0;
            this.lblRevise.Text = "Revise o artigo que desejar";
            // 
            // txtconteudoR
            // 
            this.txtconteudoR.Location = new System.Drawing.Point(150, 52);
            this.txtconteudoR.Multiline = true;
            this.txtconteudoR.Name = "txtconteudoR";
            this.txtconteudoR.Size = new System.Drawing.Size(549, 254);
            this.txtconteudoR.TabIndex = 8;
            // 
            // rdio1
            // 
            this.rdio1.AutoSize = true;
            this.rdio1.Location = new System.Drawing.Point(590, 312);
            this.rdio1.Name = "rdio1";
            this.rdio1.Size = new System.Drawing.Size(75, 17);
            this.rdio1.TabIndex = 11;
            this.rdio1.TabStop = true;
            this.rdio1.Text = "Muito Bom";
            this.rdio1.UseVisualStyleBackColor = true;
            this.rdio1.CheckedChanged += new System.EventHandler(this.rdio1_CheckedChanged);
            // 
            // rdio2
            // 
            this.rdio2.AutoSize = true;
            this.rdio2.Location = new System.Drawing.Point(428, 312);
            this.rdio2.Name = "rdio2";
            this.rdio2.Size = new System.Drawing.Size(66, 17);
            this.rdio2.TabIndex = 12;
            this.rdio2.TabStop = true;
            this.rdio2.Text = "Mediano";
            this.rdio2.UseVisualStyleBackColor = true;
            this.rdio2.CheckedChanged += new System.EventHandler(this.rdio2_CheckedChanged);
            // 
            // rdio3
            // 
            this.rdio3.AutoSize = true;
            this.rdio3.Location = new System.Drawing.Point(266, 312);
            this.rdio3.Name = "rdio3";
            this.rdio3.Size = new System.Drawing.Size(49, 17);
            this.rdio3.TabIndex = 13;
            this.rdio3.TabStop = true;
            this.rdio3.Text = "Ruim";
            this.rdio3.UseVisualStyleBackColor = true;
            this.rdio3.CheckedChanged += new System.EventHandler(this.rdio3_CheckedChanged);
            // 
            // lblaceitar
            // 
            this.lblaceitar.AutoSize = true;
            this.lblaceitar.Location = new System.Drawing.Point(13, 103);
            this.lblaceitar.Name = "lblaceitar";
            this.lblaceitar.Size = new System.Drawing.Size(40, 13);
            this.lblaceitar.TabIndex = 14;
            this.lblaceitar.Text = "Aceitar";
            this.lblaceitar.Click += new System.EventHandler(this.lblaceitar_Click);
            // 
            // lblrecusar
            // 
            this.lblrecusar.AutoSize = true;
            this.lblrecusar.Location = new System.Drawing.Point(15, 159);
            this.lblrecusar.Name = "lblrecusar";
            this.lblrecusar.Size = new System.Drawing.Size(47, 13);
            this.lblrecusar.TabIndex = 15;
            this.lblrecusar.Text = "Recusar";
            // 
            // rdAceite
            // 
            this.rdAceite.AutoSize = true;
            this.rdAceite.Location = new System.Drawing.Point(16, 119);
            this.rdAceite.Name = "rdAceite";
            this.rdAceite.Size = new System.Drawing.Size(14, 13);
            this.rdAceite.TabIndex = 16;
            this.rdAceite.TabStop = true;
            this.rdAceite.UseVisualStyleBackColor = true;
            this.rdAceite.CheckedChanged += new System.EventHandler(this.rdAceite_CheckedChanged);
            // 
            // rdiorecusa
            // 
            this.rdiorecusa.AutoSize = true;
            this.rdiorecusa.Location = new System.Drawing.Point(17, 175);
            this.rdiorecusa.Name = "rdiorecusa";
            this.rdiorecusa.Size = new System.Drawing.Size(14, 13);
            this.rdiorecusa.TabIndex = 17;
            this.rdiorecusa.TabStop = true;
            this.rdiorecusa.UseVisualStyleBackColor = true;
            this.rdiorecusa.CheckedChanged += new System.EventHandler(this.rdiorecusa_CheckedChanged);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(76, 343);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(39, 13);
            this.lblMotivo.TabIndex = 18;
            this.lblMotivo.Text = "Motivo";
            this.lblMotivo.Visible = false;
            // 
            // txtfeedMot
            // 
            this.txtfeedMot.Location = new System.Drawing.Point(150, 335);
            this.txtfeedMot.Multiline = true;
            this.txtfeedMot.Name = "txtfeedMot";
            this.txtfeedMot.Size = new System.Drawing.Size(549, 106);
            this.txtfeedMot.TabIndex = 19;
            this.txtfeedMot.Visible = false;
            // 
            // btnOks
            // 
            this.btnOks.Location = new System.Drawing.Point(12, 304);
            this.btnOks.Name = "btnOks";
            this.btnOks.Size = new System.Drawing.Size(125, 32);
            this.btnOks.TabIndex = 20;
            this.btnOks.Text = "Feito";
            this.btnOks.UseVisualStyleBackColor = true;
            this.btnOks.Click += new System.EventHandler(this.btnOks_Click);
            // 
            // btnListRev
            // 
            this.btnListRev.Location = new System.Drawing.Point(12, 40);
            this.btnListRev.Name = "btnListRev";
            this.btnListRev.Size = new System.Drawing.Size(103, 23);
            this.btnListRev.TabIndex = 22;
            this.btnListRev.Text = "Lista de artigos";
            this.btnListRev.UseVisualStyleBackColor = true;
            this.btnListRev.Click += new System.EventHandler(this.btnListRev_Click);
            // 
            // txttituloR
            // 
            this.txttituloR.Location = new System.Drawing.Point(186, 26);
            this.txttituloR.Name = "txttituloR";
            this.txttituloR.Size = new System.Drawing.Size(513, 20);
            this.txttituloR.TabIndex = 23;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(147, 29);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(33, 13);
            this.lbltitulo.TabIndex = 24;
            this.lbltitulo.Text = "Titulo";
            // 
            // lblideRev
            // 
            this.lblideRev.AutoSize = true;
            this.lblideRev.Location = new System.Drawing.Point(568, 7);
            this.lblideRev.Name = "lblideRev";
            this.lblideRev.Size = new System.Drawing.Size(57, 13);
            this.lblideRev.TabIndex = 25;
            this.lblideRev.Text = "Bem vindo";
            // 
            // lblidentRev
            // 
            this.lblidentRev.AutoSize = true;
            this.lblidentRev.Location = new System.Drawing.Point(629, 7);
            this.lblidentRev.Name = "lblidentRev";
            this.lblidentRev.Size = new System.Drawing.Size(16, 13);
            this.lblidentRev.TabIndex = 26;
            this.lblidentRev.Text = "...";
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(12, 80);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(125, 13);
            this.lblEscolha.TabIndex = 27;
            this.lblEscolha.Text = "Quer revisar este artigo ?";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(26, 343);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(44, 13);
            this.lblDe.TabIndex = 28;
            this.lblDe.Text = "Dê seu ";
            this.lblDe.Visible = false;
            // 
            // lblArti
            // 
            this.lblArti.AutoSize = true;
            this.lblArti.Location = new System.Drawing.Point(251, 7);
            this.lblArti.Name = "lblArti";
            this.lblArti.Size = new System.Drawing.Size(91, 13);
            this.lblArti.TabIndex = 29;
            this.lblArti.Text = "Número do artigo:";
            // 
            // lblIDart
            // 
            this.lblIDart.AutoSize = true;
            this.lblIDart.Location = new System.Drawing.Point(355, 7);
            this.lblIDart.Name = "lblIDart";
            this.lblIDart.Size = new System.Drawing.Size(16, 13);
            this.lblIDart.TabIndex = 30;
            this.lblIDart.Text = "...";
            // 
            // RevisarArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 448);
            this.Controls.Add(this.lblIDart);
            this.Controls.Add(this.lblArti);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.lblidentRev);
            this.Controls.Add(this.lblideRev);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.txttituloR);
            this.Controls.Add(this.btnListRev);
            this.Controls.Add(this.btnOks);
            this.Controls.Add(this.txtfeedMot);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.rdiorecusa);
            this.Controls.Add(this.rdAceite);
            this.Controls.Add(this.lblrecusar);
            this.Controls.Add(this.lblaceitar);
            this.Controls.Add(this.rdio3);
            this.Controls.Add(this.rdio2);
            this.Controls.Add(this.rdio1);
            this.Controls.Add(this.txtconteudoR);
            this.Controls.Add(this.lblRevise);
            this.Name = "RevisarArt";
            this.Text = "RevisarArt";
            this.Load += new System.EventHandler(this.RevisarArt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRevise;
        private System.Windows.Forms.TextBox txtconteudoR;
        private System.Windows.Forms.RadioButton rdio1;
        private System.Windows.Forms.RadioButton rdio2;
        private System.Windows.Forms.RadioButton rdio3;
        private System.Windows.Forms.Label lblaceitar;
        private System.Windows.Forms.Label lblrecusar;
        private System.Windows.Forms.RadioButton rdAceite;
        private System.Windows.Forms.RadioButton rdiorecusa;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtfeedMot;
        private System.Windows.Forms.Button btnOks;
        private System.Windows.Forms.Button btnListRev;
        private System.Windows.Forms.TextBox txttituloR;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblideRev;
        private System.Windows.Forms.Label lblidentRev;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblArti;
        private System.Windows.Forms.Label lblIDart;
    }
}