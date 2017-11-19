// Helge Stenström
// ah7875

namespace Assignment5.ContactFiles
{
    public class Phone
    {
        #region Properties
        public string Home { get; set; }
        public string Other { get; set; }
        public string Work { get; set; }
        #endregion

        #region Constructors
        public Phone()
        {
            DefaultValues();
        }

        public Phone(string homePhone, string workPhone)
        {
            Home = homePhone;
            Work = workPhone;
            Other = string.Empty;
        }
        #endregion

        public override string ToString()
        {
            return $"Phones: Home: {Home}, Work: {Work}, Other: {Other}";
        }

        public void DefaultValues()
        {
            Home = string.Empty;
            Other = string.Empty;
            Work = string.Empty;
        }
    }
}