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
    public partial class FormNuevaResp : Form
    {
        public string id { get; set; }
        public FormNuevaResp()
        {
            InitializeComponent();
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            EnlaceDB enlaceDB = new EnlaceDB();
            string resultado = enlaceDB.sp_cambio_respuesta(id, TB_RespActual.Texts, TB_RespNueva.Texts);
            if (resultado == "INVALIDA")
            {
                MessageBox.Show("Respuesta incorrecta", "Aviso");
            }
            else if (resultado == "VALIDA")
            {
                Close();
            }
        }
    }
}
