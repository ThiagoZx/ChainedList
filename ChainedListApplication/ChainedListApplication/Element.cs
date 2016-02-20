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

        private Element _next;

        private string _name;
        private int _age;
        private char _sex;

        private Element _previous;

        #endregion

        #region getter's/setter's
        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }


        public int Age {
            get {
                return _age;
            }
            set {
                _age = value;
            }
        }

        public char Sex {
            get {
                return _sex;
            }
            set {
                _sex = value;
            }
        }

        public Element Next {
            get {
                return _next;
            }
            set {
                _next = value;
            }
        }

        public Element Previous {
            get {
                return _previous;
            }
            set {
                _previous = value;
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

        #region asString

        public string asString () {
            return "Hi! I'm " + Name + ", " + Age + " years old. Sex: " + Sex; 
        }

        #endregion

    }
}
