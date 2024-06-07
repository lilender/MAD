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
    public partial class FormRecuperacion : Form
    {
        public string id { get; set; }
        public FormRecuperacion()
        {
            InitializeComponent();
            
        }
        private void FormRecuperacion_Load(object sender, EventArgs e)
        {
            EnlaceDB enlaceDB = new EnlaceDB();
            L_Pregunta.Text = enlaceDB.sp_obtener_datos_usuarios(id, "pregunta").pregunta;
        }

        private void B_Inicio_Click(object sender, EventArgs e)
        {
            EnlaceDB enlaceDB = new EnlaceDB();
            string resultado = enlaceDB.sp_valida_contra_y_resp(id, TB_Respuesta.Texts, "resp");
            if (resultado == "CORRECTA")
            {
                FormPrincipal pantalla = new FormPrincipal();
                pantalla.id = id;
                Hide();
                pantalla.ShowDialog();
                Close();
            } else
            {
                MessageBox.Show("Respuesta equivocada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
