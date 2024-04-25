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
    public partial class FormUsuario : Form
    {
        public string id { get; set; }

        public FormUsuario()
        {
            InitializeComponent();
        }

        private Usuario usuario = new Usuario();

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            EnlaceDB enlaceDB = new EnlaceDB();
            usuario = enlaceDB.sp_obtener_datos_usuarios(id, "todo");
            TB_U_Nombre.Texts = usuario.nombres;
            TB_U_PApellido.Texts = usuario.apellido_p;
            TB_U_MApellido.Texts = usuario.apellido_m;
            TB_U_Correo.Texts = usuario.correo;
            TB_U_Pregunta.Texts = usuario.pregunta;
            if (usuario.genero)
            {
                RB_U_Mujer.Checked = true;
                RB_U_Hombre.Checked = false;
            } else
            {
                RB_U_Mujer.Checked = false;
                RB_U_Hombre.Checked = true;
            }
            string fecha = usuario.f_nacimiento;
            fecha.Replace('-', '/');
            DTP_U_Nacimiento.Value = DateTime.Parse(fecha);
        }

        private void B_U_CerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void B_U_GuardarCambios_Click(object sender, EventArgs e)
        {
            
            bool genero = false;
            bool y = RB_U_Hombre.Checked;
            bool x = RB_U_Mujer.Checked;
            if (y) genero = false;
            else if (x) genero = true;
            
            if (!Regex.IsMatch(TB_U_Nombre.Texts, @"([A-Za-z]){2,20}"))
            {
                MessageBox.Show("Nombre inválido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Regex.IsMatch(TB_U_PApellido.Texts, @"^([A-Za-z]){2,20}$"))
            {
                MessageBox.Show("Apellido paterno inválido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Regex.IsMatch(TB_U_MApellido.Texts, @"^([A-Za-z]){2,20}$"))
            {
                MessageBox.Show("Apellido materno inválido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TB_U_Pregunta.Texts == "")
            {
                MessageBox.Show("Pregunta inválida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (DTP_U_Nacimiento.Value.Year == DateTime.Now.Year)
            {
                MessageBox.Show("Fecha inválida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string fecha = DTP_U_Nacimiento.Value.ToShortDateString();
            fecha.Replace('/', '-');
            if (!Regex.IsMatch(TB_U_Correo.Texts, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+([a-z0-9.!#$%&'*+/=?^_`{|}~-]+)*@([a-z0-9]+\.)+[a-z0-9]+"))
            {
                MessageBox.Show("Formato incorrecto del correo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            usuario.correo = TB_U_Correo.Texts;
            usuario.nombres = TB_U_Nombre.Texts;
            usuario.apellido_p = TB_U_PApellido.Texts;
            usuario.apellido_m = TB_U_MApellido.Texts;
            usuario.f_nacimiento = fecha;
            usuario.genero = genero;
            usuario.pregunta = TB_U_Pregunta.Texts;

            EnlaceDB enlaceDB = new EnlaceDB();
            if (enlaceDB.sp_update_usuarios("cambiar", usuario, id))
            {
                TB_U_Nombre.Enabled = false;
                TB_U_PApellido.Enabled = false;
                TB_U_MApellido.Enabled = false;
                TB_U_Correo.Enabled = false;
                TB_U_Pregunta.Enabled = false;
                RB_U_Hombre.Enabled = false;
                RB_U_Mujer.Enabled = false;
                DTP_U_Nacimiento.Enabled = false;
                B_U_CambioContra.Enabled = false;
                B_U_CambioResp.Enabled = false;
            }
        }

        private void B_U_EditarInfo_Click(object sender, EventArgs e)
        {
            TB_U_Nombre.Enabled = true;
            TB_U_PApellido.Enabled = true;
            TB_U_MApellido.Enabled=true;
            TB_U_Correo.Enabled = true;
            TB_U_Pregunta.Enabled = true;
            RB_U_Hombre.Enabled = true;
            RB_U_Mujer.Enabled = true;
            DTP_U_Nacimiento.Enabled = true;
            B_U_CambioContra.Enabled = true;
            B_U_CambioResp.Enabled = true;
        }

        private void B_U_CambioContra_Click(object sender, EventArgs e)
        {
            FormNuevaPassword pantalla = new FormNuevaPassword();
            pantalla.id = id;
            this.Hide();
            pantalla.ShowDialog();
            this.Show();
        }

        private void B_U_CambioResp_Click(object sender, EventArgs e)
        {
            FormNuevaResp pantalla = new FormNuevaResp();
            pantalla.id = id;
            this.Hide();
            pantalla.ShowDialog();
            this.Show();
        }

        private void B_U_Baja_Click(object sender, EventArgs e)
        {
            EnlaceDB enlaceDB = new EnlaceDB();
            enlaceDB.sp_update_usuarios("borrar", usuario, id);
            Application.Exit();
        }
    }
}
