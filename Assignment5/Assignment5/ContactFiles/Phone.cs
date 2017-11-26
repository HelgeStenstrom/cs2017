// Helge Stenström 2017
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
        /// <summary>
        /// Default constructor generates an empty Phone instance. Not very useful.
        /// </summary>
        public Phone()
        {
            SetToDefaultValues();
        }

        /// <summary>
        ///  Copy constructor.
        /// </summary>
        /// <param name="theOther"></param>
        public Phone(Phone theOther)
        {
            Home = theOther.Home;
            Work = theOther.Work;
        }

        /// <summary>
        /// Constructor with full argument list.
        /// Store the given numbers as object attributes.
        /// </summary>
        /// <param name="homePhone"></param>
        /// <param name="workPhone"></param>
        public Phone(string homePhone, string workPhone)
        {
            Home = homePhone;
            Work = workPhone;
        }
        #endregion

        /// <summary>
        /// Returns the phone numbers as a string. 
        /// No special treatment of empty phone numbers.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Phones: Home: {Home}, Work: {Work}";
        }

        /// <summary>
        /// Set the current object to default (empty) phone numbers.
        /// </summary>
        public void SetToDefaultValues()
        {
            Home = string.Empty;
            Work = string.Empty;
        }
    }
}