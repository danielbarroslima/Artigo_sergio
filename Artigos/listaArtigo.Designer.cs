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
            this.btnfeedRev = new System.Windows.Forms.Button();
            this.btnFeedArt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridArt)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridArt
            // 
            this.dtgridArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridArt.Location = new System.Drawing.Point(12, 12);
            this.dtgridArt.Name = "dtgridArt";
            this.dtgridArt.Size = new System.Drawing.Size(642, 266);
            this.dtgridArt.TabIndex = 0;

            this.dtgridArt.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridArt_CellContentDoubleClick);
            // 
            // btnfeedRev
            // 
            this.btnfeedRev.Location = new System.Drawing.Point(12, 284);
            this.btnfeedRev.Name = "btnfeedRev";
            this.btnfeedRev.Size = new System.Drawing.Size(114, 23);
            this.btnfeedRev.TabIndex = 1;
            this.btnfeedRev.Text = "Artigos Revisados";
            this.btnfeedRev.UseVisualStyleBackColor = true;
            this.btnfeedRev.Click += new System.EventHandler(this.btnfeedar_Click);
            // 
            // btnFeedArt
            // 
            this.btnFeedArt.Location = new System.Drawing.Point(169, 284);
            this.btnFeedArt.Name = "btnFeedArt";
            this.btnFeedArt.Size = new System.Drawing.Size(152, 23);
            this.btnFeedArt.TabIndex = 2;
            this.btnFeedArt.Text = "FeedBack Dos Artigos";
            this.btnFeedArt.UseVisualStyleBackColor = true;
            this.btnFeedArt.Click += new System.EventHandler(this.btnFeedArt_Click);
            // 
            // listaArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 319);
            this.Controls.Add(this.btnFeedArt);
            this.Controls.Add(this.btnfeedRev);
            this.Controls.Add(this.dtgridArt);
            this.Name = "listaArtigo";
            this.Text = "listaArtigo";
            this.Load += new System.EventHandler(this.listaArtigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridArt;
        private System.Windows.Forms.Button btnfeedRev;
        private System.Windows.Forms.Button btnFeedArt;
    }
}