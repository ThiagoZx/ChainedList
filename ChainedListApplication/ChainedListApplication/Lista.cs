using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>

namespace ChainedListApplication {   
	class ChainedList
    {

        #region properties

        private Element _element;
        private int size = 0;

        #endregion

        #region get/set

        public Element element {
            get {
                return _element;
            }
            set {
                _element = value;
            }
        }

        public Element lastElement {
            get {
                return _lastElement ();
            }
        }

        #endregion

        #region functions

        public Element _lastElement () {
            Element temp = element;
            while (temp.Next != null) {
                temp = temp.Next;
            }
            return temp;
        }

        public void addLast (Element e) {

            // I think it's a little bit weird the use of this conditional in here. if the name 
            // of the void is addLast, why would you check for a first? Anyway...

            if (element == null) {
                _element = e;
            } else {
                lastElement.Next = e;
            }
        }

        #endregion

        #region utilities
        public void asString () {
            Element temp = _element;
            while (temp != null) {
                Console.WriteLine (temp.asString ());
                temp = temp.Next;
            }
        }

        public int count () {
            
            Element temp = _element;
            int number = 0;
            
            while (temp != null) {
                number++;
                temp = _element.Next;
            }

            return number;
        }

        #endregion
    }
}
