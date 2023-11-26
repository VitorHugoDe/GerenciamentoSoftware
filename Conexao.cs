using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  //Biblioteca para chamar o Mysql
using System.Windows.Forms;

namespace GerenciamentoSoftware
{
	internal class Conexao
	{
		//String de conexão localhost xampp e apache
		public string conec = "SERVER=localhost; DATABASE=gerenciamentorh; UID=root; PWD=; PORT=;";
		//Variavel de conexão com o banco de dados
		public MySqlConnection con = null;
		//abrir conexão
		public void AbrirConexao()
		{
			//testar
			try
			{
				con = new MySqlConnection(conec);
				con.Open();
			}
			catch (Exception ex)
			{
				//erro
				MessageBox.Show("Erro no Servidor ==> " + ex.Message);
			}
		}

		//Fechar Conexão
		public void FecharConexao()
		{
			try
			{
				con = new MySqlConnection(conec);
				con.Close();
			}
			catch (Exception ex)
			{
				//erro
				MessageBox.Show("Erro no Servidor ==> " + ex.Message);
			}
		}
	}
}
