using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  //Biblioteca para chamar o Mysql

namespace GerenciamentoSoftware
{
	public partial class Gerenciamento : Form
	{
		//Intanciando a Classe Conexão
		Conexao con = new Conexao();
		String sql;
		MySqlCommand cmd;
		//Variavel que recebe a imagem
		string foto;

		//
		string alterouFoto = "nao";

		//
		string cpfAntigo;

		//variavel que pega o id do registro
		string id;

		public Gerenciamento()
		{
			InitializeComponent();
		}

		private void FormatarGD()
		{
			grid.Columns[0].HeaderText = "Codigo";
			grid.Columns[1].HeaderText = "Nome:";
			grid.Columns[2].HeaderText = "End:";
			grid.Columns[3].HeaderText = "CPF:";
			grid.Columns[4].HeaderText = "Tel.:";
			grid.Columns[5].HeaderText = "foto.:";

			grid.Columns[5].Visible = false;
		}
		private void ListarGD()
		{
			con.AbrirConexao();
			sql = "SELECT * FROM cadfuncionario ORDER BY NOME ASC ";
			cmd = new MySqlCommand(sql, con.con);
			MySqlDataAdapter da = new MySqlDataAdapter();
			da.SelectCommand = cmd;
			DataTable dt = new DataTable();
			da.Fill(dt);
			grid.DataSource = dt;
			con.FecharConexao();

			FormatarGD();
		}

