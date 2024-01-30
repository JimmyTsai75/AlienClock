namespace AlienClock
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAlienResult = new System.Windows.Forms.Label();
            this.btnToAlienClock = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEarthDtResult = new System.Windows.Forms.Label();
            this.btnToEarthClock = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtASecond = new System.Windows.Forms.TextBox();
            this.txtAMinute = new System.Windows.Forms.TextBox();
            this.txtAHour = new System.Windows.Forms.TextBox();
            this.txtADay = new System.Windows.Forms.TextBox();
            this.txtAMonth = new System.Windows.Forms.TextBox();
            this.txtAYear = new System.Windows.Forms.TextBox();
            this.clock2 = new ClockDisplay.Clock();
            this.clock1 = new ClockDisplay.Clock();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAlarmHour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAlarmMinute = new System.Windows.Forms.TextBox();
            this.lblAlarmReport = new System.Windows.Forms.Label();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.btnStopAlarm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAlienResult);
            this.groupBox1.Controls.Add(this.btnToAlienClock);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSecond);
            this.groupBox1.Controls.Add(this.txtMinute);
            this.groupBox1.Controls.Add(this.txtHour);
            this.groupBox1.Controls.Add(this.txtDay);
            this.groupBox1.Controls.Add(this.txtMonth);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Location = new System.Drawing.Point(12, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1149, 144);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter";
            // 
            // lblAlienResult
            // 
            this.lblAlienResult.AutoSize = true;
            this.lblAlienResult.Location = new System.Drawing.Point(903, 36);
            this.lblAlienResult.Name = "lblAlienResult";
            this.lblAlienResult.Size = new System.Drawing.Size(63, 15);
            this.lblAlienResult.TabIndex = 16;
            this.lblAlienResult.Text = "AlienDT";
            // 
            // btnToAlienClock
            // 
            this.btnToAlienClock.Location = new System.Drawing.Point(906, 81);
            this.btnToAlienClock.Name = "btnToAlienClock";
            this.btnToAlienClock.Size = new System.Drawing.Size(205, 43);
            this.btnToAlienClock.TabIndex = 6;
            this.btnToAlienClock.Text = "Convert To AlienClock";
            this.btnToAlienClock.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(761, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Second";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Minute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Year";
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(764, 81);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(116, 25);
            this.txtSecond.TabIndex = 5;
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(624, 81);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(116, 25);
            this.txtMinute.TabIndex = 4;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(488, 81);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(116, 25);
            this.txtHour.TabIndex = 3;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(339, 81);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(116, 25);
            this.txtDay.TabIndex = 2;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(186, 81);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(116, 25);
            this.txtMonth.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(33, 81);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(116, 25);
            this.txtYear.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEarthDtResult);
            this.groupBox2.Controls.Add(this.btnToEarthClock);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtASecond);
            this.groupBox2.Controls.Add(this.txtAMinute);
            this.groupBox2.Controls.Add(this.txtAHour);
            this.groupBox2.Controls.Add(this.txtADay);
            this.groupBox2.Controls.Add(this.txtAMonth);
            this.groupBox2.Controls.Add(this.txtAYear);
            this.groupBox2.Location = new System.Drawing.Point(12, 632);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1149, 144);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Converter";
            // 
            // lblEarthDtResult
            // 
            this.lblEarthDtResult.AutoSize = true;
            this.lblEarthDtResult.Location = new System.Drawing.Point(903, 36);
            this.lblEarthDtResult.Name = "lblEarthDtResult";
            this.lblEarthDtResult.Size = new System.Drawing.Size(63, 15);
            this.lblEarthDtResult.TabIndex = 16;
            this.lblEarthDtResult.Text = "EarthDT";
            // 
            // btnToEarthClock
            // 
            this.btnToEarthClock.Location = new System.Drawing.Point(906, 81);
            this.btnToEarthClock.Name = "btnToEarthClock";
            this.btnToEarthClock.Size = new System.Drawing.Size(205, 43);
            this.btnToEarthClock.TabIndex = 6;
            this.btnToEarthClock.Text = "Convert  To EarthClock";
            this.btnToEarthClock.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(761, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Second";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(621, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Minute";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(485, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Hour";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Day";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Month";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Year";
            // 
            // txtASecond
            // 
            this.txtASecond.Location = new System.Drawing.Point(764, 81);
            this.txtASecond.Name = "txtASecond";
            this.txtASecond.Size = new System.Drawing.Size(116, 25);
            this.txtASecond.TabIndex = 5;
            // 
            // txtAMinute
            // 
            this.txtAMinute.Location = new System.Drawing.Point(624, 81);
            this.txtAMinute.Name = "txtAMinute";
            this.txtAMinute.Size = new System.Drawing.Size(116, 25);
            this.txtAMinute.TabIndex = 4;
            // 
            // txtAHour
            // 
            this.txtAHour.Location = new System.Drawing.Point(488, 81);
            this.txtAHour.Name = "txtAHour";
            this.txtAHour.Size = new System.Drawing.Size(116, 25);
            this.txtAHour.TabIndex = 3;
            // 
            // txtADay
            // 
            this.txtADay.Location = new System.Drawing.Point(339, 81);
            this.txtADay.Name = "txtADay";
            this.txtADay.Size = new System.Drawing.Size(116, 25);
            this.txtADay.TabIndex = 2;
            // 
            // txtAMonth
            // 
            this.txtAMonth.Location = new System.Drawing.Point(186, 81);
            this.txtAMonth.Name = "txtAMonth";
            this.txtAMonth.Size = new System.Drawing.Size(116, 25);
            this.txtAMonth.TabIndex = 1;
            // 
            // txtAYear
            // 
            this.txtAYear.Location = new System.Drawing.Point(33, 81);
            this.txtAYear.Name = "txtAYear";
            this.txtAYear.Size = new System.Drawing.Size(116, 25);
            this.txtAYear.TabIndex = 0;
            // 
            // clock2
            // 
            this.clock2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clock2.Display = ClockDisplay.DisplayOption.text;
            this.clock2.IsAlienClock = false;
            this.clock2.Location = new System.Drawing.Point(818, 12);
            this.clock2.Name = "clock2";
            this.clock2.Size = new System.Drawing.Size(701, 432);
            this.clock2.TabIndex = 0;
            // 
            // clock1
            // 
            this.clock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clock1.Display = ClockDisplay.DisplayOption.text;
            this.clock1.IsAlienClock = false;
            this.clock1.Location = new System.Drawing.Point(12, 12);
            this.clock1.Name = "clock1";
            this.clock1.Size = new System.Drawing.Size(701, 432);
            this.clock1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStopAlarm);
            this.groupBox3.Controls.Add(this.btnSetAlarm);
            this.groupBox3.Controls.Add(this.lblAlarmReport);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtAlarmMinute);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtAlarmHour);
            this.groupBox3.Location = new System.Drawing.Point(1184, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 309);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set Alarm";
            // 
            // txtAlarmHour
            // 
            this.txtAlarmHour.Location = new System.Drawing.Point(75, 47);
            this.txtAlarmHour.Name = "txtAlarmHour";
            this.txtAlarmHour.Size = new System.Drawing.Size(116, 25);
            this.txtAlarmHour.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hour";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "Minute";
            // 
            // txtAlarmMinute
            // 
            this.txtAlarmMinute.Location = new System.Drawing.Point(75, 99);
            this.txtAlarmMinute.Name = "txtAlarmMinute";
            this.txtAlarmMinute.Size = new System.Drawing.Size(116, 25);
            this.txtAlarmMinute.TabIndex = 1;
            // 
            // lblAlarmReport
            // 
            this.lblAlarmReport.AutoSize = true;
            this.lblAlarmReport.Location = new System.Drawing.Point(17, 155);
            this.lblAlarmReport.Name = "lblAlarmReport";
            this.lblAlarmReport.Size = new System.Drawing.Size(95, 15);
            this.lblAlarmReport.TabIndex = 15;
            this.lblAlarmReport.Text = "AlarmReport";
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.Location = new System.Drawing.Point(24, 235);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(137, 43);
            this.btnSetAlarm.TabIndex = 16;
            this.btnSetAlarm.Text = "Set Alarm";
            this.btnSetAlarm.UseVisualStyleBackColor = true;
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.Location = new System.Drawing.Point(188, 235);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(132, 43);
            this.btnStopAlarm.TabIndex = 16;
            this.btnStopAlarm.Text = "Delete Alarm";
            this.btnStopAlarm.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 806);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clock2);
            this.Controls.Add(this.clock1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlienClock";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ClockDisplay.Clock clock1;
        private ClockDisplay.Clock clock2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblAlienResult;
        private System.Windows.Forms.Button btnToAlienClock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEarthDtResult;
        private System.Windows.Forms.Button btnToEarthClock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtASecond;
        private System.Windows.Forms.TextBox txtAMinute;
        private System.Windows.Forms.TextBox txtAHour;
        private System.Windows.Forms.TextBox txtADay;
        private System.Windows.Forms.TextBox txtAMonth;
        private System.Windows.Forms.TextBox txtAYear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.Label lblAlarmReport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAlarmMinute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAlarmHour;
        private System.Windows.Forms.Button btnStopAlarm;
    }
}

