// Helge Stenström
// ah7875

using System;
using System.Windows.Forms;
using Assignment5.ContactFiles;

namespace Assignment5
{
    public partial class MainForm : Form
    {
        private CustomerManager customerManager = new CustomerManager();
        public MainForm()
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
            //FillWithExampleData();
        }

        private string[] exampleRowStrings()
        {
            return new string[]
                {
                "IdString",
                    "Name",
                    "Street",
                    "PostalAddres",
                    "Country",
                    "Phone",
                    "Email"
                };
        }
        private void FillWithExampleData()
        {
            // Läsvärt:
            // http://www.c-sharpcorner.com/uploadfile/nipuntomar/sort-a-multicolumn-listview-in-c-sharp/

            ListViewItem item1 = new ListViewItem(new string[] { "100", "Nisse", "gatan 2" });
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

        private void UpdateTable()
        {
            listView1.Items.Clear();
            foreach(Customer customer in customerManager.Customers)
            {
                string[] rowStrings = new string[]
                {
                    customer.IdString,
                    customer.Name,
                    customer.Street,
                    customer.PostalAddres,
                    customer.Country,
                    customer.Phone,
                    customer.Email
                };
                ListViewItem row = new ListViewItem(rowStrings);
                listView1.Items.Add(row);
            }
        }

        private void btnContactForm_Click(object sender, EventArgs e)
        {
            Contact aContact = new Contact();
            ContactForm dlg = new ContactForm(aContact);
            Contact b = dlg.WorkContact;
            DialogResult dialogResult = dlg.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                showTheContact(dlg);
            }
        }

        private static void showTheContact(ContactForm dlg)
        {
            MessageBoxButtons okButton = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(dlg.WorkContact.ToString(),
                "Final result",
                okButton);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Contact aContact = new Contact();
            ContactForm dlg = new ContactForm(aContact);
            Contact b = dlg.WorkContact;
            DialogResult dialogResult = dlg.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                showTheContact(dlg);
                customerManager.AddCustomer(dlg.WorkContact);
                UpdateTable();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                btnDelete.Enabled = true;
                btnChange.Enabled = true;
            } 
            else
            {
                btnDelete.Enabled = false;
                btnChange.Enabled = false;
            }
        }
    }
}
