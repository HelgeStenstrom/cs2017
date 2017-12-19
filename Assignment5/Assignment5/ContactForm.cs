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

        /// <summary>
        /// Flag to handle the closing of the form
        /// </summary>
        private bool _closeForm;

        /// <summary>
        /// Flag used by text changed handler, to determine if the even should be handled.
        /// </summary>
        private bool _skipTextChange = false;

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
        /// Main constructor. to be called with an existing contact.
        /// </summary>
        /// <param name="contact"></param>
        public ContactForm(Contact contact)
        {
            InitializeComponent();
            InitializeGui();

            _originalContact = contact;
            _workContact = new Contact(_originalContact);

            UpdateGuiFromContact();
        }

        /// <summary>
        /// Load values for the combobox.
        /// </summary>
        private void InitializeGui()
        {
            cbxCountry.DataSource = Address.GetAllCountryStrings();
            _closeForm = true; 
        }

        /// <summary>
        /// Enable or disable the OK button, depending on if the current contact is valid or not.
        /// </summary>
        private void enableOkButtonIfValid()
        {
            if (_workContact.IsValid)
            {
                btnOK.Enabled = true;
            }
            else
                btnOK.Enabled = false;
        }

        /// <summary>
        /// Fill the GUI with data from the working contact.
        /// </summary>
        private void UpdateGuiFromContact()
        {
            _skipTextChange = true;
            txtFirstName.Text = _workContact.FirstName;
            txtLastName.Text = _workContact.LastName;
            txtPhoneHome.Text = _workContact.Phone.Home;
            txtPhoneCell.Text = _workContact.Phone.Work;
            txtEmailBusiness.Text = _workContact.Email.Work;
            txtEmailPrivate.Text = _workContact.Email.Personal;
            txtStreet.Text = _workContact.Address.StreetAddress;
            txtCity.Text = _workContact.Address.City;
            txtZip.Text = _workContact.Address.Zip;

            cbxCountry.SelectedIndex = (int)_workContact.Address.Country;

            // Check if the OK button can be activated
            enableOkButtonIfValid();
            _skipTextChange = false;
        }

        /// <summary>
        /// Update the working contact from the GUI.
        /// </summary>
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

        /// <summary>
        /// Return from the contact form. 
        /// If successful, copy the work contact to the original contact that the form was called with.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                _closeForm = true;

            }
            else
                _closeForm = false;
        }

        
        /// <summary>
        /// Cancel the contact form. 
        /// If Cancel was issued by mistake, the user is given a chanse to continue editing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// When any of Name, City or Country is changed, we need to check if the 
        /// Contact is valid, i.e., if the OK button can be activated.
        /// </summary>
        private void ValidationFields_changed(object sender, EventArgs e)
        {
            if (_skipTextChange) return;
            ReadContactFromGui();
            enableOkButtonIfValid();
        }

        /// <summary>
        /// Called by event when the form is going to be closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_closeForm)
                e.Cancel = false; // Close this form
            else
                e.Cancel = true; // Do not close (user has chosen Cancel)
        }
    }
}
