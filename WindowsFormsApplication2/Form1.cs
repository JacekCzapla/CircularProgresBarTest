using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        
        System.Timers.Timer timer;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            circularProgressBar1.Maximum = 1000;            

            timer = new System.Timers.Timer(100);
            timer.Elapsed += (s, e) => {
                i++;
                Invoke(new Action(() =>
                {
                    UpdateProgresBar();

                }));
            };
            timer.Start();

        }
        
        private void UpdateProgresBar()
        {
            label1.Text = i.ToString();
            circularProgressBar1.Value = i;
            if (i == 300)
                timer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer != null && !timer.Enabled)
            {
                timer.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer != null && timer.Enabled)
            {
                timer.Stop();
            }
        }
    }


    
}
