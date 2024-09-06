using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elarcosa_Prog2_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            quantity.Text = string.Empty;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void product1_Click(object sender, EventArgs e) //DOGS
        {
            variation1.Text = "Dalmatian";
            variation2.Text = "Bulldog";
            variation3.Text = "Chihuahua";
            pricevar1.Text = "7500.00";
            pricevar2.Text = "5000.00";
            pricevar3.Text = "3000.00";
            chosenproductimage.Image = Elarcosa_Prog2_POS.Properties.Resources.dog;
            chosenproductname.Text = name1.Text;
            variation1.Checked = false;
            variation2.Checked = false;
            variation3.Checked = false;
            quantity.Text = string.Empty;
        }

        private void product2_Click(object sender, EventArgs e) //REPTILES
        {
            variation1.Text = "Iguana";
            variation2.Text = "Gecko";
            variation3.Text = "Chameleon";
            pricevar1.Text = "3400.00";
            pricevar2.Text = "2000.00";
            pricevar3.Text = "3000.00";
            chosenproductimage.Image = Elarcosa_Prog2_POS.Properties.Resources.reptile;
            chosenproductname.Text = name2.Text;
            variation1.Checked = false;
            variation2.Checked = false;
            variation3.Checked = false;
            quantity.Text = string.Empty;
        }

        private void product3_Click(object sender, EventArgs e) //BIRDS
        {
            variation1.Text = "Parrot";
            variation2.Text = "Love Birds";
            variation3.Text = "Cockatoo";
            pricevar1.Text = "10250.00";
            pricevar2.Text = "2620.00";
            pricevar3.Text = "8095.00";
            chosenproductimage.Image = Elarcosa_Prog2_POS.Properties.Resources.bird;
            chosenproductname.Text = name3.Text;
            variation1.Checked = false;
            variation2.Checked = false;
            variation3.Checked = false;
            quantity.Text = string.Empty;
        }

        private void product4_Click(object sender, EventArgs e) //FISHES
        {
            variation1.Text = "Koi Fish";
            variation2.Text = "Catfish";
            variation3.Text = "Goldfish";
            pricevar1.Text = "2540.50";
            pricevar2.Text = "500.00";
            pricevar3.Text = "150.00";
            chosenproductimage.Image = Elarcosa_Prog2_POS.Properties.Resources.fish;
            chosenproductname.Text = name4.Text;
            variation1.Checked = false;
            variation2.Checked = false;
            variation3.Checked = false;
            quantity.Text = string.Empty;
        }

        private void product5_Click(object sender, EventArgs e) //ALIENS
        {
            variation1.Text = "E.T.";
            variation2.Text = "Predator";
            variation3.Text = "Kokey";
            pricevar1.Text = "9866.00";
            pricevar2.Text = "1000000.00";
            pricevar3.Text = "25.00";
            chosenproductimage.Image = Elarcosa_Prog2_POS.Properties.Resources.alien;
            chosenproductname.Text = name5.Text;
            variation1.Checked = false;
            variation2.Checked = false;
            variation3.Checked = false;
            quantity.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String pName = chosenproductname.Text;
            String pVar = "";
            String pPrice = "";
            if (variation1.Checked) { pVar = variation1.Text; pPrice = pricevar1.Text; }
            else if (variation2.Checked) { pVar = variation2.Text; pPrice = pricevar2.Text; }
            else if (variation3.Checked) { pVar = variation3.Text; pPrice = pricevar3.Text; }
            String qty = quantity.Text;
            Double firstprice = Double.Parse(pPrice);
            int firstquantity = Int32.Parse(qty);
            Double subtotal = firstprice * firstquantity;
            String history = ordersummary.Text;
            ordersummary.Text = history + "\n" + pName + "\t \t" + pVar + "\t \t" + pPrice + "\t \t" + qty + "\t \t" + subtotal;

            Double totalsecond = Double.Parse(totalamount.Text);
            totalsecond += subtotal;
            totalamount.Text = "" + totalsecond;
        }

        private void finish_Click(object sender, EventArgs e)
        {
            Double givenpayment = Double.Parse(payment.Text);
            Double totalthird = Double.Parse(totalamount.Text);
            change.Text = "" + (givenpayment - totalthird);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            chosenproductimage.Image = null;
            chosenproductname.Text = "ANIMAL TYPE";
            variation1.Text = "Variation 1";
            variation2.Text = "Variation 2";
            variation3.Text = "Variation 3";

            pricevar1.Text = "price 1";
            pricevar2.Text = "price 2";
            pricevar3.Text = "price 3";
            ordersummary.Text = string.Empty;

            variation1.Checked = false;
            variation2.Checked = false;
            variation3.Checked = false;
            quantity.Text = string.Empty;
            totalamount.Text = "0.00";
            payment.Text = string.Empty;
            change.Text = "0.00";
        }

        private void variation1_CheckedChanged(object sender, EventArgs e)
        {
            quantity.Text = string.Empty;
        }

        private void variation2_CheckedChanged(object sender, EventArgs e)
        {
            quantity.Text = string.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pricevar1_Click(object sender, EventArgs e)
        {

        }

        private void pricevar2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
