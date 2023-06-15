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
    public partial class PausePopup : Form
    {
        public Form1 form1;

        public PausePopup()
        {
            InitializeComponent();
        }

        private void resumeTimer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
