namespace Pomodoro_App
{
    partial class PausePopup
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
            this.pauseModal = new System.Windows.Forms.TextBox();
            this.resumeTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pauseModal
            // 
            this.pauseModal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pauseModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseModal.Location = new System.Drawing.Point(12, 25);
            this.pauseModal.Name = "pauseModal";
            this.pauseModal.Size = new System.Drawing.Size(327, 23);
            this.pauseModal.TabIndex = 0;
            this.pauseModal.Text = "Would You Like to Resume?";
            this.pauseModal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resumeTimer
            // 
            this.resumeTimer.Location = new System.Drawing.Point(99, 65);
            this.resumeTimer.Name = "resumeTimer";
            this.resumeTimer.Size = new System.Drawing.Size(137, 51);
            this.resumeTimer.TabIndex = 1;
            this.resumeTimer.Text = "Resume";
            this.resumeTimer.UseVisualStyleBackColor = true;
            this.resumeTimer.Click += new System.EventHandler(this.resumeTimer_Click);
            // 
            // pausePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 140);
            this.Controls.Add(this.resumeTimer);
            this.Controls.Add(this.pauseModal);
            this.Name = "pausePopup";
            this.Text = "pausePopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pauseModal;
        private System.Windows.Forms.Button resumeTimer;
    }
}