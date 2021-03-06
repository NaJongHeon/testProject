﻿namespace winform_guilotine
{
    partial class Form_Main
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_FrontOff = new System.Windows.Forms.Button();
            this.btn_FrontOn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scr_FrontValue = new System.Windows.Forms.HScrollBar();
            this.btn_FrontSet = new System.Windows.Forms.Button();
            this.txt_FrontValue = new System.Windows.Forms.TextBox();
            this.txt_LightLog = new System.Windows.Forms.TextBox();
            this.btn_FrontRetry = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ServoStop = new System.Windows.Forms.Button();
            this.txt_servoPort = new System.Windows.Forms.TextBox();
            this.txt_POSError = new System.Windows.Forms.TextBox();
            this.txt_POSCommand = new System.Windows.Forms.TextBox();
            this.txt_RepeatDelay = new System.Windows.Forms.TextBox();
            this.btn_StartRepeat = new System.Windows.Forms.Button();
            this.txt_RepeatCount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_RepeatEnd = new System.Windows.Forms.TextBox();
            this.txt_POSActual = new System.Windows.Forms.TextBox();
            this.txt_RepeatStart = new System.Windows.Forms.TextBox();
            this.btn_Origin = new System.Windows.Forms.Button();
            this.btn_MoveABS = new System.Windows.Forms.Button();
            this.btn_pJog = new System.Windows.Forms.Button();
            this.btn_nJog = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Slave = new System.Windows.Forms.TextBox();
            this.txt_Speed = new System.Windows.Forms.TextBox();
            this.txt_Position = new System.Windows.Forms.TextBox();
            this.btn_ServoOn = new System.Windows.Forms.Button();
            this.btn_ServoConn = new System.Windows.Forms.Button();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_CamInit = new System.Windows.Forms.Button();
            this.btn_CamRelease = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_FrontOff);
            this.groupBox1.Controls.Add(this.btn_FrontOn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.scr_FrontValue);
            this.groupBox1.Controls.Add(this.btn_FrontSet);
            this.groupBox1.Controls.Add(this.txt_FrontValue);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(313, 186);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Front_Light_Control";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // btn_FrontOff
            // 
            this.btn_FrontOff.ForeColor = System.Drawing.Color.Black;
            this.btn_FrontOff.Location = new System.Drawing.Point(179, 123);
            this.btn_FrontOff.Name = "btn_FrontOff";
            this.btn_FrontOff.Size = new System.Drawing.Size(101, 56);
            this.btn_FrontOff.TabIndex = 11;
            this.btn_FrontOff.Text = "Light Off";
            this.btn_FrontOff.UseVisualStyleBackColor = true;
            this.btn_FrontOff.Click += new System.EventHandler(this.btn_FrontOff_Click);
            // 
            // btn_FrontOn
            // 
            this.btn_FrontOn.ForeColor = System.Drawing.Color.Black;
            this.btn_FrontOn.Location = new System.Drawing.Point(18, 125);
            this.btn_FrontOn.Name = "btn_FrontOn";
            this.btn_FrontOn.Size = new System.Drawing.Size(101, 56);
            this.btn_FrontOn.TabIndex = 10;
            this.btn_FrontOn.Text = "Light On";
            this.btn_FrontOn.UseVisualStyleBackColor = true;
            this.btn_FrontOn.Click += new System.EventHandler(this.btn_FrontOn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "255(어두움)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "0(밝음)";
            // 
            // scr_FrontValue
            // 
            this.scr_FrontValue.Location = new System.Drawing.Point(18, 44);
            this.scr_FrontValue.Maximum = 264;
            this.scr_FrontValue.Name = "scr_FrontValue";
            this.scr_FrontValue.Size = new System.Drawing.Size(262, 30);
            this.scr_FrontValue.TabIndex = 6;
            this.scr_FrontValue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_FrontValue_Scroll);
            // 
            // btn_FrontSet
            // 
            this.btn_FrontSet.ForeColor = System.Drawing.Color.Black;
            this.btn_FrontSet.Location = new System.Drawing.Point(165, 76);
            this.btn_FrontSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FrontSet.Name = "btn_FrontSet";
            this.btn_FrontSet.Size = new System.Drawing.Size(136, 42);
            this.btn_FrontSet.TabIndex = 4;
            this.btn_FrontSet.Text = "Set Brightness";
            this.btn_FrontSet.UseVisualStyleBackColor = true;
            this.btn_FrontSet.Click += new System.EventHandler(this.btn_FrontSet_Click);
            // 
            // txt_FrontValue
            // 
            this.txt_FrontValue.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_FrontValue.Location = new System.Drawing.Point(5, 76);
            this.txt_FrontValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FrontValue.Name = "txt_FrontValue";
            this.txt_FrontValue.Size = new System.Drawing.Size(136, 44);
            this.txt_FrontValue.TabIndex = 3;
            this.txt_FrontValue.Text = "0";
            this.txt_FrontValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_LightLog
            // 
            this.txt_LightLog.Location = new System.Drawing.Point(12, 11);
            this.txt_LightLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LightLog.Multiline = true;
            this.txt_LightLog.Name = "txt_LightLog";
            this.txt_LightLog.Size = new System.Drawing.Size(313, 130);
            this.txt_LightLog.TabIndex = 7;
            // 
            // btn_FrontRetry
            // 
            this.btn_FrontRetry.Location = new System.Drawing.Point(91, 332);
            this.btn_FrontRetry.Name = "btn_FrontRetry";
            this.btn_FrontRetry.Size = new System.Drawing.Size(136, 41);
            this.btn_FrontRetry.TabIndex = 8;
            this.btn_FrontRetry.Text = "Front Connect Retry";
            this.btn_FrontRetry.UseVisualStyleBackColor = true;
            this.btn_FrontRetry.Click += new System.EventHandler(this.btn_FrontRetry_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ServoStop);
            this.groupBox3.Controls.Add(this.txt_servoPort);
            this.groupBox3.Controls.Add(this.txt_POSError);
            this.groupBox3.Controls.Add(this.txt_POSCommand);
            this.groupBox3.Controls.Add(this.txt_RepeatDelay);
            this.groupBox3.Controls.Add(this.btn_StartRepeat);
            this.groupBox3.Controls.Add(this.txt_RepeatCount);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_RepeatEnd);
            this.groupBox3.Controls.Add(this.txt_POSActual);
            this.groupBox3.Controls.Add(this.txt_RepeatStart);
            this.groupBox3.Controls.Add(this.btn_Origin);
            this.groupBox3.Controls.Add(this.btn_MoveABS);
            this.groupBox3.Controls.Add(this.btn_pJog);
            this.groupBox3.Controls.Add(this.btn_nJog);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_Slave);
            this.groupBox3.Controls.Add(this.txt_Speed);
            this.groupBox3.Controls.Add(this.txt_Position);
            this.groupBox3.Controls.Add(this.btn_ServoOn);
            this.groupBox3.Controls.Add(this.btn_ServoConn);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 378);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(965, 242);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servo_Control";
            // 
            // btn_ServoStop
            // 
            this.btn_ServoStop.ForeColor = System.Drawing.Color.Black;
            this.btn_ServoStop.Location = new System.Drawing.Point(6, 98);
            this.btn_ServoStop.Name = "btn_ServoStop";
            this.btn_ServoStop.Size = new System.Drawing.Size(293, 47);
            this.btn_ServoStop.TabIndex = 21;
            this.btn_ServoStop.Text = "STOP";
            this.btn_ServoStop.UseVisualStyleBackColor = true;
            this.btn_ServoStop.Click += new System.EventHandler(this.btn_ServoStop_Click);
            // 
            // txt_servoPort
            // 
            this.txt_servoPort.Location = new System.Drawing.Point(217, 20);
            this.txt_servoPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_servoPort.Name = "txt_servoPort";
            this.txt_servoPort.Size = new System.Drawing.Size(62, 23);
            this.txt_servoPort.TabIndex = 19;
            this.txt_servoPort.Text = "3";
            this.txt_servoPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_POSError
            // 
            this.txt_POSError.Location = new System.Drawing.Point(868, 104);
            this.txt_POSError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_POSError.Name = "txt_POSError";
            this.txt_POSError.ReadOnly = true;
            this.txt_POSError.Size = new System.Drawing.Size(90, 23);
            this.txt_POSError.TabIndex = 18;
            this.txt_POSError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_POSCommand
            // 
            this.txt_POSCommand.Location = new System.Drawing.Point(868, 56);
            this.txt_POSCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_POSCommand.Name = "txt_POSCommand";
            this.txt_POSCommand.ReadOnly = true;
            this.txt_POSCommand.Size = new System.Drawing.Size(90, 23);
            this.txt_POSCommand.TabIndex = 17;
            this.txt_POSCommand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_RepeatDelay
            // 
            this.txt_RepeatDelay.Location = new System.Drawing.Point(655, 131);
            this.txt_RepeatDelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_RepeatDelay.Name = "txt_RepeatDelay";
            this.txt_RepeatDelay.Size = new System.Drawing.Size(90, 23);
            this.txt_RepeatDelay.TabIndex = 16;
            this.txt_RepeatDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_StartRepeat
            // 
            this.btn_StartRepeat.ForeColor = System.Drawing.Color.Black;
            this.btn_StartRepeat.Location = new System.Drawing.Point(527, 158);
            this.btn_StartRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_StartRepeat.Name = "btn_StartRepeat";
            this.btn_StartRepeat.Size = new System.Drawing.Size(192, 46);
            this.btn_StartRepeat.TabIndex = 15;
            this.btn_StartRepeat.Text = "Start Repeat";
            this.btn_StartRepeat.UseVisualStyleBackColor = true;
            this.btn_StartRepeat.Click += new System.EventHandler(this.btn_StartRepeat_Click);
            // 
            // txt_RepeatCount
            // 
            this.txt_RepeatCount.Location = new System.Drawing.Point(655, 105);
            this.txt_RepeatCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_RepeatCount.Name = "txt_RepeatCount";
            this.txt_RepeatCount.Size = new System.Drawing.Size(90, 23);
            this.txt_RepeatCount.TabIndex = 14;
            this.txt_RepeatCount.Text = "0";
            this.txt_RepeatCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(506, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 14);
            this.label16.TabIndex = 13;
            this.label16.Text = "Delay";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(506, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 14);
            this.label15.TabIndex = 13;
            this.label15.Text = "Repeat Counter";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(506, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 14);
            this.label14.TabIndex = 13;
            this.label14.Text = "Repeat End";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(749, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 14);
            this.label19.TabIndex = 13;
            this.label19.Text = "POS ERROR";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(749, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 14);
            this.label18.TabIndex = 13;
            this.label18.Text = "Command POS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(749, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 14);
            this.label17.TabIndex = 13;
            this.label17.Text = "Actual POS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(506, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 14);
            this.label13.TabIndex = 13;
            this.label13.Text = "Repeat Start";
            // 
            // txt_RepeatEnd
            // 
            this.txt_RepeatEnd.Location = new System.Drawing.Point(655, 58);
            this.txt_RepeatEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_RepeatEnd.Name = "txt_RepeatEnd";
            this.txt_RepeatEnd.Size = new System.Drawing.Size(90, 23);
            this.txt_RepeatEnd.TabIndex = 12;
            this.txt_RepeatEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_POSActual
            // 
            this.txt_POSActual.Location = new System.Drawing.Point(868, 31);
            this.txt_POSActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_POSActual.Name = "txt_POSActual";
            this.txt_POSActual.ReadOnly = true;
            this.txt_POSActual.Size = new System.Drawing.Size(90, 23);
            this.txt_POSActual.TabIndex = 12;
            this.txt_POSActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_RepeatStart
            // 
            this.txt_RepeatStart.Location = new System.Drawing.Point(655, 32);
            this.txt_RepeatStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_RepeatStart.Name = "txt_RepeatStart";
            this.txt_RepeatStart.Size = new System.Drawing.Size(90, 23);
            this.txt_RepeatStart.TabIndex = 12;
            this.txt_RepeatStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Origin
            // 
            this.btn_Origin.ForeColor = System.Drawing.Color.Black;
            this.btn_Origin.Location = new System.Drawing.Point(308, 192);
            this.btn_Origin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Origin.Name = "btn_Origin";
            this.btn_Origin.Size = new System.Drawing.Size(192, 46);
            this.btn_Origin.TabIndex = 11;
            this.btn_Origin.Text = "Origin";
            this.btn_Origin.UseVisualStyleBackColor = true;
            this.btn_Origin.Click += new System.EventHandler(this.btn_Origin_Click);
            // 
            // btn_MoveABS
            // 
            this.btn_MoveABS.ForeColor = System.Drawing.Color.Black;
            this.btn_MoveABS.Location = new System.Drawing.Point(308, 144);
            this.btn_MoveABS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_MoveABS.Name = "btn_MoveABS";
            this.btn_MoveABS.Size = new System.Drawing.Size(192, 46);
            this.btn_MoveABS.TabIndex = 10;
            this.btn_MoveABS.Text = "Move ABS";
            this.btn_MoveABS.UseVisualStyleBackColor = true;
            this.btn_MoveABS.Click += new System.EventHandler(this.btn_MoveABS_Click);
            // 
            // btn_pJog
            // 
            this.btn_pJog.ForeColor = System.Drawing.Color.Black;
            this.btn_pJog.Location = new System.Drawing.Point(411, 80);
            this.btn_pJog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pJog.Name = "btn_pJog";
            this.btn_pJog.Size = new System.Drawing.Size(89, 59);
            this.btn_pJog.TabIndex = 9;
            this.btn_pJog.Text = "Jog+";
            this.btn_pJog.UseVisualStyleBackColor = true;
            this.btn_pJog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_pJog_MouseDown);
            this.btn_pJog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_pJog_MouseUp);
            // 
            // btn_nJog
            // 
            this.btn_nJog.ForeColor = System.Drawing.Color.Black;
            this.btn_nJog.Location = new System.Drawing.Point(308, 81);
            this.btn_nJog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nJog.Name = "btn_nJog";
            this.btn_nJog.Size = new System.Drawing.Size(89, 59);
            this.btn_nJog.TabIndex = 8;
            this.btn_nJog.Text = "Jog-";
            this.btn_nJog.UseVisualStyleBackColor = true;
            this.btn_nJog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_nJog_MouseDown);
            this.btn_nJog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_nJog_MouseUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 14);
            this.label12.TabIndex = 7;
            this.label12.Text = "Speed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 14);
            this.label11.TabIndex = 7;
            this.label11.Text = "Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Slave No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "COMPORT";
            // 
            // txt_Slave
            // 
            this.txt_Slave.Location = new System.Drawing.Point(217, 48);
            this.txt_Slave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Slave.Name = "txt_Slave";
            this.txt_Slave.Size = new System.Drawing.Size(62, 23);
            this.txt_Slave.TabIndex = 5;
            this.txt_Slave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Speed
            // 
            this.txt_Speed.Location = new System.Drawing.Point(411, 54);
            this.txt_Speed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Speed.Name = "txt_Speed";
            this.txt_Speed.Size = new System.Drawing.Size(90, 23);
            this.txt_Speed.TabIndex = 5;
            this.txt_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Position
            // 
            this.txt_Position.Location = new System.Drawing.Point(411, 28);
            this.txt_Position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Position.Name = "txt_Position";
            this.txt_Position.Size = new System.Drawing.Size(90, 23);
            this.txt_Position.TabIndex = 5;
            this.txt_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_ServoOn
            // 
            this.btn_ServoOn.ForeColor = System.Drawing.Color.Black;
            this.btn_ServoOn.Location = new System.Drawing.Point(163, 179);
            this.btn_ServoOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ServoOn.Name = "btn_ServoOn";
            this.btn_ServoOn.Size = new System.Drawing.Size(136, 59);
            this.btn_ServoOn.TabIndex = 2;
            this.btn_ServoOn.Text = "Servo On";
            this.btn_ServoOn.UseVisualStyleBackColor = true;
            this.btn_ServoOn.Click += new System.EventHandler(this.btn_ServoOn_Click);
            // 
            // btn_ServoConn
            // 
            this.btn_ServoConn.ForeColor = System.Drawing.Color.Black;
            this.btn_ServoConn.Location = new System.Drawing.Point(6, 179);
            this.btn_ServoConn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ServoConn.Name = "btn_ServoConn";
            this.btn_ServoConn.Size = new System.Drawing.Size(136, 59);
            this.btn_ServoConn.TabIndex = 2;
            this.btn_ServoConn.Text = "ServoConn";
            this.btn_ServoConn.UseVisualStyleBackColor = true;
            this.btn_ServoConn.Click += new System.EventHandler(this.btn_ServoConn_Click);
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.btn_CamRelease);
            this.groupbox2.Controls.Add(this.btn_CamInit);
            this.groupbox2.Location = new System.Drawing.Point(331, 2);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(646, 380);
            this.groupbox2.TabIndex = 11;
            this.groupbox2.TabStop = false;
            // 
            // btn_CamInit
            // 
            this.btn_CamInit.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CamInit.Location = new System.Drawing.Point(29, 330);
            this.btn_CamInit.Name = "btn_CamInit";
            this.btn_CamInit.Size = new System.Drawing.Size(129, 41);
            this.btn_CamInit.TabIndex = 1;
            this.btn_CamInit.Text = "Cam Initialize";
            this.btn_CamInit.UseVisualStyleBackColor = true;
            this.btn_CamInit.Click += new System.EventHandler(this.btn_CamInit_Click);
            // 
            // btn_CamRelease
            // 
            this.btn_CamRelease.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CamRelease.Location = new System.Drawing.Point(164, 329);
            this.btn_CamRelease.Name = "btn_CamRelease";
            this.btn_CamRelease.Size = new System.Drawing.Size(129, 41);
            this.btn_CamRelease.TabIndex = 2;
            this.btn_CamRelease.Text = "Cam Release";
            this.btn_CamRelease.UseVisualStyleBackColor = true;
            this.btn_CamRelease.Click += new System.EventHandler(this.btn_CamRelease_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(986, 638);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_FrontRetry);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_LightLog);
            this.Name = "Form_Main";
            this.Text = "길로틴 조명 컨트롤러";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_LightLog;
        private System.Windows.Forms.HScrollBar scr_FrontValue;
        private System.Windows.Forms.Button btn_FrontSet;
        private System.Windows.Forms.TextBox txt_FrontValue;
        private System.Windows.Forms.Button btn_FrontRetry;
        private System.Windows.Forms.Button btn_FrontOff;
        private System.Windows.Forms.Button btn_FrontOn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_POSError;
        private System.Windows.Forms.TextBox txt_POSCommand;
        private System.Windows.Forms.TextBox txt_RepeatDelay;
        private System.Windows.Forms.Button btn_StartRepeat;
        private System.Windows.Forms.TextBox txt_RepeatCount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_RepeatEnd;
        private System.Windows.Forms.TextBox txt_POSActual;
        private System.Windows.Forms.TextBox txt_RepeatStart;
        private System.Windows.Forms.Button btn_Origin;
        private System.Windows.Forms.Button btn_MoveABS;
        private System.Windows.Forms.Button btn_pJog;
        private System.Windows.Forms.Button btn_nJog;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Slave;
        private System.Windows.Forms.TextBox txt_Speed;
        private System.Windows.Forms.TextBox txt_Position;
        private System.Windows.Forms.Button btn_ServoOn;
        private System.Windows.Forms.Button btn_ServoConn;
        private System.Windows.Forms.TextBox txt_servoPort;
        private System.Windows.Forms.Button btn_ServoStop;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Button btn_CamInit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_CamRelease;
    }
}

