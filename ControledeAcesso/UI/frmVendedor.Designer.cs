namespace ControledeAcesso
{
    partial class PrinVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrinVendedor));
            this.picSair = new System.Windows.Forms.PictureBox();
            this.picProdutos = new System.Windows.Forms.PictureBox();
            this.lblGerente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // picSair
            // 
            this.picSair.Image = ((System.Drawing.Image)(resources.GetObject("picSair.Image")));
            this.picSair.Location = new System.Drawing.Point(104, 206);
            this.picSair.Name = "picSair";
            this.picSair.Size = new System.Drawing.Size(141, 128);
            this.picSair.TabIndex = 8;
            this.picSair.TabStop = false;
            this.picSair.Click += new System.EventHandler(this.picSair_Click);
            // 
            // picProdutos
            // 
            this.picProdutos.Image = ((System.Drawing.Image)(resources.GetObject("picProdutos.Image")));
            this.picProdutos.Location = new System.Drawing.Point(104, 29);
            this.picProdutos.Name = "picProdutos";
            this.picProdutos.Size = new System.Drawing.Size(141, 128);
            this.picProdutos.TabIndex = 7;
            this.picProdutos.TabStop = false;
            // 
            // lblGerente
            // 
            this.lblGerente.AutoSize = true;
            this.lblGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGerente.Location = new System.Drawing.Point(133, 169);
            this.lblGerente.Name = "lblGerente";
            this.lblGerente.Size = new System.Drawing.Size(98, 25);
            this.lblGerente.TabIndex = 9;
            this.lblGerente.Text = "Produtos";
            // 
            // PrinVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 367);
            this.Controls.Add(this.lblGerente);
            this.Controls.Add(this.picSair);
            this.Controls.Add(this.picProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrinVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrinVendedor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.PictureBox picProdutos;
        private System.Windows.Forms.Label lblGerente;
    }
}