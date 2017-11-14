namespace Assignment5.ContactFiles
{
	public class Email
	{
		//private email
		//work mail

		/// <summary>
		/// Default constructor - calls another constructor in this class
		/// </summary>
		/// <remarks></remarks>
		public Email()
		{
			// TODO: make call to other constructor
		}

		/// <summary>
		/// Constructor with one parameter - calls the constructor with
		/// two parameters, using a default value as the second argument.
		/// </summary>
		/// <param name="workMail">input coming from the client object</param>
		/// <remarks></remarks>
		public Email(string workMail) : this(workMail, string.Empty)
		{
			// TODO: call constructor
		}

		/// <summary>
		/// Constructor with two parameters. This is  constructor that has most
		/// number of parameters. It is in this constructor that all coding
		/// should be done.
		/// </summary>
		/// <param name="workMail">Input - office mail</param>
		/// <param name="personalMail">Input - private mail</param>
		/// <remarks></remarks>
		public Email(string workMail, string personalMail)
		{
			Work = workMail;
			Personal = personalMail;
		}

		/// <summary>
		/// Property related to the field m_Personal
		/// Both read and write access
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		/// <remarks></remarks>
		public string Personal
		{
			//private mail
			get;
			set;
		}

		/// <summary>
		/// Property related to m_work field
		/// Both read and write access
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		/// <remarks></remarks>
		public string Work { get; set; }

		/// <summary>
		/// This method prepares a format string that is in sync with the ToString
		/// method.  It will be used in the MainForm as part of the heading for the ListBox
		/// before customer information is added in the ListBox.
		/// </summary>
		/// <value></value>
		/// <returns>A formatted string as heading for the values formatted in the ToString
		/// method below.</returns>
		/// <remarks></remarks>
		public string GetToStringItemsHeadings
		{
			get { return $"{"Office Email",-20} {"Private Email",-20}"; }
		}

		/// <summary>
		/// Delivers a formatted string with data stored in the object. The values will
		/// appear as columns.  Make sure that a font like "Courier New" is used in
		/// the control displaying this information.
		/// </summary>
		/// <returns>the Formatted strings.</returns>
		/// <remarks></remarks> 1
		public override string ToString()
		{
			var strOut = $"{Work,-20} {Personal,-20}";
			return strOut;
		}
	}
}