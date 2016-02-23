using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainedListApplication
{
    public partial class Form1 : Form
    {
        public Form1 () {
            InitializeComponent ();
        }


        Element Thiago = new Element ("Thiago", 17, 'M');
        Element Saulo = new Element ("Saulo", 26, 'M');
        Element Luiza = new Element ("Luiza", 18, 'F');

        private void button1_Click (object sender, EventArgs e) {
            ChainedList lista = new ChainedList ();
            lista.addLast (Thiago);
            lista.addLast (Saulo);
            lista.asString ();
            lista.changePos (Thiago, Saulo);
            lista.asString ();
            lista.addAtPostion (Luiza, 1);
            lista.asString ();
            lista.removeElement (0);
            lista.asString ();
            Element Matheus = new Element("nefwio", 78, 'j');
            lista.addAfterElement (Matheus, Luiza.asString ());
            lista.asString ();
        }

        

    }
}
