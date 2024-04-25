using System.Collections.Generic;
using System.Windows.Forms;

namespace MAD
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.T_Busqueda = new System.Windows.Forms.TextBox();
            this.B_Buscar = new System.Windows.Forms.Button();
            this.M_Filtro = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox4 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox5 = new System.Windows.Forms.ToolStripComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_Fav_Titulo = new System.Windows.Forms.Label();
            this.L_His_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_Usuario = new System.Windows.Forms.Button();
            this.B_Historial = new System.Windows.Forms.Button();
            this.B_Favoritos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.M_Filtro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.82833F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.34595F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.82572F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.87136F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.12864F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1344, 710);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.M_Filtro, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(253, 91);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(837, 619);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(747, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Listado de versiones";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.T_Busqueda, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.B_Buscar, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(41, 50);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(753, 40);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // T_Busqueda
            // 
            this.T_Busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.T_Busqueda.BackColor = System.Drawing.Color.Azure;
            this.T_Busqueda.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Busqueda.Location = new System.Drawing.Point(3, 10);
            this.T_Busqueda.Name = "T_Busqueda";
            this.T_Busqueda.Size = new System.Drawing.Size(647, 27);
            this.T_Busqueda.TabIndex = 19;
            // 
            // B_Buscar
            // 
            this.B_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Buscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Buscar.BackColor = System.Drawing.Color.Azure;
            this.B_Buscar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Buscar.Location = new System.Drawing.Point(656, 3);
            this.B_Buscar.Name = "B_Buscar";
            this.B_Buscar.Size = new System.Drawing.Size(94, 34);
            this.B_Buscar.TabIndex = 20;
            this.B_Buscar.Text = "Buscar";
            this.B_Buscar.UseVisualStyleBackColor = false;
            this.B_Buscar.Click += new System.EventHandler(this.B_Buscar_Click);
            // 
            // M_Filtro
            // 
            this.M_Filtro.BackColor = System.Drawing.Color.Azure;
            this.M_Filtro.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_Filtro.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.M_Filtro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripComboBox2,
            this.toolStripComboBox3,
            this.toolStripComboBox4,
            this.toolStripComboBox5});
            this.M_Filtro.Location = new System.Drawing.Point(41, 120);
            this.M_Filtro.Name = "M_Filtro";
            this.M_Filtro.Size = new System.Drawing.Size(753, 33);
            this.M_Filtro.TabIndex = 20;
            this.M_Filtro.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 29);
            this.toolStripComboBox1.Text = "Versión";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(130, 29);
            this.toolStripComboBox2.Text = "Testamento";
            this.toolStripComboBox2.Visible = false;
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 29);
            this.toolStripComboBox3.Text = "Libro";
            this.toolStripComboBox3.Visible = false;
            // 
            // toolStripComboBox4
            // 
            this.toolStripComboBox4.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox4.Name = "toolStripComboBox4";
            this.toolStripComboBox4.Size = new System.Drawing.Size(121, 29);
            this.toolStripComboBox4.Text = "Capítulo";
            this.toolStripComboBox4.Visible = false;
            // 
            // toolStripComboBox5
            // 
            this.toolStripComboBox5.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox5.Name = "toolStripComboBox5";
            this.toolStripComboBox5.Size = new System.Drawing.Size(121, 29);
            this.toolStripComboBox5.Text = "Versículo";
            this.toolStripComboBox5.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.L_Fav_Titulo);
            this.panel1.Controls.Add(this.L_His_Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(41, 170);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 449);
            this.panel1.TabIndex = 21;
            // 
            // L_Fav_Titulo
            // 
            this.L_Fav_Titulo.AutoSize = true;
            this.L_Fav_Titulo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fav_Titulo.Location = new System.Drawing.Point(15, 15);
            this.L_Fav_Titulo.Name = "L_Fav_Titulo";
            this.L_Fav_Titulo.Size = new System.Drawing.Size(101, 23);
            this.L_Fav_Titulo.TabIndex = 23;
            this.L_Fav_Titulo.Text = "Favoritos";
            this.L_Fav_Titulo.Visible = false;
            // 
            // L_His_Titulo
            // 
            this.L_His_Titulo.AutoSize = true;
            this.L_His_Titulo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_His_Titulo.Location = new System.Drawing.Point(15, 15);
            this.L_His_Titulo.Name = "L_His_Titulo";
            this.L_His_Titulo.Size = new System.Drawing.Size(94, 23);
            this.L_His_Titulo.TabIndex = 4;
            this.L_His_Titulo.Text = "Historial";
            this.L_His_Titulo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(256, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jesús Nuestro Salvador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.B_Usuario);
            this.flowLayoutPanel1.Controls.Add(this.B_Historial);
            this.flowLayoutPanel1.Controls.Add(this.B_Favoritos);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 444);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(233, 266);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // B_Usuario
            // 
            this.B_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.B_Usuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Usuario.BackColor = System.Drawing.Color.White;
            this.B_Usuario.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("B_Usuario.Image")));
            this.B_Usuario.Location = new System.Drawing.Point(3, 206);
            this.B_Usuario.Name = "B_Usuario";
            this.B_Usuario.Size = new System.Drawing.Size(186, 57);
            this.B_Usuario.TabIndex = 3;
            this.B_Usuario.Text = "Mi usuario";
            this.B_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Usuario.UseVisualStyleBackColor = false;
            // 
            // B_Historial
            // 
            this.B_Historial.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.B_Historial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Historial.BackColor = System.Drawing.Color.White;
            this.B_Historial.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Historial.Location = new System.Drawing.Point(3, 143);
            this.B_Historial.Name = "B_Historial";
            this.B_Historial.Size = new System.Drawing.Size(186, 57);
            this.B_Historial.TabIndex = 7;
            this.B_Historial.Text = "Historial";
            this.B_Historial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Historial.UseVisualStyleBackColor = false;
            this.B_Historial.Click += new System.EventHandler(this.B_Historial_Click);
            // 
            // B_Favoritos
            // 
            this.B_Favoritos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.B_Favoritos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Favoritos.BackColor = System.Drawing.Color.White;
            this.B_Favoritos.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Favoritos.Location = new System.Drawing.Point(3, 80);
            this.B_Favoritos.Name = "B_Favoritos";
            this.B_Favoritos.Size = new System.Drawing.Size(186, 57);
            this.B_Favoritos.TabIndex = 8;
            this.B_Favoritos.Text = "Favoritos";
            this.B_Favoritos.UseVisualStyleBackColor = false;
            this.B_Favoritos.Click += new System.EventHandler(this.B_Favoritos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.M_Filtro.ResumeLayout(false);
            this.M_Filtro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Usuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox T_Busqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button B_Buscar;
        private System.Windows.Forms.MenuStrip M_Filtro;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        
        private List<Button> B_Con_Copiar = new List<Button>();
        private List<RichTextBox> L_Con_Versiculo = new List<RichTextBox>();
        private List<CheckBox> B_Con_Agregar = new List<CheckBox>();
        private List<Label> L_Con_Dir = new List<Label>();

        private List<CheckBox> B_Fav_Quitar = new List<CheckBox>();
        private List<RichTextBox> L_Fav_Versiculo = new List<RichTextBox>();
        private List<Label> L_Fav_Dir = new List<Label>();

        private List<Label> L_His_Fecha = new List<Label>();
        private List<Button> B_His_Resultados = new List<Button>();
        private List<Label> L_His_Busqueda = new List<Label>();

        private System.Windows.Forms.Button B_Favoritos;
        private System.Windows.Forms.Button B_Historial;

        private System.Windows.Forms.Label L_His_Titulo;
        private System.Windows.Forms.Label L_Fav_Titulo;
    }
}