		private void lblName_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Gerenciamento_Load(object sender, EventArgs e)
		{
			//Metodo para limpar a foto
			LimparFoto();
			//Carrega tudo ao abrir...
			ListarGD();
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			HabilitarCampo();
			LimparCampo();
			LimparFoto();
			txtName.Focus();

			HabilitarBotoes();
			btnNovo.Enabled = false;
			btnAlterar.Enabled = false;
			btnExcluir.Enabled = false;

			//Atualiza o grid e mostra as atualizações
			ListarGD();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			if(txtName.Text.ToString().Trim() == "")
			{
				MessageBox.Show("Digite seu Nome");
				txtName.Text = "";
				txtName.Focus();
				return;
			}
			if (txtCPF.Text == "   .   .   -" || txtCPF.Text.Length < 14)
			{
				MessageBox.Show("Digite seu CPF");
				txtCPF.Focus();
				return;
			}
			//Comando abrir conexão
			con.AbrirConexao();
			sql = "INSERT INTO cadfuncionario (nome, adress, cpf, telefone) VALUES(@nome, @adress, @cpf, @telefone)";
			cmd = new MySqlCommand(sql, con.con);
			cmd.Parameters.AddWithValue("@nome", txtName.Text);
			cmd.Parameters.AddWithValue("@adress", txtAdress.Text);
			cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
			cmd.Parameters.AddWithValue("@telefone", txtTel.Text);
			cmd.Parameters.AddWithValue("@imagem", img());  //Metodo de imagem

			//Verificação de cpf
			MySqlCommand cmdVerificar;
			cmdVerificar = new MySqlCommand("SELECT * FROM cadfuncionario WHERE cpf=@cpf", con.con);
			MySqlDataAdapter da = new MySqlDataAdapter();
			da.SelectCommand = cmdVerificar;
			cmdVerificar.Parameters.AddWithValue("@cpf", txtCPF.Text);
			DataTable dt = new DataTable();
			da.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				MessageBox.Show("Cpf Já Cadastrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				txtCPF.Text = "";
				txtCPF.Focus();
				return;
			}

			cmd.ExecuteNonQuery();
			con.FecharConexao();
			LimparCampo();
			DesabilitarCampo();
			DesabilitarBotoes();
			btnNovo.Enabled = true;


			//Metodo para limpar foto
			LimparFoto();

			//Metodo atualiza a grid e mostra as alterações
			ListarGD();
			MessageBox.Show("Registro Salvar com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			//Variavel para confirmar solicitação para excluir
			var resposta = MessageBox.Show("Deseja realmente excluir os dados ?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (resposta == DialogResult.Yes)
			{
				con.AbrirConexao();
				sql = "DELETE FROM cadfuncionario WHERE id=@id";
				cmd = new MySqlCommand(sql, con.con);
				cmd.Parameters.AddWithValue("@id", id);
				cmd.ExecuteNonQuery();
				con.FecharConexao();

				LimparCampo();
				DesabilitarCampo();
				DesabilitarBotoes();
				btnNovo.Enabled = true;
				//Mostra as auterações dos grids
				ListarGD();
				MessageBox.Show("Registro excluido com sucesso", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DesabilitarBotoes();
			DesabilitarCampo();
			LimparCampo();
			btnNovo.Enabled = true;

			ListarGD();
			alterouFoto = "nao";
		}
		//metodo de desabilitar botoes

		private void DesabilitarBotoes()
		{
			btnNovo.Enabled = false;
			btnSalvar.Enabled = false;
			btnCancelar.Enabled = false;
			btnExcluir.Enabled = false;
			btnAlterar.Enabled = false;
		}

		//metodo de Habilitar botoes

		private void HabilitarBotoes()
		{
			btnNovo.Enabled = true;
			btnSalvar.Enabled = true;
			btnCancelar.Enabled = true;
			btnExcluir.Enabled = true;
			btnAlterar.Enabled = true;
		}
		//Metodo de habilitar campos
		private void HabilitarCampo()
		{
			txtName.Enabled = true;
			txtAdress.Enabled = true;
			txtCPF.Enabled = true;
			txtTel.Enabled = true;
			
		}

		//Desabilitar Campos

		private void DesabilitarCampo()
		{
			txtName.Enabled = false;
			txtAdress.Enabled = false;
			txtCPF.Enabled = false;
			txtTel.Enabled = false;
		}
		//Limpar campo
		private void LimparCampo()
		{
			txtAdress.Text = "";
			txtCPF.Text = "";
			txtName.Text = "";
			txtTel.Text = "";
		}
		private void btnAlterar_Click(object sender, EventArgs e)
		{
			if (txtName.Text.ToString().Trim() == "")
			{
				MessageBox.Show("Digite seu Nome");
				txtName.Text = "";
				txtName.Focus();
				return;
			}
			if (txtCPF.Text == "   .   .   -" || txtCPF.Text.Length < 14)
			{
				MessageBox.Show("Digite seu CPF");
				txtCPF.Focus();
				return;
			}

			con.AbrirConexao();

			
			if(alterouFoto == "sim")
			{
				sql = "UPDATE cadfuncionario SET nome=@nome, adress=@adress, cpf=@cpf, telefone=@telefone, imagem=@imagem WHERE id=@id";
				cmd = new MySqlCommand(sql, con.con);
				cmd.Parameters.AddWithValue("@id", id);
				cmd.Parameters.AddWithValue("@nome", txtName.Text);
				cmd.Parameters.AddWithValue("@adress", txtAdress.Text);
				cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
				cmd.Parameters.AddWithValue("@telefone", txtTel.Text);
				cmd.Parameters.AddWithValue("@imagem", img());
			}
			else if (alterouFoto == "nao")
			{
				sql = "UPDATE cadfuncionario SET nome=@nome, adress=@adress, cpf=@cpf, telefone=@telefone WHERE id=@id";
				cmd = new MySqlCommand(sql, con.con);
				cmd.Parameters.AddWithValue("@id", id);
				cmd.Parameters.AddWithValue("@nome", txtName.Text);
				cmd.Parameters.AddWithValue("@adress", txtAdress.Text);
				cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
				cmd.Parameters.AddWithValue("@telefone", txtTel.Text);
			}
			//Verificar se Cpf ja existe 
			if(txtCPF.Text != cpfAntigo)
			{
				MySqlCommand cmdVerificar;
				cmdVerificar = new MySqlCommand("SELECT * FROM cadfuncionario WHERE cpf=@cpf", con.con);
				MySqlDataAdapter da = new MySqlDataAdapter();
				da.SelectCommand = cmdVerificar;
				cmdVerificar.Parameters.AddWithValue("@cpf", txtCPF.Text);
				DataTable dt = new DataTable();
				da.Fill(dt);
				if (dt.Rows.Count > 0)
				{
					MessageBox.Show("Cpf Já Cadastrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					txtCPF.Text = "";
					txtCPF.Focus();
					return;
				}
			}

			cmd.ExecuteNonQuery();
			con.FecharConexao();
			LimparCampo();
			DesabilitarCampo();
			DesabilitarBotoes();
			btnNovo.Enabled = true;

			//Atualiza a crid e mostra as alterações
			ListarGD();
			//
			LimparFoto();
			MessageBox.Show("Registro Alterado com sucesso", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				LimparFoto();

				HabilitarBotoes();
				btnNovo.Enabled = false;
				btnSalvar.Enabled = false;
				HabilitarCampo();

				alterouFoto = "nao";

				id = grid.CurrentRow.Cells[0].Value.ToString();
				txtName.Text = grid.CurrentRow.Cells[1].Value.ToString();
				txtAdress.Text = grid.CurrentRow.Cells[2].Value.ToString();
				txtCPF.Text = grid.CurrentRow.Cells[3].Value.ToString();
				txtTel.Text = grid.CurrentRow.Cells[4].Value.ToString();

				cpfAntigo = grid.CurrentRow.Cells[3].Value.ToString();

				//Pegar Foto
				if (grid.CurrentRow.Cells[5].Value != DBNull.Value)
				{
					byte[] imagem = (byte[])grid.Rows[e.RowIndex].Cells[5].Value;  //cria a variavel byte para receber a grid 
					MemoryStream ms = new MemoryStream(imagem);

					image.Image = Image.FromStream(ms);

				}
				else
				{
					image.Image = Properties.Resources.Perfil;  //Chama a imagem do banco ou a imagem do perfil
				}
			}
			else
			{
				return;
			}
		}
		//Metodo por nome
		private void BuscarNome()
		{
			con.AbrirConexao();
			sql = "SELECT * FROM cadfuncionario WHERE nome LIKE @nome ORDER BY nome ASC"; //LIKE, busca nome por aproximação.
			cmd = new MySqlCommand(sql, con.con);
			cmd.Parameters.AddWithValue("@nome", txtBuscar.Text + "%"); // operador LIKE, busca por aproximação.
			MySqlDataAdapter da = new MySqlDataAdapter();
			da.SelectCommand = cmd;
			DataTable dt = new DataTable();
			da.Fill(dt);
			grid.DataSource = dt;
			con.FecharConexao();

			FormatarGD();
		}

		private void txtBuscar_TextChanged(object sender, EventArgs e)
		{
			BuscarNome();
		}

		private void btnImg_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "imagens(*.jpg; *.png) | *.jpg; *.png"; // Mostrar somente imagem jpg e png
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				foto = dialog.FileName.ToString();  //Pega o caminho da imagem selecionada
				image.ImageLocation = foto;

				alterouFoto = "sim";
			}
			else
			{
				alterouFoto = "nao";
			}

		}
		//Metodo para enviar imagem para o banco
		private byte[] img()
		{
			byte[] imagem_byte = null;

			if(foto == "")
			{
				return null;
			}
			FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read); //Padrão para salvar imagem
			BinaryReader br = new BinaryReader(fs);

			imagem_byte = br.ReadBytes((int) fs.Length);
			return imagem_byte;
		}

		//Metodo Limpar foto

		private void LimparFoto()
		{
			image.Image = Properties.Resources.Perfil;
			foto = "ft/perfil.png";
		}

	}//fim
}
