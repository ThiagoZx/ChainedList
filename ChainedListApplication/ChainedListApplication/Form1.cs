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
        Element Marco = new Element ("Marco", 17, 'M');

        private void button1_Click (object sender, EventArgs e) {
            ChainedList lista = new ChainedList ();
            lista.addLast (Thiago);
            lista.addLast (Saulo);
            lista.addLast (Marco);
            lista.addAfterElement (Luiza, Marco.asString());
            lista.removeElement (Luiza.asString());
            lista.asString ();
            //lista.addAfterElement (Luiza, Thiago.asString());
            //lista.asString ();
            //Console.WriteLine ("Next!");
            //lista.removeElement (0);
            //lista.asString ();
            //Console.WriteLine ("Next!");
            //Element Matheus = new Element("nefwio", 78, 'j');
            //lista.addAfterElement (Matheus, Luiza.asString ());
            //lista.asString ();
            //Console.WriteLine ("Done");
        }

        

    }
}
