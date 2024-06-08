using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD
{
    public partial class FormNuevaPassword : Form
    {
        public string id { get; set; }
        public FormNuevaPassword()
        {
            InitializeComponent();
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            EnlaceDB enlaceDB = new EnlaceDB();
            string resultado = enlaceDB.sp_valida_contra_y_resp(id, TB_ContraActual.Texts, "contra");
            if (resultado == "CORRECTA")
            {
                if (TB_ContraNueva.Texts.Length > 25)
                {
                    MessageBox.Show("Formato incorrecto de contraseña: debe incluir una mayúscula, una minúscula y un carácter especial, mínimo 8 caracteres y maximo 25", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!Regex.IsMatch(TB_ContraNueva.Texts, @"(?=.*[a-z])(?=.*[A-Z])(?=.*[()¡!""#$%&/=´@¨?¿:;,._\-+*~{}[\]'|]).{8,25}")) //quizas poner un 25 aqui...
                {
                    MessageBox.Show("Formato incorrecto de contraseña: debe incluir una mayúscula, una minúscula y un carácter especial, mínimo 8 caracteres y maximo 25", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                resultado = enlaceDB.sp_nueva_contrasena(id, TB_ContraNueva.Texts);
                if (resultado == "VALIDA")
                {
                    Close();
                } else
                {
                    MessageBox.Show("La contraseña no puede ser igual a sus dos últimas contraseñas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Coontraseña equivocada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BTN_closenewpass_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_MinimizaNewPass_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
