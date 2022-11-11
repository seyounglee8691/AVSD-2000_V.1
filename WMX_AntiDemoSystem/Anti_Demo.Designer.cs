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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.button4 = new System.Windows.Forms.Button();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outIO3 = new System.Windows.Forms.CheckBox();
            this.out_reset = new System.Windows.Forms.CheckBox();
            this.out_stop = new System.Windows.Forms.CheckBox();
            this.out_start = new System.Windows.Forms.CheckBox();
            this.inIO7 = new System.Windows.Forms.CheckBox();
            this.inIO6 = new System.Windows.Forms.CheckBox();
            this.inIO5 = new System.Windows.Forms.CheckBox();
            this.inIO4 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.inIO3 = new System.Windows.Forms.CheckBox();
            this.inIO2 = new System.Windows.Forms.CheckBox();
            this.inIO1 = new System.Windows.Forms.CheckBox();
            this.inIO0 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btAfter = new System.Windows.Forms.Button();
            this.btBefore = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.Z_Move0 = new System.Windows.Forms.Button();
            this.Z_Move1 = new System.Windows.Forms.Button();
            this.Z_UnMove0 = new System.Windows.Forms.Button();
            this.Z_UnMove1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btintialize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Servo_ON
            // 
            this.Servo_ON.BackColor = System.Drawing.Color.LimeGreen;
            this.Servo_ON.FlatAppearance.BorderSize = 2;
            this.Servo_ON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.Servo_ON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Servo_ON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Servo_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Servo_ON.ForeColor = System.Drawing.Color.White;
            this.Servo_ON.Image = ((System.Drawing.Image)(resources.GetObject("Servo_ON.Image")));
            this.Servo_ON.Location = new System.Drawing.Point(858, 767);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.label20.Location = new System.Drawing.Point(446, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(142, 25);
            this.label20.TabIndex = 33;
            this.label20.Text = "Position Status";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.label21.Location = new System.Drawing.Point(447, 133);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 20);
            this.label21.TabIndex = 34;
            this.label21.Text = "Axis 0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.label22.Location = new System.Drawing.Point(447, 174);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 20);
            this.label22.TabIndex = 35;
            this.label22.Text = "Axis 1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.label23.Location = new System.Drawing.Point(447, 215);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 20);
            this.label23.TabIndex = 36;
            this.label23.Text = "Axis 2";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.label24.Location = new System.Drawing.Point(447, 256);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 20);
            this.label24.TabIndex = 37;
            this.label24.Text = "Axis 3";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.label25.Location = new System.Drawing.Point(521, 96);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 20);
            this.label25.TabIndex = 38;
            this.label25.Text = "CmdPos";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.label26.Location = new System.Drawing.Point(625, 96);
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
            this.cp0.Location = new System.Drawing.Point(507, 133);
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
            this.cp1.Location = new System.Drawing.Point(507, 174);
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
            this.cp2.Location = new System.Drawing.Point(507, 215);
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
            this.cp3.Location = new System.Drawing.Point(507, 256);
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
            this.ap3.Location = new System.Drawing.Point(618, 256);
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
            this.ap2.Location = new System.Drawing.Point(618, 215);
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
            this.ap1.Location = new System.Drawing.Point(618, 174);
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
            this.ap0.Location = new System.Drawing.Point(618, 133);
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
            this.lbOP_0.Location = new System.Drawing.Point(724, 134);
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
            this.lbOP_1.Location = new System.Drawing.Point(724, 174);
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
            this.lbOP_2.Location = new System.Drawing.Point(724, 215);
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
            this.lbOP_3.Location = new System.Drawing.Point(724, 256);
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
            this.lborg0.Location = new System.Drawing.Point(783, 133);
            this.lborg0.Name = "lborg0";
            this.lborg0.Size = new System.Drawing.Size(46, 20);
            this.lborg0.TabIndex = 65;
            this.lborg0.Text = "ORG";
            // 
            // lborg1
            // 
            this.lborg1.AutoSize = true;
            this.lborg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lborg1.Location = new System.Drawing.Point(783, 174);
            this.lborg1.Name = "lborg1";
            this.lborg1.Size = new System.Drawing.Size(46, 20);
            this.lborg1.TabIndex = 66;
            this.lborg1.Text = "ORG";
            // 
            // lborg2
            // 
            this.lborg2.AutoSize = true;
            this.lborg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lborg2.Location = new System.Drawing.Point(783, 215);
            this.lborg2.Name = "lborg2";
            this.lborg2.Size = new System.Drawing.Size(46, 20);
            this.lborg2.TabIndex = 67;
            this.lborg2.Text = "ORG";
            // 
            // lborg3
            // 
            this.lborg3.AutoSize = true;
            this.lborg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lborg3.Location = new System.Drawing.Point(783, 256);
            this.lborg3.Name = "lborg3";
            this.lborg3.Size = new System.Drawing.Size(46, 20);
            this.lborg3.TabIndex = 68;
            this.lborg3.Text = "ORG";
            // 
            // P_EL3
            // 
            this.P_EL3.AutoSize = true;
            this.P_EL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.P_EL3.Location = new System.Drawing.Point(837, 256);
            this.P_EL3.Name = "P_EL3";
            this.P_EL3.Size = new System.Drawing.Size(38, 20);
            this.P_EL3.TabIndex = 72;
            this.P_EL3.Text = "+EL";
            // 
            // P_EL2
            // 
            this.P_EL2.AutoSize = true;
            this.P_EL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.P_EL2.Location = new System.Drawing.Point(837, 215);
            this.P_EL2.Name = "P_EL2";
            this.P_EL2.Size = new System.Drawing.Size(38, 20);
            this.P_EL2.TabIndex = 71;
            this.P_EL2.Text = "+EL";
            // 
            // P_EL1
            // 
            this.P_EL1.AutoSize = true;
            this.P_EL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.P_EL1.Location = new System.Drawing.Point(837, 174);
            this.P_EL1.Name = "P_EL1";
            this.P_EL1.Size = new System.Drawing.Size(38, 20);
            this.P_EL1.TabIndex = 70;
            this.P_EL1.Text = "+EL";
            // 
            // P_EL0
            // 
            this.P_EL0.AutoSize = true;
            this.P_EL0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.P_EL0.Location = new System.Drawing.Point(837, 133);
            this.P_EL0.Name = "P_EL0";
            this.P_EL0.Size = new System.Drawing.Size(38, 20);
            this.P_EL0.TabIndex = 69;
            this.P_EL0.Text = "+EL";
            // 
            // N_EL3
            // 
            this.N_EL3.AutoSize = true;
            this.N_EL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.N_EL3.Location = new System.Drawing.Point(883, 256);
            this.N_EL3.Name = "N_EL3";
            this.N_EL3.Size = new System.Drawing.Size(34, 20);
            this.N_EL3.TabIndex = 76;
            this.N_EL3.Text = "-EL";
            // 
            // N_EL2
            // 
            this.N_EL2.AutoSize = true;
            this.N_EL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.N_EL2.Location = new System.Drawing.Point(883, 215);
            this.N_EL2.Name = "N_EL2";
            this.N_EL2.Size = new System.Drawing.Size(34, 20);
            this.N_EL2.TabIndex = 75;
            this.N_EL2.Text = "-EL";
            // 
            // N_EL1
            // 
            this.N_EL1.AutoSize = true;
            this.N_EL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.N_EL1.Location = new System.Drawing.Point(883, 174);
            this.N_EL1.Name = "N_EL1";
            this.N_EL1.Size = new System.Drawing.Size(34, 20);
            this.N_EL1.TabIndex = 74;
            this.N_EL1.Text = "-EL";
            // 
            // N_EL0
            // 
            this.N_EL0.AutoSize = true;
            this.N_EL0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.N_EL0.Location = new System.Drawing.Point(883, 133);
            this.N_EL0.Name = "N_EL0";
            this.N_EL0.Size = new System.Drawing.Size(34, 20);
            this.N_EL0.TabIndex = 73;
            this.N_EL0.Text = "-EL";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(991, 676);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 64);
            this.button4.TabIndex = 77;
            this.button4.Text = "  Home";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btHome_Click);
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
            this.lbALM0.Location = new System.Drawing.Point(925, 133);
            this.lbALM0.Name = "lbALM0";
            this.lbALM0.Size = new System.Drawing.Size(42, 20);
            this.lbALM0.TabIndex = 81;
            this.lbALM0.Text = "ALM";
            // 
            // lbALM1
            // 
            this.lbALM1.AutoSize = true;
            this.lbALM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbALM1.Location = new System.Drawing.Point(925, 174);
            this.lbALM1.Name = "lbALM1";
            this.lbALM1.Size = new System.Drawing.Size(42, 20);
            this.lbALM1.TabIndex = 82;
            this.lbALM1.Text = "ALM";
            // 
            // lbALM3
            // 
            this.lbALM3.AutoSize = true;
            this.lbALM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbALM3.Location = new System.Drawing.Point(925, 256);
            this.lbALM3.Name = "lbALM3";
            this.lbALM3.Size = new System.Drawing.Size(42, 20);
            this.lbALM3.TabIndex = 83;
            this.lbALM3.Text = "ALM";
            // 
            // lbALM2
            // 
            this.lbALM2.AutoSize = true;
            this.lbALM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbALM2.Location = new System.Drawing.Point(925, 215);
            this.lbALM2.Name = "lbALM2";
            this.lbALM2.Size = new System.Drawing.Size(42, 20);
            this.lbALM2.TabIndex = 84;
            this.lbALM2.Text = "ALM";
            // 
            // btParameter
            // 
            this.btParameter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
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
            this.btParameter.Text = "Motion Setting";
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
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
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
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(422, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 315);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "X-Axis";
            // 
            // X_Move3
            // 
            this.X_Move3.FlatAppearance.BorderSize = 2;
            this.X_Move3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_Move3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_Move3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_Move3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_Move3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.X_Move3.Location = new System.Drawing.Point(141, 239);
            this.X_Move3.Name = "X_Move3";
            this.X_Move3.Size = new System.Drawing.Size(117, 55);
            this.X_Move3.TabIndex = 103;
            this.X_Move3.Text = "Shaped:      1Cycle";
            this.X_Move3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_Move3.UseVisualStyleBackColor = true;
            // 
            // X_Move0
            // 
            this.X_Move0.FlatAppearance.BorderSize = 2;
            this.X_Move0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_Move0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_Move0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_Move0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_Move0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.X_Move0.Location = new System.Drawing.Point(141, 32);
            this.X_Move0.Name = "X_Move0";
            this.X_Move0.Size = new System.Drawing.Size(117, 55);
            this.X_Move0.TabIndex = 100;
            this.X_Move0.Text = "Shaped:       Move 0";
            this.X_Move0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_Move0.UseVisualStyleBackColor = true;
            // 
            // X_Move2
            // 
            this.X_Move2.FlatAppearance.BorderSize = 2;
            this.X_Move2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_Move2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_Move2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_Move2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_Move2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.X_Move2.Location = new System.Drawing.Point(141, 170);
            this.X_Move2.Name = "X_Move2";
            this.X_Move2.Size = new System.Drawing.Size(117, 55);
            this.X_Move2.TabIndex = 101;
            this.X_Move2.Text = "Shaped:      Move 2";
            this.X_Move2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_Move2.UseVisualStyleBackColor = true;
            // 
            // X_Move1
            // 
            this.X_Move1.FlatAppearance.BorderSize = 2;
            this.X_Move1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_Move1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_Move1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_Move1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_Move1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.X_Move1.Location = new System.Drawing.Point(141, 101);
            this.X_Move1.Name = "X_Move1";
            this.X_Move1.Size = new System.Drawing.Size(117, 55);
            this.X_Move1.TabIndex = 102;
            this.X_Move1.Text = "Shaped:       Move 1";
            this.X_Move1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_Move1.UseVisualStyleBackColor = true;
            // 
            // X_UnMove3
            // 
            this.X_UnMove3.FlatAppearance.BorderSize = 2;
            this.X_UnMove3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_UnMove3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_UnMove3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_UnMove3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_UnMove3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.X_UnMove3.Location = new System.Drawing.Point(13, 239);
            this.X_UnMove3.Name = "X_UnMove3";
            this.X_UnMove3.Size = new System.Drawing.Size(117, 55);
            this.X_UnMove3.TabIndex = 99;
            this.X_UnMove3.Text = "Un Shaped 1Cycle";
            this.X_UnMove3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_UnMove3.UseVisualStyleBackColor = true;
            this.X_UnMove3.Click += new System.EventHandler(this.X_UnMove3_Click);
            // 
            // X_UnMove0
            // 
            this.X_UnMove0.FlatAppearance.BorderSize = 2;
            this.X_UnMove0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_UnMove0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_UnMove0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_UnMove0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_UnMove0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.X_UnMove0.Location = new System.Drawing.Point(13, 32);
            this.X_UnMove0.Name = "X_UnMove0";
            this.X_UnMove0.Size = new System.Drawing.Size(117, 55);
            this.X_UnMove0.TabIndex = 96;
            this.X_UnMove0.Text = "Un Shaped Move 0";
            this.X_UnMove0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_UnMove0.UseVisualStyleBackColor = true;
            this.X_UnMove0.Click += new System.EventHandler(this.X_UnMove0_Click);
            // 
            // X_UnMove2
            // 
            this.X_UnMove2.FlatAppearance.BorderSize = 2;
            this.X_UnMove2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_UnMove2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_UnMove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_UnMove2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_UnMove2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.X_UnMove2.Location = new System.Drawing.Point(13, 170);
            this.X_UnMove2.Name = "X_UnMove2";
            this.X_UnMove2.Size = new System.Drawing.Size(117, 55);
            this.X_UnMove2.TabIndex = 97;
            this.X_UnMove2.Text = "Un Shaped Move 2";
            this.X_UnMove2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_UnMove2.UseVisualStyleBackColor = true;
            this.X_UnMove2.Click += new System.EventHandler(this.X_UnMove0_Click);
            // 
            // X_UnMove1
            // 
            this.X_UnMove1.FlatAppearance.BorderSize = 2;
            this.X_UnMove1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.X_UnMove1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.X_UnMove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_UnMove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.X_UnMove1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.X_UnMove1.Location = new System.Drawing.Point(13, 101);
            this.X_UnMove1.Name = "X_UnMove1";
            this.X_UnMove1.Size = new System.Drawing.Size(117, 55);
            this.X_UnMove1.TabIndex = 98;
            this.X_UnMove1.Text = "Un Shaped Move 1";
            this.X_UnMove1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.X_UnMove1.UseVisualStyleBackColor = true;
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
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(703, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 315);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Y-Axis";
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.button8.Location = new System.Drawing.Point(138, 239);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 55);
            this.button8.TabIndex = 103;
            this.button8.Text = "Shaped:      1Cycle";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.button9.Location = new System.Drawing.Point(138, 32);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 55);
            this.button9.TabIndex = 100;
            this.button9.Text = "Shaped:       Move 0";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 2;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.button10.Location = new System.Drawing.Point(138, 170);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(117, 55);
            this.button10.TabIndex = 101;
            this.button10.Text = "Shaped:      Move 2";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 2;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.button11.Location = new System.Drawing.Point(138, 101);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(117, 55);
            this.button11.TabIndex = 102;
            this.button11.Text = "Shaped:       Move 1";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Y_UnMove3
            // 
            this.Y_UnMove3.FlatAppearance.BorderSize = 2;
            this.Y_UnMove3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Y_UnMove3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Y_UnMove3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Y_UnMove3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Y_UnMove3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.Y_UnMove3.Location = new System.Drawing.Point(10, 239);
            this.Y_UnMove3.Name = "Y_UnMove3";
            this.Y_UnMove3.Size = new System.Drawing.Size(117, 55);
            this.Y_UnMove3.TabIndex = 99;
            this.Y_UnMove3.Text = "Un Shaped 1Cycle";
            this.Y_UnMove3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Y_UnMove3.UseVisualStyleBackColor = true;
            this.Y_UnMove3.Click += new System.EventHandler(this.Y_UnMove3_Click);
            // 
            // Y_UnMove0
            // 
            this.Y_UnMove0.FlatAppearance.BorderSize = 2;
            this.Y_UnMove0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Y_UnMove0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Y_UnMove0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Y_UnMove0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Y_UnMove0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.Y_UnMove0.Location = new System.Drawing.Point(10, 32);
            this.Y_UnMove0.Name = "Y_UnMove0";
            this.Y_UnMove0.Size = new System.Drawing.Size(117, 55);
            this.Y_UnMove0.TabIndex = 96;
            this.Y_UnMove0.Text = "Un Shaped Move 0";
            this.Y_UnMove0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Y_UnMove0.UseVisualStyleBackColor = true;
            this.Y_UnMove0.Click += new System.EventHandler(this.Y_UnMove0_Click);
            // 
            // Y_UnMove2
            // 
            this.Y_UnMove2.FlatAppearance.BorderSize = 2;
            this.Y_UnMove2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Y_UnMove2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Y_UnMove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Y_UnMove2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Y_UnMove2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.Y_UnMove2.Location = new System.Drawing.Point(10, 170);
            this.Y_UnMove2.Name = "Y_UnMove2";
            this.Y_UnMove2.Size = new System.Drawing.Size(117, 55);
            this.Y_UnMove2.TabIndex = 97;
            this.Y_UnMove2.Text = "Un Shaped Move 2";
            this.Y_UnMove2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Y_UnMove2.UseVisualStyleBackColor = true;
            this.Y_UnMove2.Click += new System.EventHandler(this.Y_UnMove2_Click);
            // 
            // Y_UnMove1
            // 
            this.Y_UnMove1.FlatAppearance.BorderSize = 2;
            this.Y_UnMove1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Y_UnMove1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Y_UnMove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Y_UnMove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Y_UnMove1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.Y_UnMove1.Location = new System.Drawing.Point(10, 101);
            this.Y_UnMove1.Name = "Y_UnMove1";
            this.Y_UnMove1.Size = new System.Drawing.Size(117, 55);
            this.Y_UnMove1.TabIndex = 98;
            this.Y_UnMove1.Text = "Un Shaped Move 1";
            this.Y_UnMove1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Y_UnMove1.UseVisualStyleBackColor = true;
            this.Y_UnMove1.Click += new System.EventHandler(this.Y_UnMove1_Click);
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
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(980, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 315);
            this.groupBox3.TabIndex = 91;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "X_Y-Axis";
            // 
            // XY_Move3
            // 
            this.XY_Move3.FlatAppearance.BorderSize = 2;
            this.XY_Move3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_Move3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_Move3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_Move3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_Move3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.XY_Move3.Location = new System.Drawing.Point(140, 239);
            this.XY_Move3.Name = "XY_Move3";
            this.XY_Move3.Size = new System.Drawing.Size(117, 55);
            this.XY_Move3.TabIndex = 103;
            this.XY_Move3.Text = "Shaped:           1Cycle";
            this.XY_Move3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_Move3.UseVisualStyleBackColor = true;
            // 
            // XY_Move0
            // 
            this.XY_Move0.FlatAppearance.BorderSize = 2;
            this.XY_Move0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_Move0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_Move0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_Move0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_Move0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.XY_Move0.Location = new System.Drawing.Point(140, 32);
            this.XY_Move0.Name = "XY_Move0";
            this.XY_Move0.Size = new System.Drawing.Size(117, 55);
            this.XY_Move0.TabIndex = 100;
            this.XY_Move0.Text = "Shaped:           Move 0";
            this.XY_Move0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_Move0.UseVisualStyleBackColor = true;
            this.XY_Move0.Click += new System.EventHandler(this.XY_Move0_Click);
            // 
            // XY_Move2
            // 
            this.XY_Move2.FlatAppearance.BorderSize = 2;
            this.XY_Move2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_Move2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_Move2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_Move2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_Move2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.XY_Move2.Location = new System.Drawing.Point(140, 170);
            this.XY_Move2.Name = "XY_Move2";
            this.XY_Move2.Size = new System.Drawing.Size(117, 55);
            this.XY_Move2.TabIndex = 101;
            this.XY_Move2.Text = "Shaped:           Move 2";
            this.XY_Move2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_Move2.UseVisualStyleBackColor = true;
            // 
            // XY_Move1
            // 
            this.XY_Move1.FlatAppearance.BorderSize = 2;
            this.XY_Move1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_Move1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_Move1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_Move1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_Move1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.XY_Move1.Location = new System.Drawing.Point(140, 101);
            this.XY_Move1.Name = "XY_Move1";
            this.XY_Move1.Size = new System.Drawing.Size(117, 55);
            this.XY_Move1.TabIndex = 102;
            this.XY_Move1.Text = "Shaped:           Move 1";
            this.XY_Move1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_Move1.UseVisualStyleBackColor = true;
            // 
            // XY_UnMove3
            // 
            this.XY_UnMove3.FlatAppearance.BorderSize = 2;
            this.XY_UnMove3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_UnMove3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_UnMove3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_UnMove3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_UnMove3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.XY_UnMove3.Location = new System.Drawing.Point(11, 239);
            this.XY_UnMove3.Name = "XY_UnMove3";
            this.XY_UnMove3.Size = new System.Drawing.Size(117, 55);
            this.XY_UnMove3.TabIndex = 99;
            this.XY_UnMove3.Text = "Un Shaped       1Cycle";
            this.XY_UnMove3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_UnMove3.UseVisualStyleBackColor = true;
            this.XY_UnMove3.Click += new System.EventHandler(this.XY_UnMove3_Click);
            // 
            // XY_UnMove0
            // 
            this.XY_UnMove0.FlatAppearance.BorderSize = 2;
            this.XY_UnMove0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_UnMove0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_UnMove0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_UnMove0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_UnMove0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.XY_UnMove0.Location = new System.Drawing.Point(11, 32);
            this.XY_UnMove0.Name = "XY_UnMove0";
            this.XY_UnMove0.Size = new System.Drawing.Size(117, 55);
            this.XY_UnMove0.TabIndex = 96;
            this.XY_UnMove0.Text = "Un Shaped      Move 0";
            this.XY_UnMove0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_UnMove0.UseVisualStyleBackColor = true;
            this.XY_UnMove0.Click += new System.EventHandler(this.XY_UnMove0_Click);
            // 
            // XY_UnMove2
            // 
            this.XY_UnMove2.FlatAppearance.BorderSize = 2;
            this.XY_UnMove2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_UnMove2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_UnMove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_UnMove2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_UnMove2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.XY_UnMove2.Location = new System.Drawing.Point(11, 170);
            this.XY_UnMove2.Name = "XY_UnMove2";
            this.XY_UnMove2.Size = new System.Drawing.Size(117, 55);
            this.XY_UnMove2.TabIndex = 97;
            this.XY_UnMove2.Text = "Un Shaped       Move 2";
            this.XY_UnMove2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_UnMove2.UseVisualStyleBackColor = true;
            this.XY_UnMove2.Click += new System.EventHandler(this.XY_UnMove2_Click);
            // 
            // XY_UnMove1
            // 
            this.XY_UnMove1.FlatAppearance.BorderSize = 2;
            this.XY_UnMove1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.XY_UnMove1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.XY_UnMove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY_UnMove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.XY_UnMove1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.XY_UnMove1.Location = new System.Drawing.Point(11, 101);
            this.XY_UnMove1.Name = "XY_UnMove1";
            this.XY_UnMove1.Size = new System.Drawing.Size(117, 55);
            this.XY_UnMove1.TabIndex = 98;
            this.XY_UnMove1.Text = "Un Shaped        Move 1";
            this.XY_UnMove1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XY_UnMove1.UseVisualStyleBackColor = true;
            this.XY_UnMove1.Click += new System.EventHandler(this.XY_UnMove1_Click);
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
            this.btE_Stop.Location = new System.Drawing.Point(991, 767);
            this.btE_Stop.Name = "btE_Stop";
            this.btE_Stop.Size = new System.Drawing.Size(108, 64);
            this.btE_Stop.TabIndex = 132;
            this.btE_Stop.Text = "Stop";
            this.btE_Stop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btE_Stop.UseVisualStyleBackColor = false;
            this.btE_Stop.Click += new System.EventHandler(this.btE_Stop_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.outIO3);
            this.groupBox5.Controls.Add(this.out_reset);
            this.groupBox5.Controls.Add(this.out_stop);
            this.groupBox5.Controls.Add(this.out_start);
            this.groupBox5.Controls.Add(this.inIO7);
            this.groupBox5.Controls.Add(this.inIO6);
            this.groupBox5.Controls.Add(this.inIO5);
            this.groupBox5.Controls.Add(this.inIO4);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.inIO3);
            this.groupBox5.Controls.Add(this.inIO2);
            this.groupBox5.Controls.Add(this.inIO1);
            this.groupBox5.Controls.Add(this.inIO0);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(841, 910);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(403, 184);
            this.groupBox5.TabIndex = 133;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "IO";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(329, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 64);
            this.button6.TabIndex = 146;
            this.button6.Text = "import";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(225, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 22);
            this.checkBox1.TabIndex = 71;
            this.checkBox1.Text = "PLC-SERVO ON/OFF";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(327, -10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 64);
            this.button1.TabIndex = 145;
            this.button1.Text = "export";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outIO3
            // 
            this.outIO3.AutoSize = true;
            this.outIO3.Location = new System.Drawing.Point(225, 124);
            this.outIO3.Name = "outIO3";
            this.outIO3.Size = new System.Drawing.Size(165, 22);
            this.outIO3.TabIndex = 70;
            this.outIO3.Text = "PLC-ALARM RESET";
            this.outIO3.UseVisualStyleBackColor = true;
            // 
            // out_reset
            // 
            this.out_reset.AutoSize = true;
            this.out_reset.Location = new System.Drawing.Point(224, 97);
            this.out_reset.Name = "out_reset";
            this.out_reset.Size = new System.Drawing.Size(77, 22);
            this.out_reset.TabIndex = 69;
            this.out_reset.Text = "RESET";
            this.out_reset.UseVisualStyleBackColor = true;
            // 
            // out_stop
            // 
            this.out_stop.AutoSize = true;
            this.out_stop.Location = new System.Drawing.Point(224, 70);
            this.out_stop.Name = "out_stop";
            this.out_stop.Size = new System.Drawing.Size(68, 22);
            this.out_stop.TabIndex = 68;
            this.out_stop.Text = "STOP";
            this.out_stop.UseVisualStyleBackColor = true;
            // 
            // out_start
            // 
            this.out_start.AutoSize = true;
            this.out_start.Location = new System.Drawing.Point(224, 43);
            this.out_start.Name = "out_start";
            this.out_start.Size = new System.Drawing.Size(75, 22);
            this.out_start.TabIndex = 67;
            this.out_start.Text = "START";
            this.out_start.UseVisualStyleBackColor = true;
            this.out_start.CheckedChanged += new System.EventHandler(this.out_start_CheckedChanged);
            // 
            // inIO7
            // 
            this.inIO7.AutoSize = true;
            this.inIO7.Location = new System.Drawing.Point(81, 144);
            this.inIO7.Name = "inIO7";
            this.inIO7.Size = new System.Drawing.Size(47, 22);
            this.inIO7.TabIndex = 66;
            this.inIO7.Text = "0,7";
            this.inIO7.UseVisualStyleBackColor = true;
            // 
            // inIO6
            // 
            this.inIO6.AutoSize = true;
            this.inIO6.Location = new System.Drawing.Point(81, 112);
            this.inIO6.Name = "inIO6";
            this.inIO6.Size = new System.Drawing.Size(47, 22);
            this.inIO6.TabIndex = 65;
            this.inIO6.Text = "0,6";
            this.inIO6.UseVisualStyleBackColor = true;
            // 
            // inIO5
            // 
            this.inIO5.AutoSize = true;
            this.inIO5.Location = new System.Drawing.Point(81, 80);
            this.inIO5.Name = "inIO5";
            this.inIO5.Size = new System.Drawing.Size(47, 22);
            this.inIO5.TabIndex = 64;
            this.inIO5.Text = "0,5";
            this.inIO5.UseVisualStyleBackColor = true;
            // 
            // inIO4
            // 
            this.inIO4.AutoSize = true;
            this.inIO4.Location = new System.Drawing.Point(81, 48);
            this.inIO4.Name = "inIO4";
            this.inIO4.Size = new System.Drawing.Size(47, 22);
            this.inIO4.TabIndex = 63;
            this.inIO4.Text = "0,4";
            this.inIO4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(250, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 19);
            this.textBox3.TabIndex = 62;
            this.textBox3.Text = "Output";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(48, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 19);
            this.textBox2.TabIndex = 61;
            this.textBox2.Text = "Input";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inIO3
            // 
            this.inIO3.AutoSize = true;
            this.inIO3.Location = new System.Drawing.Point(28, 144);
            this.inIO3.Name = "inIO3";
            this.inIO3.Size = new System.Drawing.Size(47, 22);
            this.inIO3.TabIndex = 3;
            this.inIO3.Text = "0,3";
            this.inIO3.UseVisualStyleBackColor = true;
            // 
            // inIO2
            // 
            this.inIO2.AutoSize = true;
            this.inIO2.Location = new System.Drawing.Point(28, 112);
            this.inIO2.Name = "inIO2";
            this.inIO2.Size = new System.Drawing.Size(47, 22);
            this.inIO2.TabIndex = 2;
            this.inIO2.Text = "0,2";
            this.inIO2.UseVisualStyleBackColor = true;
            // 
            // inIO1
            // 
            this.inIO1.AutoSize = true;
            this.inIO1.Location = new System.Drawing.Point(28, 80);
            this.inIO1.Name = "inIO1";
            this.inIO1.Size = new System.Drawing.Size(47, 22);
            this.inIO1.TabIndex = 1;
            this.inIO1.Text = "0,1";
            this.inIO1.UseVisualStyleBackColor = true;
            // 
            // inIO0
            // 
            this.inIO0.AutoSize = true;
            this.inIO0.Location = new System.Drawing.Point(28, 48);
            this.inIO0.Name = "inIO0";
            this.inIO0.Size = new System.Drawing.Size(47, 22);
            this.inIO0.TabIndex = 0;
            this.inIO0.Text = "0,0";
            this.inIO0.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btAfter);
            this.groupBox7.Controls.Add(this.btBefore);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(703, 662);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(136, 184);
            this.groupBox7.TabIndex = 136;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Squence";
            // 
            // btAfter
            // 
            this.btAfter.FlatAppearance.BorderSize = 2;
            this.btAfter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btAfter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btAfter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btAfter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btAfter.Image = ((System.Drawing.Image)(resources.GetObject("btAfter.Image")));
            this.btAfter.Location = new System.Drawing.Point(12, 104);
            this.btAfter.Name = "btAfter";
            this.btAfter.Size = new System.Drawing.Size(111, 64);
            this.btAfter.TabIndex = 64;
            this.btAfter.Text = "After";
            this.btAfter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAfter.UseVisualStyleBackColor = true;
            this.btAfter.Click += new System.EventHandler(this.btAfter_Click);
            // 
            // btBefore
            // 
            this.btBefore.FlatAppearance.BorderSize = 2;
            this.btBefore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btBefore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btBefore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btBefore.Image = ((System.Drawing.Image)(resources.GetObject("btBefore.Image")));
            this.btBefore.Location = new System.Drawing.Point(12, 23);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(111, 64);
            this.btBefore.TabIndex = 0;
            this.btBefore.Text = "Before";
            this.btBefore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBefore.UseVisualStyleBackColor = true;
            this.btBefore.Click += new System.EventHandler(this.btBefore_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.Z_Move0);
            this.groupBox9.Controls.Add(this.Z_Move1);
            this.groupBox9.Controls.Add(this.Z_UnMove0);
            this.groupBox9.Controls.Add(this.Z_UnMove1);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(422, 662);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(269, 184);
            this.groupBox9.TabIndex = 105;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Z-Axis";
            // 
            // Z_Move0
            // 
            this.Z_Move0.FlatAppearance.BorderSize = 2;
            this.Z_Move0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Z_Move0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Z_Move0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Z_Move0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Z_Move0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.Z_Move0.Location = new System.Drawing.Point(139, 32);
            this.Z_Move0.Name = "Z_Move0";
            this.Z_Move0.Size = new System.Drawing.Size(117, 55);
            this.Z_Move0.TabIndex = 100;
            this.Z_Move0.Text = "Shaped:       Move 0";
            this.Z_Move0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Z_Move0.UseVisualStyleBackColor = true;
            // 
            // Z_Move1
            // 
            this.Z_Move1.FlatAppearance.BorderSize = 2;
            this.Z_Move1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Z_Move1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Z_Move1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Z_Move1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Z_Move1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.Z_Move1.Location = new System.Drawing.Point(139, 101);
            this.Z_Move1.Name = "Z_Move1";
            this.Z_Move1.Size = new System.Drawing.Size(117, 55);
            this.Z_Move1.TabIndex = 102;
            this.Z_Move1.Text = "Shaped:       Move 1";
            this.Z_Move1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Z_Move1.UseVisualStyleBackColor = true;
            // 
            // Z_UnMove0
            // 
            this.Z_UnMove0.FlatAppearance.BorderSize = 2;
            this.Z_UnMove0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Z_UnMove0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Z_UnMove0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Z_UnMove0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Z_UnMove0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.Z_UnMove0.Location = new System.Drawing.Point(11, 32);
            this.Z_UnMove0.Name = "Z_UnMove0";
            this.Z_UnMove0.Size = new System.Drawing.Size(117, 55);
            this.Z_UnMove0.TabIndex = 96;
            this.Z_UnMove0.Text = "Un Shaped Move 0";
            this.Z_UnMove0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Z_UnMove0.UseVisualStyleBackColor = true;
            this.Z_UnMove0.Click += new System.EventHandler(this.Z_UnMove0_Click);
            // 
            // Z_UnMove1
            // 
            this.Z_UnMove1.FlatAppearance.BorderSize = 2;
            this.Z_UnMove1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Z_UnMove1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Z_UnMove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Z_UnMove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Z_UnMove1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.Z_UnMove1.Location = new System.Drawing.Point(11, 101);
            this.Z_UnMove1.Name = "Z_UnMove1";
            this.Z_UnMove1.Size = new System.Drawing.Size(117, 55);
            this.Z_UnMove1.TabIndex = 98;
            this.Z_UnMove1.Text = "Un Shaped Move 1";
            this.Z_UnMove1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Z_UnMove1.UseVisualStyleBackColor = true;
            this.Z_UnMove1.Click += new System.EventHandler(this.Z_UnMove1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(21, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 493);
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(21, 671);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(384, 240);
            this.textBox1.TabIndex = 139;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
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
            this.button3.Location = new System.Drawing.Point(858, 676);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 64);
            this.button3.TabIndex = 141;
            this.button3.Text = "Alarm Clear";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(438, 877);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(220, 34);
            this.txtFile.TabIndex = 142;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(664, 877);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(83, 34);
            this.btOpen.TabIndex = 143;
            this.btOpen.Text = "button6";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btintialize
            // 
            this.btintialize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btintialize.FlatAppearance.BorderSize = 2;
            this.btintialize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btintialize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btintialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btintialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btintialize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btintialize.Image = ((System.Drawing.Image)(resources.GetObject("btintialize.Image")));
            this.btintialize.Location = new System.Drawing.Point(1120, 767);
            this.btintialize.Name = "btintialize";
            this.btintialize.Size = new System.Drawing.Size(108, 64);
            this.btintialize.TabIndex = 144;
            this.btintialize.Text = "Intiallize";
            this.btintialize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btintialize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btintialize.UseVisualStyleBackColor = false;
            this.btintialize.Click += new System.EventHandler(this.btintialize_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1276, 935);
            this.Controls.Add(this.btintialize);
            this.Controls.Add(this.Servo_ON);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btE_Stop);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btParameter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lbALM2);
            this.Controls.Add(this.lbALM3);
            this.Controls.Add(this.lbALM1);
            this.Controls.Add(this.lbALM0);
            this.Controls.Add(this.N_EL3);
            this.Controls.Add(this.N_EL2);
            this.Controls.Add(this.N_EL1);
            this.Controls.Add(this.N_EL0);
            this.Controls.Add(this.P_EL3);
            this.Controls.Add(this.P_EL2);
            this.Controls.Add(this.P_EL1);
            this.Controls.Add(this.P_EL0);
            this.Controls.Add(this.lborg3);
            this.Controls.Add(this.lborg2);
            this.Controls.Add(this.lborg1);
            this.Controls.Add(this.lborg0);
            this.Controls.Add(this.lbOP_3);
            this.Controls.Add(this.lbOP_2);
            this.Controls.Add(this.lbOP_1);
            this.Controls.Add(this.lbOP_0);
            this.Controls.Add(this.ap3);
            this.Controls.Add(this.ap2);
            this.Controls.Add(this.ap1);
            this.Controls.Add(this.ap0);
            this.Controls.Add(this.cp3);
            this.Controls.Add(this.cp2);
            this.Controls.Add(this.cp1);
            this.Controls.Add(this.cp0);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "AVSD-2000";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WMX3Test_FormClosed);
            this.Load += new System.EventHandler(this.WMX3_Anti_Demo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Servo_ON;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Timer timer1;
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
        private System.Windows.Forms.Button button4;
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btAfter;
        private System.Windows.Forms.Button btBefore;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button Z_Move0;
        private System.Windows.Forms.Button Z_Move1;
        private System.Windows.Forms.Button Z_UnMove0;
        private System.Windows.Forms.Button Z_UnMove1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox inIO2;
        private System.Windows.Forms.CheckBox inIO1;
        private System.Windows.Forms.CheckBox inIO0;
        private System.Windows.Forms.CheckBox inIO3;
        private System.Windows.Forms.CheckBox outIO3;
        private System.Windows.Forms.CheckBox out_reset;
        private System.Windows.Forms.CheckBox out_stop;
        private System.Windows.Forms.CheckBox out_start;
        private System.Windows.Forms.CheckBox inIO7;
        private System.Windows.Forms.CheckBox inIO6;
        private System.Windows.Forms.CheckBox inIO5;
        private System.Windows.Forms.CheckBox inIO4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btintialize;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
    }
}

