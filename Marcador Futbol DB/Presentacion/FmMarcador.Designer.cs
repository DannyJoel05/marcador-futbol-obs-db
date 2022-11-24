
namespace Presentacion
{
    partial class FmMarcador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_visitor = new System.Windows.Forms.TextBox();
            this.btnImgLocal = new System.Windows.Forms.Button();
            this.txt_local = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imgVisitor = new System.Windows.Forms.PictureBox();
            this.imgLocal = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblVisitor = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imgTorneo = new System.Windows.Forms.PictureBox();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.timerChronometer = new System.Windows.Forms.Timer(this.components);
            this.btnImgVisitor = new System.Windows.Forms.Button();
            this.btnPrimaryTime = new System.Windows.Forms.Button();
            this.btnSecondTime = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCountLocal = new System.Windows.Forms.Label();
            this.lblCountVisitor = new System.Windows.Forms.Label();
            this.btnRemoveCountVisitor = new System.Windows.Forms.Button();
            this.btnAddCountVisitor = new System.Windows.Forms.Button();
            this.btnAddCountLocal = new System.Windows.Forms.Button();
            this.btnRemoveCountLocal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTorneo = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timerExtra = new System.Windows.Forms.Timer(this.components);
            this.lblExtra = new System.Windows.Forms.Label();
            this.btnPrimaryTimePause = new System.Windows.Forms.Button();
            this.btnPrimaryTimeRestart = new System.Windows.Forms.Button();
            this.btnSecondTimeRestart = new System.Windows.Forms.Button();
            this.btnSecondTimePause = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblFase = new System.Windows.Forms.Label();
            this.btnImgTorneo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVisitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocal)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTorneo)).BeginInit();
            this.panel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONFIGURACIONES";
            // 
            // txt_visitor
            // 
            this.txt_visitor.Location = new System.Drawing.Point(6, 33);
            this.txt_visitor.Name = "txt_visitor";
            this.txt_visitor.Size = new System.Drawing.Size(149, 20);
            this.txt_visitor.TabIndex = 3;
            this.txt_visitor.TextChanged += new System.EventHandler(this.txt_visitor_TextChanged);
            // 
            // btnImgLocal
            // 
            this.btnImgLocal.Location = new System.Drawing.Point(153, 31);
            this.btnImgLocal.Name = "btnImgLocal";
            this.btnImgLocal.Size = new System.Drawing.Size(60, 22);
            this.btnImgLocal.TabIndex = 2;
            this.btnImgLocal.Text = "IMAGEN";
            this.btnImgLocal.UseVisualStyleBackColor = true;
            this.btnImgLocal.Click += new System.EventHandler(this.btnImgLocal_Click);
            // 
            // txt_local
            // 
            this.txt_local.Location = new System.Drawing.Point(6, 32);
            this.txt_local.Name = "txt_local";
            this.txt_local.Size = new System.Drawing.Size(146, 20);
            this.txt_local.TabIndex = 1;
            this.txt_local.TextChanged += new System.EventHandler(this.txt_local_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.Controls.Add(this.lblExtra);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.imgVisitor);
            this.panel3.Controls.Add(this.imgLocal);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 100);
            this.panel3.TabIndex = 1;
            // 
            // imgVisitor
            // 
            this.imgVisitor.Location = new System.Drawing.Point(441, 38);
            this.imgVisitor.Name = "imgVisitor";
            this.imgVisitor.Size = new System.Drawing.Size(32, 31);
            this.imgVisitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVisitor.TabIndex = 4;
            this.imgVisitor.TabStop = false;
            // 
            // imgLocal
            // 
            this.imgLocal.Location = new System.Drawing.Point(101, 38);
            this.imgLocal.Name = "imgLocal";
            this.imgLocal.Size = new System.Drawing.Size(32, 31);
            this.imgLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLocal.TabIndex = 3;
            this.imgLocal.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(13)))), ((int)(((byte)(50)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblVisitor);
            this.panel6.Controls.Add(this.lblLocal);
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(13)))), ((int)(((byte)(50)))));
            this.panel6.Location = new System.Drawing.Point(137, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(298, 31);
            this.panel6.TabIndex = 2;
            // 
            // lblVisitor
            // 
            this.lblVisitor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVisitor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitor.ForeColor = System.Drawing.Color.White;
            this.lblVisitor.Location = new System.Drawing.Point(150, 4);
            this.lblVisitor.Name = "lblVisitor";
            this.lblVisitor.Size = new System.Drawing.Size(143, 19);
            this.lblVisitor.TabIndex = 1;
            this.lblVisitor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLocal
            // 
            this.lblLocal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLocal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.White;
            this.lblLocal.Location = new System.Drawing.Point(3, 4);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(145, 19);
            this.lblLocal.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(3, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(74, 31);
            this.panel5.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(5, 1);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 26);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(13)))), ((int)(((byte)(50)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblFase);
            this.panel4.Controls.Add(this.lblGroup);
            this.panel4.Controls.Add(this.lblFecha);
            this.panel4.Controls.Add(this.imgTorneo);
            this.panel4.Controls.Add(this.lblTorneo);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 31);
            this.panel4.TabIndex = 0;
            // 
            // imgTorneo
            // 
            this.imgTorneo.Location = new System.Drawing.Point(3, -2);
            this.imgTorneo.Name = "imgTorneo";
            this.imgTorneo.Size = new System.Drawing.Size(23, 30);
            this.imgTorneo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTorneo.TabIndex = 1;
            this.imgTorneo.TabStop = false;
            // 
            // lblTorneo
            // 
            this.lblTorneo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorneo.ForeColor = System.Drawing.Color.White;
            this.lblTorneo.Location = new System.Drawing.Point(32, 4);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(188, 19);
            this.lblTorneo.TabIndex = 0;
            // 
            // timerChronometer
            // 
            this.timerChronometer.Interval = 1000;
            this.timerChronometer.Tick += new System.EventHandler(this.timerChronometer_Tick);
            // 
            // btnImgVisitor
            // 
            this.btnImgVisitor.Location = new System.Drawing.Point(155, 32);
            this.btnImgVisitor.Name = "btnImgVisitor";
            this.btnImgVisitor.Size = new System.Drawing.Size(59, 22);
            this.btnImgVisitor.TabIndex = 3;
            this.btnImgVisitor.Text = "IMAGEN";
            this.btnImgVisitor.UseVisualStyleBackColor = true;
            this.btnImgVisitor.Click += new System.EventHandler(this.btnImgVisitor_Click);
            // 
            // btnPrimaryTime
            // 
            this.btnPrimaryTime.Location = new System.Drawing.Point(6, 19);
            this.btnPrimaryTime.Name = "btnPrimaryTime";
            this.btnPrimaryTime.Size = new System.Drawing.Size(437, 23);
            this.btnPrimaryTime.TabIndex = 4;
            this.btnPrimaryTime.Text = "1° TIEMPO";
            this.btnPrimaryTime.UseVisualStyleBackColor = true;
            this.btnPrimaryTime.Click += new System.EventHandler(this.btnPrimaryTime_Click);
            // 
            // btnSecondTime
            // 
            this.btnSecondTime.Location = new System.Drawing.Point(6, 48);
            this.btnSecondTime.Name = "btnSecondTime";
            this.btnSecondTime.Size = new System.Drawing.Size(437, 23);
            this.btnSecondTime.TabIndex = 5;
            this.btnSecondTime.Text = "2° TIEMPO";
            this.btnSecondTime.UseVisualStyleBackColor = true;
            this.btnSecondTime.Click += new System.EventHandler(this.btnSecondTime_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.lblCountVisitor);
            this.panel7.Controls.Add(this.lblCountLocal);
            this.panel7.Location = new System.Drawing.Point(245, 38);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(79, 31);
            this.panel7.TabIndex = 5;
            // 
            // lblCountLocal
            // 
            this.lblCountLocal.AutoSize = true;
            this.lblCountLocal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountLocal.ForeColor = System.Drawing.Color.Black;
            this.lblCountLocal.Location = new System.Drawing.Point(8, 3);
            this.lblCountLocal.Name = "lblCountLocal";
            this.lblCountLocal.Size = new System.Drawing.Size(20, 23);
            this.lblCountLocal.TabIndex = 1;
            this.lblCountLocal.Text = "0";
            // 
            // lblCountVisitor
            // 
            this.lblCountVisitor.AutoSize = true;
            this.lblCountVisitor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountVisitor.ForeColor = System.Drawing.Color.Black;
            this.lblCountVisitor.Location = new System.Drawing.Point(52, 3);
            this.lblCountVisitor.Name = "lblCountVisitor";
            this.lblCountVisitor.Size = new System.Drawing.Size(20, 23);
            this.lblCountVisitor.TabIndex = 2;
            this.lblCountVisitor.Text = "0";
            // 
            // btnRemoveCountVisitor
            // 
            this.btnRemoveCountVisitor.Location = new System.Drawing.Point(6, 59);
            this.btnRemoveCountVisitor.Name = "btnRemoveCountVisitor";
            this.btnRemoveCountVisitor.Size = new System.Drawing.Size(93, 23);
            this.btnRemoveCountVisitor.TabIndex = 4;
            this.btnRemoveCountVisitor.Text = "<";
            this.btnRemoveCountVisitor.UseVisualStyleBackColor = true;
            this.btnRemoveCountVisitor.Click += new System.EventHandler(this.btnRemoveCountVisitor_Click);
            // 
            // btnAddCountVisitor
            // 
            this.btnAddCountVisitor.Location = new System.Drawing.Point(121, 59);
            this.btnAddCountVisitor.Name = "btnAddCountVisitor";
            this.btnAddCountVisitor.Size = new System.Drawing.Size(93, 23);
            this.btnAddCountVisitor.TabIndex = 5;
            this.btnAddCountVisitor.Text = ">";
            this.btnAddCountVisitor.UseVisualStyleBackColor = true;
            this.btnAddCountVisitor.Click += new System.EventHandler(this.btnAddCountVisitor_Click);
            // 
            // btnAddCountLocal
            // 
            this.btnAddCountLocal.Location = new System.Drawing.Point(120, 58);
            this.btnAddCountLocal.Name = "btnAddCountLocal";
            this.btnAddCountLocal.Size = new System.Drawing.Size(93, 23);
            this.btnAddCountLocal.TabIndex = 7;
            this.btnAddCountLocal.Text = ">";
            this.btnAddCountLocal.UseVisualStyleBackColor = true;
            this.btnAddCountLocal.Click += new System.EventHandler(this.btnAddCountLocal_Click);
            // 
            // btnRemoveCountLocal
            // 
            this.btnRemoveCountLocal.Location = new System.Drawing.Point(6, 58);
            this.btnRemoveCountLocal.Name = "btnRemoveCountLocal";
            this.btnRemoveCountLocal.Size = new System.Drawing.Size(97, 23);
            this.btnRemoveCountLocal.TabIndex = 6;
            this.btnRemoveCountLocal.Text = "<";
            this.btnRemoveCountLocal.UseVisualStyleBackColor = true;
            this.btnRemoveCountLocal.Click += new System.EventHandler(this.btnRemoveCountLocal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddCountLocal);
            this.groupBox2.Controls.Add(this.btnImgLocal);
            this.groupBox2.Controls.Add(this.txt_local);
            this.groupBox2.Controls.Add(this.btnRemoveCountLocal);
            this.groupBox2.Location = new System.Drawing.Point(16, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipo Local";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddCountVisitor);
            this.groupBox3.Controls.Add(this.btnImgVisitor);
            this.groupBox3.Controls.Add(this.btnRemoveCountVisitor);
            this.groupBox3.Controls.Add(this.txt_visitor);
            this.groupBox3.Location = new System.Drawing.Point(245, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Equipo Visitante";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSecondTimeRestart);
            this.groupBox4.Controls.Add(this.btnSecondTimePause);
            this.groupBox4.Controls.Add(this.btnPrimaryTimeRestart);
            this.groupBox4.Controls.Add(this.btnPrimaryTimePause);
            this.groupBox4.Controls.Add(this.btnPrimaryTime);
            this.groupBox4.Controls.Add(this.btnSecondTime);
            this.groupBox4.Location = new System.Drawing.Point(16, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(452, 80);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PARTIDA";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnImgTorneo);
            this.groupBox5.Controls.Add(this.txtFase);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtGroup);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.TxtFecha);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtTorneo);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(16, 134);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(452, 75);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "EXTRA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Torneo: ";
            // 
            // txtTorneo
            // 
            this.txtTorneo.Location = new System.Drawing.Point(55, 17);
            this.txtTorneo.MaxLength = 20;
            this.txtTorneo.Name = "txtTorneo";
            this.txtTorneo.Size = new System.Drawing.Size(253, 20);
            this.txtTorneo.TabIndex = 1;
            this.txtTorneo.TextChanged += new System.EventHandler(this.txtTorneo_TextChanged);
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(55, 43);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(80, 20);
            this.TxtFecha.TabIndex = 3;
            this.TxtFecha.Text = "| FECHA ";
            this.TxtFecha.TextChanged += new System.EventHandler(this.TxtFecha_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha: ";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(342, 43);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(99, 20);
            this.txtGroup.TabIndex = 5;
            this.txtGroup.Text = "| GRUPO ";
            this.txtGroup.TextChanged += new System.EventHandler(this.txtGrup_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grupo: ";
            // 
            // txtFase
            // 
            this.txtFase.Location = new System.Drawing.Point(184, 43);
            this.txtFase.Name = "txtFase";
            this.txtFase.Size = new System.Drawing.Size(99, 20);
            this.txtFase.TabIndex = 7;
            this.txtFase.Text = "| FASE ";
            this.txtFase.TextChanged += new System.EventHandler(this.txtFase_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fase: ";
            // 
            // timerExtra
            // 
            this.timerExtra.Interval = 1000;
            this.timerExtra.Tick += new System.EventHandler(this.timerExtra_Tick);
            // 
            // lblExtra
            // 
            this.lblExtra.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtra.ForeColor = System.Drawing.Color.Black;
            this.lblExtra.Location = new System.Drawing.Point(4, 72);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(62, 18);
            this.lblExtra.TabIndex = 1;
            this.lblExtra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrimaryTimePause
            // 
            this.btnPrimaryTimePause.Location = new System.Drawing.Point(6, 19);
            this.btnPrimaryTimePause.Name = "btnPrimaryTimePause";
            this.btnPrimaryTimePause.Size = new System.Drawing.Size(296, 23);
            this.btnPrimaryTimePause.TabIndex = 6;
            this.btnPrimaryTimePause.Text = "PAUSA 1° TIEMPO";
            this.btnPrimaryTimePause.UseVisualStyleBackColor = true;
            this.btnPrimaryTimePause.Visible = false;
            this.btnPrimaryTimePause.Click += new System.EventHandler(this.btnPrimaryTimePause_Click);
            // 
            // btnPrimaryTimeRestart
            // 
            this.btnPrimaryTimeRestart.Location = new System.Drawing.Point(308, 19);
            this.btnPrimaryTimeRestart.Name = "btnPrimaryTimeRestart";
            this.btnPrimaryTimeRestart.Size = new System.Drawing.Size(135, 23);
            this.btnPrimaryTimeRestart.TabIndex = 7;
            this.btnPrimaryTimeRestart.Text = "REINICIAR 1° TIEMPO";
            this.btnPrimaryTimeRestart.UseVisualStyleBackColor = true;
            this.btnPrimaryTimeRestart.Visible = false;
            this.btnPrimaryTimeRestart.Click += new System.EventHandler(this.btnPrimaryTimeRestart_Click);
            // 
            // btnSecondTimeRestart
            // 
            this.btnSecondTimeRestart.Location = new System.Drawing.Point(308, 48);
            this.btnSecondTimeRestart.Name = "btnSecondTimeRestart";
            this.btnSecondTimeRestart.Size = new System.Drawing.Size(135, 23);
            this.btnSecondTimeRestart.TabIndex = 9;
            this.btnSecondTimeRestart.Text = "REINICIAR 2° TIEMPO";
            this.btnSecondTimeRestart.UseVisualStyleBackColor = true;
            this.btnSecondTimeRestart.Visible = false;
            this.btnSecondTimeRestart.Click += new System.EventHandler(this.btnSecondTimeRestart_Click);
            // 
            // btnSecondTimePause
            // 
            this.btnSecondTimePause.Location = new System.Drawing.Point(6, 48);
            this.btnSecondTimePause.Name = "btnSecondTimePause";
            this.btnSecondTimePause.Size = new System.Drawing.Size(296, 23);
            this.btnSecondTimePause.TabIndex = 8;
            this.btnSecondTimePause.Text = "PAUSA 2° TIEMPO";
            this.btnSecondTimePause.UseVisualStyleBackColor = true;
            this.btnSecondTimePause.Visible = false;
            this.btnSecondTimePause.Click += new System.EventHandler(this.btnSecondTimePause_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(384, 3);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(85, 19);
            this.lblFecha.TabIndex = 2;
            // 
            // lblGroup
            // 
            this.lblGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.Color.White;
            this.lblGroup.Location = new System.Drawing.Point(298, 3);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(90, 19);
            this.lblGroup.TabIndex = 3;
            // 
            // lblFase
            // 
            this.lblFase.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFase.ForeColor = System.Drawing.Color.White;
            this.lblFase.Location = new System.Drawing.Point(226, 3);
            this.lblFase.Name = "lblFase";
            this.lblFase.Size = new System.Drawing.Size(80, 19);
            this.lblFase.TabIndex = 4;
            this.lblFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImgTorneo
            // 
            this.btnImgTorneo.Location = new System.Drawing.Point(325, 15);
            this.btnImgTorneo.Name = "btnImgTorneo";
            this.btnImgTorneo.Size = new System.Drawing.Size(116, 22);
            this.btnImgTorneo.TabIndex = 6;
            this.btnImgTorneo.Text = "IMAGEN";
            this.btnImgTorneo.UseVisualStyleBackColor = true;
            this.btnImgTorneo.Click += new System.EventHandler(this.btnImgTorneo_Click);
            // 
            // FmMarcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 467);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmMarcador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcador";
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVisitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocal)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTorneo)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_local;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.PictureBox imgVisitor;
        private System.Windows.Forms.PictureBox imgLocal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblVisitor;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox imgTorneo;
        private System.Windows.Forms.Timer timerChronometer;
        private System.Windows.Forms.TextBox txt_visitor;
        private System.Windows.Forms.Button btnImgLocal;
        private System.Windows.Forms.Button btnImgVisitor;
        private System.Windows.Forms.Button btnSecondTime;
        private System.Windows.Forms.Button btnPrimaryTime;
        private System.Windows.Forms.Button btnAddCountVisitor;
        private System.Windows.Forms.Button btnRemoveCountVisitor;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCountVisitor;
        private System.Windows.Forms.Label lblCountLocal;
        private System.Windows.Forms.Button btnAddCountLocal;
        private System.Windows.Forms.Button btnRemoveCountLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTorneo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerExtra;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.Button btnPrimaryTimePause;
        private System.Windows.Forms.Button btnPrimaryTimeRestart;
        private System.Windows.Forms.Button btnSecondTimeRestart;
        private System.Windows.Forms.Button btnSecondTimePause;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblFase;
        private System.Windows.Forms.Button btnImgTorneo;
    }
}

