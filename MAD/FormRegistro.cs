using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
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

		private void B_Registro_Click_1(object sender, EventArgs e)
		{
			bool genero = false;
			bool y = RB_R_Hombre.Checked;
			bool x = RB_R_Mujer.Checked;
			if (y) genero = false;
			else if (x) genero = true;
			if (!Regex.IsMatch(TB_R_Nombre.Texts, @"([A-Za-z]){2,20}")) { 
                MessageBox.Show("Nombre inválido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; }
			if (!Regex.IsMatch(TB_R_PApellido.Texts, @"^([A-Za-z]){2,20}$")) { 
                MessageBox.Show("Apellido paterno inválido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; }
			if (!Regex.IsMatch(TB_R_MApellido.Texts, @"^([A-Za-z]){2,20}$")) { 
                MessageBox.Show("Apellido materno inválido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; }
			if (TB_R_Pregunta.Texts == "") { 
                MessageBox.Show("Pregunta inválida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; }
			if(TB_R_Respuesta.Texts == "") { 
                MessageBox.Show("Respuesta inválida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; }
            if (DTP_R_Nacimiento.Value.Year == DateTime.Now.Year)
            {
                MessageBox.Show("Fecha inválida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string fecha = DTP_R_Nacimiento.Value.ToShortDateString();
			fecha.Replace('/', '-');
            if (!Regex.IsMatch(TB_R_Correo.Texts, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+([a-z0-9.!#$%&'*+/=?^_`{|}~-]+)*@([a-z0-9]+\.)+[a-z0-9]+"))
            {
                MessageBox.Show("Formato incorrecto del correo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(TB_R_Contra.Texts.Length > 25)
            {
                MessageBox.Show("Formato incorrecto de contraseña: debe incluir una mayúscula, una minúscula y un carácter especial, mínimo 8 caracteres y maximo 25", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Regex.IsMatch(TB_R_Contra.Texts, @"(?=.*[a-z])(?=.*[A-Z])(?=.*[()¡!""#$%&/=´@¨?¿:;,._\-+*~{}[\]'|]).{8,25}")) //quizas poner un 25 aqui...
            {
                MessageBox.Show("Formato incorrecto de contraseña: debe incluir una mayúscula, una minúscula y un carácter especial, mínimo 8 caracteres y maximo 25", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Usuario usuario = new Usuario(TB_R_Correo.Texts, TB_R_Nombre.Texts, TB_R_PApellido.Texts, TB_R_MApellido.Texts, fecha, genero, TB_R_Pregunta.Texts, TB_R_Respuesta.Texts, TB_R_Contra.Texts);

			EnlaceDB enlaceDB = new EnlaceDB();
			if (enlaceDB.sp_update_usuarios("agregar", usuario, null))
			{
                Close();
            }

        }

		private void TB_R_Pregunta_Enter(object sender, EventArgs e)
		{
            MessageBox.Show("La pregunta de seguridad sirve en caso de que haya olvidado la contraseña. Ingrese cualquier pregunta a la cual solo usted conozca la respuesta, por ejemplo, el nombre de su mascota de la niñez.", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

		
	}
}
