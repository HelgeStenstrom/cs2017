// Helge Stenström
// ah7875


using System;
using System.Windows.Forms;
using Assignment5.ContactFiles;

namespace Assignment5
{
    public partial class ContactForm : Form
    {
        /// <summary>
        /// The contact that the form methods work with.
        /// </summary>
        private Contact _workContact;

        /// <summary>
        /// The contact that the form class is created with, coming from the caller.
        /// </summary>
        private Contact _originalContact;

        // Flag to handle the closing of the form
        private bool _closeForm;

        /// <summary>
        /// The contact that the form methods work with. 
        /// When the form exits with OK, it will contain data that is OK.
        /// </summary>
        public Contact WorkContact
        {
            get => _workContact;
            set
            {
                if (value != null)
                    _workContact = value;
                else
                    throw new Exception("You must not set contact as null!");
                UpdateGuiFromContact();
            }
        }

        /// <summary>
        /// Default constructor, will likely not be used.
        /// </summary>
        public ContactForm(): this(new Contact())
        {
        }

        /// <summary>
        /// Main constructor. to be called with an existing contact.
        /// </summary>
        /// <param name="contact"></param>
        public ContactForm(Contact contact)
        {
            InitializeComponent();
            
            _originalContact = contact;
            _workContact = new Contact();

            InitializeGui();

            UpdateGuiFromContact();
        }

        private void InitializeGui()
        {
            cbxCountry.DataSource = Address.GetAllCountryStrings();
            _closeForm = true;
        }

        private void activateButtons()
        {
            if (_workContact.IsValid)
            {
                btnOK.Enabled = true;
            }
            else
                btnOK.Enabled = false;
        }

        private void UpdateGuiFromContact()
        {
            txtFirstName.Text = _workContact.FirstName;
            txtLastName.Text = _workContact.LastName;
            txtPhoneHome.Text = _workContact.Phone.Home;
            txtPhoneCell.Text = _workContact.Phone.Work;
            txtEmailBusiness.Text = _workContact.Email.Work;
            txtEmailPrivate.Text = _workContact.Email.Personal;
            txtStreet.Text = _workContact.Address.StreetAddress;
            txtCity.Text = _workContact.Address.City;
            txtZip.Text = _workContact.Address.Zip;
            cbxCountry.SelectedItem = _workContact.Address.Country;

            activateButtons();
        }

        private void ReadContactFromGui()
        {
            _workContact.FirstName = txtFirstName.Text;
            _workContact.LastName = txtLastName.Text;
            _workContact.Phone.Home = txtPhoneHome.Text;
            _workContact.Phone.Work = txtPhoneCell.Text;
            _workContact.Email.Work = txtEmailBusiness.Text;
            _workContact.Email.Personal = txtEmailPrivate.Text;
            _workContact.Address.StreetAddress = txtStreet.Text;
            _workContact.Address.City = txtCity.Text;
            _workContact.Address.Zip = txtZip.Text;
            _workContact.Address.Country = (Countries) cbxCountry.SelectedIndex;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            ReadContactFromGui();
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(_workContact.ToString(), 
                "Check your contact",
                buttons);

            if (result == DialogResult.OK)
            {
                _originalContact = _workContact;
                //_contact = new Contact();
                _closeForm = true;
                // throw new NotImplementedException();
            }
            else
                _closeForm = false;
            // throw new NotImplementedException();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            // Hjälpfilen, stycke 8.5
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Discard all data?",
                "Think twice!", buttons);

            if (result == DialogResult.Yes)
                _closeForm = true;
            else
                _closeForm = false;
//            throw new NotImplementedException();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ReadContactFromGui();
            UpdateGuiFromContact();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ReadContactFromGui();
            UpdateGuiFromContact();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            ReadContactFromGui();
            UpdateGuiFromContact();
        }

        private void cbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadContactFromGui();
            UpdateGuiFromContact();
        }

        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_closeForm)
                e.Cancel = false; // Close this form
            else
                e.Cancel = true; // Do not close (user has chosen Cancel)
        }
    }
}
