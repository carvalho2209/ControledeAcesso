namespace ControledeAcesso
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.picGerente = new System.Windows.Forms.PictureBox();
            this.lblGerente = new System.Windows.Forms.Label();
            this.picVendedor = new System.Windows.Forms.PictureBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.picProdutos = new System.Windows.Forms.PictureBox();
            this.picSair = new System.Windows.Forms.PictureBox();
            this.lblProdutos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGerente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            this.SuspendLayout();
            // 
            // picGerente
            // 
            this.picGerente.Image = ((System.Drawing.Image)(resources.GetObject("picGerente.Image")));
            this.picGerente.Location = new System.Drawing.Point(24, 12);
            this.picGerente.Name = "picGerente";
            this.picGerente.Size = new System.Drawing.Size(180, 176);
            this.picGerente.TabIndex = 0;
            this.picGerente.TabStop = false;
            this.picGerente.Click += new System.EventHandler(this.picGerente_Click);
            // 
            // lblGerente
            // 
            this.lblGerente.AutoSize = true;
            this.lblGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGerente.Location = new System.Drawing.Point(24, 195);
            this.lblGerente.Name = "lblGerente";
            this.lblGerente.Size = new System.Drawing.Size(89, 25);
            this.lblGerente.TabIndex = 1;
            this.lblGerente.Text = "Gerente";
            // 
            // picVendedor
            // 
            this.picVendedor.Image = global::ControledeAcesso.Properties.Resources._1360470961_personal;
            this.picVendedor.Location = new System.Drawing.Point(260, 12);
            this.picVendedor.Name = "picVendedor";
            this.picVendedor.Size = new System.Drawing.Size(133, 140);
            this.picVendedor.TabIndex = 2;
            this.picVendedor.TabStop = false;
            this.picVendedor.Click += new System.EventHandler(this.picVendedor_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(257, 175);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(105, 25);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "Vendedor";
            // 
            // picProdutos
            // 
            this.picProdutos.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picProdutos.ErrorImage")));
            this.picProdutos.Image = ((System.Drawing.Image)(resources.GetObject("picProdutos.Image")));
            this.picProdutos.InitialImage = ((System.Drawing.Image)(resources.GetObject("picProdutos.InitialImage")));
            this.picProdutos.Location = new System.Drawing.Point(465, 12);
            this.picProdutos.Name = "picProdutos";
            this.picProdutos.Size = new System.Drawing.Size(145, 140);
            this.picProdutos.TabIndex = 4;
            this.picProdutos.TabStop = false;
            this.picProdutos.Click += new System.EventHandler(this.picProdutos_Click);
            // 
            // picSair
            // 
            this.picSair.Image = ((System.Drawing.Image)(resources.GetObject("picSair.Image")));
            this.picSair.Location = new System.Drawing.Point(262, 253);
            this.picSair.Name = "picSair";
            this.picSair.Size = new System.Drawing.Size(140, 147);
            this.picSair.TabIndex = 5;
            this.picSair.TabStop = false;
            this.picSair.Click += new System.EventHandler(this.picSair_Click);
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(465, 174);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(98, 25);
            this.lblProdutos.TabIndex = 6;
            this.lblProdutos.Text = "Produtos";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 412);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.picSair);
            this.Controls.Add(this.picProdutos);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.picVendedor);
            this.Controls.Add(this.lblGerente);
            this.Controls.Add(this.picGerente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Acesso";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Principal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picGerente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGerente;
        private System.Windows.Forms.Label lblGerente;
        private System.Windows.Forms.PictureBox picVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.PictureBox picProdutos;
        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.Label lblProdutos;
    }
}