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

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private ModelGry gra;

        public Form1()
        {
            InitializeComponent();
            buttonLosuj.Enabled = false;
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
            int x;
            try
            {
                x = int.Parse(textBoxOd.Text);                
            }
            catch(FormatException)
            {
                textBoxOd.BackColor = Color.Red;
                return;
            }
            textBoxOd.BackColor = Color.White;

            int y = int.Parse(textBoxDo.Text);

            groupBoxLosowanie.Enabled = false;
            groupBoxOdgadywanie.Visible = true;


            gra = new ModelGry(x, y);
           
        }

        private bool blokada()
        {
            int wynik1, wynik2;
            if (int.TryParse(textBoxDo.Text, out wynik1)
                &&
                int.TryParse(textBoxOd.Text, out wynik2))
                return true;
            else
                return false;
        }
        

        private void textBoxDo_TextChanged(object sender, EventArgs e)
        {
            int wynik;
            if (int.TryParse(textBoxDo.Text, out wynik))
            {
                textBoxDo.BackColor = Color.LightGreen;
            }
            else
            {
                textBoxDo.BackColor = Color.LightPink;
            }
            buttonLosuj.Enabled = blokada();
        }

        private void textBoxOd_TextChanged(object sender, EventArgs e)
        {
            int wynik;
            if (int.TryParse(textBoxOd.Text, out wynik))
            {
                textBoxOd.BackColor = Color.LightGreen;
            }
            else
            {
                textBoxOd.BackColor = Color.LightPink;
            }
            buttonLosuj.Enabled = blokada();
        }
    }
}
