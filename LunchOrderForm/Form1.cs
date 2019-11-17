using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrderForm
{
    public partial class lunchOrderFrm : Form
    {
        public lunchOrderFrm()
        {
            InitializeComponent();
        }

        private void HamburgerRdo_CheckedChanged(object sender, EventArgs e)
        {
            addOn1Cbx.Text = "Lettuce, tomato, and onions";
            addOn2Cbx.Text = "Ketchup, mustard, and mayo";
            addOn3Cbx.Text = "French Fries";
            ClearCheckBoxes();
        }

        private void PizzaRdo_CheckedChanged(object sender, EventArgs e)
        {
            addOn1Cbx.Text = "Pepperoni";
            addOn2Cbx.Text = "Sausage";
            addOn3Cbx.Text = "Olives";
            ClearCheckBoxes();
        }

        private void SaladRdo_CheckedChanged(object sender, EventArgs e)
        {
            addOn1Cbx.Text = "Croutons";
            addOn2Cbx.Text = "Bacon Bits";
            addOn3Cbx.Text = "Bread Sticks";
            ClearCheckBoxes();
        }

        private void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            double subtotal = GetSubtotal();
            double tax = GetTax(subtotal);
            double total = GetTotal(subtotal, tax);

            DisplayResults(subtotal, tax, total);
        }

        private double GetSubtotal()
        {
            double mainCourse;
            double addOnTotal = 0;

            if(hamburgerRdo.Checked == true)
            {
                mainCourse = 6.95;
            }
            else if(pizzaRdo.Checked == true)
            {
                mainCourse = 5.95;
            }
            else
            {
                mainCourse = 4.95;
            }

            if (addOn1Cbx.Checked == true)
            {
                addOnTotal += .75;
            }
            if (addOn2Cbx.Checked == true)
            {
                addOnTotal += .75;
            }
            if (addOn3Cbx.Checked == true)
            {
                addOnTotal += .75;
            }

            return Math.Round(mainCourse + addOnTotal, 2);
        }

        private double GetTax(double subtotal)
        {
            return Math.Round(subtotal * .0775, 2);
        }

        private double GetTotal(double subtotal, double tax)
        {
            return Math.Round(subtotal + tax, 2);
        } 

        private void DisplayResults(double subtotal, double tax, double total)
        {
            subtotalResultLbl.Text = subtotal.ToString();
            taxResultLbl.Text = tax.ToString();
            orderTotalResultLbl.Text = total.ToString();
        }

        private void ClearTotals(object sender, EventArgs e)
        {
            subtotalResultLbl.Text = "";
            taxResultLbl.Text = "";
            orderTotalResultLbl.Text = "";
        }

        private void ClearCheckBoxes()
        {
            addOn1Cbx.Checked = false;
            addOn2Cbx.Checked = false;
            addOn3Cbx.Checked = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
