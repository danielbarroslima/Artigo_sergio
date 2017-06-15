namespace Artigos
{
    partial class listaArtigo
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
            this.dtgridArt = new System.Windows.Forms.DataGridView();
            this.btnfeedar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridArt)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridArt
            // 
            this.dtgridArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridArt.Location = new System.Drawing.Point(12, 12);
            this.dtgridArt.Name = "dtgridArt";
            this.dtgridArt.Size = new System.Drawing.Size(549, 304);
            this.dtgridArt.TabIndex = 0;
            this.dtgridArt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridArt_CellContentClick);
            this.dtgridArt.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridArt_CellContentDoubleClick);
            // 
            // btnfeedar
            // 
            this.btnfeedar.Location = new System.Drawing.Point(592, 120);
            this.btnfeedar.Name = "btnfeedar";
            this.btnfeedar.Size = new System.Drawing.Size(75, 23);
            this.btnfeedar.TabIndex = 1;
            this.btnfeedar.Text = "A revisar ";
            this.btnfeedar.UseVisualStyleBackColor = true;
            this.btnfeedar.Click += new System.EventHandler(this.btnfeedar_Click);
            // 
            // listaArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 319);
            this.Controls.Add(this.btnfeedar);
            this.Controls.Add(this.dtgridArt);
            this.Name = "listaArtigo";
            this.Text = "listaArtigo";
            this.Load += new System.EventHandler(this.listaArtigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridArt;
        private System.Windows.Forms.Button btnfeedar;
    }
}