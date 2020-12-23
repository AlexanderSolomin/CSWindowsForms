﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace ITMO.CSWindowsForms.Lab4._2.EditPerson
{
    public partial class Form1 : Form
    {
        List<Person> pers = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();

            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            pers.Add(p);
            personsListView.VirtualListSize = pers.Count;
            personsListView.Invalidate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedIndices.Count == 0)
                return;
            Person p = pers[personsListView.SelectedIndices[0]];
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                personsListView.Invalidate();
            }
        }

        private void personsListView_RetrieveVirtualItem_1(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                StringBuilder sb = new StringBuilder();
                foreach (Person item in pers)
                {
                    sb.Append("Сотрудник: \n" + item.ToString());
                }
                richTextBox1.Text = sb.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                //BinaryFormatter binFormat = new BinaryFormatter();
                //using (FileStream fStream = new FileStream("AllMyPerson.dat",
                //FileMode.Create, FileAccess.Write, FileShare.None))
                //{
                //    binFormat.Serialize(fStream, pers);
                //}
                using (FileStream fStream = new FileStream("PersonCollection.xml",
                    FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    XmlSerializer xmlFormat = new
                    XmlSerializer(typeof(List<Person>));
                    xmlFormat.Serialize(fStream, pers);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                //BinaryFormatter binFormat = new BinaryFormatter();
                //try
                //{
                //    using (FileStream fStream = new FileStream("AllMyPerson.dat",
                //    FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                //    {
                //        pers.AddRange((List<Person>)binFormat.Deserialize(fStream));
                //    }
                //}
                //catch
                //{ }
            }
        }
    }
}
