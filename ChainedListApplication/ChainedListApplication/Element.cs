using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>

namespace ChainedListApplication {
    class Element {
        
        #region properties 

        private Element next;

        private string name;
        private int age;
        private char sex;

        private Element previous;

        #endregion

        #region getter's/setter's
        public string Name {
            get {
                return Name;
            }
            set {
                Name = value;
            }
        }


        public int Age {
            get {
                return Age;
            }
            set {
                Age = value;
            }
        }

        public char Sex {
            get {
                return Sex;
            }
            set {
                Sex = value;
            }
        }

        public Element Next {
            get {
                return Next;
            }
            set {
                Next = value;
            }
        }

        public Element Previous {
            get {
                return Previous;
            }
            set {
                Previous = value;
            }
        }

        #endregion

        #region constructors
        public Element(string name, int age, char sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Next = null;
            Previous = null;
        }

        public Element(string name, int age, char sex, Element n = null)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Next = n;
            Previous = null;
        }

        public Element(string name, int age, char sex, Element n = null, Element p = null) 
        {
            Name = name;
            Age = age;
            Sex = sex;
            Next = n;
            Previous = p;
        }

        #endregion
        
    }
}
