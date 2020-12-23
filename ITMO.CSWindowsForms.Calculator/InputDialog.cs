using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class InputDialog : Form
    {
        public double A
        {
            get { return Convert.ToDouble(textBox1.Text); }

        }
        public double B
        {
            get { return Convert.ToDouble(textBox2.Text); }
        }
        public double C
        {
            get { return Convert.ToDouble(textBox3.Text); }
        }
        public InputDialog()
        {
            InitializeComponent();
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (!char.IsDigit(e.KeyChar) &&
                    e.KeyChar != (char)Keys.Back &&
                    e.KeyChar != (char)Keys.Delete &&
                    e.KeyChar != '-')
                {
                    e.Handled = true;
                }

        }
        private void Empty_Validating(object sender, CancelEventArgs e)
        {
            Control sendCtrl = (Control)sender;
            bool valid = false;
            int value = 0;
            if (String.IsNullOrWhiteSpace(sendCtrl.Text) || int.TryParse(sendCtrl.Text, out value))
            {
                valid = true;
            }
            e.Cancel = !valid;
            errorProvider1.SetError(sendCtrl, (valid ? string.Empty : sendCtrl.Tag.ToString()));
        }

    }
}
