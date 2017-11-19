﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeGui()
        {
            InitializeListView();

        }

        private void InitializeListView()
        {
            listView1.Items.Clear();

            ListViewItem item1 = new ListViewItem(new string [] { "100", "Nisse", "gatan 2"});
            ListViewItem item2 = new ListViewItem(new string[] { "101", "Anna", "Vägen 3" });
            ListViewItem item3 = new ListViewItem("103");
            item3.SubItems.Add("Oskar");
            item3.SubItems.Add("Gränden 4");
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);

            string[] row1 = { "Ett 111", "Två", "Tre", "Fyra" };
            string[] row2 = { "1", "2", "3", "4" };
            var listViewItem = new ListViewItem(row1);
            listView1.Items.Add(listViewItem);
            var lvi2 = new ListViewItem();
            lvi2.SubItems.Add("Einz");
            lvi2.SubItems.Add("Zwei");
            lvi2.SubItems.Add("Drei");
            lvi2.SubItems.Add("Vier");
            listView1.Items.Add(lvi2);
            listView1.Items.Add(new ListViewItem(row2));
            // throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGui();
        }
    }
}
