using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraLib;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ModelGry gra;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosowanie.Visible = true;
            buttonNowaGra.Enabled = false;
            buttonPoddaj.Visible = true;
                    }

        private void buttonPoddaj_Click(object sender, EventArgs e)
        {
            buttonPoddaj.Visible = false;
            buttonNowaGra.Enabled = true;
        }
 
        private void buttonLosuj_Click(object sender, EventArgs e)
        {

            int x =int.Parse(textBoxOd.Text);
            int y= int.Parse(textBoxDo.Text);

            groupBoxLosowanie.Enabled = false;
            groupBoxOdgadywanie.Visible = true;
           
            gra = new ModelGry(x,y);
        }

    }
}
