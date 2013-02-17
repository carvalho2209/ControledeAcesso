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
    public partial class PrincGerente : Form
    {
        public PrincGerente()
        {
            InitializeComponent();
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Pergunta do Sistema",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picVendedor_Click(object sender, EventArgs e)
        {
            var vendedor = new PrinVendedor();
            vendedor.ShowDialog();
           vendedor.Close();
        }

        private void PrincGerente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) 
                Close();
        }
    }
}
