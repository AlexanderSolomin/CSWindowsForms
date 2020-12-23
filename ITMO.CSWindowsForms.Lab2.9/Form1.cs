using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSWindowsForms.Lab2._9
{
    public partial class Form1 : Form
    {
        
        List<Item> its = new List<Item>();
        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get
            {
                if (this.tabControl1.SelectedTab == tabPage1)
                {
                    return textBox2.Text;
                }
                else
                {
                    return textBox4.Text;
                }

            }
            set
            {
                if (this.tabControl1.SelectedTab == tabPage1)
                {
                    textBox2.Text = value;
                }
                else
                {
                    textBox4.Text = value;
                }
            }
        }
        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get 
            { 
                if(this.tabControl1.SelectedTab == tabPage1)
                {
                    return (int)numericUpDown2.Value;
                }
                else
                {
                    return (int)numericUpDown6.Value;
                }
                
            }
            set 
            {
                if (this.tabControl1.SelectedTab == tabPage1)
                {
                    numericUpDown2.Value = value;
                }
                else
                {
                    numericUpDown6.Value = value;
                }
            }
        }
        public int InvNumber // Инвентарный номер
        {
            get
            {
                if (this.tabControl1.SelectedTab == tabPage1)
                {
                    return (int)numericUpDown3.Value;
                }
                else
                {
                    return (int)numericUpDown7.Value;
                }

            }
            set
            {
                if (this.tabControl1.SelectedTab == tabPage1)
                {
                    numericUpDown3.Value = value;
                }
                else
                {
                    numericUpDown7.Value = value;
                }
            }
        }
        public int PeriodUse // Период использования
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        public bool Existence // Наличие
        {
            get
            {
                if (this.tabControl1.SelectedTab == tabPage1)
                {
                    return checkBox1.Checked;
                }
                else
                {
                    return checkBox4.Checked;
                }

            }
            set
            {
                if (this.tabControl1.SelectedTab == tabPage1)
                {
                    checkBox1.Checked = value;
                }
                else
                {
                    checkBox4.Checked = value;
                }
            }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get
            {
                if (this.tabControl1.SelectedTab == tabPage1)
                {
                    return checkBox3.Checked;
                }
                else
                {
                    return checkBox6.Checked;
                }

            }
            set
            {
                if (this.tabControl1.SelectedTab == tabPage1)
                {
                    checkBox3.Checked = value;
                }
                else
                {
                    checkBox6.Checked = value;
                }
            }
        }
        public string Volume
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public int Number
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        public bool Subscription
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse,
            Page, Year, InvNumber, Existence);
            
            if (ReturnTime)
                b.ReturnSrok();
            
            b.PriceBook(PeriodUse);

            its.Add(b);

            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2000;
            Existence = ReturnTime = false;
        }
          
        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            if (this.tabControl1.SelectedTab == tabPage1)
            {
                richTextBox1.Text = sb.ToString();
            }
            else { richTextBox2.Text = sb.ToString(); }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(Volume, Number, Title, Year, InvNumber, Existence);

            if (Subscription)
                m.Subs();

            its.Add(m);

            Volume = Title = "";
            InvNumber = Number = 0;
            Year = 2000;
            Existence = ReturnTime = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
    }
}
