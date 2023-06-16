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
 feature-branch
        // TODO: If user selected 30 minutes, once timer hits 0 -> ask to set timer to 5 minutes and countdown begins again
        // TODO: If user selected 1 hour, once time hits 0 -> ask to set timer to 10 minutes and countdown begins again
        // TODO: When user clicks on reset, timer resets.
        // TODO: When timer is done, alarm goes off and pop up modal displays: "Break Time!"
        // TODO: Pop up has two buttons, one to continue to break and one to stop the timer

        // == 💜 Variables == //
        private int totalSeconds;


        // == 💜 Variables ==
        int seconds;
