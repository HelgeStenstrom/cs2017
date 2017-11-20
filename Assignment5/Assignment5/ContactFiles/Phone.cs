// Helge Stenström
// ah7875

namespace Assignment5.ContactFiles
{
    public class Phone
    {
        #region Properties
        public string Home { get; set; }
        public string Work { get; set; }
        #endregion

        #region Constructors
        public Phone()
        {
            DefaultValues();
        }

        public Phone(Phone theOther)
        {
            Home = theOther.Home;
            Work = theOther.Work;
        }

        public Phone(string homePhone, string workPhone)
        {
            Home = homePhone;
            Work = workPhone;
        }
        #endregion

        public override string ToString()
        {
            return $"Phones: Home: {Home}, Work: {Work}";
        }

        public void DefaultValues()
        {
            Home = string.Empty;
            Work = string.Empty;
        }
    }
}