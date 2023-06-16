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
            this.countDown = new System.Windows.Forms.TextBox();
            this.optionTime = new System.Windows.Forms.ComboBox();
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
            // countDown
            // 
            this.countDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDown.Location = new System.Drawing.Point(38, 97);
            this.countDown.Name = "countDown";
            this.countDown.Size = new System.Drawing.Size(321, 98);
            this.countDown.TabIndex = 6;
            this.countDown.Text = "00:00:00";
            // 
            // optionTime
            // 
            this.optionTime.FormattingEnabled = true;
            this.optionTime.Items.AddRange(new object[] {
            "25",
            "60"});
            this.optionTime.Location = new System.Drawing.Point(13, 238);
            this.optionTime.Name = "optionTime";
            this.optionTime.Size = new System.Drawing.Size(121, 21);
            this.optionTime.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 348);
            this.Controls.Add(this.countDown);
            this.Controls.Add(this.optionTime);
            this.Controls.Add(this.resetTimer);
            this.Controls.Add(this.stopTimer);
            this.Controls.Add(this.startTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.Button stopTimer;
        private System.Windows.Forms.Button resetTimer;
        private System.Windows.Forms.Timer countTimer;
        private System.Windows.Forms.TextBox countDown;
        private System.Windows.Forms.ComboBox optionTime;
    }
}

