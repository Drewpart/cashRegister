using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
namespace cashRegister
{
    public partial class drewsShoes : Form
    {
        
        double forcesPrice = 120;

        double magsPrice = 150;

        double jordansPrice = 200;
      

        public drewsShoes()
        {

            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            int forces = Convert.ToInt32(airForceInput.Text);
            double mags = Convert.ToDouble(airMagsInput.Text);
            double jordans = Convert.ToDouble(jordansInput.Text);

            double totalForce = forces * forcesPrice;
            double totalMags = mags * magsPrice;
            double totalJordans = jordans * jordansPrice;
            double subTotal = totalForce + totalMags + totalJordans;
            double taxrate = 0.13;
            double total = subTotal * (1 + taxrate);
            double taxAmmount = total - subTotal;

            // making it calculate the total and taxes
            subTotalLabel.Text = $"Sub Total: {subTotal.ToString("0.00")}";
            totalLabel.Text = $"Total: {total.ToString("0.00")}";
            taxLabel.Text = $" Tax: {taxAmmount.ToString("0.00")}";
            welcomeLabel.Text = $"ah, good choice!";
            






        }

        private void changeButton_Click(object sender, EventArgs e)
        {

            int forces = Convert.ToInt32(airForceInput.Text);
            double mags = Convert.ToDouble(airMagsInput.Text);
            double jordans = Convert.ToDouble(jordansInput.Text);

            double totalForce = forces * forcesPrice;
            double totalMags = mags * magsPrice;
            double totalJordans = jordans * jordansPrice;
            double subTotal = totalForce + totalMags + totalJordans;
            double taxrate = 0.13;
            double total = subTotal * (1 + taxrate);
            double taxAmmount = total - subTotal;
            double tendered = Convert.ToDouble(tenderedInput.Text);
            double change = tendered - total;

            // calculating change
            changeLabel.Text = $"Change: {change.ToString("0.00")}";
            welcomeLabel.Text = $"Your change will be ${change.ToString("0.00")}";
            welcomeLabel.Text = $"Would you like a copy of the Receipt?";
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            int forces = Convert.ToInt32(airForceInput.Text);
            double mags = Convert.ToDouble(airMagsInput.Text);
            double jordans = Convert.ToDouble(jordansInput.Text);

            double totalForce = forces * forcesPrice;
            double totalMags = mags * magsPrice;
            double totalJordans = jordans * jordansPrice;
            double subTotal = totalForce + totalMags + totalJordans;
            double taxrate = 0.13;
            double total = subTotal * (1 + taxrate);
            double taxAmmount = total - subTotal;
            double tendered = Convert.ToDouble(tenderedInput.Text);
            double change = tendered - total;

            //printing the receipt
            receiptLabel.Text = $"         Drews Shoes\n\n order number 5760\n september 29, 2021\n\n Air Forces x{forces}            @{forcesPrice}\n Air Mags x{mags}              @{magsPrice}\n Jordan 4's x{jordans}           @{jordansPrice}\n\n Sub Total:                  {subTotal}\n Tax:                           {taxAmmount.ToString("0.00")}\n Total:                         {total}\n\n Tendered:                  {tendered.ToString("0.00")}\n Change:                     {change.ToString("0.00")}\n\n Have A Great Day!\n Thank you for shopping.";
            
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            int forces = Convert.ToInt32(airForceInput.Text);
            double mags = Convert.ToDouble(airMagsInput.Text);
            double jordans = Convert.ToDouble(jordansInput.Text);

            double totalForce = forces * forcesPrice;
            double totalMags = mags * magsPrice;
            double totalJordans = jordans * jordansPrice;
            double subTotal = totalForce + totalMags + totalJordans;
            double taxrate = 0.13;
            double total = subTotal * (1 + taxrate);
            double taxAmmount = total - subTotal;
            double tendered = Convert.ToDouble(tenderedInput.Text);
            double change = tendered - total;

            // yes button. printing the receipt
            welcomeLabel.Text = $"okay, here you go! Have a great day";
            receiptLabel.Text = $"         Drews Shoes\n\n order number 5760\n september 29, 2021\n\n Air Forces x{forces}            @{forcesPrice}\n Air Mags x{mags}              @{magsPrice}\n Jordan 4's x{jordans}           @{jordansPrice}\n\n Sub Total:                  {subTotal}\n Tax:                           {taxAmmount.ToString("0.00")}\n Total:                         {total}\n\n Tendered:                  {tendered.ToString("0.00")}\n Change:                     {change.ToString("0.00")}\n\n Have A Great Day!\n Thank you for shopping.";
            SoundPlayer receipt = new SoundPlayer(Properties.Resources._202531__kalisemorrison__cash_drawer_and_receipt);
            receipt.Play();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            // if they say no, just say have a good day
            welcomeLabel.Text = $"have a great day:)";
            

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //reseting everything.
            airForceInput.Text = "";
            airMagsInput.Text = "";
            jordansInput.Text = "";
            welcomeLabel.Text = "Welcome!";
            taxLabel.Text = "Tax:";
            totalLabel.Text = "Total:";
            subTotalLabel.Text = "Sub Total:";
            tenderedInput.Text = "";
            receiptLabel.Text = "";
            changeLabel.Text = "Change:";

        
               


        }
    }
}
