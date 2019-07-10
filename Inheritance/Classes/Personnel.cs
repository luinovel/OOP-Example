using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    /// <summary>
    /// All personnel in a play
    /// </summary>
    public abstract class Personnel
    {
        private TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        // Private variables allow encapsulation!
        private string _lastName;
        private string _firstName;
        private int _age;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = ti.ToTitleCase(value);
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = ti.ToTitleCase(value);
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                else
                {
                    _age = 0;
                };
            }
        }
    }
}
