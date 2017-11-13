using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerRegistry.ContactFiles
{
	public class Email
	{
		//private email
		private string _personal;
		//work mail
		private string _work;

		/// <summary>
		/// Default constructor - calls another constructor in this class
		/// </summary>
		/// <remarks></remarks>
		public Email()
		{
		}

		/// <summary>
		/// Constructor with one parameter - calls the constructor with
		/// two parameters, using a default value as the second argument.
		/// </summary>
		/// <param name="workMail">input coming from the client object</param>
		/// <remarks></remarks>
		public Email(string workMail) : this(workMail, string.Empty)
		{
		}

		/// <summary>
		/// Constructor with two parameters. This is  constructor that has most
		/// number of parameters. It is in tis constructor that all coding
		/// should be done.
		/// </summary>
		/// <param name="workMail">Input - office mail</param>
		/// <param name="personalMail">Input - private mail</param>
		/// <remarks></remarks>
		public Email(string workMail, string personalMail)
		{
			_work = workMail;
			_personal = personalMail;
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
			get { return _personal; }
			set { _personal = value; }
		}

		/// <summary>
		/// Property related to m_work field
		/// Both read and write access
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		/// <remarks></remarks>
		public string Work
		{
			get { return _work; }
			set { _work = value; }
		}

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
			get { return string.Format("{0,-20} {1, -20}", "Office Email", "Private Email"); }
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
			string strOut = string.Format("{0,-20} {1, -20}", _work, _personal);
			return strOut;
		}
	}
}