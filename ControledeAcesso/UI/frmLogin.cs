using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControledeAcesso
{
    public partial class Login : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString; 
        public Login()
        {
            InitializeComponent();
        }

        private void AcessarSistema(string Login, string Senha)
        {
            var objAcessoDados = new AcessoDadosLogin();
            var objModelo = new AcessoDadosLogin.Modelo();
            var lstRetorno = new List<AcessoDadosLogin.Modelo>();
            objModelo.Login = Login;
            objModelo.Senha = Senha;
            lstRetorno = objAcessoDados.ValidarAcesso(objModelo);
            if (lstRetorno != null && lstRetorno.Count > 0)
            {
                MessageBox.Show("Usuário logado com sucesso!");
                //var objPrincipal = new Principal();
                //objPrincipal.ShowDialog();
                var objPrincipal = new Principal();
                if (!String.IsNullOrEmpty(lstRetorno[0].Perfil))
                    objPrincipal.Perfil = lstRetorno[0].Perfil;
                objPrincipal.ShowDialog();   
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtLogin.Text) && !String.IsNullOrEmpty(this.txtSenha.Text))
            {
                AcessarSistema(this.txtLogin.Text, this.txtSenha.Text);
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
