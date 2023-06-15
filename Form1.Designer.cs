namespace Pomodoro_App
{
    partial class Form1
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
            this.startTimer = new System.Windows.Forms.Button();
            this.stopTimer = new System.Windows.Forms.Button();
            this.resetTimer = new System.Windows.Forms.Button();
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.timerText = new System.Windows.Forms.TextBox();
            this.minutesBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.secondsBox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startTimer
            // 
            this.startTimer.BackColor = System.Drawing.Color.YellowGreen;
            this.startTimer.Location = new System.Drawing.Point(12, 276);
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(103, 42);
            this.startTimer.TabIndex = 0;
            this.startTimer.Text = "Start";
            this.startTimer.UseVisualStyleBackColor = false;
            this.startTimer.Click += new System.EventHandler(this.startTimer_Click);
            // 
            // stopTimer
            // 
            this.stopTimer.BackColor = System.Drawing.Color.Crimson;
            this.stopTimer.Location = new System.Drawing.Point(141, 276);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(103, 42);
            this.stopTimer.TabIndex = 3;
            this.stopTimer.Text = "Stop";
            this.stopTimer.UseVisualStyleBackColor = false;
            this.stopTimer.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // resetTimer
            // 
            this.resetTimer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resetTimer.Location = new System.Drawing.Point(271, 276);
            this.resetTimer.Name = "resetTimer";
            this.resetTimer.Size = new System.Drawing.Size(103, 42);
            this.resetTimer.TabIndex = 4;
            this.resetTimer.Text = "Reset";
            this.resetTimer.UseVisualStyleBackColor = false;
            // 
            // countTimer
            // 
            this.countTimer.Enabled = true;
            this.countTimer.Interval = 1000;
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // timerText
            // 
            this.timerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerText.Location = new System.Drawing.Point(38, 97);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(321, 98);
            this.timerText.TabIndex = 6;
            this.timerText.Text = "00:00:00";
            // 
            // minutesBox
            // 
            this.minutesBox.FormattingEnabled = true;
            this.minutesBox.Location = new System.Drawing.Point(13, 238);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(121, 21);
            this.minutesBox.TabIndex = 5;
            this.minutesBox.SelectedIndexChanged += new System.EventHandler(this.optionTime_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(25, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Minutes";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // secondsBox
            // 
            this.secondsBox.FormattingEnabled = true;
            this.secondsBox.Location = new System.Drawing.Point(141, 238);
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(121, 21);
            this.secondsBox.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(153, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Seconds";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 348);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.secondsBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.resetTimer);
            this.Controls.Add(this.stopTimer);
            this.Controls.Add(this.startTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.Button stopTimer;
        private System.Windows.Forms.Button resetTimer;
        private System.Windows.Forms.Timer countTimer;
        private System.Windows.Forms.TextBox timerText;
        private System.Windows.Forms.ComboBox minutesBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox secondsBox;
        private System.Windows.Forms.TextBox textBox2;
    }
}

