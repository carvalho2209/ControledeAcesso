namespace ControledeAcesso
{
    partial class PrincGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincGerente));
            this.picSair = new System.Windows.Forms.PictureBox();
            this.picProdutos = new System.Windows.Forms.PictureBox();
            this.picVendedor = new System.Windows.Forms.PictureBox();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // picSair
            // 
            this.picSair.Image = ((System.Drawing.Image)(resources.GetObject("picSair.Image")));
            this.picSair.Location = new System.Drawing.Point(113, 221);
            this.picSair.Name = "picSair";
            this.picSair.Size = new System.Drawing.Size(141, 128);
            this.picSair.TabIndex = 11;
            this.picSair.TabStop = false;
            this.picSair.Click += new System.EventHandler(this.picSair_Click);
            // 
            // picProdutos
            // 
            this.picProdutos.Image = ((System.Drawing.Image)(resources.GetObject("picProdutos.Image")));
            this.picProdutos.Location = new System.Drawing.Point(210, 16);
            this.picProdutos.Name = "picProdutos";
            this.picProdutos.Size = new System.Drawing.Size(141, 143);
            this.picProdutos.TabIndex = 9;
            this.picProdutos.TabStop = false;
            this.picProdutos.Click += new System.EventHandler(this.picVendedor_Click);
            // 
            // picVendedor
            // 
            this.picVendedor.Image = ((System.Drawing.Image)(resources.GetObject("picVendedor.Image")));
            this.picVendedor.Location = new System.Drawing.Point(28, 16);
            this.picVendedor.Name = "picVendedor";
            this.picVendedor.Size = new System.Drawing.Size(123, 143);
            this.picVendedor.TabIndex = 7;
            this.picVendedor.TabStop = false;
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProdutos.Location = new System.Drawing.Point(236, 174);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(98, 25);
            this.lblProdutos.TabIndex = 12;
            this.lblProdutos.Text = "Produtos";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVendedor.Location = new System.Drawing.Point(45, 174);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(105, 25);
            this.lblVendedor.TabIndex = 13;
            this.lblVendedor.Text = "Vendedor";
            // 
            // PrincGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 373);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.picSair);
            this.Controls.Add(this.picProdutos);
            this.Controls.Add(this.picVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrincGerente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.PictureBox picProdutos;
        private System.Windows.Forms.PictureBox picVendedor;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblVendedor;
    }
}