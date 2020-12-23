using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSWindowsForms.Lab6._3.WinAsynchMethod
{
    public partial class Form1 : Form
    {
        private delegate int AsyncSumm(int a, int b);
        delegate void PrintLabel(string str);
        private PrintLabel PrintDlegateFunc;

        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            InitializeComponent();
            PrintDlegateFunc = new PrintLabel(PrintFunc);


        }

        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                // Преобразование типов данных.
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                txbA.Text = txbB.Text = "";
                return;
            }

            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);

            summdelegate.BeginInvoke(a, b, cb, summdelegate);

        }
        private void CallBackMethod(IAsyncResult ar)
        {
            string str;

            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("Сумма введенных чисел равна {0}",
            summdelegate.EndInvoke(ar));

            lblResult.Invoke(PrintDlegateFunc, new object[] { str });

            MessageBox.Show(str, "Результат операции");
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress");
        }

        void PrintFunc(string str)
        {
            lblResult.Text = str;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                txbA.Text = txbB.Text = "";
                return;
            }
            int res = await Subb(a, b);
            lblResult.Text = res.ToString();
        }
        private async Task<int> Subb(int a, int b)
        {
            return await Task.Run(() =>
                                        {
                                            Thread.Sleep(5000);
                                            return a - b;
                                        });
        }
    }
}
