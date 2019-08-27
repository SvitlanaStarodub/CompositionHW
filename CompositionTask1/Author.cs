using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionHW
{
    public class Author
    {
        public string _name;
        public string _lastName;

        public Author(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }

        public string Name
        {
            get {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            private set
            {
                _lastName = value;
            }
        }

        public override string ToString()
        {
            string fullName = _name + " " + _lastName;
            return fullName;
        }
    }
}
