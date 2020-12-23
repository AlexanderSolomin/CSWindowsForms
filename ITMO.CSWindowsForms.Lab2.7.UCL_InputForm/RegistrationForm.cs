using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSWindowsForms.Lab2._7.UCL_InputForm
{
    public partial class RegistrationForm : UserControl
    {
        public string UserName
        {
            get
            {
                return nameBox.Text;
            }
        }
        public DateTime UserDateBirth
        {
            get
            {
                return birthPicker.Value;
            }
        }
        public string UserPhoneNum
        {
            get
            {
                return maskedTextBox1.Text;
            }
        }
        public string UserGender
        {
            get
            {
                return genderComboBox.Text;
            }
        }
        public bool BoxFilled
        {
            get
            {
                if (nameBox.Text != "" && maskedTextBox1.MaskCompleted && 
                    genderComboBox.SelectedIndex != -1)
                {
                    return true;
                }
                else return false;
            }
        }


        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void empty_Validating(object sender, CancelEventArgs e)
        {
            Control sendCtrl = (Control)sender;
            bool valid;

            if (sendCtrl is MaskedTextBox)
            {
                valid = maskedTextBox1.MaskCompleted;
            }
            else
            {
                valid = !String.IsNullOrWhiteSpace(sendCtrl.Text);
            }

            e.Cancel = !valid;
            errorProvider1.SetError(sendCtrl, (valid ? string.Empty : sendCtrl.Tag.ToString()));
        }

        // Кнопка на usercontrole

        //Button button1 = new Button();
        private void VerificationForm_Load(object sender, EventArgs e)
        {
            
        //    button1.Enabled = false;
        //    button1.Location = new System.Drawing.Point(111, 156);
        //    button1.Name = "button1";
        //    button1.Size = new System.Drawing.Size(75, 23);
        //    button1.TabIndex = 4;
        //    button1.Text = "ОК";
        //    button1.UseVisualStyleBackColor = true;
        //    Controls.Add(button1);

        //    //button1.Click += new System.EventHandler(this.button1_Click);

        //    foreach (Control ctrl in this.Controls)
        //    {
        //        ctrl.KeyUp += KeyRelease;
        //    }
        }
        ////private void button1_Click(object sender, EventArgs e)
        ////{

        ////}
        //private void KeyRelease(object sender, EventArgs e)
        //{
        //    button1.Enabled = BoxFilled;
        //}

    }
}
