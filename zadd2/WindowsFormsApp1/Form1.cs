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


            if (radioMala.Checked == true)
            {
                this.textBox1.Font = new System.Drawing.Font("Segoe UI", 5, FontStyle.Regular);
            }
          
            else if (radDuza.Checked == true)
            {
                this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15, FontStyle.Regular);
            }

            else if (radBardzoDuza.Checked == true)
            {
               this.textBox1.Font = new System.Drawing.Font("Segoe UI", 30, FontStyle.Regular);
               
            }

            if (radCzerwony.Checked == true)
            {
                this.textBox1.ForeColor = Color.Red;
            }

            if (radNiebieski.Checked == true)
            {
                this.textBox1.ForeColor = Color.Blue;
            }

            if (radPomaranczowy.Checked == true)
            {
                this.textBox1.ForeColor = Color.Orange;
            }

            if (radPogrubiona.Checked == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }

            if (radPochylona.Checked == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }

            if (radPodkreslona.Checked == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            }

        }

    }
}
