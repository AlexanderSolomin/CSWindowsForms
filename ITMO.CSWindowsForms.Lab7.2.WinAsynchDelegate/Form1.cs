using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSWindowsForms.Lab6._2.WinAsynchDelegate
{
    public partial class Form1 : Form
    {
        private delegate void TimeConsumingMethodDelegate(int seconds);

        bool Cancel;

        public Form1()
        {
            InitializeComponent();
        }

        private void TimeConsumingMethod(int seconds)
        {
            for (int j = 1; j <= seconds; j++)
            {
                System.Threading.Thread.Sleep(1000);
                SetProgress((int)(j * 100) / seconds);
                if (Cancel) break;
            }

            if (Cancel)
            {
                System.Windows.Forms.MessageBox.Show("Cancelled");
                Cancel = false;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Complete");
            }

        }
        public delegate void SetProgressDelegate(int val);

        public void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeConsumingMethodDelegate del = new TimeConsumingMethodDelegate(TimeConsumingMethod);
            del.BeginInvoke(int.Parse(numericUpDown1.Value.ToString()), null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }
    }
}
