namespace MAD
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_U_CerrarSesion = new CustomControls.RJControls.RJButton();
            this.B_U_Baja = new CustomControls.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B_U_EditarInfo = new CustomControls.RJControls.RJButton();
            this.B_U_GuardarCambios = new CustomControls.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.B_U_CambioResp = new CustomControls.RJControls.RJButton();
            this.B_U_CambioContra = new CustomControls.RJControls.RJButton();
            this.TB_U_Pregunta = new MAD.RJTextBoxcs();
            this.TB_U_Correo = new MAD.RJTextBoxcs();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.RB_U_Hombre = new MAD.RJRadioButton();
            this.RB_U_Mujer = new MAD.RJRadioButton();
            this.DTP_U_Nacimiento = new MAD.RJDatePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_U_MApellido = new MAD.RJTextBoxcs();
            this.TB_U_PApellido = new MAD.RJTextBoxcs();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_U_Nombre = new MAD.RJTextBoxcs();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 76);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.Image = global::MAD.Properties.Resources.MyTomillo;
            this.pictureBox4.Location = new System.Drawing.Point(17, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.Image = global::MAD.Properties.Resources.minimizar;
            this.pictureBox3.Location = new System.Drawing.Point(1171, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = global::MAD.Properties.Resources.boton_cancelar;
            this.pictureBox2.Location = new System.Drawing.Point(1211, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(574, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tomillo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_U_CerrarSesion
            // 
            this.B_U_CerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(80)))), ((int)(((byte)(242)))));
            this.B_U_CerrarSesion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(80)))), ((int)(((byte)(242)))));
            this.B_U_CerrarSesion.BorderColor = System.Drawing.Color.Transparent;
            this.B_U_CerrarSesion.BorderRadius = 15;
            this.B_U_CerrarSesion.BorderSize = 0;
            this.B_U_CerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.B_U_CerrarSesion.FlatAppearance.BorderSize = 0;
            this.B_U_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_U_CerrarSesion.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_U_CerrarSesion.ForeColor = System.Drawing.Color.White;
            this.B_U_CerrarSesion.Location = new System.Drawing.Point(3, 468);
            this.B_U_CerrarSesion.Name = "B_U_CerrarSesion";
            this.B_U_CerrarSesion.Size = new System.Drawing.Size(424, 35);
            this.B_U_CerrarSesion.TabIndex = 4;
            this.B_U_CerrarSesion.Text = "Cerrar Sesión";
            this.B_U_CerrarSesion.TextColor = System.Drawing.Color.White;
            this.B_U_CerrarSesion.UseVisualStyleBackColor = false;
            this.B_U_CerrarSesion.Click += new System.EventHandler(this.B_U_CerrarSesion_Click);
            // 
            // B_U_Baja
            // 
            this.B_U_Baja.BackColor = System.Drawing.Color.IndianRed;
            this.B_U_Baja.BackgroundColor = System.Drawing.Color.IndianRed;
            this.B_U_Baja.BorderColor = System.Drawing.Color.IndianRed;
            this.B_U_Baja.BorderRadius = 15;
            this.B_U_Baja.BorderSize = 0;
            this.B_U_Baja.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.B_U_Baja.FlatAppearance.BorderSize = 0;
            this.B_U_Baja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_U_Baja.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_U_Baja.ForeColor = System.Drawing.Color.White;
            this.B_U_Baja.Location = new System.Drawing.Point(3, 511);
            this.B_U_Baja.Name = "B_U_Baja";
            this.B_U_Baja.Size = new System.Drawing.Size(424, 35);
            this.B_U_Baja.TabIndex = 3;
            this.B_U_Baja.Text = "Darse de baja";
            this.B_U_Baja.TextColor = System.Drawing.Color.White;
            this.B_U_Baja.UseVisualStyleBackColor = false;
            this.B_U_Baja.Click += new System.EventHandler(this.B_U_Baja_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(141)))));
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(65, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 549);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.B_U_Baja, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.B_U_EditarInfo, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.B_U_GuardarCambios, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.B_U_CerrarSesion, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.20219F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.74317F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.925319F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.2969F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.650273F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(430, 549);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // B_U_EditarInfo
            // 
            this.B_U_EditarInfo.BackColor = System.Drawing.Color.Transparent;
            this.B_U_EditarInfo.BackgroundColor = System.Drawing.Color.Transparent;
            this.B_U_EditarInfo.BorderColor = System.Drawing.Color.PowderBlue;
            this.B_U_EditarInfo.BorderRadius = 20;
            this.B_U_EditarInfo.BorderSize = 3;
            this.B_U_EditarInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.B_U_EditarInfo.FlatAppearance.BorderSize = 0;
            this.B_U_EditarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_U_EditarInfo.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_U_EditarInfo.ForeColor = System.Drawing.Color.PowderBlue;
            this.B_U_EditarInfo.Location = new System.Drawing.Point(3, 341);
            this.B_U_EditarInfo.Name = "B_U_EditarInfo";
            this.B_U_EditarInfo.Size = new System.Drawing.Size(424, 40);
            this.B_U_EditarInfo.TabIndex = 5;
            this.B_U_EditarInfo.Text = "Editar Información";
            this.B_U_EditarInfo.TextColor = System.Drawing.Color.PowderBlue;
            this.B_U_EditarInfo.UseVisualStyleBackColor = false;
            this.B_U_EditarInfo.Click += new System.EventHandler(this.B_U_EditarInfo_Click);
            // 
            // B_U_GuardarCambios
            // 
            this.B_U_GuardarCambios.BackColor = System.Drawing.Color.Transparent;
            this.B_U_GuardarCambios.BackgroundColor = System.Drawing.Color.Transparent;
            this.B_U_GuardarCambios.BorderColor = System.Drawing.Color.PowderBlue;
            this.B_U_GuardarCambios.BorderRadius = 20;
            this.B_U_GuardarCambios.BorderSize = 3;
            this.B_U_GuardarCambios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.B_U_GuardarCambios.FlatAppearance.BorderSize = 0;
            this.B_U_GuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_U_GuardarCambios.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_U_GuardarCambios.ForeColor = System.Drawing.Color.PowderBlue;
            this.B_U_GuardarCambios.Location = new System.Drawing.Point(3, 390);
            this.B_U_GuardarCambios.Name = "B_U_GuardarCambios";
            this.B_U_GuardarCambios.Size = new System.Drawing.Size(424, 40);
            this.B_U_GuardarCambios.TabIndex = 7;
            this.B_U_GuardarCambios.Text = "Guardar Cambios";
            this.B_U_GuardarCambios.TextColor = System.Drawing.Color.PowderBlue;
            this.B_U_GuardarCambios.UseVisualStyleBackColor = false;
            this.B_U_GuardarCambios.Click += new System.EventHandler(this.B_U_GuardarCambios_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(67)))), ((int)(((byte)(115)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 605);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 580);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1247, 25);
            this.panel5.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1247, 555);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(189)))), ((int)(((byte)(215)))));
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(501, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(679, 549);
            this.panel4.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackgroundImage = global::MAD.Properties.Resources.Background2;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.B_U_CambioResp, 1, 15);
            this.tableLayoutPanel4.Controls.Add(this.B_U_CambioContra, 1, 11);
            this.tableLayoutPanel4.Controls.Add(this.TB_U_Pregunta, 1, 13);
            this.tableLayoutPanel4.Controls.Add(this.TB_U_Correo, 1, 9);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.DTP_U_Nacimiento, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 15);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 13);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 11);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 9);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.TB_U_Nombre, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 17;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.017957F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6886F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.005986F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.92896F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.005986F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20036F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.005986F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69363F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.017957F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69363F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.005986F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69363F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.005986F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69363F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.005986F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.05986F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.017957F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(679, 549);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // B_U_CambioResp
            // 
            this.B_U_CambioResp.BackColor = System.Drawing.Color.Transparent;
            this.B_U_CambioResp.BackgroundColor = System.Drawing.Color.Transparent;
            this.B_U_CambioResp.BorderColor = System.Drawing.Color.PowderBlue;
            this.B_U_CambioResp.BorderRadius = 10;
            this.B_U_CambioResp.BorderSize = 3;
            this.B_U_CambioResp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.B_U_CambioResp.Enabled = false;
            this.B_U_CambioResp.FlatAppearance.BorderSize = 0;
            this.B_U_CambioResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_U_CambioResp.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_U_CambioResp.ForeColor = System.Drawing.Color.PowderBlue;
            this.B_U_CambioResp.Location = new System.Drawing.Point(274, 472);
            this.B_U_CambioResp.Name = "B_U_CambioResp";
            this.B_U_CambioResp.Size = new System.Drawing.Size(402, 48);
            this.B_U_CambioResp.TabIndex = 43;
            this.B_U_CambioResp.Text = "Cambiar Respuesta";
            this.B_U_CambioResp.TextColor = System.Drawing.Color.PowderBlue;
            this.B_U_CambioResp.UseVisualStyleBackColor = false;
            this.B_U_CambioResp.Click += new System.EventHandler(this.B_U_CambioResp_Click);
            // 
            // B_U_CambioContra
            // 
            this.B_U_CambioContra.BackColor = System.Drawing.Color.Transparent;
            this.B_U_CambioContra.BackgroundColor = System.Drawing.Color.Transparent;
            this.B_U_CambioContra.BorderColor = System.Drawing.Color.PowderBlue;
            this.B_U_CambioContra.BorderRadius = 10;
            this.B_U_CambioContra.BorderSize = 3;
            this.B_U_CambioContra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.B_U_CambioContra.Enabled = false;
            this.B_U_CambioContra.FlatAppearance.BorderSize = 0;
            this.B_U_CambioContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_U_CambioContra.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_U_CambioContra.ForeColor = System.Drawing.Color.PowderBlue;
            this.B_U_CambioContra.Location = new System.Drawing.Point(274, 349);
            this.B_U_CambioContra.Name = "B_U_CambioContra";
            this.B_U_CambioContra.Size = new System.Drawing.Size(402, 48);
            this.B_U_CambioContra.TabIndex = 42;
            this.B_U_CambioContra.Text = "Cambiar Contraseña";
            this.B_U_CambioContra.TextColor = System.Drawing.Color.PowderBlue;
            this.B_U_CambioContra.UseVisualStyleBackColor = false;
            this.B_U_CambioContra.Click += new System.EventHandler(this.B_U_CambioContra_Click);
            // 
            // TB_U_Pregunta
            // 
            this.TB_U_Pregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.TB_U_Pregunta.BorderColor = System.Drawing.Color.White;
            this.TB_U_Pregunta.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.TB_U_Pregunta.BorderSize = 5;
            this.TB_U_Pregunta.Dock = System.Windows.Forms.DockStyle.Left;
            this.TB_U_Pregunta.Enabled = false;
            this.TB_U_Pregunta.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_U_Pregunta.ForeColor = System.Drawing.Color.White;
            this.TB_U_Pregunta.Location = new System.Drawing.Point(275, 409);
            this.TB_U_Pregunta.Margin = new System.Windows.Forms.Padding(4);
            this.TB_U_Pregunta.Multiline = false;
            this.TB_U_Pregunta.Name = "TB_U_Pregunta";
            this.TB_U_Pregunta.Padding = new System.Windows.Forms.Padding(7);
            this.TB_U_Pregunta.PasswordChar = false;
            this.TB_U_Pregunta.Size = new System.Drawing.Size(400, 36);
            this.TB_U_Pregunta.TabIndex = 41;
            this.TB_U_Pregunta.Texts = "";
            this.TB_U_Pregunta.UnderlinedStyle = true;
            // 
            // TB_U_Correo
            // 
            this.TB_U_Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.TB_U_Correo.BorderColor = System.Drawing.Color.White;
            this.TB_U_Correo.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.TB_U_Correo.BorderSize = 5;
            this.TB_U_Correo.Dock = System.Windows.Forms.DockStyle.Left;
            this.TB_U_Correo.Enabled = false;
            this.TB_U_Correo.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_U_Correo.ForeColor = System.Drawing.Color.White;
            this.TB_U_Correo.Location = new System.Drawing.Point(275, 283);
            this.TB_U_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.TB_U_Correo.Multiline = false;
            this.TB_U_Correo.Name = "TB_U_Correo";
            this.TB_U_Correo.Padding = new System.Windows.Forms.Padding(7);
            this.TB_U_Correo.PasswordChar = false;
            this.TB_U_Correo.Size = new System.Drawing.Size(400, 36);
            this.TB_U_Correo.TabIndex = 39;
            this.TB_U_Correo.Texts = "";
            this.TB_U_Correo.UnderlinedStyle = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.RB_U_Hombre, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.RB_U_Mujer, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(271, 223);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(408, 40);
            this.tableLayoutPanel6.TabIndex = 38;
            // 
            // RB_U_Hombre
            // 
            this.RB_U_Hombre.AutoSize = true;
            this.RB_U_Hombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.RB_U_Hombre.Checked = true;
            this.RB_U_Hombre.CheckedColor = System.Drawing.Color.White;
            this.RB_U_Hombre.Dock = System.Windows.Forms.DockStyle.Right;
            this.RB_U_Hombre.Enabled = false;
            this.RB_U_Hombre.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_U_Hombre.ForeColor = System.Drawing.Color.White;
            this.RB_U_Hombre.Location = new System.Drawing.Point(83, 3);
            this.RB_U_Hombre.MinimumSize = new System.Drawing.Size(0, 21);
            this.RB_U_Hombre.Name = "RB_U_Hombre";
            this.RB_U_Hombre.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RB_U_Hombre.Size = new System.Drawing.Size(118, 34);
            this.RB_U_Hombre.TabIndex = 2;
            this.RB_U_Hombre.TabStop = true;
            this.RB_U_Hombre.Text = "Hombre";
            this.RB_U_Hombre.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.RB_U_Hombre.UseVisualStyleBackColor = false;
            // 
            // RB_U_Mujer
            // 
            this.RB_U_Mujer.AutoSize = true;
            this.RB_U_Mujer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.RB_U_Mujer.CheckedColor = System.Drawing.Color.White;
            this.RB_U_Mujer.Dock = System.Windows.Forms.DockStyle.Left;
            this.RB_U_Mujer.Enabled = false;
            this.RB_U_Mujer.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_U_Mujer.ForeColor = System.Drawing.Color.White;
            this.RB_U_Mujer.Location = new System.Drawing.Point(207, 3);
            this.RB_U_Mujer.MinimumSize = new System.Drawing.Size(0, 21);
            this.RB_U_Mujer.Name = "RB_U_Mujer";
            this.RB_U_Mujer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RB_U_Mujer.Size = new System.Drawing.Size(99, 34);
            this.RB_U_Mujer.TabIndex = 1;
            this.RB_U_Mujer.Text = "Mujer";
            this.RB_U_Mujer.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.RB_U_Mujer.UseVisualStyleBackColor = false;
            // 
            // DTP_U_Nacimiento
            // 
            this.DTP_U_Nacimiento.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DTP_U_Nacimiento.BorderSize = 0;
            this.DTP_U_Nacimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTP_U_Nacimiento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DTP_U_Nacimiento.Enabled = false;
            this.DTP_U_Nacimiento.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_U_Nacimiento.Location = new System.Drawing.Point(274, 162);
            this.DTP_U_Nacimiento.MinimumSize = new System.Drawing.Size(4, 35);
            this.DTP_U_Nacimiento.Name = "DTP_U_Nacimiento";
            this.DTP_U_Nacimiento.Size = new System.Drawing.Size(402, 35);
            this.DTP_U_Nacimiento.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.DTP_U_Nacimiento.TabIndex = 37;
            this.DTP_U_Nacimiento.TextColor = System.Drawing.Color.White;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.TB_U_MApellido, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.TB_U_PApellido, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(271, 79);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(408, 60);
            this.tableLayoutPanel5.TabIndex = 35;
            // 
            // TB_U_MApellido
            // 
            this.TB_U_MApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_U_MApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.TB_U_MApellido.BorderColor = System.Drawing.Color.White;
            this.TB_U_MApellido.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.TB_U_MApellido.BorderSize = 5;
            this.TB_U_MApellido.Enabled = false;
            this.TB_U_MApellido.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_U_MApellido.ForeColor = System.Drawing.Color.White;
            this.TB_U_MApellido.Location = new System.Drawing.Point(208, 4);
            this.TB_U_MApellido.Margin = new System.Windows.Forms.Padding(4);
            this.TB_U_MApellido.Multiline = false;
            this.TB_U_MApellido.Name = "TB_U_MApellido";
            this.TB_U_MApellido.Padding = new System.Windows.Forms.Padding(7);
            this.TB_U_MApellido.PasswordChar = false;
            this.TB_U_MApellido.Size = new System.Drawing.Size(196, 36);
            this.TB_U_MApellido.TabIndex = 35;
            this.TB_U_MApellido.Texts = "Materno...";
            this.TB_U_MApellido.UnderlinedStyle = true;
            // 
            // TB_U_PApellido
            // 
            this.TB_U_PApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_U_PApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.TB_U_PApellido.BorderColor = System.Drawing.Color.White;
            this.TB_U_PApellido.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.TB_U_PApellido.BorderSize = 5;
            this.TB_U_PApellido.Enabled = false;
            this.TB_U_PApellido.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_U_PApellido.ForeColor = System.Drawing.Color.White;
            this.TB_U_PApellido.Location = new System.Drawing.Point(4, 4);
            this.TB_U_PApellido.Margin = new System.Windows.Forms.Padding(4);
            this.TB_U_PApellido.Multiline = false;
            this.TB_U_PApellido.Name = "TB_U_PApellido";
            this.TB_U_PApellido.Padding = new System.Windows.Forms.Padding(7);
            this.TB_U_PApellido.PasswordChar = false;
            this.TB_U_PApellido.Size = new System.Drawing.Size(196, 36);
            this.TB_U_PApellido.TabIndex = 34;
            this.TB_U_PApellido.Texts = "Paterno...";
            this.TB_U_PApellido.UnderlinedStyle = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(150, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 55);
            this.label9.TabIndex = 34;
            this.label9.Text = "Respuesta:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(124, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 58);
            this.label8.TabIndex = 28;
            this.label8.Text = "Pregunta de recuperación:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(138, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 58);
            this.label3.TabIndex = 25;
            this.label3.Text = "Contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 58);
            this.label2.TabIndex = 24;
            this.label2.Text = "Correo electrónico:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(181, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 58);
            this.label5.TabIndex = 23;
            this.label5.Text = "Género:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 56);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha de nacimiento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(164, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 60);
            this.label7.TabIndex = 21;
            this.label7.Text = "Apellidos:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(154, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 58);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nombre(s):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TB_U_Nombre
            // 
            this.TB_U_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.TB_U_Nombre.BorderColor = System.Drawing.Color.White;
            this.TB_U_Nombre.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.TB_U_Nombre.BorderSize = 5;
            this.TB_U_Nombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.TB_U_Nombre.Enabled = false;
            this.TB_U_Nombre.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_U_Nombre.ForeColor = System.Drawing.Color.White;
            this.TB_U_Nombre.Location = new System.Drawing.Point(275, 20);
            this.TB_U_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.TB_U_Nombre.Multiline = false;
            this.TB_U_Nombre.Name = "TB_U_Nombre";
            this.TB_U_Nombre.Padding = new System.Windows.Forms.Padding(7);
            this.TB_U_Nombre.PasswordChar = false;
            this.TB_U_Nombre.Size = new System.Drawing.Size(400, 36);
            this.TB_U_Nombre.TabIndex = 33;
            this.TB_U_Nombre.Texts = "";
            this.TB_U_Nombre.UnderlinedStyle = true;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuario";
            this.Text = "Tu usuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton B_U_CerrarSesion;
        private CustomControls.RJControls.RJButton B_U_Baja;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CustomControls.RJControls.RJButton B_U_EditarInfo;
        private CustomControls.RJControls.RJButton B_U_GuardarCambios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private RJTextBoxcs TB_U_Nombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private RJTextBoxcs TB_U_MApellido;
        private RJTextBoxcs TB_U_PApellido;
        private RJDatePicker DTP_U_Nacimiento;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private RJRadioButton RB_U_Hombre;
        private RJRadioButton RB_U_Mujer;
        private RJTextBoxcs TB_U_Correo;
        private RJTextBoxcs TB_U_Pregunta;
        private CustomControls.RJControls.RJButton B_U_CambioContra;
        private CustomControls.RJControls.RJButton B_U_CambioResp;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}