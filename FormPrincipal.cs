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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            

        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            //resetear contador de intentos
            //SI NO HAY CONTRASEÑA
            Form pantalla = new FormNuevaContra();
            pantalla.ShowDialog();
        }

        private void B_Buscar_Click(object sender, EventArgs e)
        {
            clear();
            for (int i = 0; i < 10; i++)
            {
                L_Con_Dir.Add(new Label());
                this.panel1.Controls.Add(L_Con_Dir[i]);
                L_Con_Dir[i].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))); ;
                L_Con_Dir[i].AutoSize = true;
                L_Con_Dir[i].Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_Con_Dir[i].Location = new System.Drawing.Point(15, 15 + (i * 120));
                L_Con_Dir[i].Name = "L_Con_Dir";
                L_Con_Dir[i].Size = new System.Drawing.Size(123, 23);
                L_Con_Dir[i].Text = "Genesis 3:" + i;
                L_Con_Dir[i].Visible = true;

                L_Con_Versiculo.Add(new RichTextBox());
                this.panel1.Controls.Add(L_Con_Versiculo[i]);
                L_Con_Versiculo[i].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left)));
                L_Con_Versiculo[i].BackColor = System.Drawing.Color.Azure;
                L_Con_Versiculo[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                L_Con_Versiculo[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_Con_Versiculo[i].Location = new System.Drawing.Point(30, 40 + (i*120) );
                L_Con_Versiculo[i].Name = "L_Con_Versiculo";
                L_Con_Versiculo[i].Size = new System.Drawing.Size(panel1.Width - 60, 42);
                L_Con_Versiculo[i].Text = "Dieu appela la lumière jour, et il appela les ténèbres nuit. Ainsi, il y eut un soir, et il y eut un matin: ce fut le premier jour.";
                L_Con_Versiculo[i].Visible = true;

                B_Con_Copiar.Add(new Button());
                this.panel1.Controls.Add(B_Con_Copiar[i]);
                B_Con_Copiar[i].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                B_Con_Copiar[i].AutoSize = true;
                B_Con_Copiar[i].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                B_Con_Copiar[i].BackColor = System.Drawing.Color.Azure;
                B_Con_Copiar[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                B_Con_Copiar[i].Location = new System.Drawing.Point(panel1.Width - 255, 90 + (i * 120));
                B_Con_Copiar[i].Name = "B_Con_Copiar";
                B_Con_Copiar[i].Size = new System.Drawing.Size(76, 31);
                B_Con_Copiar[i].Text = "Copiar";
                B_Con_Copiar[i].UseVisualStyleBackColor = false;
                B_Con_Copiar[i].Visible = true;

                B_Con_Agregar.Add(new CheckBox());
                this.panel1.Controls.Add(B_Con_Agregar[i]);
                B_Con_Agregar[i].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                B_Con_Agregar[i].Appearance = System.Windows.Forms.Appearance.Button;
                B_Con_Agregar[i].AutoSize = true;
                B_Con_Agregar[i].BackColor = System.Drawing.Color.Azure;
                B_Con_Agregar[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                B_Con_Agregar[i].Location = new System.Drawing.Point(panel1.Width - 380, 90 + (i*120) );
                B_Con_Agregar[i].Name = "B_Con_Agregar";
                B_Con_Agregar[i].Size = new System.Drawing.Size(350, 31);
                B_Con_Agregar[i].Text = "Agregar a favoritos";
                B_Con_Agregar[i].UseVisualStyleBackColor = false;
                B_Con_Agregar[i].Visible = true;
            }
            panel1.AutoScrollMinSize = new System.Drawing.Size(0, 10 * 120 + 50);
        }

        private void B_Favoritos_Click(object sender, EventArgs e)
        {
            clear();
            L_Fav_Titulo.Visible = true;
            for (int i = 0; i < 5; i++)
            {
                L_Fav_Dir.Add(new Label());
                this.panel1.Controls.Add(L_Fav_Dir[i]);
                L_Fav_Dir[i].AutoSize = true;
                L_Fav_Dir[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_Fav_Dir[i].Location = new System.Drawing.Point(15, 40 + (i * 110));
                L_Fav_Dir[i].Name = "L_Fav_Dir";
                L_Fav_Dir[i].Size = new System.Drawing.Size(110, 21);
                L_Fav_Dir[i].Text = "Nombres 20:" + i;
                L_Fav_Dir[i].Visible = true;

                L_Fav_Versiculo.Add(new RichTextBox());
                this.panel1.Controls.Add(L_Fav_Versiculo[i]);
                L_Fav_Versiculo[i].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left)));
                L_Fav_Versiculo[i].BackColor = System.Drawing.Color.Azure;
                L_Fav_Versiculo[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                L_Fav_Versiculo[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_Fav_Versiculo[i].Location = new System.Drawing.Point(30, 65 + (i * 110));
                L_Fav_Versiculo[i].Name = "L_Fav_Versiculo";
                L_Fav_Versiculo[i].Size = new System.Drawing.Size(panel1.Width - 60, 42);
                L_Fav_Versiculo[i].Text = "Toute l'assemblée vit qu'Aaron avait expiré, et toute la maison d'Israël pleura Aaron pendant trente jours.";
                L_Fav_Versiculo[i].Visible = true;

                B_Fav_Quitar.Add(new CheckBox());
                this.panel1.Controls.Add(B_Fav_Quitar[i]);
                B_Fav_Quitar[i].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                B_Fav_Quitar[i].Appearance = System.Windows.Forms.Appearance.Button;
                B_Fav_Quitar[i].AutoSize = true;
                B_Fav_Quitar[i].BackColor = System.Drawing.Color.Azure;
                B_Fav_Quitar[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                B_Fav_Quitar[i].Location = new System.Drawing.Point(panel1.Width - 205, 115 + (i * 110));
                B_Fav_Quitar[i].Name = "B_Fav_Quitar";
                B_Fav_Quitar[i].Size = new System.Drawing.Size(176, 31);
                B_Fav_Quitar[i].Text = "Quitar de favoritos";
                B_Fav_Quitar[i].UseVisualStyleBackColor = false;
                B_Fav_Quitar[i].Visible = true;

            }
            panel1.AutoScrollMinSize = new System.Drawing.Size(0, 5 * 110 + 50);

        }


        private void B_Historial_Click(object sender, EventArgs e)
        {
            clear();
            L_His_Titulo.Visible = true;
            for (int i = 0; i < 5; i++)
            {
                L_His_Fecha.Add(new Label());
                this.panel1.Controls.Add(L_His_Fecha[i]);
                L_His_Fecha[i].AutoSize = true;
                L_His_Fecha[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_His_Fecha[i].Location = new System.Drawing.Point(15, 40 + (i * 80));
                L_His_Fecha[i].Name = "L_His_Fecha";
                L_His_Fecha[i].Size = new System.Drawing.Size(116, 21);
                L_His_Fecha[i].Text = "23/09/2023";
                L_His_Fecha[i].Visible = true;

                L_His_Busqueda.Add(new Label());
                this.panel1.Controls.Add(L_His_Busqueda[i]);
                L_His_Busqueda[i].AutoSize = true;
                L_His_Busqueda[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_His_Busqueda[i].Location = new System.Drawing.Point(30, 60 + (i * 80));
                L_His_Busqueda[i].Name = "L_His_Busqueda";
                L_His_Busqueda[i].Size = new System.Drawing.Size(300, 42);
                L_His_Busqueda[i].Text = "\"Casita\" buscado en xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
                L_His_Busqueda[i].Visible = true;

                B_His_Resultados.Add(new Button());
                this.panel1.Controls.Add(B_His_Resultados[i]);
                B_His_Resultados[i].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                B_His_Resultados[i].AutoSize = true;
                B_His_Resultados[i].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                B_His_Resultados[i].BackColor = System.Drawing.Color.Azure;
                B_His_Resultados[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                B_His_Resultados[i].Location = new System.Drawing.Point(panel1.Width - 170, 83 + (i * 80));
                B_His_Resultados[i].Name = "B_His_Resultados";
                B_His_Resultados[i].Size = new System.Drawing.Size(143, 31);
                B_His_Resultados[i].Text = "Ver resultados";
                B_His_Resultados[i].UseVisualStyleBackColor = false;
                B_His_Resultados[i].Visible = true;

            }
            panel1.AutoScrollMinSize = new System.Drawing.Size(0, 5 * 80 + 50);
            
        }

        private void clear()
        {
            foreach (var item in B_Con_Copiar)
            {
                item.Visible = false;
            }
            B_Con_Copiar.Clear();

            foreach (var item in L_Con_Versiculo)
            {
                item.Visible = false;
            }
            L_Con_Versiculo.Clear();

            foreach (var item in B_Con_Agregar)
            {
                item.Visible = false;
            }
            B_Con_Agregar.Clear();

            foreach (var item in L_Con_Dir)
            {
                item.Visible = false;
            }
            L_Con_Dir.Clear();

            L_Fav_Titulo.Visible = false;

            foreach (var item in L_Fav_Dir)
            {
                item.Visible = false;
            }
            L_Fav_Dir.Clear();

            foreach (var item in L_Fav_Versiculo)
            {
                item.Visible = false;
            }
            L_Fav_Versiculo.Clear();

            foreach (var item in B_Fav_Quitar)
            {
                item.Visible = false;
            }
            B_Fav_Quitar.Clear();

            L_His_Titulo.Visible = false;

            foreach (var item in L_His_Fecha)
            {
                item.Visible = false;
            }
            L_His_Fecha.Clear();

            foreach (var item in L_His_Busqueda)
            {
                item.Visible = false;
            }
            L_His_Busqueda.Clear();

            foreach (var item in B_His_Resultados)
            {
                item.Visible = false;
            }
            B_His_Resultados.Clear();

            panel1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
