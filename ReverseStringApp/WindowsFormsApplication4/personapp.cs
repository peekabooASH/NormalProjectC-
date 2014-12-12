using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class personapp
    {
        public string firstname;
        public string middlename;
        public string lastname;

        public string Getfullname()
        {
            return firstname +" " + middlename+" " + lastname;
        }

        public string Getfullreversename()
        {
            string fullname = Getfullname();
            char[] cArray = fullname.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;

        }
    }
}
