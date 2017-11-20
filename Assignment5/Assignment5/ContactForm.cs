// Helge Stenström
// ah7875


using System;
using System.Windows.Forms;
using Assignment5.ContactFiles;

namespace Assignment5
{
    public partial class ContactForm : Form
    {
        private readonly Contact _workContact;
        private  Contact _originalContact;

        public ContactForm()
        {
            InitializeComponent();
            _workContact = new Contact();
            _originalContact = _workContact;
            InitializeGui();
            UpdateGuiFromContact();
        }

        public ContactForm(Contact contact)
        {
            InitializeComponent();

            _workContact = contact.DeepClone();
            _originalContact = contact;
            InitializeGui();
            UpdateGuiFromContact();
        }

        private void InitializeGui()
        {
            //cbxCountry.DataSource = Enum.GetValues(typeof(Countries));
            cbxCountry.DataSource = Address.GetAllCountryStrings();
            
        }

        private void UpdateGuiFromContact()
        {
            txtFirstName.Text = _workContact.FirstName;
            txtLastName.Text = _workContact.LastName;
            txtPhoneHome.Text = _workContact.Phone.Home;
            txtPhoneCell.Text = _workContact.Phone.Work;
            txtEmailBusiness.Text = _workContact.Email.Work;
            txtEmailPrivate.Text = _workContact.Email.Personal;
            txtStreet.Text = _workContact.Address.Street;
            txtCity.Text = _workContact.Address.City;
            txtZip.Text = _workContact.Address.Zip;
            cbxCountry.SelectedItem = _workContact.Address.Country;           
        }

        private void ReadContactFromGui()
        {
            _workContact.FirstName = txtFirstName.Text;
            _workContact.LastName = txtLastName.Text;
            _workContact.Phone.Home = txtPhoneHome.Text;
            _workContact.Phone.Work = txtPhoneCell.Text;
            _workContact.Email.Work = txtEmailBusiness.Text;
            _workContact.Email.Personal = txtEmailPrivate.Text;
            _workContact.Address.Street = txtStreet.Text;
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
            }
            throw new NotImplementedException();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
