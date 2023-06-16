using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro_App
{
    public partial class Form1 : Form
    {
        // == 💜 Variables ==
        int seconds;
        public Form1()
        {
            InitializeComponent();
        }
        #region TO DOs 
        //TODO: When user select time from dropdown, Countdown updates to reflect option ✅
        //TODO: When user clicks on start, Countdown begins ✅
        //TODO: Convert Count Down to HH MM SS
        //TODO: If user selected 30 minutes, once timer hits 0 -> reset to 5 minutes and countdown begins again
        //TODO: If user selected 1 hour, once time hits 0 -> reset to 10 minutes and countdown begins again
        //TODO: When user clicks on stop, timer stops
        //TODO: When user clicks on reset, timer resets
        #endregion
        private void startTimer_Click(object sender, EventArgs e)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            string str = time.ToString(@"hh\:mm\:ss");

            seconds = Int32.Parse(optionTime.Text);
            optionTime.Enabled = false;
            countTimer.Start();

           

        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            countDown.Text = seconds--.ToString();
        }
    }
}
