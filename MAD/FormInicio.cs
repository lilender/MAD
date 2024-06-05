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
        private string id { get; set; }
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
            if (TB_Inicio_Correo.Texts == "")
            {
                MessageBox.Show("Escriba un correo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TB_Inicio_Contra.Texts == "")
            {
                MessageBox.Show("Escriba una contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            EnlaceDB enlaceDB = new EnlaceDB();
            id = enlaceDB.sp_obtener_id(TB_Inicio_Correo.Texts);
            if (id == "")
            {
                MessageBox.Show("No hay una cuenta asociada a este correo","Mensaje" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string resultado = enlaceDB.sp_obtener_datos_usuarios(id, "contador").contador;
            if (resultado == "3") {         //si el contador ya es = 3 te manda directo al form recuperacion
                FormRecuperacion pantalla = new FormRecuperacion();
                pantalla.id = id;
                Hide();
                pantalla.ShowDialog();
                Close();
            }
            else
            {
                resultado = enlaceDB.sp_valida_contra_y_resp(id, TB_Inicio_Contra.Texts, "contra");
                if (resultado == "CORRECTA")
                {
                    FormPrincipal pantalla = new FormPrincipal();
                    pantalla.id = id;
                    Hide();
                    pantalla.ShowDialog();
                    Close();
                }
                else if (resultado == "MAX")
                {
                    FormRecuperacion pantalla = new FormRecuperacion();
                    pantalla.id = id;
                    Hide();
                    pantalla.ShowDialog();
                    Close();
                }
                else if (resultado == "INCORRECTA")
                {
                    MessageBox.Show("Contraseña equivocada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void BTN_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
