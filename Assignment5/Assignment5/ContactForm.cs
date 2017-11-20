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
        private readonly Contact _originalContact;

        public ContactForm()
        {
            InitializeComponent();
            InitializeGui();
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
            cbxCountry.DataSource = Enum.GetValues(typeof(Countries));
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
            txtZip.Text = _workContact.Address.Zip;
            cbxCountry.SelectedItem = _workContact.Address.Country;
           
            // throw new NotImplementedException();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
