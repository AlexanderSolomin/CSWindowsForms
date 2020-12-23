using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ITMO.CSWindowsForms.Lab2._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(88, 86);
                lbl.Size = new System.Drawing.Size(32, 23);
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(128, 80);
                txt.Size = new System.Drawing.Size(163, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);

                //txt.KeyPress += new 
                //    System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
                txt.Validating += new
                    System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            }
            else
            {
                int lcv;
                lcv = groupBox1.Controls.Count;// определяется количество элементов
                while (lcv > 4)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox1, "Must be letter");
                MessageBox.Show("Поле Name не может содержать цифры");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Поле PIN не может содержать буквы");
            //}
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse((sender as TextBox).Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле PIN не может содержать буквы");
                }
            }
        }
    }
}
