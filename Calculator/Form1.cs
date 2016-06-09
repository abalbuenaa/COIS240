using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form

    {
        double fisrtNumber, secondNumber, total;
        string command; //if its multiplication, division etc.


        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {

            lblDesplegar.Text += "1";
        }
            #region buttons

        private void button1_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "4";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblDesplegar.Text += "7";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "3";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "9";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            //si el tipo de ecalculo, comand, es multiply
            if (command == "multiply")
        {
                secondNumber = Convert.ToDouble(lblDesplegar.Text);
                total = fisrtNumber * secondNumber;
                lblDesplegar.Text = total.ToString();
         }
        }

        private void btnErrase_Click(object sender, EventArgs e)
        {
            fisrtNumber = Convert.ToDouble(lblDesplegar.Text);
            lblDesplegar.Text = "";
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            //si el tipo de ecalculo, comand, es add
            if (command == "add")
        {
                secondNumber = Convert.ToDouble(lblDesplegar.Text);
                total = fisrtNumber + secondNumber;
                lblDesplegar.Text = total.ToString();
        }
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(lblDesplegar.Text);
            total = fisrtNumber - secondNumber;
            lblDesplegar.Text = total.ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "0";
            #endregion
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            fisrtNumber = Convert.ToDouble(lblDesplegar.Text);
            lblDesplegar.Text = "";
            command = "multiply";
        }
    }
}
