using CustomControls.RJControls;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_Fav_Titulo = new System.Windows.Forms.Label();
            this.L_His_Titulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.B_Favoritos = new CustomControls.RJControls.RJButton();
            this.B_Historial = new CustomControls.RJControls.RJButton();
            this.B_Usuario = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.CB_Idioma = new MAD.RJComboBox();
            this.CB_Versiculo = new MAD.RJComboBox();
            this.CB_Version = new MAD.RJComboBox();
            this.CB_Cap = new MAD.RJComboBox();
            this.CB_Testa = new MAD.RJComboBox();
            this.CB_Libro = new MAD.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.B_Buscar = new CustomControls.RJControls.RJButton();
            this.T_Busqueda = new MAD.RJTextBoxcs();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1382, 877);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(193)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel2.BackgroundImage = global::MAD.Properties.Resources.Background2;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 255);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 566F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1342, 566);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::MAD.Properties.Resources.Background3;
            this.panel1.Controls.Add(this.L_Fav_Titulo);
            this.panel1.Controls.Add(this.L_His_Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(67, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 546);
            this.panel1.TabIndex = 22;
            // 
            // L_Fav_Titulo
            // 
            this.L_Fav_Titulo.AutoSize = true;
            this.L_Fav_Titulo.BackColor = System.Drawing.Color.Transparent;
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(78)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.B_Favoritos);
            this.panel2.Controls.Add(this.B_Historial);
            this.panel2.Controls.Add(this.B_Usuario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(23, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1336, 74);
            this.panel2.TabIndex = 9;
            // 
            // B_Favoritos
            // 
            this.B_Favoritos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Favoritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.B_Favoritos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.B_Favoritos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(225)))), ((int)(((byte)(242)))));
            this.B_Favoritos.BorderRadius = 20;
            this.B_Favoritos.BorderSize = 2;
            this.B_Favoritos.FlatAppearance.BorderSize = 0;
            this.B_Favoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Favoritos.ForeColor = System.Drawing.Color.White;
            this.B_Favoritos.Image = ((System.Drawing.Image)(resources.GetObject("B_Favoritos.Image")));
            this.B_Favoritos.Location = new System.Drawing.Point(1211, 5);
            this.B_Favoritos.Name = "B_Favoritos";
            this.B_Favoritos.Size = new System.Drawing.Size(111, 64);
            this.B_Favoritos.TabIndex = 11;
            this.B_Favoritos.TextColor = System.Drawing.Color.White;
            this.B_Favoritos.UseVisualStyleBackColor = false;
            this.B_Favoritos.Click += new System.EventHandler(this.B_Favoritos_Click);
            // 
            // B_Historial
            // 
            this.B_Historial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Historial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.B_Historial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.B_Historial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(225)))), ((int)(((byte)(242)))));
            this.B_Historial.BorderRadius = 20;
            this.B_Historial.BorderSize = 2;
            this.B_Historial.FlatAppearance.BorderSize = 0;
            this.B_Historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Historial.ForeColor = System.Drawing.Color.White;
            this.B_Historial.Image = ((System.Drawing.Image)(resources.GetObject("B_Historial.Image")));
            this.B_Historial.Location = new System.Drawing.Point(1091, 5);
            this.B_Historial.Name = "B_Historial";
            this.B_Historial.Size = new System.Drawing.Size(111, 64);
            this.B_Historial.TabIndex = 10;
            this.B_Historial.TextColor = System.Drawing.Color.White;
            this.B_Historial.UseVisualStyleBackColor = false;
            this.B_Historial.Click += new System.EventHandler(this.B_Historial_Click);
            // 
            // B_Usuario
            // 
            this.B_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.B_Usuario.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.B_Usuario.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.B_Usuario.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.B_Usuario.BorderRadius = 20;
            this.B_Usuario.BorderSize = 0;
            this.B_Usuario.FlatAppearance.BorderSize = 0;
            this.B_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Usuario.ForeColor = System.Drawing.Color.White;
            this.B_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("B_Usuario.Image")));
            this.B_Usuario.Location = new System.Drawing.Point(19, 5);
            this.B_Usuario.Name = "B_Usuario";
            this.B_Usuario.Size = new System.Drawing.Size(73, 64);
            this.B_Usuario.TabIndex = 9;
            this.B_Usuario.TextColor = System.Drawing.Color.White;
            this.B_Usuario.UseVisualStyleBackColor = false;
            this.B_Usuario.Click += new System.EventHandler(this.B_Usuario_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1336, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tomillo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(86)))), ((int)(((byte)(124)))));
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Location = new System.Drawing.Point(23, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1336, 164);
            this.panel4.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.134078F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.57557F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.64133F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.51494F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.134078F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1336, 164);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 7;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32147F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32147F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.071194F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32147F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32147F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32147F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32147F));
            this.tableLayoutPanel5.Controls.Add(this.CB_Idioma, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.CB_Versiculo, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.CB_Version, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.CB_Cap, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.CB_Testa, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.CB_Libro, 4, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(29, 92);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1276, 58);
            this.tableLayoutPanel5.TabIndex = 33;
            // 
            // CB_Idioma
            // 
            this.CB_Idioma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Idioma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CB_Idioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(86)))), ((int)(((byte)(124)))));
            this.CB_Idioma.BorderColor = System.Drawing.Color.Navy;
            this.CB_Idioma.BorderSize = 3;
            this.CB_Idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CB_Idioma.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Idioma.ForeColor = System.Drawing.Color.White;
            this.CB_Idioma.IconColor = System.Drawing.SystemColors.Window;
            this.CB_Idioma.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CB_Idioma.ListTextColor = System.Drawing.Color.DimGray;
            this.CB_Idioma.Location = new System.Drawing.Point(3, 3);
            this.CB_Idioma.MinimumSize = new System.Drawing.Size(200, 30);
            this.CB_Idioma.Name = "CB_Idioma";
            this.CB_Idioma.Padding = new System.Windows.Forms.Padding(3);
            this.CB_Idioma.Size = new System.Drawing.Size(202, 52);
            this.CB_Idioma.TabIndex = 28;
            this.CB_Idioma.Texts = "Idioma";
            this.CB_Idioma.OnSelectedIndexChanged += new System.EventHandler(this.CB_Idioma_OnSelectedIndexChanged);
            // 
            // CB_Versiculo
            // 
            this.CB_Versiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Versiculo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CB_Versiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(86)))), ((int)(((byte)(124)))));
            this.CB_Versiculo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(228)))), ((int)(((byte)(249)))));
            this.CB_Versiculo.BorderSize = 3;
            this.CB_Versiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CB_Versiculo.Enabled = false;
            this.CB_Versiculo.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Versiculo.ForeColor = System.Drawing.Color.White;
            this.CB_Versiculo.IconColor = System.Drawing.SystemColors.Window;
            this.CB_Versiculo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CB_Versiculo.ListTextColor = System.Drawing.Color.DimGray;
            this.CB_Versiculo.Location = new System.Drawing.Point(1069, 3);
            this.CB_Versiculo.MinimumSize = new System.Drawing.Size(200, 30);
            this.CB_Versiculo.Name = "CB_Versiculo";
            this.CB_Versiculo.Padding = new System.Windows.Forms.Padding(3);
            this.CB_Versiculo.Size = new System.Drawing.Size(204, 52);
            this.CB_Versiculo.TabIndex = 32;
            this.CB_Versiculo.Texts = "Versículo";
            this.CB_Versiculo.OnSelectedIndexChanged += new System.EventHandler(this.CB_Versiculo_OnSelectedIndexChanged);
            // 
            // CB_Version
            // 
            this.CB_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Version.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CB_Version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(86)))), ((int)(((byte)(124)))));
            this.CB_Version.BorderColor = System.Drawing.Color.Indigo;
            this.CB_Version.BorderSize = 3;
            this.CB_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CB_Version.Enabled = false;
            this.CB_Version.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Version.ForeColor = System.Drawing.Color.White;
            this.CB_Version.IconColor = System.Drawing.SystemColors.Window;
            this.CB_Version.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CB_Version.ListTextColor = System.Drawing.Color.DimGray;
            this.CB_Version.Location = new System.Drawing.Point(211, 3);
            this.CB_Version.MinimumSize = new System.Drawing.Size(200, 30);
            this.CB_Version.Name = "CB_Version";
            this.CB_Version.Padding = new System.Windows.Forms.Padding(3);
            this.CB_Version.Size = new System.Drawing.Size(202, 52);
            this.CB_Version.TabIndex = 27;
            this.CB_Version.Texts = "Versión";
            this.CB_Version.OnSelectedIndexChanged += new System.EventHandler(this.CB_Version_OnSelectedIndexChanged);
            // 
            // CB_Cap
            // 
            this.CB_Cap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Cap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CB_Cap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(86)))), ((int)(((byte)(124)))));
            this.CB_Cap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(192)))), ((int)(((byte)(243)))));
            this.CB_Cap.BorderSize = 3;
            this.CB_Cap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CB_Cap.Enabled = false;
            this.CB_Cap.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Cap.ForeColor = System.Drawing.Color.White;
            this.CB_Cap.IconColor = System.Drawing.SystemColors.Window;
            this.CB_Cap.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CB_Cap.ListTextColor = System.Drawing.Color.DimGray;
            this.CB_Cap.Location = new System.Drawing.Point(861, 3);
            this.CB_Cap.MinimumSize = new System.Drawing.Size(200, 30);
            this.CB_Cap.Name = "CB_Cap";
            this.CB_Cap.Padding = new System.Windows.Forms.Padding(3);
            this.CB_Cap.Size = new System.Drawing.Size(202, 52);
            this.CB_Cap.TabIndex = 31;
            this.CB_Cap.Texts = "Capítulo";
            this.CB_Cap.OnSelectedIndexChanged += new System.EventHandler(this.CB_Cap_OnSelectedIndexChanged);
            // 
            // CB_Testa
            // 
            this.CB_Testa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Testa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CB_Testa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(86)))), ((int)(((byte)(124)))));
            this.CB_Testa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.CB_Testa.BorderSize = 3;
            this.CB_Testa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CB_Testa.Enabled = false;
            this.CB_Testa.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Testa.ForeColor = System.Drawing.Color.White;
            this.CB_Testa.IconColor = System.Drawing.SystemColors.Window;
            this.CB_Testa.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CB_Testa.ListTextColor = System.Drawing.Color.DimGray;
            this.CB_Testa.Location = new System.Drawing.Point(445, 3);
            this.CB_Testa.MinimumSize = new System.Drawing.Size(200, 30);
            this.CB_Testa.Name = "CB_Testa";
            this.CB_Testa.Padding = new System.Windows.Forms.Padding(3);
            this.CB_Testa.Size = new System.Drawing.Size(202, 52);
            this.CB_Testa.TabIndex = 29;
            this.CB_Testa.Texts = "Testamento";
            this.CB_Testa.OnSelectedIndexChanged += new System.EventHandler(this.CB_Testa_OnSelectedIndexChanged);
            // 
            // CB_Libro
            // 
            this.CB_Libro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Libro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CB_Libro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(86)))), ((int)(((byte)(124)))));
            this.CB_Libro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(163)))), ((int)(((byte)(237)))));
            this.CB_Libro.BorderSize = 3;
            this.CB_Libro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CB_Libro.Enabled = false;
            this.CB_Libro.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Libro.ForeColor = System.Drawing.Color.White;
            this.CB_Libro.IconColor = System.Drawing.SystemColors.Window;
            this.CB_Libro.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CB_Libro.ListTextColor = System.Drawing.Color.DimGray;
            this.CB_Libro.Location = new System.Drawing.Point(653, 3);
            this.CB_Libro.MinimumSize = new System.Drawing.Size(200, 30);
            this.CB_Libro.Name = "CB_Libro";
            this.CB_Libro.Padding = new System.Windows.Forms.Padding(3);
            this.CB_Libro.Size = new System.Drawing.Size(202, 52);
            this.CB_Libro.TabIndex = 30;
            this.CB_Libro.Texts = "Libro";
            this.CB_Libro.OnSelectedIndexChanged += new System.EventHandler(this.CB_Libro_OnSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1276, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Listado de versiones";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.tableLayoutPanel3.Controls.Add(this.B_Buscar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.T_Busqueda, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(26, 8);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1282, 56);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // B_Buscar
            // 
            this.B_Buscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.B_Buscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.B_Buscar.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.B_Buscar.BorderRadius = 10;
            this.B_Buscar.BorderSize = 0;
            this.B_Buscar.FlatAppearance.BorderSize = 0;
            this.B_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Buscar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Buscar.ForeColor = System.Drawing.Color.Navy;
            this.B_Buscar.Location = new System.Drawing.Point(1185, 3);
            this.B_Buscar.Name = "B_Buscar";
            this.B_Buscar.Size = new System.Drawing.Size(94, 34);
            this.B_Buscar.TabIndex = 27;
            this.B_Buscar.Text = "Buscar";
            this.B_Buscar.TextColor = System.Drawing.Color.Navy;
            this.B_Buscar.UseVisualStyleBackColor = false;
            this.B_Buscar.Click += new System.EventHandler(this.B_Buscar_Click);
            // 
            // T_Busqueda
            // 
            this.T_Busqueda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.T_Busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(86)))), ((int)(((byte)(124)))));
            this.T_Busqueda.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.T_Busqueda.BorderFocusColor = System.Drawing.Color.AliceBlue;
            this.T_Busqueda.BorderSize = 5;
            this.T_Busqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.T_Busqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.T_Busqueda.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Busqueda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.T_Busqueda.Location = new System.Drawing.Point(4, 4);
            this.T_Busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.T_Busqueda.Multiline = false;
            this.T_Busqueda.Name = "T_Busqueda";
            this.T_Busqueda.Padding = new System.Windows.Forms.Padding(7);
            this.T_Busqueda.PasswordChar = false;
            this.T_Busqueda.Size = new System.Drawing.Size(1174, 36);
            this.T_Busqueda.TabIndex = 27;
            this.T_Busqueda.Texts = "Ingrese palabra(s) por buscar...";
            this.T_Busqueda.UnderlinedStyle = true;
            this.T_Busqueda.Enter += new System.EventHandler(this.T_Busqueda_Enter);
            this.T_Busqueda.Leave += new System.EventHandler(this.T_Busqueda_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1382, 50);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MAD.Properties.Resources.MyTomillo;
            this.pictureBox3.Location = new System.Drawing.Point(12, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::MAD.Properties.Resources.minimizar;
            this.pictureBox2.Location = new System.Drawing.Point(1313, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MAD.Properties.Resources.boton_cancelar;
            this.pictureBox1.Location = new System.Drawing.Point(1348, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 852);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1382, 25);
            this.panel5.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(67)))), ((int)(((byte)(115)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 877);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private CustomControls.RJControls.RJButton B_Usuario;
        private RJTextBoxcs T_Busqueda;
        private TableLayoutPanel tableLayoutPanel5;

        private CustomControls.RJControls.RJButton B_Buscar;


        private List<RJButton> B_Con_Copiar = new List<RJButton>();
        private List<RichTextBox> L_Con_Versiculo = new List<RichTextBox>();
        private List<RJButton> B_Con_Agregar = new List<RJButton>();
        private List<Label> L_Con_Dir = new List<Label>();

        private List<RJButton> B_Fav_Quitar = new List<RJButton>();
        private List<RichTextBox> L_Fav_Versiculo = new List<RichTextBox>();
        private List<Label> L_Fav_Dir = new List<Label>();

        private List<Label> L_His_Fecha = new List<Label>();
        private List<RJButton> B_His_Resultados = new List<RJButton>();
        private List<Label> L_His_Busqueda = new List<Label>();
        private List<RJButton> B_His_Borrar = new List<RJButton>();

        private CustomControls.RJControls.RJButton B_Favoritos;
        private CustomControls.RJControls.RJButton B_Historial;
        private RJComboBox CB_Idioma;
        private RJComboBox CB_Versiculo;
        private RJComboBox CB_Version;
        private RJComboBox CB_Cap;
        private RJComboBox CB_Testa;
        private RJComboBox CB_Libro;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label L_Fav_Titulo;
        private Label L_His_Titulo;
        private Panel panel3;
        private Panel panel5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}