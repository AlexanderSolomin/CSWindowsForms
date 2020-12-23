using System;
using System.Windows.Forms;

namespace ITMO.CSWindowsForms.Lab7._5.Eratosthenes
{
    public delegate string EratoSieve(int maxValue);
    delegate void ResultPrint(string str);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string EratoString(int maxValue)
        {
            System.Text.StringBuilder resultText = new System.Text.StringBuilder();
            
            for (int trial = 2; trial <= maxValue; trial++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                {
                    if (trial % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    resultText.AppendFormat("{0} ", trial);
                    //richTextBox1.Text = resultText.ToString();
                    
                    System.Threading.Thread.Sleep(1);
                }
            }
            return resultText.ToString();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int maxValue = 0;
            if (int.TryParse(this.maxValue.Text, out maxValue))
            {
                EratoSieve es = EratoString;
                AsyncCallback acb = CallBackMethod;
                es.BeginInvoke(maxValue, acb, es);
            }
            else
            {
                label1.Text = "Unable to parse maximum value.";
                return;
            }
        }
        void CallBackMethod(IAsyncResult ar)
        {
            EratoSieve es = ar.AsyncState as EratoSieve;
            MethodInvoker mi = delegate
                                        {
                                            richTextBox1.Text = es.EndInvoke(ar);
                                        };
            this.BeginInvoke(mi);
            //ResultPrint rp = PrintRes;
            //rp.BeginInvoke(es.EndInvoke(ar).ToString(),null,null);
            //richTextBox1.Text = es.EndInvoke(ar);
        }

        //private void ExecuteSecure(Action a)
        //{
        //    if (InvokeRequired)
        //        BeginInvoke(a);
        //    else
        //        a();
        //}
        //private void PrintRes(string str)
        //{
        //    richTextBox1.Text = str;
        //}
    }
}
