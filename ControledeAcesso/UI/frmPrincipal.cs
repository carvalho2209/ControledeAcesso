using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControledeAcesso
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        public string Perfil = string.Empty;

        private void Principal_Load(object sender, EventArgs e)
        {
            {
                if (!String.IsNullOrEmpty(Perfil))
                {
                    switch (Perfil)
                    {
                        case "Administrador":
                            this.picGerente.Visible = true;
                            this.lblGerente.Visible = true;
                            this.picVendedor.Visible = true;
                            this.lblVendedor.Visible = true;
                            this.picProdutos.Visible = true;
                            this.lblProdutos.Visible = true;
                            break;
                        case "Gerente":
                            this.lblGerente.Visible = false;
                            this.picGerente.Visible = false;
                            this.picVendedor.Visible = true;
                            this.lblVendedor.Visible = true;
                            this.picProdutos.Visible = true;
                            this.lblProdutos.Visible = true;
                            break;
                        case "Vendedor":
                            this.lblGerente.Visible = false;
                            this.picGerente.Visible = false;
                            this.lblVendedor.Visible = false;
                            this.picVendedor.Visible = false;
                            this.picProdutos.Visible = true;
                            this.lblProdutos.Visible = true;
                            break;
                    }
                }
            }
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Pergunta do Sistema",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void picVendedor_Click(object sender, EventArgs e)
        {
            var gerente = new PrincGerente();
            gerente.ShowDialog();
            Close();
        }

        private void picProdutos_Click(object sender, EventArgs e)
        {
            var vendedor = new PrinVendedor();
            vendedor.ShowDialog();
            Close();
        }

        private void picGerente_Click(object sender, EventArgs e)
        {
            var gerente = new Administrador();
            gerente.ShowDialog();
            Close();
        }
    }
}
