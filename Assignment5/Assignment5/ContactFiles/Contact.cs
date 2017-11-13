using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerRegistry.ContactFiles
{
    public class Contact
    {
        public int FullName
        {
            get => default(int);
            set
            {
            }
        }

        public int FullMailAddress
        {
            get => default(int);
            set
            {
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}