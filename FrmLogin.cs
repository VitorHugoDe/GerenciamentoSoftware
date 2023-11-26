using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GerenciamentoSoftware
{
	public partial class FrmLogin : Form
	{
		Conexao con = new Conexao();
		public FrmLogin()
		{
			InitializeComponent();
		}
		private void chamarLogin()
		{
			if (txtNome.Text.ToString().Trim() == "" || txtSenha.Text.ToString().Trim() == "")
			{
				MessageBox.Show("Digite os dados");
				txtNome.Text = "";
				txtNome.Focus();
				return;
			}
		}
		private void btnEntrar_Click(object sender, EventArgs e)
		{
			//Login
			chamarLogin();
			try
			{
				con.AbrirConexao();
				MySqlCommand cmdVerificar;
				MySqlDataReader reader;//Com o reader vou conseguir extrair dados da tabela
				cmdVerificar = new MySqlCommand("SELECT * FROM logi WHERE nome=@nome AND senha=@senha", con.con);
				MySqlDataAdapter da = new MySqlDataAdapter();
				da.SelectCommand = cmdVerificar;
				cmdVerificar.Parameters.AddWithValue("@nome", txtNome.Text);
				cmdVerificar.Parameters.AddWithValue("@senha", txtSenha.Text);
				reader = cmdVerificar.ExecuteReader();
				if (reader.HasRows)
				{
					FrmMenu frm = new FrmMenu();
					frm.Show();

				}
				MessageBox.Show("Sucesso");
			}
			catch (Exception)
			{
				MessageBox.Show("Error");
				throw;
			}

		

		}
	}
}
