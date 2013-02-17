using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControledeAcesso
{
    public class AcessoDadosLogin
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;

        public class Modelo
        {
            public int IdLogin { get; set; }
            public string Login { get; set; }
            public string Senha { get; set; }
            public string Nome { get; set; }
            public string Perfil { get; set; }
        }

        private string strInstrucaoSelect = "SELECT L.IdLogin, L.Login, L.Senha, U.Nome, P.Perfil " +
                                            "FROM Login AS L INNER JOIN Usuario AS U ON U.IdLogin = L.IdLogin " +
                                            "INNER JOIN Perfil AS P ON P.IdPerfil = U.IdPerfil " +
                                            "WHERE L.Login = @Login AND L.Senha = @Senha AND U.Ativo = 1";

        public List<Modelo> ValidarAcesso(Modelo dadosModelo)
        {
            var lstRetorno = new List<Modelo>();
            using (var objConexao = new SqlConnection(strConnectionString))
            {
                using (var objCommand = new SqlCommand(strInstrucaoSelect, objConexao))
                {
                    objCommand.Parameters.AddWithValue("@Login", dadosModelo.Login);
                    objCommand.Parameters.AddWithValue("@Senha", dadosModelo.Senha);
                    try
                    {
                        objConexao.Open();
                        SqlDataReader objDataReader = objCommand.ExecuteReader();
                        if (objDataReader.HasRows)
                        {
                            while (objDataReader.Read())
                            {
                                var objModelo = new Modelo
                                                    {
                                                        IdLogin = Convert.ToInt32(objDataReader["IdLogin"].ToString()),
                                                        Login = objDataReader["Login"].ToString(),
                                                        Senha = objDataReader["Senha"].ToString(),
                                                        Nome = objDataReader["Nome"].ToString(),
                                                        Perfil = objDataReader["Perfil"].ToString()
                                                    };
                                lstRetorno.Add(objModelo);
                            }
                        }
                        objDataReader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
                    }
                    finally
                    {
                        objConexao.Close();
                    }
                }
            }
            return lstRetorno;
        }
    }
}