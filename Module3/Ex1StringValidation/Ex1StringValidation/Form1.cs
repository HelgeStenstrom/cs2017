using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex1StringValidation
{
    public partial class Form1 : Form
    {
        private string name;
        public Form1()
        {
            InitializeComponent();
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(String.Format("namn: {0}.", name));
            if (isOk(name))
                MessageBox.Show("Welcome " + name.ToUpper(), "Message");
            else
                MessageBox.Show("Please try to remember your name!", "Error");
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            name = NameBox.Text.Trim();
            Console.WriteLine(String.Format("NameBox_TextChanged name: {0}.", name));
        }

        private static bool isOk(string str)
        {
            return (!string.IsNullOrEmpty(str));
        }

        private void prompt_Click(object sender, EventArgs e)
        {

        }


    }
}
