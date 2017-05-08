namespace winform_guilotine
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FrontLog = new System.Windows.Forms.TextBox();
            this.scr_FrontValue = new System.Windows.Forms.HScrollBar();
            this.btn_FrontSet = new System.Windows.Forms.Button();
            this.txt_FrontValue = new System.Windows.Forms.TextBox();
            this.btn_FrontConn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_BackLog = new System.Windows.Forms.TextBox();
            this.scr_BackValue = new System.Windows.Forms.HScrollBar();
            this.btn_BackSet = new System.Windows.Forms.Button();
            this.txt_BackValue = new System.Windows.Forms.TextBox();
            this.btn_BackConn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_FrontLog);
            this.groupBox1.Controls.Add(this.scr_FrontValue);
            this.groupBox1.Controls.Add(this.btn_FrontSet);
            this.groupBox1.Controls.Add(this.txt_FrontValue);
            this.groupBox1.Controls.Add(this.btn_FrontConn);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(306, 330);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Front_Light_Control";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "255(어두움)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "0(밝음)";
            // 
            // txt_FrontLog
            // 
            this.txt_FrontLog.Location = new System.Drawing.Point(5, 21);
            this.txt_FrontLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FrontLog.Multiline = true;
            this.txt_FrontLog.Name = "txt_FrontLog";
            this.txt_FrontLog.Size = new System.Drawing.Size(296, 130);
            this.txt_FrontLog.TabIndex = 7;
            // 
            // scr_FrontValue
            // 
            this.scr_FrontValue.Location = new System.Drawing.Point(19, 187);
            this.scr_FrontValue.Maximum = 264;
            this.scr_FrontValue.Name = "scr_FrontValue";
            this.scr_FrontValue.Size = new System.Drawing.Size(262, 30);
            this.scr_FrontValue.TabIndex = 6;
            this.scr_FrontValue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_FrontValue_Scroll);
            // 
            // btn_FrontSet
            // 
            this.btn_FrontSet.ForeColor = System.Drawing.Color.Black;
            this.btn_FrontSet.Location = new System.Drawing.Point(166, 219);
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
            this.txt_FrontValue.Location = new System.Drawing.Point(6, 219);
            this.txt_FrontValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FrontValue.Name = "txt_FrontValue";
            this.txt_FrontValue.Size = new System.Drawing.Size(136, 44);
            this.txt_FrontValue.TabIndex = 3;
            this.txt_FrontValue.Text = "0";
            this.txt_FrontValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_FrontConn
            // 
            this.btn_FrontConn.ForeColor = System.Drawing.Color.Black;
            this.btn_FrontConn.Location = new System.Drawing.Point(6, 266);
            this.btn_FrontConn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FrontConn.Name = "btn_FrontConn";
            this.btn_FrontConn.Size = new System.Drawing.Size(294, 59);
            this.btn_FrontConn.TabIndex = 1;
            this.btn_FrontConn.Text = "Connect";
            this.btn_FrontConn.UseVisualStyleBackColor = true;
            this.btn_FrontConn.Click += new System.EventHandler(this.btn_FrontConn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_BackLog);
            this.groupBox2.Controls.Add(this.scr_BackValue);
            this.groupBox2.Controls.Add(this.btn_BackSet);
            this.groupBox2.Controls.Add(this.txt_BackValue);
            this.groupBox2.Controls.Add(this.btn_BackConn);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(694, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(306, 330);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Back_Light_Control";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "255(어두움)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "0(밝음)";
            // 
            // txt_BackLog
            // 
            this.txt_BackLog.Location = new System.Drawing.Point(5, 21);
            this.txt_BackLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_BackLog.Multiline = true;
            this.txt_BackLog.Name = "txt_BackLog";
            this.txt_BackLog.Size = new System.Drawing.Size(296, 130);
            this.txt_BackLog.TabIndex = 7;
            // 
            // scr_BackValue
            // 
            this.scr_BackValue.Location = new System.Drawing.Point(19, 187);
            this.scr_BackValue.Maximum = 264;
            this.scr_BackValue.Name = "scr_BackValue";
            this.scr_BackValue.Size = new System.Drawing.Size(262, 30);
            this.scr_BackValue.TabIndex = 6;
            this.scr_BackValue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_BackValue_Scroll);
            // 
            // btn_BackSet
            // 
            this.btn_BackSet.ForeColor = System.Drawing.Color.Black;
            this.btn_BackSet.Location = new System.Drawing.Point(166, 219);
            this.btn_BackSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BackSet.Name = "btn_BackSet";
            this.btn_BackSet.Size = new System.Drawing.Size(136, 42);
            this.btn_BackSet.TabIndex = 4;
            this.btn_BackSet.Text = "Set Brightness";
            this.btn_BackSet.UseVisualStyleBackColor = true;
            this.btn_BackSet.Click += new System.EventHandler(this.btn_BackSet_Click);
            // 
            // txt_BackValue
            // 
            this.txt_BackValue.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_BackValue.Location = new System.Drawing.Point(6, 219);
            this.txt_BackValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_BackValue.Name = "txt_BackValue";
            this.txt_BackValue.Size = new System.Drawing.Size(136, 44);
            this.txt_BackValue.TabIndex = 3;
            this.txt_BackValue.Text = "0";
            this.txt_BackValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_BackConn
            // 
            this.btn_BackConn.ForeColor = System.Drawing.Color.Black;
            this.btn_BackConn.Location = new System.Drawing.Point(6, 266);
            this.btn_BackConn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BackConn.Name = "btn_BackConn";
            this.btn_BackConn.Size = new System.Drawing.Size(294, 59);
            this.btn_BackConn.TabIndex = 1;
            this.btn_BackConn.Text = "Connect";
            this.btn_BackConn.UseVisualStyleBackColor = true;
            this.btn_BackConn.Click += new System.EventHandler(this.btn_BackConn_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1012, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Main";
            this.Text = "길로틴 조명 컨트롤러";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FrontLog;
        private System.Windows.Forms.HScrollBar scr_FrontValue;
        private System.Windows.Forms.Button btn_FrontSet;
        private System.Windows.Forms.TextBox txt_FrontValue;
        private System.Windows.Forms.Button btn_FrontConn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_BackLog;
        private System.Windows.Forms.HScrollBar scr_BackValue;
        private System.Windows.Forms.Button btn_BackSet;
        private System.Windows.Forms.TextBox txt_BackValue;
        private System.Windows.Forms.Button btn_BackConn;
    }
}

