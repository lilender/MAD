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
	public partial class FormRegistro : Form
	{
		public FormRegistro()
		{
			InitializeComponent();
		}

		private void B_Registro_Click(object sender, EventArgs e)
		{

		}
		private void T_Pregunta_Click(object sender, EventArgs e)
		{
			MessageBox.Show("La pregunta de seguridad sirve en caso de que haya olvidado la contraseña. Ingrese cualquier pregunta a la cual solo usted conozca la respuesta, por ejemplo, el nombre de su mascota de la niñez.", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
