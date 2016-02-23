using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                while (temp.Next != null) {
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

        public void addLast (Element e) {

            if (element == null) {
                _element = e;
            } else {
                lastElement.Next = e;
            }
        }

        public void addAtPostion (Element e, int position) {
            if (position < this.count ()) {

                Element temp = element;
                int aux = 0;

                if (temp == null) {
                    _element = e;
                } else {
                
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
            } else {
                Console.WriteLine ("Hey Buddy, That's a little bigger than our list!");
            }
        }

        public void addAfterElement (Element e, string property) {
            Element temp = element;
            int aux = 0;

            if (temp == null) {
                _element = e;
            } else {
                while (temp.Next != null) {
                    if (temp.asString () == property) {

                        Element _temp = this.getElement (aux);
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

        public void changePos (Element e_1, Element e_2) {

            Element temp = element;
            Element aux;

            while (temp.Next != null) {
                if (temp.Next == e_1) {
                    aux = (temp.Next != null) ? temp.Next.Next : null;
                    temp.Next = e_2;
                    temp.Next.Next = aux;
                } else if (temp.Next == e_2) {
                    aux = (temp.Next != null) ? temp.Next.Next : null;
                    temp.Next = e_1;
                    temp.Next.Next = aux;
                }
                temp = temp.Next;
            }
        }

        public void removeElement (string property) {

            Element temp = element;

            if (temp == null) {
                Console.WriteLine ("Sorry but... The list is empty!");
            } else {
                while (temp.Next != null) {
                    if (temp.Next.asString() == property) {
                        temp = temp.Next.Next;
                        Element _temp = temp.Next;
                        _temp = null;
                    } else {
                        temp = temp.Next;
                    }
                }
            }
        }

        public void removeElement (int position) {

            Element temp = element;
            int aux = 0;

            if (temp == null) {
                Console.WriteLine ("Sorry but... The list is empty!");
            } else {
                while (temp.Next != null) {
                    if (aux == position) {
                        temp = temp.Next.Next;
                        Element _temp = temp.Next;
                        _temp = null;
                    } else {
                        temp = temp.Next;
                    }
                    aux++;
                }
            }
        }

        #endregion


        
        #region utilities
        public void asString () {
            Element temp = _element;
            while (temp.Next != null) {
                Console.WriteLine (temp.asString ());
                temp = temp.Next;
            }
        }

        public int count () {
            
            Element temp = _element;
            int number = 0;
            
            while (temp.Next != null) {
                number++;
                temp = _element.Next;
            }

            return number;
        }

        public Element _lastElement () {
            Element temp = element;
            while (temp.Next != null) {
                temp = temp.Next;
            }
            return temp;
        }

        #endregion
    }
}
