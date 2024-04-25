using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace MAD
{
    public partial class FormPrincipal : Form
    {
        public string id { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();


        }
        private DataTable dataTable {  get; set; }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            EnlaceDB enlaceDB = new EnlaceDB();
            string resultado = enlaceDB.sp_obtener_datos_usuarios(id, "contador").contador;
            while (resultado == "3")
            {
                FormNuevaContra pantalla = new FormNuevaContra();
                pantalla.id = id;
                pantalla.ShowDialog();

                resultado = enlaceDB.sp_obtener_datos_usuarios(id, "contador").contador;
            }
            DataTable tabla = enlaceDB.sp_llenar_combos("0","0", "0", "0", "0");
            string idioma = enlaceDB.sp_obtener_datos_usuarios(id, "idioma").idioma;
            int count = 0;
            foreach (DataRow item in tabla.Rows)
            {
                CB_Idioma.Items.Add(item.ItemArray[0].ToString());
                if (item.ItemArray[0].ToString() == idioma)
                {
                    CB_Idioma.SelectedIndex = count;
                }
                count++;
            }
            tabla.Clear();
            label1_Click(this, EventArgs.Empty);

        }

        private void B_Buscar_Click(object sender, EventArgs e)
        {
            if (CB_Idioma.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un idioma", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (CB_Version.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una versión", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            EnlaceDB enlaceDB = new EnlaceDB();
            DataTable tabla = enlaceDB.sp_resultados(
                CB_Idioma.SelectedItem,
                CB_Version.SelectedItem,
                CB_Testa.SelectedItem,
                CB_Libro.SelectedItem,
                CB_Cap.SelectedItem,
                CB_Versiculo.SelectedItem,
                T_Busqueda.Texts, id);


            clear();
            if (tabla.Rows.Count < 1)
            {
                L_Fav_Titulo.Text = "No se han encontrado resultados";
                L_Fav_Titulo.Visible = true;
                return;
            }

            int max = tabla.Rows.Count;
            if (max > 50)
            {
                max = 50;
            }
            for (int i = 0; i < max; i++)
            {
                L_Con_Dir.Add(new Label());
                this.panel1.Controls.Add(L_Con_Dir[i]);
                L_Con_Dir[i].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))); ;
                L_Con_Dir[i].AutoSize = true;
                L_Con_Dir[i].Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_Con_Dir[i].Location = new System.Drawing.Point(15, 15 + (i * 120));
                L_Con_Dir[i].Name = "L_Con_Dir";
                L_Con_Dir[i].Size = new System.Drawing.Size(123, 23);
                L_Con_Dir[i].Text = tabla.Rows[i].ItemArray[1].ToString() + " "
                                    + tabla.Rows[i].ItemArray[2].ToString() + ":"
                                    + tabla.Rows[i].ItemArray[3].ToString();
                L_Con_Dir[i].Visible = true;

                L_Con_Versiculo.Add(new RichTextBox());
                this.panel1.Controls.Add(L_Con_Versiculo[i]);
                L_Con_Versiculo[i].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left)));
                L_Con_Versiculo[i].BackColor = System.Drawing.Color.Azure;
                L_Con_Versiculo[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                L_Con_Versiculo[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_Con_Versiculo[i].Location = new System.Drawing.Point(30, 40 + (i * 120));
                L_Con_Versiculo[i].Name = "L_Con_Versiculo";
                L_Con_Versiculo[i].Size = new System.Drawing.Size(panel1.Width - 60, 42);
                L_Con_Versiculo[i].Text = tabla.Rows[i].ItemArray[4].ToString();
                L_Con_Versiculo[i].Visible = true;
                L_Con_Versiculo[i].ReadOnly = true;

                B_Con_Copiar.Add(new RJButton());
                this.panel1.Controls.Add(B_Con_Copiar[i]);
                B_Con_Copiar[i].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                B_Con_Copiar[i].AutoSize = true;
                B_Con_Copiar[i].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                //B_Con_Copiar[i].BackColor = System.Drawing.Color.Azure;
                B_Con_Copiar[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                B_Con_Copiar[i].Location = new System.Drawing.Point(panel1.Width - 265, 90 + (i * 120));
                B_Con_Copiar[i].Name = tabla.Rows[i].ItemArray[4].ToString();
                B_Con_Copiar[i].Size = new System.Drawing.Size(76, 31);
                B_Con_Copiar[i].Text = "Copiar";
                B_Con_Copiar[i].UseVisualStyleBackColor = false;
                B_Con_Copiar[i].Visible = true;
                B_Con_Copiar[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_Con_Copiar[i].BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_Con_Copiar[i].BorderColor = System.Drawing.SystemColors.ControlLightLight;
                B_Con_Copiar[i].BorderRadius = 10;
                B_Con_Copiar[i].BorderSize = 0;
                B_Con_Copiar[i].FlatAppearance.BorderSize = 0;
                B_Con_Copiar[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                B_Con_Copiar[i].ForeColor = System.Drawing.Color.Navy;
                B_Con_Copiar[i].TextColor = System.Drawing.Color.Navy;
                B_Con_Copiar[i].Click += new EventHandler(B_Con_Copiar_Click);

                B_Con_Agregar.Add(new RJButton());
                this.panel1.Controls.Add(B_Con_Agregar[i]);
                B_Con_Agregar[i].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                B_Con_Agregar[i].AutoSize = true;
                //B_Con_Agregar[i].BackColor = System.Drawing.Color.Azure;
                B_Con_Agregar[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                B_Con_Agregar[i].Location = new System.Drawing.Point(panel1.Width - 180, 90 + (i * 120));
                B_Con_Agregar[i].Name = tabla.Rows[i].ItemArray[0].ToString() + "$"
                                    + tabla.Rows[i].ItemArray[1].ToString() + "$"
                                    + tabla.Rows[i].ItemArray[2].ToString() + "$"
                                    + tabla.Rows[i].ItemArray[3].ToString();
                B_Con_Agregar[i].Size = new System.Drawing.Size(150, 31);
                B_Con_Agregar[i].Text = "Agregar a favoritos";
                B_Con_Agregar[i].UseVisualStyleBackColor = false;
                B_Con_Agregar[i].Visible = true;
                B_Con_Agregar[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_Con_Agregar[i].BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_Con_Agregar[i].BorderColor = System.Drawing.SystemColors.ControlLightLight;
                B_Con_Agregar[i].BorderRadius = 10;
                B_Con_Agregar[i].BorderSize = 0;
                B_Con_Agregar[i].FlatAppearance.BorderSize = 0;
                B_Con_Agregar[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                B_Con_Agregar[i].ForeColor = System.Drawing.Color.Navy;
                B_Con_Agregar[i].TextColor = System.Drawing.Color.Navy;
                B_Con_Agregar[i].Click += new EventHandler(B_Con_Agregar_Click);
                if(i == max)
                {
                    break;
                }
            }
            panel1.AutoScrollMinSize = new System.Drawing.Size(0, max * 120 + 50);
        }

        private void B_Favoritos_Click(object sender, EventArgs e)
        {
            clear();

            //limpiamos idiomas y los recargamos para volver a obtener su index 
            EnlaceDB enlaceDB = new EnlaceDB();
            DataTable tabla = enlaceDB.sp_llenar_combos("0", "0", "0", "0", "0");
            string idioma = enlaceDB.sp_obtener_datos_usuarios(id, "idioma").idioma;
            int count = 0;
            CB_Idioma.Items.Clear();
            foreach (DataRow item in tabla.Rows)
            {
                CB_Idioma.Items.Add(item.ItemArray[0].ToString());
                if (item.ItemArray[0].ToString() == idioma)
                {
                    CB_Idioma.SelectedIndex = count;
                }
                count++;
            }
            tabla.Clear();
            //obtenemos favoritos
            tabla = enlaceDB.sp_favoritos(id);
            dataTable = tabla;
            clear();

            if (tabla.Rows.Count < 1)
            {
                L_Fav_Titulo.Text = "No se han seleccionado favoritos";
                L_Fav_Titulo.Visible = true;
                return;
            }
            L_Fav_Titulo.Visible = true;
            L_Fav_Titulo.Text = "Favoritos";

            int n_control = 0;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                L_Fav_Versiculo.Add(new RichTextBox());
                this.panel1.Controls.Add(L_Fav_Versiculo[n_control]);
                L_Fav_Versiculo[n_control].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left)));
                L_Fav_Versiculo[n_control].BackColor = System.Drawing.Color.Azure;
                L_Fav_Versiculo[n_control].BorderStyle = System.Windows.Forms.BorderStyle.None;
                L_Fav_Versiculo[n_control].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_Fav_Versiculo[n_control].Location = new System.Drawing.Point(30, 65 + (n_control * 110));
                L_Fav_Versiculo[n_control].Name = "L_Fav_Versiculo";
                L_Fav_Versiculo[n_control].Size = new System.Drawing.Size(panel1.Width - 60, 42);
                L_Fav_Versiculo[n_control].Text = "";
                L_Fav_Versiculo[n_control].Visible = true;
                L_Fav_Versiculo[n_control].ReadOnly = true;

                B_Fav_Quitar.Add(new RJButton());
                this.panel1.Controls.Add(B_Fav_Quitar[n_control]);
                B_Fav_Quitar[n_control].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                B_Fav_Quitar[n_control].AutoSize = true;
                //B_Fav_Quitar[i].BackColor = System.Drawing.Color.Azure;
                B_Fav_Quitar[n_control].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                B_Fav_Quitar[n_control].Location = new System.Drawing.Point(panel1.Width - 205, 115 + (n_control * 110));
                B_Fav_Quitar[n_control].Name = tabla.Rows[i].ItemArray[6].ToString();
                B_Fav_Quitar[n_control].Size = new System.Drawing.Size(176, 31);
                B_Fav_Quitar[n_control].Text = "Quitar de favoritos";
                B_Fav_Quitar[n_control].UseVisualStyleBackColor = false;
                B_Fav_Quitar[n_control].Visible = true;
                B_Fav_Quitar[n_control].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_Fav_Quitar[n_control].BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_Fav_Quitar[n_control].BorderColor = System.Drawing.SystemColors.ControlLightLight;
                B_Fav_Quitar[n_control].BorderRadius = 10;
                B_Fav_Quitar[n_control].BorderSize = 0;
                B_Fav_Quitar[n_control].FlatAppearance.BorderSize = 0;
                B_Fav_Quitar[n_control].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                B_Fav_Quitar[n_control].ForeColor = System.Drawing.Color.Navy;
                B_Fav_Quitar[n_control].TextColor = System.Drawing.Color.Navy;
                B_Fav_Quitar[n_control].Click += new EventHandler(B_Fav_Quitar_Click);

                L_Fav_Dir.Add(new Label());
                this.panel1.Controls.Add(L_Fav_Dir[n_control]);
                L_Fav_Dir[n_control].AutoSize = true;
                L_Fav_Dir[n_control].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_Fav_Dir[n_control].Location = new System.Drawing.Point(15, 40 + (n_control * 110));
                L_Fav_Dir[n_control].Name = "L_Fav_Dir";
                L_Fav_Dir[n_control].Size = new System.Drawing.Size(110, 21);
                L_Fav_Dir[n_control].Text = tabla.Rows[i].ItemArray[1].ToString() + " " + tabla.Rows[i].ItemArray[2].ToString() + " " + tabla.Rows[i].ItemArray[3].ToString();
                L_Fav_Dir[n_control].Visible = true;
                if (tabla.Rows[i].ItemArray[4].ToString() != "")
                {
                    L_Fav_Dir[n_control].Text += ":" + tabla.Rows[i].ItemArray[4].ToString();    //versiculo
                    L_Fav_Versiculo[n_control].Text = tabla.Rows[i].ItemArray[5].ToString();
                }
                else
                {
                    while (tabla.Rows[i].ItemArray[4].ToString() == "")
                    {
                        L_Fav_Versiculo[n_control].Text += tabla.Rows[i].ItemArray[5].ToString() +" ";
                        i++;
                        if (i == tabla.Rows.Count)
                        {
                            break;
                        }
                        if (tabla.Rows[i-1].ItemArray[6].ToString() != tabla.Rows[i].ItemArray[6].ToString())
                        {
                            break;
                        }
                    }
                    i--;

                }
                B_Con_Copiar.Add(new RJButton());
                this.panel1.Controls.Add(B_Con_Copiar[n_control]);
                B_Con_Copiar[n_control].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                B_Con_Copiar[n_control].AutoSize = true;
                B_Con_Copiar[n_control].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                //B_Con_Copiar[i].BackColor = System.Drawing.Color.Azure;
                B_Con_Copiar[n_control].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                B_Con_Copiar[n_control].Location = new System.Drawing.Point(panel1.Width - 290, 115 + (n_control * 110));
                B_Con_Copiar[n_control].Name = L_Fav_Versiculo[n_control].Text;
                B_Con_Copiar[n_control].Size = new System.Drawing.Size(76, 31);
                B_Con_Copiar[n_control].Text = "Copiar";
                B_Con_Copiar[n_control].UseVisualStyleBackColor = false;
                B_Con_Copiar[n_control].Visible = true;
                B_Con_Copiar[n_control].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_Con_Copiar[n_control].BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_Con_Copiar[n_control].BorderColor = System.Drawing.SystemColors.ControlLightLight;
                B_Con_Copiar[n_control].BorderRadius = 10;
                B_Con_Copiar[n_control].BorderSize = 0;
                B_Con_Copiar[n_control].FlatAppearance.BorderSize = 0;
                B_Con_Copiar[n_control].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                B_Con_Copiar[n_control].ForeColor = System.Drawing.Color.Navy;
                B_Con_Copiar[n_control].TextColor = System.Drawing.Color.Navy;
                B_Con_Copiar[n_control].Click += new EventHandler(B_Con_Copiar_Click);
                n_control++;
            }
            panel1.AutoScrollMinSize = new System.Drawing.Size(0, n_control * 110 + 50);

        }

        private void B_Historial_Click(object sender, EventArgs e)
        {
            //limpiamos idiomas y los recargamos para volver a obtener su index 
            EnlaceDB enlaceDB = new EnlaceDB();
            DataTable tabla = enlaceDB.sp_llenar_combos("0", "0", "0", "0", "0");
            string idioma = enlaceDB.sp_obtener_datos_usuarios(id, "idioma").idioma;
            int count = 0;
            CB_Idioma.Items.Clear();
            foreach (DataRow item in tabla.Rows)
            {
                CB_Idioma.Items.Add(item.ItemArray[0].ToString());
                if (item.ItemArray[0].ToString() == idioma)
                {
                    CB_Idioma.SelectedIndex = count;
                }
                count++;
            }
            tabla.Clear();
            //obtenemos historial
            tabla = enlaceDB.sp_historial(id);
            dataTable = tabla;
            DateTime fecha;
            clear();
            if (tabla.Rows.Count < 1)
            {
                L_Fav_Titulo.Text = "No hay historial";
                L_Fav_Titulo.Visible = true;
                return;
            }

            L_His_Titulo.Visible = true;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                L_His_Fecha.Add(new Label());
                this.panel1.Controls.Add(L_His_Fecha[i]);
                L_His_Fecha[i].AutoSize = true;
                L_His_Fecha[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_His_Fecha[i].Location = new System.Drawing.Point(15, 40 + (i * 80));
                L_His_Fecha[i].Name = "L_His_Fecha";
                L_His_Fecha[i].Size = new System.Drawing.Size(116, 21);
                fecha = (DateTime)tabla.Rows[i].ItemArray[7];
                L_His_Fecha[i].Text = fecha.ToShortDateString();
                L_His_Fecha[i].Visible = true;

                L_His_Busqueda.Add(new Label());
                this.panel1.Controls.Add(L_His_Busqueda[i]);
                L_His_Busqueda[i].AutoSize = true;
                L_His_Busqueda[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_His_Busqueda[i].Location = new System.Drawing.Point(30, 60 + (i * 80));
                L_His_Busqueda[i].Name = "L_His_Busqueda";
                L_His_Busqueda[i].Size = new System.Drawing.Size(300, 42);
                if (tabla.Rows[i].ItemArray[6].ToString() == "")
                {
                    L_His_Busqueda[i].Text = "Consulta en ";
                                            
                } else
                {
                    L_His_Busqueda[i].Text = "Busqueda de " + tabla.Rows[i].ItemArray[6] + " en ";
                }
                L_His_Busqueda[i].Text += tabla.Rows[i].ItemArray[1] + "-";   //version
                                        
                if (tabla.Rows[i].ItemArray[2].ToString() != "")
                {
                    L_His_Busqueda[i].Text += tabla.Rows[i].ItemArray[2] + " ";   //testamento
                }
                if (tabla.Rows[i].ItemArray[3].ToString() != "")
                {
                    L_His_Busqueda[i].Text += tabla.Rows[i].ItemArray[3] + " ";   //libro
                }
                if (tabla.Rows[i].ItemArray[4].ToString() != "")
                {
                    L_His_Busqueda[i].Text += tabla.Rows[i].ItemArray[4];   //capitulo
                }
                if (tabla.Rows[i].ItemArray[5].ToString() != "")
                {
                    L_His_Busqueda[i].Text += ":" + tabla.Rows[i].ItemArray[5];    //versiculo
                }
                L_His_Busqueda[i].Visible = true;

                B_His_Resultados.Add(new RJButton());
                this.panel1.Controls.Add(B_His_Resultados[i]);
                B_His_Resultados[i].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                B_His_Resultados[i].AutoSize = true;
                B_His_Resultados[i].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                //B_His_Resultados[i].BackColor = System.Drawing.Color.Azure;
                B_His_Resultados[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                B_His_Resultados[i].Location = new System.Drawing.Point(panel1.Width - 170, 83 + (i * 80));
                B_His_Resultados[i].Name = i.ToString();
                B_His_Resultados[i].Size = new System.Drawing.Size(143, 31);
                B_His_Resultados[i].Text = "Ver resultados";
                B_His_Resultados[i].UseVisualStyleBackColor = false;
                B_His_Resultados[i].Visible = true;
                B_His_Resultados[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_His_Resultados[i].BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_His_Resultados[i].BorderColor = System.Drawing.SystemColors.ControlLightLight;
                B_His_Resultados[i].BorderRadius = 10;
                B_His_Resultados[i].BorderSize = 0;
                B_His_Resultados[i].FlatAppearance.BorderSize = 0;
                B_His_Resultados[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                B_His_Resultados[i].ForeColor = System.Drawing.Color.Navy;
                B_His_Resultados[i].TextColor = System.Drawing.Color.Navy;
                B_His_Resultados[i].Click += new EventHandler(B_His_Resultados_Click);

                B_His_Borrar.Add(new RJButton());
                this.panel1.Controls.Add(B_His_Borrar[i]);
                B_His_Borrar[i].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                B_His_Borrar[i].AutoSize = true;
                B_His_Borrar[i].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                B_His_Borrar[i].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                B_His_Borrar[i].Location = new System.Drawing.Point(panel1.Width - 240, 83 + (i * 80));
                B_His_Borrar[i].Name = tabla.Rows[i].ItemArray[8].ToString();
                B_His_Borrar[i].Size = new System.Drawing.Size(76, 31);
                B_His_Borrar[i].Text = "Borrar";
                B_His_Borrar[i].UseVisualStyleBackColor = false;
                B_His_Borrar[i].Visible = true;
                B_His_Borrar[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_His_Borrar[i].BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_His_Borrar[i].BorderColor = System.Drawing.SystemColors.ControlLightLight;
                B_His_Borrar[i].BorderRadius = 10;
                B_His_Borrar[i].BorderSize = 0;
                B_His_Borrar[i].FlatAppearance.BorderSize = 0;
                B_His_Borrar[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                B_His_Borrar[i].ForeColor = System.Drawing.Color.Navy;
                B_His_Borrar[i].TextColor = System.Drawing.Color.Navy;
                B_His_Borrar[i].Click += new EventHandler(B_His_Borrar_Click);
            }
            B_His_Borrar.Add(new RJButton());
            this.panel1.Controls.Add(B_His_Borrar[tabla.Rows.Count]);
            B_His_Borrar[tabla.Rows.Count].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            B_His_Borrar[tabla.Rows.Count].AutoSize = true;
            B_His_Borrar[tabla.Rows.Count].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            B_His_Borrar[tabla.Rows.Count].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            B_His_Borrar[tabla.Rows.Count].Location = new System.Drawing.Point(panel1.Width - 170, 50 + (tabla.Rows.Count * 80));
            B_His_Borrar[tabla.Rows.Count].Name = "ALL";
            B_His_Borrar[tabla.Rows.Count].Size = new System.Drawing.Size(143, 31);
            B_His_Borrar[tabla.Rows.Count].Text = "Borrar todos";
            B_His_Borrar[tabla.Rows.Count].UseVisualStyleBackColor = false;
            B_His_Borrar[tabla.Rows.Count].Visible = true;
            B_His_Borrar[tabla.Rows.Count].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            B_His_Borrar[tabla.Rows.Count].BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            B_His_Borrar[tabla.Rows.Count].BorderColor = System.Drawing.SystemColors.ControlLightLight;
            B_His_Borrar[tabla.Rows.Count].BorderRadius = 10;
            B_His_Borrar[tabla.Rows.Count].BorderSize = 0;
            B_His_Borrar[tabla.Rows.Count].FlatAppearance.BorderSize = 0;
            B_His_Borrar[tabla.Rows.Count].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            B_His_Borrar[tabla.Rows.Count].ForeColor = System.Drawing.Color.Navy;
            B_His_Borrar[tabla.Rows.Count].TextColor = System.Drawing.Color.Navy;
            B_His_Borrar[tabla.Rows.Count].Click += new EventHandler(B_His_Borrar_Click);
            panel1.AutoScrollMinSize = new System.Drawing.Size(0, tabla.Rows.Count * 80 + 50);

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

            foreach (var item in B_His_Borrar)
            {
                item.Visible = false;
            }
            B_His_Borrar.Clear();

            panel1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            clear();
            //limpiamos idiomas y los recargamos para volver a obtener su index 
            EnlaceDB enlaceDB = new EnlaceDB();
            DataTable tabla = enlaceDB.sp_llenar_combos("0", "0", "0", "0", "0");
            string idioma = enlaceDB.sp_obtener_datos_usuarios(id, "idioma").idioma;
            int count = 0;
            CB_Idioma.Items.Clear();
            foreach (DataRow item in tabla.Rows)
            {
                CB_Idioma.Items.Add(item.ItemArray[0].ToString());
                if (item.ItemArray[0].ToString() == idioma)
                {
                    CB_Idioma.SelectedIndex = count;
                }
                count++;
            }
            tabla.Clear();
            //obtenemos favoritos
            tabla = enlaceDB.sp_obtener_top_favoritos();
            dataTable = tabla;
            clear();

            if (tabla.Rows.Count < 1)
            {
                L_Fav_Titulo.Text = "No se han seleccionado favoritos";
                L_Fav_Titulo.Visible = true;
                return;
            }
            L_Fav_Titulo.Visible = true;
            L_Fav_Titulo.Text = "Top Favoritos";

            int n_control = 0;
            string dir;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dir = tabla.Rows[i].ItemArray[0].ToString() + " " + tabla.Rows[i].ItemArray[1].ToString() + " " + tabla.Rows[i].ItemArray[2].ToString() + " " + tabla.Rows[i].ItemArray[3].ToString();
                if (tabla.Rows[i].ItemArray[4].ToString() != "")
                {
                    dir += ":" + tabla.Rows[i].ItemArray[4].ToString();    //versiculo
                }

                if (n_control != 0)
                {
                    if (L_Fav_Dir[n_control-1].Text == dir)
                    {
                        continue;
                    }
                }
                
                L_Fav_Versiculo.Add(new RichTextBox());
                this.panel1.Controls.Add(L_Fav_Versiculo[n_control]);
                L_Fav_Versiculo[n_control].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left)));
                L_Fav_Versiculo[n_control].BackColor = System.Drawing.Color.Azure;
                L_Fav_Versiculo[n_control].BorderStyle = System.Windows.Forms.BorderStyle.None;
                L_Fav_Versiculo[n_control].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_Fav_Versiculo[n_control].Location = new System.Drawing.Point(30, 65 + (n_control * 110));
                L_Fav_Versiculo[n_control].Name = "L_Fav_Versiculo";
                L_Fav_Versiculo[n_control].Size = new System.Drawing.Size(panel1.Width - 60, 42);
                L_Fav_Versiculo[n_control].Text = "";
                L_Fav_Versiculo[n_control].Visible = true;
                L_Fav_Versiculo[n_control].ReadOnly = true;

                L_Fav_Dir.Add(new Label());
                this.panel1.Controls.Add(L_Fav_Dir[n_control]);
                L_Fav_Dir[n_control].AutoSize = true;
                L_Fav_Dir[n_control].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                L_Fav_Dir[n_control].Location = new System.Drawing.Point(15, 40 + (n_control * 110));
                L_Fav_Dir[n_control].Name = "L_Fav_Dir";
                L_Fav_Dir[n_control].Size = new System.Drawing.Size(110, 21);
                L_Fav_Dir[n_control].Text = dir;
                L_Fav_Dir[n_control].Visible = true;
                if (tabla.Rows[i].ItemArray[4].ToString() != "")
                {
                    L_Fav_Versiculo[n_control].Text = tabla.Rows[i].ItemArray[5].ToString();    //texto
                }
                else
                {
                    while (tabla.Rows[i].ItemArray[4].ToString() == "")
                    {
                        L_Fav_Versiculo[n_control].Text += tabla.Rows[i].ItemArray[5].ToString() + " ";
                        i++;
                        if (i == tabla.Rows.Count)
                        {
                            break;
                        }
                        if (tabla.Rows[i - 1].ItemArray[7].ToString() != tabla.Rows[i].ItemArray[7].ToString())
                        {
                            break;
                        }
                    }
                    i--;

                }
                B_Con_Copiar.Add(new RJButton());
                this.panel1.Controls.Add(B_Con_Copiar[n_control]);
                B_Con_Copiar[n_control].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                B_Con_Copiar[n_control].AutoSize = true;
                B_Con_Copiar[n_control].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                //B_Con_Copiar[i].BackColor = System.Drawing.Color.Azure;
                B_Con_Copiar[n_control].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                B_Con_Copiar[n_control].Location = new System.Drawing.Point(panel1.Width - 150, 115 + (n_control * 110));
                B_Con_Copiar[n_control].Name = L_Fav_Versiculo[n_control].Text;
                B_Con_Copiar[n_control].Size = new System.Drawing.Size(76, 31);
                B_Con_Copiar[n_control].Text = "Copiar";
                B_Con_Copiar[n_control].UseVisualStyleBackColor = false;
                B_Con_Copiar[n_control].Visible = true;
                B_Con_Copiar[n_control].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_Con_Copiar[n_control].BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
                B_Con_Copiar[n_control].BorderColor = System.Drawing.SystemColors.ControlLightLight;
                B_Con_Copiar[n_control].BorderRadius = 10;
                B_Con_Copiar[n_control].BorderSize = 0;
                B_Con_Copiar[n_control].FlatAppearance.BorderSize = 0;
                B_Con_Copiar[n_control].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                B_Con_Copiar[n_control].ForeColor = System.Drawing.Color.Navy;
                B_Con_Copiar[n_control].TextColor = System.Drawing.Color.Navy;
                B_Con_Copiar[n_control].Click += new EventHandler(B_Con_Copiar_Click);
                n_control++;
            }
            panel1.AutoScrollMinSize = new System.Drawing.Size(0, n_control * 110 + 50);
        }

        private void T_Busqueda_Enter(object sender, EventArgs e)
        {
            if (string.Compare(T_Busqueda.Texts, "Ingrese palabra(s) por buscar...") == 0)
            {
                T_Busqueda.Texts = "";
            }
        }
        private void T_Busqueda_Leave(object sender, EventArgs e)
        {
            if (string.Compare(T_Busqueda.Texts, "") == 0)
            {
                T_Busqueda.Texts = "Ingrese palabra(s) por buscar...";
            }
        }

        private void B_Usuario_Click(object sender, EventArgs e)
        {
            FormUsuario pantalla = new FormUsuario();
            pantalla.id = id;
            this.Hide();
            pantalla.ShowDialog();
            this.Show();
        }

        private void CB_Idioma_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            EnlaceDB enlaceDB = new EnlaceDB();
            DataTable tabla = enlaceDB.sp_llenar_combos(
                CB_Idioma.SelectedItem.ToString(), "0", "0", "0", "0");

            CB_Version.Enabled = true;
            CB_Testa.Enabled = false;
            CB_Libro.Enabled = false;
            CB_Cap.Enabled = false;
            CB_Versiculo.Enabled = false;

            CB_Version.Items.Add("Versión");
            CB_Version.SelectedItem = "Versión";
            CB_Testa.Items.Add("Testamento");
            CB_Testa.SelectedItem = "Testamento";
            CB_Libro.Items.Add("Libro");
            CB_Libro.SelectedItem = "Libro";
            CB_Cap.Items.Add("Capítulo");
            CB_Cap.SelectedItem = "Capítulo";
            CB_Versiculo.Items.Add("Versículo");
            CB_Versiculo.SelectedItem = "Versículo";
            CB_Version.Items.Clear();
            CB_Testa.Items.Clear();
            CB_Libro.Items.Clear();
            CB_Cap.Items.Clear();
            CB_Versiculo.Items.Clear();
            foreach (DataRow item in tabla.Rows)
                {
                    CB_Version.Items.Add(item.ItemArray[0].ToString());
                }
            
        }
        private void CB_Version_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Version.SelectedItem.ToString() == "Versión")
            {
                return;
            }
            EnlaceDB enlaceDB = new EnlaceDB();
            DataTable tabla = enlaceDB.sp_llenar_combos(
                CB_Idioma.SelectedItem.ToString(),
                CB_Version.SelectedItem.ToString(), "0","0","0");
            CB_Testa.Enabled = true;
            CB_Libro.Enabled = false;
            CB_Cap.Enabled = false;
            CB_Versiculo.Enabled = false;

            CB_Testa.Items.Add("Testamento");
            CB_Testa.SelectedItem = "Testamento";
            CB_Libro.Items.Add("Libro");
            CB_Libro.SelectedItem = "Libro";
            CB_Cap.Items.Add("Capítulo");
            CB_Cap.SelectedItem = "Capítulo";
            CB_Versiculo.Items.Add("Versículo");
            CB_Versiculo.SelectedItem = "Versículo";
            CB_Testa.Items.Clear();
            CB_Libro.Items.Clear();
            CB_Cap.Items.Clear();
            CB_Versiculo.Items.Clear();
            CB_Testa.Items.Add("AMBOS");
            foreach (DataRow item in tabla.Rows)
                {
                    CB_Testa.Items.Add(item.ItemArray[0].ToString());
                }
            
        }
        private void CB_Testa_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Testa.SelectedItem.ToString() == "Testamento")
            {
                return;
            }
            EnlaceDB enlaceDB = new EnlaceDB();
            DataTable tabla = enlaceDB.sp_llenar_combos(
                CB_Idioma.SelectedItem.ToString(),
                CB_Version.SelectedItem.ToString(), 
                CB_Testa.SelectedItem.ToString(),"0","0");
            CB_Libro.Enabled = true;
            CB_Cap.Enabled = false;
            CB_Versiculo.Enabled = false;

            CB_Libro.Items.Add("Libro");
            CB_Libro.SelectedItem = "Libro";
            CB_Cap.Items.Add("Capítulo");
            CB_Cap.SelectedItem = "Capítulo";
            CB_Versiculo.Items.Add("Versículo");
            CB_Versiculo.SelectedItem = "Versículo";
            CB_Libro.Items.Clear();
            CB_Cap.Items.Clear();
            CB_Versiculo.Items.Clear();
            foreach (DataRow item in tabla.Rows)
            {
                CB_Libro.Items.Add(item.ItemArray[0]);
            }
        }

        private void CB_Libro_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Libro.SelectedItem.ToString() == "Libro")
            {
                return;
            }
            EnlaceDB enlaceDB = new EnlaceDB();
            DataTable tabla = enlaceDB.sp_llenar_combos(
                CB_Idioma.SelectedItem.ToString(),
                CB_Version.SelectedItem.ToString(),
                CB_Testa.SelectedItem.ToString(), 
                CB_Libro.SelectedItem.ToString(), "0");
            CB_Cap.Enabled = true;
            CB_Versiculo.Enabled = false;

            CB_Cap.Items.Add("Capítulo");
            CB_Cap.SelectedItem = "Capítulo";
            CB_Versiculo.Items.Add("Versículo");
            CB_Versiculo.SelectedItem = "Versículo";
            CB_Cap.Items.Clear();
            CB_Versiculo.Items.Clear();

            clear();

            if(tabla.Rows.Count == 0)
            {
                L_Fav_Titulo.Text = "El capítulo no ha sido agregado";
                L_Fav_Titulo.Visible = true;
                return;
            }

            foreach (DataRow item in tabla.Rows)
            {
                CB_Cap.Items.Add(item.ItemArray[0]);
            }
            if (tabla.Rows.Count > 0) { CB_Cap.SelectedIndex = 0; }
        }

        private void CB_Cap_OnSelectedIndexChanged(object sender, EventArgs e)

        {
            if (CB_Cap.SelectedItem.ToString() == "Capítulo")
            {
                return;
            }
            EnlaceDB enlaceDB = new EnlaceDB();
            DataTable tabla = enlaceDB.sp_llenar_combos(
                CB_Idioma.SelectedItem.ToString(),
                CB_Version.SelectedItem.ToString(),
                CB_Testa.SelectedItem.ToString(),
                CB_Libro.SelectedItem.ToString(), 
                CB_Cap.SelectedItem.ToString());

            clear();

            CB_Versiculo.Enabled = true;

            CB_Versiculo.Items.Add("Versículo");
            CB_Versiculo.SelectedItem = "Versículo";
            CB_Versiculo.Items.Clear();
            foreach (DataRow item in tabla.Rows)
            {
                CB_Versiculo.Items.Add(item.ItemArray[0]);
            }

            tabla = enlaceDB.sp_resultados(
                CB_Idioma.SelectedItem,
                CB_Version.SelectedItem,
                CB_Testa.SelectedItem,
                CB_Libro.SelectedItem,
                CB_Cap.SelectedItem,
                null, null, id);


            L_Con_Dir.Add(new Label());
            this.panel1.Controls.Add(L_Con_Dir[0]);
            L_Con_Dir[0].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))); ;
            L_Con_Dir[0].AutoSize = true;
            L_Con_Dir[0].Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            L_Con_Dir[0].Location = new System.Drawing.Point(15, 15);
            L_Con_Dir[0].Name = "L_Con_Dir";
            L_Con_Dir[0].Size = new System.Drawing.Size(123, 23);
            L_Con_Dir[0].Text = tabla.Rows[0].ItemArray[1].ToString();
            L_Con_Dir[0].Visible = true;


            L_Con_Versiculo.Add(new RichTextBox());
            this.panel1.Controls.Add(L_Con_Versiculo[0]);
            L_Con_Versiculo[0].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left)));
            L_Con_Versiculo[0].BackColor = System.Drawing.Color.Azure;
            L_Con_Versiculo[0].BorderStyle = System.Windows.Forms.BorderStyle.None;
            L_Con_Versiculo[0].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            L_Con_Versiculo[0].Location = new System.Drawing.Point(30, 40);
            L_Con_Versiculo[0].Name = "L_Con_Versiculo";
            L_Con_Versiculo[0].Size = new System.Drawing.Size(panel1.Width - 60, panel1.Height - 90);
            L_Con_Versiculo[0].ReadOnly = true;
            string texto = "";
            foreach (DataRow item in tabla.Rows)
            {
                texto += item.ItemArray[2].ToString() + ":"
                       + item.ItemArray[3].ToString() + " - "
                       + item.ItemArray[4].ToString() + "\n";
            }
            L_Con_Versiculo[0].Text = texto;
            L_Con_Versiculo[0].Visible = true;

            B_Con_Copiar.Add(new RJButton());
            this.panel1.Controls.Add(B_Con_Copiar[0]);
            B_Con_Copiar[0].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            B_Con_Copiar[0].AutoSize = true;
            B_Con_Copiar[0].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //B_Con_Copiar[0].BackColor = System.Drawing.Color.Azure;
            B_Con_Copiar[0].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            B_Con_Copiar[0].Location = new System.Drawing.Point(panel1.Width - 265, panel1.Height-40);
            B_Con_Copiar[0].Name = texto;
            B_Con_Copiar[0].Size = new System.Drawing.Size(76, 31);
            B_Con_Copiar[0].Text = "Copiar";
            B_Con_Copiar[0].UseVisualStyleBackColor = false;
            B_Con_Copiar[0].Visible = true;
            B_Con_Copiar[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            B_Con_Copiar[0].BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            B_Con_Copiar[0].BorderColor = System.Drawing.SystemColors.ControlLightLight;
            B_Con_Copiar[0].BorderRadius = 10;
            B_Con_Copiar[0].BorderSize = 0;
            B_Con_Copiar[0].FlatAppearance.BorderSize = 0;
            B_Con_Copiar[0].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            B_Con_Copiar[0].ForeColor = System.Drawing.Color.Navy;
            B_Con_Copiar[0].TextColor = System.Drawing.Color.Navy;
            B_Con_Copiar[0].Click += new EventHandler(B_Con_Copiar_Click);

            B_Con_Agregar.Add(new RJButton());
            this.panel1.Controls.Add(B_Con_Agregar[0]);
            B_Con_Agregar[0].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            B_Con_Agregar[0].AutoSize = true;
            //B_Con_Agregar[0].BackColor = System.Drawing.Color.Azure;
            B_Con_Agregar[0].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            B_Con_Agregar[0].Location = new System.Drawing.Point(panel1.Width - 180, panel1.Height-40);
            B_Con_Agregar[0].Name = tabla.Rows[0].ItemArray[0].ToString() + "$"
                                    + tabla.Rows[0].ItemArray[1].ToString() + "$"
                                    + tabla.Rows[0].ItemArray[2].ToString() + "$"
                                    + " ";
            B_Con_Agregar[0].Size = new System.Drawing.Size(150, 31);
            B_Con_Agregar[0].Text = "Agregar a favoritos";
            B_Con_Agregar[0].UseVisualStyleBackColor = false;
            B_Con_Agregar[0].Visible = true;
            B_Con_Agregar[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            B_Con_Agregar[0].BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            B_Con_Agregar[0].BorderColor = System.Drawing.SystemColors.ControlLightLight;
            B_Con_Agregar[0].BorderRadius = 10;
            B_Con_Agregar[0].BorderSize = 0;
            B_Con_Agregar[0].FlatAppearance.BorderSize = 0;
            B_Con_Agregar[0].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            B_Con_Agregar[0].ForeColor = System.Drawing.Color.Navy;
            B_Con_Agregar[0].TextColor = System.Drawing.Color.Navy;
            B_Con_Agregar[0].Click += new EventHandler(B_Con_Agregar_Click);

            panel1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
        }

        private void CB_Versiculo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Versiculo.SelectedItem.ToString() == "Versículo")
            {
                return;
            }
            EnlaceDB enlaceDB = new EnlaceDB();
            DataTable tabla = enlaceDB.sp_resultados(
                CB_Idioma.SelectedItem,
                CB_Version.SelectedItem,
                CB_Testa.SelectedItem,
                CB_Libro.SelectedItem,
                CB_Cap.SelectedItem,
                CB_Versiculo.SelectedItem, null, id);

            clear();

            L_Con_Dir.Add(new Label());
            this.panel1.Controls.Add(L_Con_Dir[0]);
            L_Con_Dir[0].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))); ;
            L_Con_Dir[0].AutoSize = true;
            L_Con_Dir[0].Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            L_Con_Dir[0].Location = new System.Drawing.Point(15, 15 + (0 * 120));
            L_Con_Dir[0].Name = "L_Con_Dir";
            L_Con_Dir[0].Size = new System.Drawing.Size(123, 23);
            L_Con_Dir[0].Text = tabla.Rows[0].ItemArray[1].ToString() + " "
                                + tabla.Rows[0].ItemArray[2].ToString() + ":"
                                + tabla.Rows[0].ItemArray[3].ToString() ;
            L_Con_Dir[0].Visible = true;

            L_Con_Versiculo.Add(new RichTextBox());
            this.panel1.Controls.Add(L_Con_Versiculo[0]);
            L_Con_Versiculo[0].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left)));
            L_Con_Versiculo[0].BackColor = System.Drawing.Color.Azure;
            L_Con_Versiculo[0].BorderStyle = System.Windows.Forms.BorderStyle.None;
            L_Con_Versiculo[0].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            L_Con_Versiculo[0].Location = new System.Drawing.Point(30, 40 + (0 * 120));
            L_Con_Versiculo[0].Name = "L_Con_Versiculo";
            L_Con_Versiculo[0].Size = new System.Drawing.Size(panel1.Width - 60, 42);
            L_Con_Versiculo[0].Text = tabla.Rows[0].ItemArray[4].ToString();
            L_Con_Versiculo[0].Visible = true;
            L_Con_Versiculo[0].ReadOnly = true;

            B_Con_Copiar.Add(new RJButton());
            this.panel1.Controls.Add(B_Con_Copiar[0]);
            B_Con_Copiar[0].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            B_Con_Copiar[0].AutoSize = true;
            B_Con_Copiar[0].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //B_Con_Copiar[0].BackColor = System.Drawing.Color.Azure;
            B_Con_Copiar[0].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            B_Con_Copiar[0].Location = new System.Drawing.Point(panel1.Width - 265, 90 + (0 * 120));
            B_Con_Copiar[0].Name = tabla.Rows[0].ItemArray[4].ToString();
            B_Con_Copiar[0].Size = new System.Drawing.Size(76, 31);
            B_Con_Copiar[0].Text = "Copiar";
            B_Con_Copiar[0].UseVisualStyleBackColor = false;
            B_Con_Copiar[0].Visible = true;
            B_Con_Copiar[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            B_Con_Copiar[0].BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            B_Con_Copiar[0].BorderColor = System.Drawing.SystemColors.ControlLightLight;
            B_Con_Copiar[0].BorderRadius = 10;
            B_Con_Copiar[0].BorderSize = 0;
            B_Con_Copiar[0].FlatAppearance.BorderSize = 0;
            B_Con_Copiar[0].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            B_Con_Copiar[0].ForeColor = System.Drawing.Color.Navy;
            B_Con_Copiar[0].TextColor = System.Drawing.Color.Navy;
            B_Con_Copiar[0].Click += new EventHandler(B_Con_Copiar_Click);

            B_Con_Agregar.Add(new RJButton());
            this.panel1.Controls.Add(B_Con_Agregar[0]);
            B_Con_Agregar[0].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            B_Con_Agregar[0].AutoSize = true;
            //B_Con_Agregar[0].BackColor = System.Drawing.Color.Azure;
            B_Con_Agregar[0].Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            B_Con_Agregar[0].Location = new System.Drawing.Point(panel1.Width - 180, 90 + (0 * 120));
            B_Con_Agregar[0].Name = tabla.Rows[0].ItemArray[0].ToString() + "$"
                                    + tabla.Rows[0].ItemArray[1].ToString() + "$"
                                    + tabla.Rows[0].ItemArray[2].ToString() + "$"
                                    + tabla.Rows[0].ItemArray[3].ToString();
            B_Con_Agregar[0].Size = new System.Drawing.Size(150, 31);
            B_Con_Agregar[0].Text = "Agregar a favoritos";
            B_Con_Agregar[0].UseVisualStyleBackColor = false;
            B_Con_Agregar[0].Visible = true;
            B_Con_Agregar[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            B_Con_Agregar[0].BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            B_Con_Agregar[0].BorderColor = System.Drawing.SystemColors.ControlLightLight;
            B_Con_Agregar[0].BorderRadius = 10;
            B_Con_Agregar[0].BorderSize = 0;
            B_Con_Agregar[0].FlatAppearance.BorderSize = 0;
            B_Con_Agregar[0].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            B_Con_Agregar[0].ForeColor = System.Drawing.Color.Navy;
            B_Con_Agregar[0].TextColor = System.Drawing.Color.Navy;
            B_Con_Agregar[0].Click += new EventHandler(B_Con_Agregar_Click);

            panel1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
        }
        private void B_His_Borrar_Click(object sender, EventArgs e)
        {
            RJButton boton = (RJButton)sender;
            EnlaceDB enlaceDB = new EnlaceDB();
            
            if (boton.Name == "ALL")
            {
                enlaceDB.sp_borrar_historial(null, id);
            }
            else
            {
                enlaceDB.sp_borrar_historial(boton.Name, null);
            }
            
            B_Historial_Click(sender, e);
        }
        private void B_His_Resultados_Click(object sender, EventArgs e)
        {
            RJButton boton = (RJButton)sender;
            int i = int.Parse(boton.Name);
            int count = 0;

            foreach (object item in CB_Idioma.Items)
            {
                if (item.ToString() == dataTable.Rows[i].ItemArray[0].ToString())
                {
                    CB_Idioma.SelectedIndex = count;
                    count = 0;
                    break;
                }
                count++;
            }
            foreach (object item in CB_Version.Items)
            {
                if (item.ToString() == dataTable.Rows[i].ItemArray[1].ToString())
                {
                    CB_Version.SelectedIndex = count;
                    count = 0;
                    break;
                }
                count++;
            }
            foreach (object item in CB_Testa.Items)
            {
                if (item.ToString() == dataTable.Rows[i].ItemArray[2].ToString())
                {
                    CB_Testa.SelectedIndex = count;
                    count = 0;
                    break;
                }
                count++;
            }
            foreach (object item in CB_Libro.Items)
            {
                if (item.ToString() == dataTable.Rows[i].ItemArray[3].ToString())
                {
                    CB_Libro.SelectedIndex = count;
                    count = 0;
                    break;
                }
                count++;
            }
            foreach (object item in CB_Cap.Items)
            {
                if (item.ToString() == dataTable.Rows[i].ItemArray[4].ToString())
                {
                    CB_Cap.SelectedIndex = count;
                    count = 0;
                    break;
                }
                count++;
            }
            foreach (object item in CB_Versiculo.Items)
            {
                if (item.ToString() == dataTable.Rows[i].ItemArray[5].ToString())
                {
                    CB_Versiculo.SelectedIndex = count;
                    count = 0;
                    break;
                }
                count++;
            }

            if (dataTable.Rows[i].ItemArray[6].ToString() == "")
            {
                
            }
            else
            {
                T_Busqueda.Texts = dataTable.Rows[i].ItemArray[6].ToString();
                B_Buscar_Click(this, null);
            }
            

        }
        private void B_Con_Copiar_Click(object sender, EventArgs e)
        {
            RJButton boton = (RJButton)sender;
            Clipboard.SetText(boton.Name);
        }
        private void B_Con_Agregar_Click(object sender, EventArgs e)
        {
            RJButton boton = (RJButton)sender;
            string[] a = boton.Name.Split('$');
            EnlaceDB enlaceDB = new EnlaceDB();
            if (a[3] == " "){
                a[3] = null;
            }
            enlaceDB.sp_agregar_favorito(CB_Idioma.SelectedItem,CB_Version.SelectedItem, a[0], a[1], a[2], a[3], id);
            MessageBox.Show("Agregado a favoritos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void B_Fav_Quitar_Click(object sender, EventArgs e)
        {
            RJButton boton = (RJButton)sender;

            EnlaceDB enlaceDB = new EnlaceDB();
            enlaceDB.sp_borrar_favorito(boton.Name, id);

            B_Favoritos_Click(sender, e);
        }

    }
}
