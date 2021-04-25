
namespace CapaPresentacion
{
    partial class frmRegistro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.comboBoxAula = new System.Windows.Forms.Panel();
            this.comboBoxHoraSalida = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBoxAula2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CuadroImag = new System.Windows.Forms.PictureBox();
            this.btnBuscarFoto = new System.Windows.Forms.PictureBox();
            this.txtFoto = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMotivoVisita = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxEdificio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarrera = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.MinimizarFormulario = new System.Windows.Forms.PictureBox();
            this.CerrarFormulario = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.moverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.comboBoxAula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuadroImag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFoto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAula
            // 
            this.comboBoxAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(78)))), ((int)(((byte)(198)))));
            this.comboBoxAula.Controls.Add(this.comboBoxHoraSalida);
            this.comboBoxAula.Controls.Add(this.btnGuardar);
            this.comboBoxAula.Controls.Add(this.comboBoxAula2);
            this.comboBoxAula.Controls.Add(this.label12);
            this.comboBoxAula.Controls.Add(this.CuadroImag);
            this.comboBoxAula.Controls.Add(this.btnBuscarFoto);
            this.comboBoxAula.Controls.Add(this.txtFoto);
            this.comboBoxAula.Controls.Add(this.label11);
            this.comboBoxAula.Controls.Add(this.label10);
            this.comboBoxAula.Controls.Add(this.panel4);
            this.comboBoxAula.Controls.Add(this.txtMotivoVisita);
            this.comboBoxAula.Controls.Add(this.label9);
            this.comboBoxAula.Controls.Add(this.label8);
            this.comboBoxAula.Controls.Add(this.dateTimePicker1);
            this.comboBoxAula.Controls.Add(this.panel3);
            this.comboBoxAula.Controls.Add(this.label7);
            this.comboBoxAula.Controls.Add(this.comboBoxEdificio);
            this.comboBoxAula.Controls.Add(this.label6);
            this.comboBoxAula.Controls.Add(this.txtCarrera);
            this.comboBoxAula.Controls.Add(this.label5);
            this.comboBoxAula.Controls.Add(this.txtCorreo);
            this.comboBoxAula.Controls.Add(this.label4);
            this.comboBoxAula.Controls.Add(this.txtApellido);
            this.comboBoxAula.Controls.Add(this.txtNombre);
            this.comboBoxAula.Controls.Add(this.label2);
            this.comboBoxAula.Controls.Add(this.label1);
            this.comboBoxAula.Controls.Add(this.panel2);
            this.comboBoxAula.Controls.Add(this.pictureBox2);
            this.comboBoxAula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxAula.Location = new System.Drawing.Point(0, 0);
            this.comboBoxAula.Name = "comboBoxAula";
            this.comboBoxAula.Size = new System.Drawing.Size(960, 540);
            this.comboBoxAula.TabIndex = 1;
            // 
            // comboBoxHoraSalida
            // 
            this.comboBoxHoraSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.comboBoxHoraSalida.FormattingEnabled = true;
            this.comboBoxHoraSalida.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxHoraSalida.Location = new System.Drawing.Point(389, 285);
            this.comboBoxHoraSalida.Name = "comboBoxHoraSalida";
            this.comboBoxHoraSalida.Size = new System.Drawing.Size(203, 21);
            this.comboBoxHoraSalida.TabIndex = 78;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 7;
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 70D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(682, 442);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(168, 48);
            this.btnGuardar.TabIndex = 77;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(109)))));
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // comboBoxAula2
            // 
            this.comboBoxAula2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.comboBoxAula2.FormattingEnabled = true;
            this.comboBoxAula2.Location = new System.Drawing.Point(385, 124);
            this.comboBoxAula2.Name = "comboBoxAula2";
            this.comboBoxAula2.Size = new System.Drawing.Size(203, 21);
            this.comboBoxAula2.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(78)))), ((int)(((byte)(198)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(384, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 29);
            this.label12.TabIndex = 65;
            this.label12.Text = "Aula";
            // 
            // CuadroImag
            // 
            this.CuadroImag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroImag.Location = new System.Drawing.Point(682, 209);
            this.CuadroImag.Name = "CuadroImag";
            this.CuadroImag.Size = new System.Drawing.Size(247, 216);
            this.CuadroImag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CuadroImag.TabIndex = 64;
            this.CuadroImag.TabStop = false;
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(78)))), ((int)(((byte)(198)))));
            this.btnBuscarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFoto.Image")));
            this.btnBuscarFoto.Location = new System.Drawing.Point(883, 151);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(46, 42);
            this.btnBuscarFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarFoto.TabIndex = 63;
            this.btnBuscarFoto.TabStop = false;
            this.btnBuscarFoto.Click += new System.EventHandler(this.btnBuscarFoto_Click);
            // 
            // txtFoto
            // 
            this.txtFoto.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtFoto.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtFoto.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtFoto.BorderThickness = 3;
            this.txtFoto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFoto.isPassword = false;
            this.txtFoto.Location = new System.Drawing.Point(682, 150);
            this.txtFoto.Margin = new System.Windows.Forms.Padding(4);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(194, 44);
            this.txtFoto.TabIndex = 62;
            this.txtFoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(78)))), ((int)(((byte)(198)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(678, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "Archivo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(78)))), ((int)(((byte)(198)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(677, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 29);
            this.label10.TabIndex = 60;
            this.label10.Text = "Agregar imagen";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.panel4.Location = new System.Drawing.Point(640, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 436);
            this.panel4.TabIndex = 59;
            // 
            // txtMotivoVisita
            // 
            this.txtMotivoVisita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtMotivoVisita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMotivoVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoVisita.Location = new System.Drawing.Point(389, 369);
            this.txtMotivoVisita.Name = "txtMotivoVisita";
            this.txtMotivoVisita.Size = new System.Drawing.Size(228, 139);
            this.txtMotivoVisita.TabIndex = 58;
            this.txtMotivoVisita.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(78)))), ((int)(((byte)(198)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(384, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 29);
            this.label9.TabIndex = 57;
            this.label9.Text = "Motivo de la visita";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(78)))), ((int)(((byte)(198)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(384, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 29);
            this.label8.TabIndex = 55;
            this.label8.Text = "Hora de salida";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.panel3.Location = new System.Drawing.Point(352, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 436);
            this.panel3.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(78)))), ((int)(((byte)(198)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(384, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 29);
            this.label7.TabIndex = 51;
            this.label7.Text = "Hora de entrada";
            // 
            // comboBoxEdificio
            // 
            this.comboBoxEdificio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.comboBoxEdificio.FormattingEnabled = true;
            this.comboBoxEdificio.Location = new System.Drawing.Point(10, 452);
            this.comboBoxEdificio.Name = "comboBoxEdificio";
            this.comboBoxEdificio.Size = new System.Drawing.Size(263, 21);
            this.comboBoxEdificio.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(78)))), ((int)(((byte)(198)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 49;
            this.label6.Text = "Edificio";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.ForeColor = System.Drawing.Color.White;
            this.txtCarrera.HintForeColor = System.Drawing.Color.Black;
            this.txtCarrera.HintText = "";
            this.txtCarrera.isPassword = false;
            this.txtCarrera.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtCarrera.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtCarrera.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtCarrera.LineThickness = 4;
            this.txtCarrera.Location = new System.Drawing.Point(6, 366);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(265, 30);
            this.txtCarrera.TabIndex = 48;
            this.txtCarrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(78)))), ((int)(((byte)(198)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 47;
            this.label5.Text = "Carrera";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.HintForeColor = System.Drawing.Color.Black;
            this.txtCorreo.HintText = "";
            this.txtCorreo.isPassword = false;
            this.txtCorreo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtCorreo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtCorreo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtCorreo.LineThickness = 4;
            this.txtCorreo.Location = new System.Drawing.Point(10, 285);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(265, 30);
            this.txtCorreo.TabIndex = 46;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(78)))), ((int)(((byte)(198)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "Correo";
            // 
            // txtApellido
            // 
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.HintForeColor = System.Drawing.Color.Black;
            this.txtApellido.HintText = "";
            this.txtApellido.isPassword = false;
            this.txtApellido.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtApellido.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtApellido.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtApellido.LineThickness = 4;
            this.txtApellido.Location = new System.Drawing.Point(10, 199);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(265, 30);
            this.txtApellido.TabIndex = 44;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.HintForeColor = System.Drawing.Color.Black;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtNombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.txtNombre.LineThickness = 4;
            this.txtNombre.Location = new System.Drawing.Point(10, 115);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 30);
            this.txtNombre.TabIndex = 43;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(78)))), ((int)(((byte)(198)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(78)))), ((int)(((byte)(198)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.MinimizarFormulario);
            this.panel2.Controls.Add(this.CerrarFormulario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 66);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 42);
            this.label3.TabIndex = 44;
            this.label3.Text = "Registro";
            // 
            // MinimizarFormulario
            // 
            this.MinimizarFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.MinimizarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarFormulario.Image")));
            this.MinimizarFormulario.Location = new System.Drawing.Point(857, 12);
            this.MinimizarFormulario.Name = "MinimizarFormulario";
            this.MinimizarFormulario.Size = new System.Drawing.Size(46, 42);
            this.MinimizarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MinimizarFormulario.TabIndex = 6;
            this.MinimizarFormulario.TabStop = false;
            this.MinimizarFormulario.Click += new System.EventHandler(this.MinimizarFormulario_Click);
            // 
            // CerrarFormulario
            // 
            this.CerrarFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.CerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("CerrarFormulario.Image")));
            this.CerrarFormulario.Location = new System.Drawing.Point(909, 12);
            this.CerrarFormulario.Name = "CerrarFormulario";
            this.CerrarFormulario.Size = new System.Drawing.Size(46, 42);
            this.CerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CerrarFormulario.TabIndex = 4;
            this.CerrarFormulario.TabStop = false;
            this.CerrarFormulario.Click += new System.EventHandler(this.CerrarFormulario_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(596, 353);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(364, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // moverFormulario
            // 
            this.moverFormulario.Fixed = true;
            this.moverFormulario.Horizontal = true;
            this.moverFormulario.TargetControl = this.panel2;
            this.moverFormulario.Vertical = true;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.comboBoxAula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistro";
            this.comboBoxAula.ResumeLayout(false);
            this.comboBoxAula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuadroImag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel comboBoxAula;
        private System.Windows.Forms.PictureBox MinimizarFormulario;
        private System.Windows.Forms.PictureBox CerrarFormulario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCarrera;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCorreo;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellido;
        private System.Windows.Forms.ComboBox comboBoxEdificio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtMotivoVisita;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox btnBuscarFoto;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFoto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox CuadroImag;
        private Bunifu.Framework.UI.BunifuDragControl moverFormulario;
        private System.Windows.Forms.ComboBox comboBoxAula2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.ComboBox comboBoxHoraSalida;
    }
}