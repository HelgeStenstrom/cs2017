// Helge Stenström
// ah7875

using System;
using System.Windows.Forms;
using Assignment5.ContactFiles;

namespace Assignment5
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// The main form has a customer manager
        /// </summary>
        private readonly CustomerManager _customerManager = new CustomerManager();
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize the GUI when the form is created.
        /// </summary>
        private void InitializeGui()
        {
            listView1.Items.Clear();
        }

        /// <summary>
        /// When the form is loaded, the GUI is initialized
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGui();
        }

        /// <summary>
        /// Fill the ListVIEW for customers, with data from the customer manager
        /// </summary>
        private void UpdateTable()
        {
            listView1.Items.Clear();
            foreach(var customer in _customerManager.CustomersAsRows)
            {
                // Create a row of the data
                ListViewItem row = new ListViewItem(customer);
                // and add it to the ListView
                listView1.Items.Add(row);
            }
        }



        /// <summary>
        /// Show the data that the ContactForm generated,.
        /// </summary>
        /// <param name="dlg"></param>
        private static void showTheContact(ContactForm dlg)
        {
            MessageBoxButtons okButton = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(dlg.WorkContact.ToString(),
                "Final result",
                okButton);
        }

        
        /// <summary>
        /// When Add is clicked, a ContactForm is created and called.
        /// 
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Contact aContact = new Contact();
            ContactForm dlg = new ContactForm(aContact);
            DialogResult dialogResult = dlg.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                //showTheContact(dlg);  // Activate to show a dialog box
                _customerManager.AddCustomer(dlg.WorkContact);
                UpdateTable();
            }
        }

        /// <summary>
        /// When a row is activated, the Change button is activated.
        /// When it is clicked, the customer manager is called to replace the customer.
        /// with another one.
        /// </summary>
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 1)
            {
                int index = listView1.SelectedIndices[0];
                if (index < _customerManager.Count)
                {
                    var aCustomer = _customerManager.GetCustomer(index);
                    var aContact = aCustomer.Contact;
                    var itsID = aCustomer.Id;


                    ContactForm dlg = new ContactForm(aCustomer.Contact);
                    Contact b = dlg.WorkContact;
                    DialogResult dialogResult = dlg.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        var changedCustomer = new Customer(b, aCustomer.Id);
                        //showTheContact(dlg);  // Activate to show a dialog box
                        _customerManager.ChangeCustomer(changedCustomer, index);
                        UpdateTable();
                    }
                }
            }
        }

        /// <summary>
        /// When a row is activated, the Delete button is activated.
        /// When it is clicked, the customer manager is called to delete the customer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 1)
            {
                int index = listView1.SelectedIndices[0];
                if (index < _customerManager.Count)
                {
                    _customerManager.DeleteCustomer(index);
                    UpdateTable();
                }
            }
        }


        /// <summary>
        /// When there is a row selected, we enable the Delete and Change buttons
        /// </summary>
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
