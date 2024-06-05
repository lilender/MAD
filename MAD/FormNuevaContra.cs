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
    public partial class FormNuevaContra : Form
    {
        public string id { get; set; }
        public FormNuevaContra()
        {
            InitializeComponent();
        }
        
        private void B_Confirmar_Click(object sender, EventArgs e)
        {
            if (TB_NuevaContra.Texts.Length > 25)
            {
                MessageBox.Show("Formato incorrecto de contraseña: debe incluir una mayúscula, una minúscula y un carácter especial, mínimo 8 caracteres y maximo 25", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Regex.IsMatch(TB_NuevaContra.Texts, @"(?=.*[a-z])(?=.*[A-Z])(?=.*[()¡!""#$%&/=´@¨?¿:;,._\-+*~{}[\]'|]).{8,25}")) //quizas poner un 25 aqui...
            {
                MessageBox.Show("Formato incorrecto de contraseña: debe incluir una mayúscula, una minúscula y un carácter especial, mínimo 8 caracteres y maximo 25", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            EnlaceDB enlaceDB = new EnlaceDB();
            
            string resultado = enlaceDB.sp_nueva_contrasena(id, TB_NuevaContra.Texts);

            if (resultado == "INVALIDA")
            {
                MessageBox.Show("La contraseña no puede ser igual a sus dos últimas contraseñas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (resultado == "VALIDA")
            {
                Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
