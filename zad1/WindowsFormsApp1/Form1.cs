using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double waga = 0;
                float wzrost = float.Parse(textBox1.Text);

                if ((checkStandard.Checked == false) && (checkIdealna.Checked == false))
                {
                    MessageBox.Show(" Zaznacz rodzaj wagi", "Uwaga!", MessageBoxButtons.OK);
                }
                if ((checkStandard.Checked == true) && (checkIdealna.Checked == true))
                {
                    MessageBox.Show(" Mozesz wybrać tylko 1 pole do obliczenia wagi Standarowej / Idealnej", "Uwaga!", MessageBoxButtons.OK);

                }
                else if ((radKobieta.Checked == true) && (checkIdealna.Checked == true))
                {
                    waga = (wzrost - 100) * 0.85;
                    labWynik.Text = "Obliczona waga:" + Convert.ToString(waga) + " kg";
                }

                else if ((radKobieta.Checked == true) && (checkStandard.Checked == true))
                {
                    waga = (wzrost - 100);
                    labWynik.Text = "Obliczona waga:" + Convert.ToString(waga) + " kg";
                }

                else if ((radMezczyzna.Checked == true) && (checkStandard.Checked == true))
                {
                    waga = (wzrost - 100);
                    labWynik.Text = "Obliczona waga:" + Convert.ToString(waga) + " kg";
                }

                else if ((radMezczyzna.Checked == true) && (checkIdealna.Checked == true))
                {
                    waga = (wzrost - 100) * 0.90;
                    labWynik.Text = "Obliczona waga:" + Convert.ToString(waga) + " kg";
                }
             

            }
            catch (Exception) { 
    
                            
                MessageBox.Show("Coś poszło nie tak, podaj ponownie poprawne dane.", "Uwaga!", MessageBoxButtons.OK);
            }
           
                
            
        }
    }
}
