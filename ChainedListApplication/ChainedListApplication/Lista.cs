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

        public Element getElement (int position) {

            Element temp = element;
            int aux = 0;

            if (element == null) {
                return null;
            } else {
                while (temp != null) {
                    if (aux == position) {
                        return temp;
                    } else {
                        temp = temp.Next;
                    }
                    aux++;
                }
            }

            return null;
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

            if (element == null) {
                _element = e;
            } else {
                lastElement.Next = e;
            }
        }

        public void addAt (Element e, int position) {

            Element temp = element;
            int aux = 0;

            if (temp == null) {
                _element = e;
            } else {
                if (position < this.count ()) {
                    while (aux != position) {
                        if (aux == position) {

                            Element _temp = this.getElement (position);
                            temp.Next = e;
                            e.Next = _temp;
                            temp = e;

                        } else {
                            temp = temp.Next;
                        }
                        aux++;
                    }
                }
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
