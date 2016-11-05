using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1_3_TimerEvents
{
    public partial class Form1 : Form
    {
        private Timer _timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _timer = new Timer {Interval = 1000};
            _timer.Tick += (s, ev) =>
            {
                ProgressBar.Value += 10;
                if (ProgressBar.Value == 100)
                    _timer.Stop();
            };
            _timer.Start();
        }
    }
}
