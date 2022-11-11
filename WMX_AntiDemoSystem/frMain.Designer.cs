namespace WMX_Anti
{
    partial class Main_Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Servo_ON = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tmCycle = new System.Windows.Forms.Timer(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cp0 = new System.Windows.Forms.TextBox();
            this.cp1 = new System.Windows.Forms.TextBox();
            this.cp2 = new System.Windows.Forms.TextBox();
            this.cp3 = new System.Windows.Forms.TextBox();
            this.ap3 = new System.Windows.Forms.TextBox();
            this.ap2 = new System.Windows.Forms.TextBox();
            this.ap1 = new System.Windows.Forms.TextBox();
            this.ap0 = new System.Windows.Forms.TextBox();
            this.lbOP_0 = new System.Windows.Forms.TextBox();
            this.lbOP_1 = new System.Windows.Forms.TextBox();
            this.lbOP_2 = new System.Windows.Forms.TextBox();
            this.lbOP_3 = new System.Windows.Forms.TextBox();
            this.lborg0 = new System.Windows.Forms.Label();
            this.lborg1 = new System.Windows.Forms.Label();
            this.lborg2 = new System.Windows.Forms.Label();
            this.lborg3 = new System.Windows.Forms.Label();
            this.P_EL3 = new System.Windows.Forms.Label();
            this.P_EL2 = new System.Windows.Forms.Label();
            this.P_EL1 = new System.Windows.Forms.Label();
            this.P_EL0 = new System.Windows.Forms.Label();
            this.N_EL3 = new System.Windows.Forms.Label();
            this.N_EL2 = new System.Windows.Forms.Label();
            this.N_EL1 = new System.Windows.Forms.Label();
            this.N_EL0 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbALM0 = new System.Windows.Forms.Label();
            this.lbALM1 = new System.Windows.Forms.Label();
            this.lbALM3 = new System.Windows.Forms.Label();
            this.lbALM2 = new System.Windows.Forms.Label();
            this.btParameter = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aVSD2000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.X_Move3 = new System.Windows.Forms.Button();
            this.X_Move0 = new System.Windows.Forms.Button();
            this.X_Move2 = new System.Windows.Forms.Button();
            this.X_Move1 = new System.Windows.Forms.Button();
            this.X_UnMove3 = new System.Windows.Forms.Button();
            this.X_UnMove0 = new System.Windows.Forms.Button();
            this.X_UnMove2 = new System.Windows.Forms.Button();
            this.X_UnMove1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Y_UnMove3 = new System.Windows.Forms.Button();
            this.Y_UnMove0 = new System.Windows.Forms.Button();
            this.Y_UnMove2 = new System.Windows.Forms.Button();
            this.Y_UnMove1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.XY_Move3 = new System.Windows.Forms.Button();
            this.XY_Move0 = new System.Windows.Forms.Button();
            this.XY_Move2 = new System.Windows.Forms.Button();
            this.XY_Move1 = new System.Windows.Forms.Button();
            this.XY_UnMove3 = new System.Windows.Forms.Button();
            this.XY_UnMove0 = new System.Windows.Forms.Button();
            this.XY_UnMove2 = new System.Windows.Forms.Button();
            this.XY_UnMove1 = new System.Windows.Forms.Button();
            this.btE_Stop = new System.Windows.Forms.Button();
            this.btBefore = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.Z_Move0 = new System.Windows.Forms.Button();
            this.Z_Move1 = new System.Windows.Forms.Button();
            this.Z_UnMove0 = new System.Windows.Forms.Button();
            this.Z_UnMove1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btintialize = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btAfter = new System.Windows.Forms.Button();
            this.btBofore = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.led3 = new NationalInstruments.UI.WindowsForms.Led();
            this.led2 = new NationalInstruments.UI.WindowsForms.Led();
            this.led1 = new NationalInstruments.UI.WindowsForms.Led();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Servo_ON
            // 
            this.Servo_ON.BackColor = System.Drawing.Color.LimeGreen;
            this.Servo_ON.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Servo_ON.FlatAppearance.BorderSize = 2;
            this.Servo_ON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.Servo_ON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Servo_ON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Servo_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Servo_ON.ForeColor = System.Drawing.Color.White;
            this.Servo_ON.Image = ((System.Drawing.Image)(resources.GetObject("Servo_ON.Image")));
            this.Servo_ON.Location = new System.Drawing.Point(155, 20);
            this.Servo_ON.Name = "Servo_ON";
            this.Servo_ON.Size = new System.Drawing.Size(108, 64);
            this.Servo_ON.TabIndex = 0;
            this.Servo_ON.Text = "  Servo";
            this.Servo_ON.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Servo_ON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Servo_ON.UseVisualStyleBackColor = false;
            this.Servo_ON.Click += new System.EventHandler(this.Servo_ON_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tmCycle
            // 
            this.tmCycle.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(13, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(142, 25);
            this.label20.TabIndex = 33;
            this.label20.Text = "Position Status";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(14, 102);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 20);
            this.label21.TabIndex = 34;
            this.label21.Text = "Axis 0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(14, 143);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 20);
            this.label22.TabIndex = 35;
            this.label22.Text = "Axis 1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(14, 184);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 20);
            this.label23.TabIndex = 36;
            this.label23.Text = "Axis 2";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(14, 225);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 20);
            this.label24.TabIndex = 37;
            this.label24.Text = "Axis 3";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(88, 65);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 20);
            this.label25.TabIndex = 38;
            this.label25.Text = "CmdPos";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(192, 65);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 20);
            this.label26.TabIndex = 39;
            this.label26.Text = "ActualPos";
            // 
            // cp0
            // 
            this.cp0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.cp0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cp0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cp0.ForeColor = System.Drawing.Color.LimeGreen;
            this.cp0.Location = new System.Drawing.Point(74, 102);
            this.cp0.Name = "cp0";
            this.cp0.Size = new System.Drawing.Size(93, 19);
            this.cp0.TabIndex = 52;
            this.cp0.Text = "0";
            this.cp0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cp1
            // 
            this.cp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.cp1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cp1.ForeColor = System.Drawing.Color.LimeGreen;
            this.cp1.Location = new System.Drawing.Point(74, 143);
            this.cp1.Name = "cp1";
            this.cp1.Size = new System.Drawing.Size(93, 19);
            this.cp1.TabIndex = 53;
            this.cp1.Text = "0";
            this.cp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cp2
            // 
            this.cp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.cp2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cp2.ForeColor = System.Drawing.Color.LimeGreen;
            this.cp2.Location = new System.Drawing.Point(74, 184);
            this.cp2.Name = "cp2";
            this.cp2.Size = new System.Drawing.Size(93, 19);
            this.cp2.TabIndex = 54;
            this.cp2.Text = "0";
            this.cp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cp3
            // 
            this.cp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.cp3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cp3.ForeColor = System.Drawing.Color.LimeGreen;
            this.cp3.Location = new System.Drawing.Point(74, 225);
            this.cp3.Name = "cp3";
            this.cp3.Size = new System.Drawing.Size(93, 19);
            this.cp3.TabIndex = 55;
            this.cp3.Text = "0";
            this.cp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ap3
            // 
            this.ap3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.ap3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ap3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ap3.ForeColor = System.Drawing.Color.LimeGreen;
            this.ap3.Location = new System.Drawing.Point(185, 225);
            this.ap3.Name = "ap3";
            this.ap3.Size = new System.Drawing.Size(93, 19);
            this.ap3.TabIndex = 59;
            this.ap3.Text = "0";
            this.ap3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ap2
            // 
            this.ap2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.ap2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ap2.ForeColor = System.Drawing.Color.LimeGreen;
            this.ap2.Location = new System.Drawing.Point(185, 184);
            this.ap2.Name = "ap2";
            this.ap2.Size = new System.Drawing.Size(93, 19);
            this.ap2.TabIndex = 58;
            this.ap2.Text = "0";
            this.ap2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ap1
            // 
            this.ap1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.ap1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ap1.ForeColor = System.Drawing.Color.LimeGreen;
            this.ap1.Location = new System.Drawing.Point(185, 143);
            this.ap1.Name = "ap1";
            this.ap1.Size = new System.Drawing.Size(93, 19);
            this.ap1.TabIndex = 57;
            this.ap1.Text = "0";
            this.ap1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ap0
            // 
            this.ap0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.ap0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ap0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ap0.ForeColor = System.Drawing.Color.LimeGreen;
            this.ap0.Location = new System.Drawing.Point(185, 102);
            this.ap0.Name = "ap0";
            this.ap0.Size = new System.Drawing.Size(93, 19);
            this.ap0.TabIndex = 56;
            this.ap0.Text = "0";
            this.ap0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbOP_0
            // 
            this.lbOP_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.lbOP_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbOP_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbOP_0.ForeColor = System.Drawing.Color.Black;
            this.lbOP_0.Location = new System.Drawing.Point(291, 103);
            this.lbOP_0.Name = "lbOP_0";
            this.lbOP_0.Size = new System.Drawing.Size(51, 19);
            this.lbOP_0.TabIndex = 60;
            this.lbOP_0.Text = "OFF";
            this.lbOP_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbOP_1
            // 
            this.lbOP_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.lbOP_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbOP_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbOP_1.ForeColor = System.Drawing.Color.Black;
            this.lbOP_1.Location = new System.Drawing.Point(291, 143);
            this.lbOP_1.Name = "lbOP_1";
            this.lbOP_1.Size = new System.Drawing.Size(51, 19);
            this.lbOP_1.TabIndex = 61;
            this.lbOP_1.Text = "OFF";
            this.lbOP_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbOP_2
            // 
            this.lbOP_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.lbOP_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbOP_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbOP_2.ForeColor = System.Drawing.Color.Black;
            this.lbOP_2.Location = new System.Drawing.Point(291, 184);
            this.lbOP_2.Name = "lbOP_2";
            this.lbOP_2.Size = new System.Drawing.Size(51, 19);
            this.lbOP_2.TabIndex = 62;
            this.lbOP_2.Text = "OFF";
            this.lbOP_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbOP_3
            // 
            this.lbOP_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.lbOP_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbOP_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbOP_3.ForeColor = System.Drawing.Color.Black;
            this.lbOP_3.Location = new System.Drawing.Point(291, 225);
            this.lbOP_3.Name = "lbOP_3";
            this.lbOP_3.Size = new System.Drawing.Size(51, 19);
            this.lbOP_3.TabIndex = 63;
            this.lbOP_3.Text = "OFF";
            this.lbOP_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lborg0
            // 
            this.lborg0.AutoSize = true;
            this.lborg0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lborg0.Location = new System.Drawing.Point(15, 101);
            this.lborg0.Name = "lborg0";
            this.lborg0.Size = new System.Drawing.Size(46, 20);
            this.lborg0.TabIndex = 65;
            this.lborg0.Text = "ORG";
            // 
            // lborg1
            // 
            this.lborg1.AutoSize = true;
            this.lborg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lborg1.Location = new System.Drawing.Point(15, 142);
            this.lborg1.Name = "lborg1";
            this.lborg1.Size = new System.Drawing.Size(46, 20);
            this.lborg1.TabIndex = 66;
            this.lborg1.Text = "ORG";
            // 
            // lborg2
            // 
            this.lborg2.AutoSize = true;
            this.lborg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lborg2.Location = new System.Drawing.Point(15, 183);
            this.lborg2.Name = "lborg2";
            this.lborg2.Size = new System.Drawing.Size(46, 20);
            this.lborg2.TabIndex = 67;
            this.lborg2.Text = "ORG";
            // 
            // lborg3
            // 
            this.lborg3.AutoSize = true;
            this.lborg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lborg3.Location = new System.Drawing.Point(15, 224);
            this.lborg3.Name = "lborg3";
            this.lborg3.Size = new System.Drawing.Size(46, 20);
            this.lborg3.TabIndex = 68;
            this.lborg3.Text = "ORG";
            // 
            // P_EL3
            // 
            this.P_EL3.AutoSize = true;
            this.P_EL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.P_EL3.Location = new System.Drawing.Point(69, 224);
            this.P_EL3.Name = "P_EL3";
            this.P_EL3.Size = new System.Drawing.Size(38, 20);
            this.P_EL3.TabIndex = 72;
            this.P_EL3.Text = "+EL";
            // 
            // P_EL2
            // 
            this.P_EL2.AutoSize = true;
            this.P_EL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.P_EL2.Location = new System.Drawing.Point(69, 183);
            this.P_EL2.Name = "P_EL2";
            this.P_EL2.Size = new System.Drawing.Size(38, 20);
            this.P_EL2.TabIndex = 71;
            this.P_EL2.Text = "+EL";
            // 
            // P_EL1
            // 
            this.P_EL1.AutoSize = true;
            this.P_EL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.P_EL1.Location = new System.Drawing.Point(69, 142);
            this.P_EL1.Name = "P_EL1";
            this.P_EL1.Size = new System.Drawing.Size(38, 20);
            this.P_EL1.TabIndex = 70;
            this.P_EL1.Text = "+EL";
            // 
            // P_EL0
            // 
            this.P_EL0.AutoSize = true;
            this.P_EL0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.P_EL0.Location = new System.Drawing.Point(69, 101);
            this.P_EL0.Name = "P_EL0";
            this.P_EL0.Size = new System.Drawing.Size(38, 20);
            this.P_EL0.TabIndex = 69;
            this.P_EL0.Text = "+EL";
            // 
            // N_EL3
            // 
            this.N_EL3.AutoSize = true;
            this.N_EL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.N_EL3.Location = new System.Drawing.Point(115, 224);
            this.N_EL3.Name = "N_EL3";
            this.N_EL3.Size = new System.Drawing.Size(34, 20);
            this.N_EL3.TabIndex = 76;
            this.N_EL3.Text = "-EL";
            // 
            // N_EL2
            // 
            this.N_EL2.AutoSize = true;
            this.N_EL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.N_EL2.Location = new System.Drawing.Point(115, 183);
            this.N_EL2.Name = "N_EL2";
            this.N_EL2.Size = new System.Drawing.Size(34, 20);
            this.N_EL2.TabIndex = 75;
            this.N_EL2.Text = "-EL";
            // 
            // N_EL1
            // 
            this.N_EL1.AutoSize = true;
            this.N_EL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.N_EL1.Location = new System.Drawing.Point(115, 142);
            this.N_EL1.Name = "N_EL1";
            this.N_EL1.Size = new System.Drawing.Size(34, 20);
            this.N_EL1.TabIndex = 74;
            this.N_EL1.Text = "-EL";
            // 
            // N_EL0
            // 
            this.N_EL0.AutoSize = true;
            this.N_EL0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.N_EL0.Location = new System.Drawing.Point(115, 101);
            this.N_EL0.Name = "N_EL0";
            this.N_EL0.Size = new System.Drawing.Size(34, 20);
            this.N_EL0.TabIndex = 73;
            this.N_EL0.Text = "-EL";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.button2.Location = new System.Drawing.Point(1586, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 40);
            this.button2.TabIndex = 78;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbALM0
            // 
            this.lbALM0.AutoSize = true;
            this.lbALM0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbALM0.Location = new System.Drawing.Point(157, 101);
            this.lbALM0.Name = "lbALM0";
            this.lbALM0.Size = new System.Drawing.Size(42, 20);
            this.lbALM0.TabIndex = 81;
            this.lbALM0.Text = "ALM";
            // 
            // lbALM1
            // 
            this.lbALM1.AutoSize = true;
            this.lbALM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbALM1.Location = new System.Drawing.Point(157, 142);
            this.lbALM1.Name = "lbALM1";
            this.lbALM1.Size = new System.Drawing.Size(42, 20);
            this.lbALM1.TabIndex = 82;
            this.lbALM1.Text = "ALM";
            // 
            // lbALM3
            // 
            this.lbALM3.AutoSize = true;
            this.lbALM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbALM3.Location = new System.Drawing.Point(157, 224);
            this.lbALM3.Name = "lbALM3";
            this.lbALM3.Size = new System.Drawing.Size(42, 20);
            this.lbALM3.TabIndex = 83;
            this.lbALM3.Text = "ALM";
            // 
            // lbALM2
            // 
            this.lbALM2.AutoSize = true;
            this.lbALM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbALM2.Location = new System.Drawing.Point(157, 183);
            this.lbALM2.Name = "lbALM2";
            this.lbALM2.Size = new System.Drawing.Size(42, 20);
            this.lbALM2.TabIndex = 84;
            this.lbALM2.Text = "ALM";
            // 
            // btParameter
            // 
            this.btParameter.BackColor = System.Drawing.Color.White;
            this.btParameter.FlatAppearance.BorderSize = 2;
            this.btParameter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btParameter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btParameter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btParameter.ForeColor = System.Drawing.Color.Black;
            this.btParameter.Image = ((System.Drawing.Image)(resources.GetObject("btParameter.Image")));
            this.btParameter.Location = new System.Drawing.Point(31, 38);
            this.btParameter.Name = "btParameter";
            this.btParameter.Size = new System.Drawing.Size(367, 99);
            this.btParameter.TabIndex = 85;
            this.btParameter.Text = "Motion Parameter";
            this.btParameter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btParameter.UseVisualStyleBackColor = false;
            this.btParameter.Click += new System.EventHandler(this.btParameter_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1367, 529);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 87;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip1.TabIndex = 88;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aVSD2000ToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // aVSD2000ToolStripMenuItem
            // 
            this.aVSD2000ToolStripMenuItem.Name = "aVSD2000ToolStripMenuItem";
            this.aVSD2000ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.aVSD2000ToolStripMenuItem.Text = "AVSD-2000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.X_Move3);
            this.groupBox1.Controls.Add(this.X_Move0);
            this.groupBox1.Controls.Add(this.X_Move2);
            this.groupBox1.Controls.Add(this.X_Move1);
            this.groupBox1.Controls.Add(this.X_UnMove3);
            this.groupBox1.Controls.Add(this.X_UnMove0);
            this.groupBox1.Controls.Add(this.X_UnMove2);
            this.groupBox1.Controls.Add(this.X_UnMove1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(422, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 315);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "X-Axis";
            // 
            // X_Move3
            // 
            this.X_Move3.BackColor = System.Drawing.SystemColors.Control;
            this.X_Move3.FlatAppearance.BorderSize = 2;
            this.X_Move3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_Move3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_Move3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_Move3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_Move3.ForeColor = System.Drawing.Color.Black;
            this.X_Move3.Location = new System.Drawing.Point(141, 239);
            this.X_Move3.Name = "X_Move3";
            this.X_Move3.Size = new System.Drawing.Size(117, 55);
            this.X_Move3.TabIndex = 103;
            this.X_Move3.Text = "Shaped:      1Cycle";
            this.X_Move3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_Move3.UseVisualStyleBackColor = false;
            // 
            // X_Move0
            // 
            this.X_Move0.BackColor = System.Drawing.SystemColors.Control;
            this.X_Move0.FlatAppearance.BorderSize = 2;
            this.X_Move0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_Move0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_Move0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_Move0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_Move0.ForeColor = System.Drawing.Color.Black;
            this.X_Move0.Location = new System.Drawing.Point(141, 32);
            this.X_Move0.Name = "X_Move0";
            this.X_Move0.Size = new System.Drawing.Size(117, 55);
            this.X_Move0.TabIndex = 100;
            this.X_Move0.Text = "Shaped:       Move 0";
            this.X_Move0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_Move0.UseVisualStyleBackColor = false;
            this.X_Move0.Click += new System.EventHandler(this.X_Move0_Click);
            // 
            // X_Move2
            // 
            this.X_Move2.BackColor = System.Drawing.SystemColors.Control;
            this.X_Move2.FlatAppearance.BorderSize = 2;
            this.X_Move2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_Move2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_Move2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_Move2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_Move2.ForeColor = System.Drawing.Color.Black;
            this.X_Move2.Location = new System.Drawing.Point(141, 170);
            this.X_Move2.Name = "X_Move2";
            this.X_Move2.Size = new System.Drawing.Size(117, 55);
            this.X_Move2.TabIndex = 101;
            this.X_Move2.Text = "Shaped:      Move 2";
            this.X_Move2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_Move2.UseVisualStyleBackColor = false;
            // 
            // X_Move1
            // 
            this.X_Move1.BackColor = System.Drawing.SystemColors.Control;
            this.X_Move1.FlatAppearance.BorderSize = 2;
            this.X_Move1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_Move1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_Move1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_Move1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_Move1.ForeColor = System.Drawing.Color.Black;
            this.X_Move1.Location = new System.Drawing.Point(141, 101);
            this.X_Move1.Name = "X_Move1";
            this.X_Move1.Size = new System.Drawing.Size(117, 55);
            this.X_Move1.TabIndex = 102;
            this.X_Move1.Text = "Shaped:       Move 1";
            this.X_Move1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_Move1.UseVisualStyleBackColor = false;
            // 
            // X_UnMove3
            // 
            this.X_UnMove3.BackColor = System.Drawing.SystemColors.Control;
            this.X_UnMove3.FlatAppearance.BorderSize = 2;
            this.X_UnMove3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_UnMove3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_UnMove3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_UnMove3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_UnMove3.ForeColor = System.Drawing.Color.Black;
            this.X_UnMove3.Location = new System.Drawing.Point(13, 239);
            this.X_UnMove3.Name = "X_UnMove3";
            this.X_UnMove3.Size = new System.Drawing.Size(117, 55);
            this.X_UnMove3.TabIndex = 99;
            this.X_UnMove3.Text = "Un Shaped 1Cycle";
            this.X_UnMove3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_UnMove3.UseVisualStyleBackColor = false;
            this.X_UnMove3.Click += new System.EventHandler(this.X_UnMove3_Click);
            // 
            // X_UnMove0
            // 
            this.X_UnMove0.BackColor = System.Drawing.SystemColors.Control;
            this.X_UnMove0.FlatAppearance.BorderSize = 2;
            this.X_UnMove0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_UnMove0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_UnMove0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_UnMove0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_UnMove0.ForeColor = System.Drawing.Color.Black;
            this.X_UnMove0.Location = new System.Drawing.Point(13, 32);
            this.X_UnMove0.Name = "X_UnMove0";
            this.X_UnMove0.Size = new System.Drawing.Size(117, 55);
            this.X_UnMove0.TabIndex = 96;
            this.X_UnMove0.Text = "Un Shaped Move 0";
            this.X_UnMove0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_UnMove0.UseVisualStyleBackColor = false;
            this.X_UnMove0.Click += new System.EventHandler(this.X_UnMove0_Click);
            // 
            // X_UnMove2
            // 
            this.X_UnMove2.BackColor = System.Drawing.SystemColors.Control;
            this.X_UnMove2.FlatAppearance.BorderSize = 2;
            this.X_UnMove2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_UnMove2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_UnMove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_UnMove2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_UnMove2.ForeColor = System.Drawing.Color.Black;
            this.X_UnMove2.Location = new System.Drawing.Point(13, 170);
            this.X_UnMove2.Name = "X_UnMove2";
            this.X_UnMove2.Size = new System.Drawing.Size(117, 55);
            this.X_UnMove2.TabIndex = 97;
            this.X_UnMove2.Text = "Un Shaped Move 2";
            this.X_UnMove2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_UnMove2.UseVisualStyleBackColor = false;
            this.X_UnMove2.Click += new System.EventHandler(this.X_UnMove0_Click);
            // 
            // X_UnMove1
            // 
            this.X_UnMove1.BackColor = System.Drawing.SystemColors.Control;
            this.X_UnMove1.FlatAppearance.BorderSize = 2;
            this.X_UnMove1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_UnMove1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_UnMove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_UnMove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_UnMove1.ForeColor = System.Drawing.Color.Black;
            this.X_UnMove1.Location = new System.Drawing.Point(13, 101);
            this.X_UnMove1.Name = "X_UnMove1";
            this.X_UnMove1.Size = new System.Drawing.Size(117, 55);
            this.X_UnMove1.TabIndex = 98;
            this.X_UnMove1.Text = "Un Shaped Move 1";
            this.X_UnMove1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_UnMove1.UseVisualStyleBackColor = false;
            this.X_UnMove1.Click += new System.EventHandler(this.X_UnMove0_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.Y_UnMove3);
            this.groupBox2.Controls.Add(this.Y_UnMove0);
            this.groupBox2.Controls.Add(this.Y_UnMove2);
            this.groupBox2.Controls.Add(this.Y_UnMove1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(703, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 315);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Y-Axis";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(138, 239);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 55);
            this.button8.TabIndex = 103;
            this.button8.Text = "Shaped:      1Cycle";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(138, 32);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 55);
            this.button9.TabIndex = 100;
            this.button9.Text = "Shaped:       Move 0";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Control;
            this.button10.FlatAppearance.BorderSize = 2;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(138, 170);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(117, 55);
            this.button10.TabIndex = 101;
            this.button10.Text = "Shaped:      Move 2";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Control;
            this.button11.FlatAppearance.BorderSize = 2;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(138, 101);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(117, 55);
            this.button11.TabIndex = 102;
            this.button11.Text = "Shaped:       Move 1";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // Y_UnMove3
            // 
            this.Y_UnMove3.BackColor = System.Drawing.SystemColors.Control;
            this.Y_UnMove3.FlatAppearance.BorderSize = 2;
            this.Y_UnMove3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Y_UnMove3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Y_UnMove3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Y_UnMove3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Y_UnMove3.ForeColor = System.Drawing.Color.Black;
            this.Y_UnMove3.Location = new System.Drawing.Point(10, 239);
            this.Y_UnMove3.Name = "Y_UnMove3";
            this.Y_UnMove3.Size = new System.Drawing.Size(117, 55);
            this.Y_UnMove3.TabIndex = 99;
            this.Y_UnMove3.Text = "Un Shaped 1Cycle";
            this.Y_UnMove3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Y_UnMove3.UseVisualStyleBackColor = false;
            this.Y_UnMove3.Click += new System.EventHandler(this.Y_UnMove3_Click);
            // 
            // Y_UnMove0
            // 
            this.Y_UnMove0.BackColor = System.Drawing.SystemColors.Control;
            this.Y_UnMove0.FlatAppearance.BorderSize = 2;
            this.Y_UnMove0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Y_UnMove0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Y_UnMove0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Y_UnMove0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Y_UnMove0.ForeColor = System.Drawing.Color.Black;
            this.Y_UnMove0.Location = new System.Drawing.Point(10, 32);
            this.Y_UnMove0.Name = "Y_UnMove0";
            this.Y_UnMove0.Size = new System.Drawing.Size(117, 55);
            this.Y_UnMove0.TabIndex = 96;
            this.Y_UnMove0.Text = "Un Shaped Move 0";
            this.Y_UnMove0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Y_UnMove0.UseVisualStyleBackColor = false;
            this.Y_UnMove0.Click += new System.EventHandler(this.Y_UnMove0_Click);
            // 
            // Y_UnMove2
            // 
            this.Y_UnMove2.BackColor = System.Drawing.SystemColors.Control;
            this.Y_UnMove2.FlatAppearance.BorderSize = 2;
            this.Y_UnMove2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Y_UnMove2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Y_UnMove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Y_UnMove2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Y_UnMove2.ForeColor = System.Drawing.Color.Black;
            this.Y_UnMove2.Location = new System.Drawing.Point(10, 170);
            this.Y_UnMove2.Name = "Y_UnMove2";
            this.Y_UnMove2.Size = new System.Drawing.Size(117, 55);
            this.Y_UnMove2.TabIndex = 97;
            this.Y_UnMove2.Text = "Un Shaped Move 2";
            this.Y_UnMove2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Y_UnMove2.UseVisualStyleBackColor = false;
            this.Y_UnMove2.Click += new System.EventHandler(this.Y_UnMove0_Click);
            // 
            // Y_UnMove1
            // 
            this.Y_UnMove1.BackColor = System.Drawing.SystemColors.Control;
            this.Y_UnMove1.FlatAppearance.BorderSize = 2;
            this.Y_UnMove1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Y_UnMove1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Y_UnMove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Y_UnMove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Y_UnMove1.ForeColor = System.Drawing.Color.Black;
            this.Y_UnMove1.Location = new System.Drawing.Point(10, 101);
            this.Y_UnMove1.Name = "Y_UnMove1";
            this.Y_UnMove1.Size = new System.Drawing.Size(117, 55);
            this.Y_UnMove1.TabIndex = 98;
            this.Y_UnMove1.Text = "Un Shaped Move 1";
            this.Y_UnMove1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Y_UnMove1.UseVisualStyleBackColor = false;
            this.Y_UnMove1.Click += new System.EventHandler(this.Y_UnMove0_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.XY_Move3);
            this.groupBox3.Controls.Add(this.XY_Move0);
            this.groupBox3.Controls.Add(this.XY_Move2);
            this.groupBox3.Controls.Add(this.XY_Move1);
            this.groupBox3.Controls.Add(this.XY_UnMove3);
            this.groupBox3.Controls.Add(this.XY_UnMove0);
            this.groupBox3.Controls.Add(this.XY_UnMove2);
            this.groupBox3.Controls.Add(this.XY_UnMove1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(980, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 315);
            this.groupBox3.TabIndex = 91;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "X_Y-Axis";
            // 
            // XY_Move3
            // 
            this.XY_Move3.BackColor = System.Drawing.SystemColors.Control;
            this.XY_Move3.FlatAppearance.BorderSize = 2;
            this.XY_Move3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_Move3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_Move3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_Move3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_Move3.ForeColor = System.Drawing.Color.Black;
            this.XY_Move3.Location = new System.Drawing.Point(140, 239);
            this.XY_Move3.Name = "XY_Move3";
            this.XY_Move3.Size = new System.Drawing.Size(117, 55);
            this.XY_Move3.TabIndex = 103;
            this.XY_Move3.Text = "Shaped:           1Cycle";
            this.XY_Move3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_Move3.UseVisualStyleBackColor = false;
            // 
            // XY_Move0
            // 
            this.XY_Move0.BackColor = System.Drawing.SystemColors.Control;
            this.XY_Move0.FlatAppearance.BorderSize = 2;
            this.XY_Move0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_Move0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_Move0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_Move0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_Move0.ForeColor = System.Drawing.Color.Black;
            this.XY_Move0.Location = new System.Drawing.Point(140, 32);
            this.XY_Move0.Name = "XY_Move0";
            this.XY_Move0.Size = new System.Drawing.Size(117, 55);
            this.XY_Move0.TabIndex = 100;
            this.XY_Move0.Text = "Shaped:           Move 0";
            this.XY_Move0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_Move0.UseVisualStyleBackColor = false;
            this.XY_Move0.Click += new System.EventHandler(this.XY_Move0_Click);
            // 
            // XY_Move2
            // 
            this.XY_Move2.BackColor = System.Drawing.SystemColors.Control;
            this.XY_Move2.FlatAppearance.BorderSize = 2;
            this.XY_Move2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_Move2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_Move2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_Move2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_Move2.ForeColor = System.Drawing.Color.Black;
            this.XY_Move2.Location = new System.Drawing.Point(140, 170);
            this.XY_Move2.Name = "XY_Move2";
            this.XY_Move2.Size = new System.Drawing.Size(117, 55);
            this.XY_Move2.TabIndex = 101;
            this.XY_Move2.Text = "Shaped:           Move 2";
            this.XY_Move2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_Move2.UseVisualStyleBackColor = false;
            // 
            // XY_Move1
            // 
            this.XY_Move1.BackColor = System.Drawing.SystemColors.Control;
            this.XY_Move1.FlatAppearance.BorderSize = 2;
            this.XY_Move1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_Move1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_Move1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_Move1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_Move1.ForeColor = System.Drawing.Color.Black;
            this.XY_Move1.Location = new System.Drawing.Point(140, 101);
            this.XY_Move1.Name = "XY_Move1";
            this.XY_Move1.Size = new System.Drawing.Size(117, 55);
            this.XY_Move1.TabIndex = 102;
            this.XY_Move1.Text = "Shaped:           Move 1";
            this.XY_Move1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_Move1.UseVisualStyleBackColor = false;
            // 
            // XY_UnMove3
            // 
            this.XY_UnMove3.BackColor = System.Drawing.SystemColors.Control;
            this.XY_UnMove3.FlatAppearance.BorderSize = 2;
            this.XY_UnMove3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_UnMove3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_UnMove3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_UnMove3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_UnMove3.ForeColor = System.Drawing.Color.Black;
            this.XY_UnMove3.Location = new System.Drawing.Point(11, 239);
            this.XY_UnMove3.Name = "XY_UnMove3";
            this.XY_UnMove3.Size = new System.Drawing.Size(117, 55);
            this.XY_UnMove3.TabIndex = 99;
            this.XY_UnMove3.Text = "Un Shaped       1Cycle";
            this.XY_UnMove3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_UnMove3.UseVisualStyleBackColor = false;
            this.XY_UnMove3.Click += new System.EventHandler(this.XY_UnMove3_Click);
            // 
            // XY_UnMove0
            // 
            this.XY_UnMove0.BackColor = System.Drawing.SystemColors.Control;
            this.XY_UnMove0.FlatAppearance.BorderSize = 2;
            this.XY_UnMove0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_UnMove0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_UnMove0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_UnMove0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_UnMove0.ForeColor = System.Drawing.Color.Black;
            this.XY_UnMove0.Location = new System.Drawing.Point(11, 32);
            this.XY_UnMove0.Name = "XY_UnMove0";
            this.XY_UnMove0.Size = new System.Drawing.Size(117, 55);
            this.XY_UnMove0.TabIndex = 96;
            this.XY_UnMove0.Text = "Un Shaped      Move 0";
            this.XY_UnMove0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_UnMove0.UseVisualStyleBackColor = false;
            this.XY_UnMove0.Click += new System.EventHandler(this.XY_UnMove0_Click);
            // 
            // XY_UnMove2
            // 
            this.XY_UnMove2.BackColor = System.Drawing.SystemColors.Control;
            this.XY_UnMove2.FlatAppearance.BorderSize = 2;
            this.XY_UnMove2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_UnMove2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_UnMove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_UnMove2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_UnMove2.ForeColor = System.Drawing.Color.Black;
            this.XY_UnMove2.Location = new System.Drawing.Point(11, 170);
            this.XY_UnMove2.Name = "XY_UnMove2";
            this.XY_UnMove2.Size = new System.Drawing.Size(117, 55);
            this.XY_UnMove2.TabIndex = 97;
            this.XY_UnMove2.Text = "Un Shaped       Move 2";
            this.XY_UnMove2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_UnMove2.UseVisualStyleBackColor = false;
            this.XY_UnMove2.Click += new System.EventHandler(this.XY_UnMove0_Click);
            // 
            // XY_UnMove1
            // 
            this.XY_UnMove1.BackColor = System.Drawing.SystemColors.Control;
            this.XY_UnMove1.FlatAppearance.BorderSize = 2;
            this.XY_UnMove1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_UnMove1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_UnMove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_UnMove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_UnMove1.ForeColor = System.Drawing.Color.Black;
            this.XY_UnMove1.Location = new System.Drawing.Point(11, 101);
            this.XY_UnMove1.Name = "XY_UnMove1";
            this.XY_UnMove1.Size = new System.Drawing.Size(117, 55);
            this.XY_UnMove1.TabIndex = 98;
            this.XY_UnMove1.Text = "Un Shaped        Move 1";
            this.XY_UnMove1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_UnMove1.UseVisualStyleBackColor = false;
            this.XY_UnMove1.Click += new System.EventHandler(this.XY_UnMove0_Click);
            // 
            // btE_Stop
            // 
            this.btE_Stop.BackColor = System.Drawing.Color.DarkRed;
            this.btE_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btE_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btE_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btE_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btE_Stop.ForeColor = System.Drawing.Color.Yellow;
            this.btE_Stop.Image = ((System.Drawing.Image)(resources.GetObject("btE_Stop.Image")));
            this.btE_Stop.Location = new System.Drawing.Point(290, 20);
            this.btE_Stop.Name = "btE_Stop";
            this.btE_Stop.Size = new System.Drawing.Size(108, 64);
            this.btE_Stop.TabIndex = 132;
            this.btE_Stop.Text = "Stop";
            this.btE_Stop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btE_Stop.UseVisualStyleBackColor = false;
            this.btE_Stop.Click += new System.EventHandler(this.btE_Stop_Click);
            // 
            // btBefore
            // 
            this.btBefore.BackColor = System.Drawing.SystemColors.Control;
            this.btBefore.FlatAppearance.BorderSize = 2;
            this.btBefore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btBefore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btBefore.ForeColor = System.Drawing.Color.Black;
            this.btBefore.Location = new System.Drawing.Point(115, 29);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(80, 60);
            this.btBefore.TabIndex = 0;
            this.btBefore.Text = "START";
            this.btBefore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBefore.UseVisualStyleBackColor = false;
            this.btBefore.Click += new System.EventHandler(this.btBefore_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.Z_Move0);
            this.groupBox9.Controls.Add(this.Z_Move1);
            this.groupBox9.Controls.Add(this.Z_UnMove0);
            this.groupBox9.Controls.Add(this.Z_UnMove1);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.Black;
            this.groupBox9.Location = new System.Drawing.Point(980, 651);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(270, 179);
            this.groupBox9.TabIndex = 105;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "㉧-Axis";
            // 
            // Z_Move0
            // 
            this.Z_Move0.BackColor = System.Drawing.SystemColors.Control;
            this.Z_Move0.FlatAppearance.BorderSize = 2;
            this.Z_Move0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Z_Move0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Z_Move0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Z_Move0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Z_Move0.ForeColor = System.Drawing.Color.Black;
            this.Z_Move0.Location = new System.Drawing.Point(139, 32);
            this.Z_Move0.Name = "Z_Move0";
            this.Z_Move0.Size = new System.Drawing.Size(117, 55);
            this.Z_Move0.TabIndex = 100;
            this.Z_Move0.Text = "Shaped:       Move 0";
            this.Z_Move0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Z_Move0.UseVisualStyleBackColor = false;
            // 
            // Z_Move1
            // 
            this.Z_Move1.BackColor = System.Drawing.SystemColors.Control;
            this.Z_Move1.FlatAppearance.BorderSize = 2;
            this.Z_Move1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Z_Move1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Z_Move1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Z_Move1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Z_Move1.ForeColor = System.Drawing.Color.Black;
            this.Z_Move1.Location = new System.Drawing.Point(139, 101);
            this.Z_Move1.Name = "Z_Move1";
            this.Z_Move1.Size = new System.Drawing.Size(117, 55);
            this.Z_Move1.TabIndex = 102;
            this.Z_Move1.Text = "Shaped:       Move 1";
            this.Z_Move1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Z_Move1.UseVisualStyleBackColor = false;
            // 
            // Z_UnMove0
            // 
            this.Z_UnMove0.BackColor = System.Drawing.SystemColors.Control;
            this.Z_UnMove0.FlatAppearance.BorderSize = 2;
            this.Z_UnMove0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Z_UnMove0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Z_UnMove0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Z_UnMove0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Z_UnMove0.ForeColor = System.Drawing.Color.Black;
            this.Z_UnMove0.Location = new System.Drawing.Point(11, 32);
            this.Z_UnMove0.Name = "Z_UnMove0";
            this.Z_UnMove0.Size = new System.Drawing.Size(117, 55);
            this.Z_UnMove0.TabIndex = 96;
            this.Z_UnMove0.Text = "Un Shaped Move 0";
            this.Z_UnMove0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Z_UnMove0.UseVisualStyleBackColor = false;
            this.Z_UnMove0.Click += new System.EventHandler(this.Z_UnMove0_Click);
            // 
            // Z_UnMove1
            // 
            this.Z_UnMove1.BackColor = System.Drawing.SystemColors.Control;
            this.Z_UnMove1.FlatAppearance.BorderSize = 2;
            this.Z_UnMove1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Z_UnMove1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Z_UnMove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Z_UnMove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Z_UnMove1.ForeColor = System.Drawing.Color.Black;
            this.Z_UnMove1.Location = new System.Drawing.Point(11, 101);
            this.Z_UnMove1.Name = "Z_UnMove1";
            this.Z_UnMove1.Size = new System.Drawing.Size(117, 55);
            this.Z_UnMove1.TabIndex = 98;
            this.Z_UnMove1.Text = "Un Shaped Move 1";
            this.Z_UnMove1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Z_UnMove1.UseVisualStyleBackColor = false;
            this.Z_UnMove1.Click += new System.EventHandler(this.Z_UnMove1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(21, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 486);
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(21, 658);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(384, 240);
            this.textBox1.TabIndex = 139;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(425, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 64);
            this.button3.TabIndex = 141;
            this.button3.Text = "Reset";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btintialize
            // 
            this.btintialize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btintialize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btintialize.FlatAppearance.BorderSize = 2;
            this.btintialize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btintialize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btintialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btintialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btintialize.ForeColor = System.Drawing.Color.White;
            this.btintialize.Location = new System.Drawing.Point(20, 19);
            this.btintialize.Name = "btintialize";
            this.btintialize.Size = new System.Drawing.Size(108, 64);
            this.btintialize.TabIndex = 144;
            this.btintialize.Text = "Intiallize";
            this.btintialize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btintialize.UseVisualStyleBackColor = false;
            this.btintialize.Click += new System.EventHandler(this.btintialize_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 906);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(674, 17);
            this.progressBar1.TabIndex = 145;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.button1.Location = new System.Drawing.Point(435, 818);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 64);
            this.button1.TabIndex = 146;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(435, 665);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 21);
            this.textBox2.TabIndex = 153;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbOP_3);
            this.groupBox4.Controls.Add(this.lbOP_2);
            this.groupBox4.Controls.Add(this.lbOP_1);
            this.groupBox4.Controls.Add(this.lbOP_0);
            this.groupBox4.Controls.Add(this.ap3);
            this.groupBox4.Controls.Add(this.ap2);
            this.groupBox4.Controls.Add(this.ap1);
            this.groupBox4.Controls.Add(this.ap0);
            this.groupBox4.Controls.Add(this.cp3);
            this.groupBox4.Controls.Add(this.cp2);
            this.groupBox4.Controls.Add(this.cp1);
            this.groupBox4.Controls.Add(this.cp0);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Location = new System.Drawing.Point(422, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 272);
            this.groupBox4.TabIndex = 154;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.lbALM2);
            this.groupBox5.Controls.Add(this.lbALM3);
            this.groupBox5.Controls.Add(this.lbALM1);
            this.groupBox5.Controls.Add(this.lbALM0);
            this.groupBox5.Controls.Add(this.N_EL3);
            this.groupBox5.Controls.Add(this.N_EL2);
            this.groupBox5.Controls.Add(this.N_EL1);
            this.groupBox5.Controls.Add(this.N_EL0);
            this.groupBox5.Controls.Add(this.P_EL3);
            this.groupBox5.Controls.Add(this.P_EL2);
            this.groupBox5.Controls.Add(this.P_EL1);
            this.groupBox5.Controls.Add(this.P_EL0);
            this.groupBox5.Controls.Add(this.lborg3);
            this.groupBox5.Controls.Add(this.lborg2);
            this.groupBox5.Controls.Add(this.lborg1);
            this.groupBox5.Controls.Add(this.lborg0);
            this.groupBox5.Location = new System.Drawing.Point(788, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(232, 272);
            this.groupBox5.TabIndex = 155;
            this.groupBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 85;
            this.label4.Text = "Motion Status";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btAfter);
            this.groupBox6.Controls.Add(this.btBofore);
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.led3);
            this.groupBox6.Controls.Add(this.led2);
            this.groupBox6.Controls.Add(this.led1);
            this.groupBox6.Controls.Add(this.btBefore);
            this.groupBox6.Location = new System.Drawing.Point(1028, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(222, 272);
            this.groupBox6.TabIndex = 156;
            this.groupBox6.TabStop = false;
            // 
            // btAfter
            // 
            this.btAfter.BackColor = System.Drawing.SystemColors.Control;
            this.btAfter.FlatAppearance.BorderSize = 2;
            this.btAfter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btAfter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btAfter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btAfter.ForeColor = System.Drawing.Color.Black;
            this.btAfter.Location = new System.Drawing.Point(115, 191);
            this.btAfter.Name = "btAfter";
            this.btAfter.Size = new System.Drawing.Size(80, 60);
            this.btAfter.TabIndex = 157;
            this.btAfter.Text = "After";
            this.btAfter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAfter.UseVisualStyleBackColor = false;
            this.btAfter.Click += new System.EventHandler(this.btAfter_Click_1);
            // 
            // btBofore
            // 
            this.btBofore.BackColor = System.Drawing.SystemColors.Control;
            this.btBofore.FlatAppearance.BorderSize = 2;
            this.btBofore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btBofore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btBofore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBofore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btBofore.ForeColor = System.Drawing.Color.Black;
            this.btBofore.Location = new System.Drawing.Point(29, 191);
            this.btBofore.Name = "btBofore";
            this.btBofore.Size = new System.Drawing.Size(80, 60);
            this.btBofore.TabIndex = 156;
            this.btBofore.Text = "Before";
            this.btBofore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBofore.UseVisualStyleBackColor = false;
            this.btBofore.Click += new System.EventHandler(this.btBofore_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(115, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 60);
            this.button4.TabIndex = 155;
            this.button4.Text = "Stop";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btE_Stop_Click);
            // 
            // led3
            // 
            this.led3.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led3.Location = new System.Drawing.Point(30, 130);
            this.led3.Name = "led3";
            this.led3.OffColor = System.Drawing.Color.RoyalBlue;
            this.led3.OnColor = System.Drawing.Color.Blue;
            this.led3.Size = new System.Drawing.Size(43, 40);
            this.led3.TabIndex = 154;
            // 
            // led2
            // 
            this.led2.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led2.Location = new System.Drawing.Point(30, 81);
            this.led2.Name = "led2";
            this.led2.OffColor = System.Drawing.Color.DarkRed;
            this.led2.OnColor = System.Drawing.Color.Red;
            this.led2.Size = new System.Drawing.Size(43, 40);
            this.led2.TabIndex = 153;
            // 
            // led1
            // 
            this.led1.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led1.Location = new System.Drawing.Point(30, 32);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(43, 40);
            this.led1.TabIndex = 152;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btintialize);
            this.groupBox7.Controls.Add(this.Servo_ON);
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Controls.Add(this.btE_Stop);
            this.groupBox7.Location = new System.Drawing.Point(703, 827);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(547, 96);
            this.groupBox7.TabIndex = 157;
            this.groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button12);
            this.groupBox8.Controls.Add(this.button13);
            this.groupBox8.Controls.Add(this.button14);
            this.groupBox8.Controls.Add(this.button15);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.Black;
            this.groupBox8.Location = new System.Drawing.Point(703, 651);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(265, 179);
            this.groupBox8.TabIndex = 158;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Z-Axis";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Control;
            this.button12.FlatAppearance.BorderSize = 2;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(139, 32);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(117, 55);
            this.button12.TabIndex = 100;
            this.button12.Text = "Shaped:       Move 0";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Control;
            this.button13.FlatAppearance.BorderSize = 2;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(139, 101);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(117, 55);
            this.button13.TabIndex = 102;
            this.button13.Text = "Shaped:       Move 1";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.Control;
            this.button14.FlatAppearance.BorderSize = 2;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Location = new System.Drawing.Point(11, 32);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(117, 55);
            this.button14.TabIndex = 96;
            this.button14.Text = "Un Shaped Move 0";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.Control;
            this.button15.FlatAppearance.BorderSize = 2;
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(11, 101);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(117, 55);
            this.button15.TabIndex = 98;
            this.button15.Text = "Un Shaped Move 1";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(435, 692);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 21);
            this.textBox3.TabIndex = 159;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(435, 717);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 21);
            this.textBox4.TabIndex = 160;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(435, 744);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(134, 21);
            this.textBox5.TabIndex = 161;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1276, 935);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btParameter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "AVSD-2000";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.WMX3_Anti_Demo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.led3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Servo_ON;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Timer tmCycle;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox ap3;
        private System.Windows.Forms.TextBox ap2;
        private System.Windows.Forms.TextBox ap1;
        private System.Windows.Forms.TextBox ap0;
        private System.Windows.Forms.TextBox cp3;
        private System.Windows.Forms.TextBox cp2;
        private System.Windows.Forms.TextBox cp1;
        private System.Windows.Forms.TextBox cp0;
        private System.Windows.Forms.TextBox lbOP_3;
        private System.Windows.Forms.TextBox lbOP_2;
        private System.Windows.Forms.TextBox lbOP_1;
        private System.Windows.Forms.TextBox lbOP_0;
        private System.Windows.Forms.Label lborg3;
        private System.Windows.Forms.Label lborg2;
        private System.Windows.Forms.Label lborg1;
        private System.Windows.Forms.Label lborg0;
        private System.Windows.Forms.Label N_EL3;
        private System.Windows.Forms.Label N_EL2;
        private System.Windows.Forms.Label N_EL1;
        private System.Windows.Forms.Label N_EL0;
        private System.Windows.Forms.Label P_EL3;
        private System.Windows.Forms.Label P_EL2;
        private System.Windows.Forms.Label P_EL1;
        private System.Windows.Forms.Label P_EL0;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbALM2;
        private System.Windows.Forms.Label lbALM3;
        private System.Windows.Forms.Label lbALM1;
        private System.Windows.Forms.Label lbALM0;
        private System.Windows.Forms.Button btParameter;
    
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button X_UnMove3;
        private System.Windows.Forms.Button X_UnMove0;
        private System.Windows.Forms.Button X_UnMove2;
        private System.Windows.Forms.Button X_UnMove1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button XY_Move3;
        private System.Windows.Forms.Button XY_Move0;
        private System.Windows.Forms.Button XY_Move2;
        private System.Windows.Forms.Button XY_Move1;
        private System.Windows.Forms.Button XY_UnMove3;
        private System.Windows.Forms.Button XY_UnMove0;
        private System.Windows.Forms.Button XY_UnMove2;
        private System.Windows.Forms.Button XY_UnMove1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button Y_UnMove3;
        private System.Windows.Forms.Button Y_UnMove0;
        private System.Windows.Forms.Button Y_UnMove2;
        private System.Windows.Forms.Button Y_UnMove1;
        private System.Windows.Forms.Button X_Move3;
        private System.Windows.Forms.Button X_Move0;
        private System.Windows.Forms.Button X_Move2;
        private System.Windows.Forms.Button X_Move1;
        private System.Windows.Forms.Button btE_Stop;
        private System.Windows.Forms.Button btBefore;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button Z_Move0;
        private System.Windows.Forms.Button Z_Move1;
        private System.Windows.Forms.Button Z_UnMove0;
        private System.Windows.Forms.Button Z_UnMove1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btintialize;
        private System.Windows.Forms.ToolStripMenuItem aVSD2000ToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btAfter;
        private System.Windows.Forms.Button btBofore;
        private System.Windows.Forms.Button button4;
        private NationalInstruments.UI.WindowsForms.Led led3;
        private NationalInstruments.UI.WindowsForms.Led led2;
        private NationalInstruments.UI.WindowsForms.Led led1;
    }
}

