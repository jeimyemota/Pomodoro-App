using System;
using System.Windows.Forms;

namespace Pomodoro_App
{
    public partial class Form1 : Form
    {
        // TODO: If user selected 30 minutes, once timer hits 0 -> ask to set timer to 5 minutes and countdown begins again
        // TODO: If user selected 1 hour, once time hits 0 -> ask to set timer to 10 minutes and countdown begins again
        // TODO: When user clicks on reset, timer resets.
        // TODO: When timer is done, alarm goes off and pop up modal displays: "Break Time!"
        // TODO: Pop up has two buttons, one to continue to break and one to stop the timer

        // == 💜 Variables == //
        private int totalSeconds;

        public Form1()
        {
            InitializeComponent();
        }

        // == 💜 Set up choices on form load == //
        private void Form1_Load(object sender, EventArgs e)
        {
            stopTimer.Enabled = false;
            for (int i = 0; i < 60; i++)
            {
                hoursBox.Items.Add(i.ToString());
                minutesBox.Items.Add(i.ToString());
                secondsBox.Items.Add(i.ToString());
            }
            //Starts at 0
            hoursBox.SelectedIndex = 0;
            minutesBox.SelectedIndex = 0;
            secondsBox.SelectedIndex = 0;
        }

        // == 💜 Start/Resume Button Click == \\
        private void startTimer_Click(object sender, EventArgs e)
        {
            startTimer.Enabled = false;
            if (startTimer.Text == "Start")
            {
                int hours = int.Parse(hoursBox.SelectedItem.ToString());
                int minutes = int.Parse(minutesBox.SelectedItem.ToString());
                int seconds = int.Parse(secondsBox.SelectedItem.ToString());

                totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
                countTimer.Enabled = true;
            }
            else if (startTimer.Text == "Resume")
            {
                countTimer.Enabled = true;
                startTimer.Text = "Start";
            }
        }

        // == 💜 Countdown Functionality == //
        private void countTimer_Tick(object sender, EventArgs e)
        {
            //countdown formula
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int hours = totalSeconds / 3600; // Calculate hours
                int minutes = (totalSeconds % 3600) / 60; // Calculate minutes
                int seconds = totalSeconds % 60; // Calculate seconds 
                timerText.Text = hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + seconds.ToString("D2"); // Convert int to string and display on timerText
            }
            else
            {
                countTimer.Stop();
            }
            stopTimer.Enabled = true;
            startTimer.Enabled = true;
        }

        // == 💜 Stop Button  == //
        private void stopTimer_Click(object sender, EventArgs e)
        {
            countTimer.Stop();
            startTimer.Text = "Resume";
        }
    }
}
