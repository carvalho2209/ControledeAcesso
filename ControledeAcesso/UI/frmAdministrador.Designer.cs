namespace ControledeAcesso
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.picGerente = new System.Windows.Forms.PictureBox();
            this.picVendedor = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picSair = new System.Windows.Forms.PictureBox();
            this.picProdutos = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblGerente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGerente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // picGerente
            // 
            this.picGerente.Image = ((System.Drawing.Image)(resources.GetObject("picGerente.Image")));
            this.picGerente.Location = new System.Drawing.Point(214, 26);
            this.picGerente.Name = "picGerente";
            this.picGerente.Size = new System.Drawing.Size(183, 145);
            this.picGerente.TabIndex = 0;
            this.picGerente.TabStop = false;
            // 
            // picVendedor
            // 
            this.picVendedor.Image = ((System.Drawing.Image)(resources.GetObject("picVendedor.Image")));
            this.picVendedor.Location = new System.Drawing.Point(326, 192);
            this.picVendedor.Name = "picVendedor";
            this.picVendedor.Size = new System.Drawing.Size(123, 129);
            this.picVendedor.TabIndex = 2;
            this.picVendedor.TabStop = false;
            this.picVendedor.Click += new System.EventHandler(this.picGerente_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(21, 192);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(141, 128);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.picVendedor_Click);
            // 
            // picSair
            // 
            this.picSair.Image = ((System.Drawing.Image)(resources.GetObject("picSair.Image")));
            this.picSair.Location = new System.Drawing.Point(236, 359);
            this.picSair.Name = "picSair";
            this.picSair.Size = new System.Drawing.Size(141, 128);
            this.picSair.TabIndex = 6;
            this.picSair.TabStop = false;
            this.picSair.Click += new System.EventHandler(this.picSair_Click);
            // 
            // picProdutos
            // 
            this.picProdutos.Image = ((System.Drawing.Image)(resources.GetObject("picProdutos.Image")));
            this.picProdutos.Location = new System.Drawing.Point(168, 192);
            this.picProdutos.Name = "picProdutos";
            this.picProdutos.Size = new System.Drawing.Size(141, 128);
            this.picProdutos.TabIndex = 8;
            this.picProdutos.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(455, 191);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 129);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(117, 333);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(98, 25);
            this.lblProdutos.TabIndex = 9;
            this.lblProdutos.Text = "Produtos";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(400, 333);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(105, 25);
            this.lblVendedor.TabIndex = 10;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblGerente
            // 
            this.lblGerente.AutoSize = true;
            this.lblGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGerente.Location = new System.Drawing.Point(416, 84);
            this.lblGerente.Name = "lblGerente";
            this.lblGerente.Size = new System.Drawing.Size(89, 25);
            this.lblGerente.TabIndex = 11;
            this.lblGerente.Text = "Gerente";
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 510);
            this.Controls.Add(this.lblGerente);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.picProdutos);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.picSair);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.picVendedor);
            this.Controls.Add(this.picGerente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Administrador_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picGerente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGerente;
        private System.Windows.Forms.PictureBox picVendedor;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.PictureBox picProdutos;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblGerente;
    }
}