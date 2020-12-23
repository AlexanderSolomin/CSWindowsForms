using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ITMO.CSWindowsForms.Lab3._4.ValidationForm
{
    public partial class Form1 : Form
    {
        
        public string UName
        {
            get { return registrationForm1.UserName; }
        }
        public DateTime UDateBirth
        {
            get { return registrationForm1.UserDateBirth; }
        }
        public string UPhone
        {
            get { return registrationForm1.UserPhoneNum; }
        }
        public string UGender
        {
            get { return registrationForm1.UserGender; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in registrationForm1.Controls)
            {
                ctrl.KeyUp += KeyRelease;
            }
        }
        private void KeyRelease(object sender, EventArgs e)
        {
            button1.Enabled = registrationForm1.BoxFilled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User usr = new User(UName, UDateBirth.Date, UPhone, UGender);
            richTextBox1.Text = usr.ToString();
        }

    }
}
