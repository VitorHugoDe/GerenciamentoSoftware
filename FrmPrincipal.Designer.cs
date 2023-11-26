namespace GerenciamentoSoftware
{
	partial class Gerenciamento
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtAdress = new System.Windows.Forms.TextBox();
			this.txtCPF = new System.Windows.Forms.MaskedTextBox();
			this.txtTel = new System.Windows.Forms.MaskedTextBox();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.grid = new System.Windows.Forms.DataGridView();
			this.image = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnImg = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(6, 51);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name";
			this.lblName.Click += new System.EventHandler(this.lblName_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Adress";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "CPF:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "tel.:";
			// 
			// txtName
			// 
			this.txtName.Enabled = false;
			this.txtName.Location = new System.Drawing.Point(57, 44);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(471, 20);
			this.txtName.TabIndex = 4;
			// 
			// txtAdress
			// 
			this.txtAdress.Enabled = false;
			this.txtAdress.Location = new System.Drawing.Point(57, 85);
			this.txtAdress.Name = "txtAdress";
			this.txtAdress.Size = new System.Drawing.Size(471, 20);
			this.txtAdress.TabIndex = 5;
			// 
			// txtCPF
			// 
			this.txtCPF.Enabled = false;
			this.txtCPF.Location = new System.Drawing.Point(57, 122);
			this.txtCPF.Mask = "000,000,000-00";
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(179, 20);
			this.txtCPF.TabIndex = 6;
			// 
			// txtTel
			// 
			this.txtTel.Enabled = false;
			this.txtTel.Location = new System.Drawing.Point(57, 161);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(179, 20);
			this.txtTel.TabIndex = 7;
			// 
			// btnNovo
			// 
			this.btnNovo.Location = new System.Drawing.Point(329, 161);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 23);
			this.btnNovo.TabIndex = 8;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = true;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Enabled = false;
			this.btnSalvar.Location = new System.Drawing.Point(410, 161);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 9;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Enabled = false;
			this.btnExcluir.Location = new System.Drawing.Point(573, 163);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 10;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Enabled = false;
			this.btnCancelar.Location = new System.Drawing.Point(654, 163);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Enabled = false;
			this.btnAlterar.Location = new System.Drawing.Point(492, 163);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 13;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(553, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Buscar:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(325, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(362, 21);
			this.label4.TabIndex = 16;
			this.label4.Text = "Tela de cadastro de Funcionarios";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(597, 44);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(306, 20);
			this.txtBuscar.TabIndex = 17;
			this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
			// 
			// grid
			// 
			this.grid.AllowUserToAddRows = false;
			this.grid.AllowUserToDeleteRows = false;
			this.grid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Location = new System.Drawing.Point(29, 202);
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.Size = new System.Drawing.Size(700, 236);
			this.grid.TabIndex = 18;
			this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
			// 
			// image
			// 
			this.image.Image = global::GerenciamentoSoftware.Properties.Resources.Perfil1;
			this.image.Location = new System.Drawing.Point(945, 9);
			this.image.Name = "image";
			this.image.Size = new System.Drawing.Size(211, 201);
			this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.image.TabIndex = 19;
			this.image.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(1037, 215);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Foto:";
			// 
			// btnImg
			// 
			this.btnImg.Location = new System.Drawing.Point(1016, 231);
			this.btnImg.Name = "btnImg";
			this.btnImg.Size = new System.Drawing.Size(75, 23);
			this.btnImg.TabIndex = 21;
			this.btnImg.Text = "foto";
			this.btnImg.UseVisualStyleBackColor = true;
			this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
			// 
			// Gerenciamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1168, 450);
			this.Controls.Add(this.btnImg);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.image);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtCPF);
			this.Controls.Add(this.txtAdress);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblName);
			this.Name = "Gerenciamento";
			this.Text = "Principal";
			this.Load += new System.EventHandler(this.Gerenciamento_Load);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtAdress;
		private System.Windows.Forms.MaskedTextBox txtCPF;
		private System.Windows.Forms.MaskedTextBox txtTel;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.DataGridView grid;
		private System.Windows.Forms.PictureBox image;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnImg;
	}
}

