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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConcordar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdio1 = new System.Windows.Forms.RadioButton();
            this.rdio2 = new System.Windows.Forms.RadioButton();
            this.rdio3 = new System.Windows.Forms.RadioButton();
            this.lblaceitar = new System.Windows.Forms.Label();
            this.lblrecusar = new System.Windows.Forms.Label();
            this.rdAceite = new System.Windows.Forms.RadioButton();
            this.rdiorecusa = new System.Windows.Forms.RadioButton();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOks = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRevise
            // 
            this.lblRevise.AutoSize = true;
            this.lblRevise.Location = new System.Drawing.Point(13, 13);
            this.lblRevise.Name = "lblRevise";
            this.lblRevise.Size = new System.Drawing.Size(136, 13);
            this.lblRevise.TabIndex = 0;
            this.lblRevise.Text = "Revise o artigo que deseja ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 277);
            this.textBox1.TabIndex = 8;
            // 
            // btnConcordar
            // 
            this.btnConcordar.Location = new System.Drawing.Point(624, 341);
            this.btnConcordar.Name = "btnConcordar";
            this.btnConcordar.Size = new System.Drawing.Size(75, 23);
            this.btnConcordar.TabIndex = 9;
            this.btnConcordar.Text = "Submeter";
            this.btnConcordar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // rdio1
            // 
            this.rdio1.AutoSize = true;
            this.rdio1.Location = new System.Drawing.Point(638, 172);
            this.rdio1.Name = "rdio1";
            this.rdio1.Size = new System.Drawing.Size(75, 17);
            this.rdio1.TabIndex = 11;
            this.rdio1.TabStop = true;
            this.rdio1.Text = "Muito Bom";
            this.rdio1.UseVisualStyleBackColor = true;
            // 
            // rdio2
            // 
            this.rdio2.AutoSize = true;
            this.rdio2.Location = new System.Drawing.Point(638, 213);
            this.rdio2.Name = "rdio2";
            this.rdio2.Size = new System.Drawing.Size(66, 17);
            this.rdio2.TabIndex = 12;
            this.rdio2.TabStop = true;
            this.rdio2.Text = "Mediano";
            this.rdio2.UseVisualStyleBackColor = true;
            // 
            // rdio3
            // 
            this.rdio3.AutoSize = true;
            this.rdio3.Location = new System.Drawing.Point(640, 257);
            this.rdio3.Name = "rdio3";
            this.rdio3.Size = new System.Drawing.Size(49, 17);
            this.rdio3.TabIndex = 13;
            this.rdio3.TabStop = true;
            this.rdio3.Text = "Ruim";
            this.rdio3.UseVisualStyleBackColor = true;
            // 
            // lblaceitar
            // 
            this.lblaceitar.AutoSize = true;
            this.lblaceitar.Location = new System.Drawing.Point(10, 110);
            this.lblaceitar.Name = "lblaceitar";
            this.lblaceitar.Size = new System.Drawing.Size(40, 13);
            this.lblaceitar.TabIndex = 14;
            this.lblaceitar.Text = "Aceitar";
            this.lblaceitar.Click += new System.EventHandler(this.lblaceitar_Click);
            // 
            // lblrecusar
            // 
            this.lblrecusar.AutoSize = true;
            this.lblrecusar.Location = new System.Drawing.Point(10, 142);
            this.lblrecusar.Name = "lblrecusar";
            this.lblrecusar.Size = new System.Drawing.Size(47, 13);
            this.lblrecusar.TabIndex = 15;
            this.lblrecusar.Text = "Recusar";
            // 
            // rdAceite
            // 
            this.rdAceite.AutoSize = true;
            this.rdAceite.Location = new System.Drawing.Point(13, 126);
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
            this.rdiorecusa.Location = new System.Drawing.Point(13, 158);
            this.rdiorecusa.Name = "rdiorecusa";
            this.rdiorecusa.Size = new System.Drawing.Size(14, 13);
            this.rdiorecusa.TabIndex = 17;
            this.rdiorecusa.TabStop = true;
            this.rdiorecusa.UseVisualStyleBackColor = true;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(13, 189);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(39, 13);
            this.lblMotivo.TabIndex = 18;
            this.lblMotivo.Text = "Motivo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 223);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 106);
            this.textBox2.TabIndex = 19;
            // 
            // btnOks
            // 
            this.btnOks.Location = new System.Drawing.Point(63, 150);
            this.btnOks.Name = "btnOks";
            this.btnOks.Size = new System.Drawing.Size(81, 29);
            this.btnOks.TabIndex = 20;
            this.btnOks.Text = "Feito";
            this.btnOks.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(638, 110);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 21;
            this.btnDown.Text = "Download";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // RevisarArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 376);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnOks);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.rdiorecusa);
            this.Controls.Add(this.rdAceite);
            this.Controls.Add(this.lblrecusar);
            this.Controls.Add(this.lblaceitar);
            this.Controls.Add(this.rdio3);
            this.Controls.Add(this.rdio2);
            this.Controls.Add(this.rdio1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnConcordar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRevise);
            this.Name = "RevisarArt";
            this.Text = "RevisarArt";
            this.Load += new System.EventHandler(this.RevisarArt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRevise;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConcordar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdio1;
        private System.Windows.Forms.RadioButton rdio2;
        private System.Windows.Forms.RadioButton rdio3;
        private System.Windows.Forms.Label lblaceitar;
        private System.Windows.Forms.Label lblrecusar;
        private System.Windows.Forms.RadioButton rdAceite;
        private System.Windows.Forms.RadioButton rdiorecusa;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOks;
        private System.Windows.Forms.Button btnDown;
    }
}