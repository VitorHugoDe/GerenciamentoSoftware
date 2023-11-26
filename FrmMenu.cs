using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoSoftware
{
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			InitializeComponent();
		}

		private void MenuFuncionario_Click(object sender, EventArgs e)
		{
			Gerenciamento frm = new Gerenciamento();
			frm.ShowDialog();
		}
	}
}
