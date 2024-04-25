using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD
{
	public partial class FormInicio : Form
	{
		public FormInicio()
		{
			InitializeComponent();
		}

		private void B_Registro_Click(object sender, EventArgs e)
		{
			Form pantalla = new FormRegistro();
			pantalla.ShowDialog();
		}

		private void B_Inicio_Click(object sender, EventArgs e)
		{
            Form pantalla = new FormRecuperacion();
            pantalla.ShowDialog();
			Close();
        }

		private void FormInicio_Load(object sender, EventArgs e)
		{

		}
	}
}
