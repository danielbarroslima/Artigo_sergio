namespace Artigos
{
    partial class ListaRevisao
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
            this.dtgrdRev = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdRev)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdRev
            // 
            this.dtgrdRev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdRev.Location = new System.Drawing.Point(22, 12);
            this.dtgrdRev.Name = "dtgrdRev";
            this.dtgrdRev.Size = new System.Drawing.Size(558, 235);
            this.dtgrdRev.TabIndex = 0;

            // 
            // ListaRevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 262);
            this.Controls.Add(this.dtgrdRev);
            this.Name = "ListaRevisao";
            this.Text = "ListaRevisao";
            this.Load += new System.EventHandler(this.ListaRevisao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdRev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdRev;
    }
}