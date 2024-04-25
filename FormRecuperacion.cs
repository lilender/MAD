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
        public FormRecuperacion()
        {
            InitializeComponent();
            L_Pregunta.Text = "Tu contraseña es contraseña_123";
        }

        private void B_Inicio_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
