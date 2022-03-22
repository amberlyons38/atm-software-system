using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Deposit : Form
    {
        private String amount;
        private String t;
        private String an;
        private String cardn;
        private double balance;
        public Deposit(string accType, string acNum, string cn)
        {
            InitializeComponent();
            t = accType;
            Console.WriteLine(t);
            cardn = cn;
            Console.WriteLine(cardn);
            an = acNum;
            Console.WriteLine(an);
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            amount = "";

            Transactions transactions = new Transactions(an);
            balance = transactions.CheckBalance();

            accountLabel.Text = t + " - " + an;

            Console.WriteLine(t);

            String b = "$" + balance;
            Console.WriteLine(b);
            if (b.Substring(b.IndexOf(".")).Length < 3)
            {
                b = b + "0";
            }

            balanceLabel.Text = "Balance: " + b;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (amount.Length < 4)
            {
                amount = amount + 0;
            }
            pinNumberTextBox.Text = amount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (amount.Length < 4)
            {
                amount = amount + 1;
            }
            pinNumberTextBox.Text = amount;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (amount.Length < 4)
            {
                amount = amount + 2;
            }
            pinNumberTextBox.Text = amount;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (amount.Length < 4)
            {
                amount = amount + 3;
            }
            pinNumberTextBox.Text = amount;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (amount.Length < 4)
            {
                amount = amount + 4;
            }
            pinNumberTextBox.Text = amount;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (amount.Length < 4)
            {
                amount = amount + 5;
            }
            pinNumberTextBox.Text = amount;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (amount.Length < 4)
            {
                amount = amount + 6;
            }
            pinNumberTextBox.Text = amount;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (amount.Length < 4)
            {
                amount = amount + 7;
            }
            pinNumberTextBox.Text = amount;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (amount.Length < 4)
            {
                amount = amount + 8;
            }
            pinNumberTextBox.Text = amount;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (amount.Length < 4)
            {
                amount = amount + 9;
            }
            pinNumberTextBox.Text = amount;
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            if (amount.Length > 0)
            {
                amount = amount.Substring(0, amount.Length - 1);
                pinNumberTextBox.Text = amount;
            }
            errorMessage.Visible = false;
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            amount = "";
            pinNumberTextBox.Text = "";
            errorMessage.Visible = false;
        }
        private void buttonenter_Click(object sender, EventArgs e)
        {
            errorMessage.Visible = false;

            Console.WriteLine(Convert.ToDouble(amount));

            if (Convert.ToDouble(amount) > 3000)
            {
                errorMessage.Text = "Maximum deposit amount is $3,000";
                errorMessage.Location = new Point(305, 205);
                errorMessage.Visible = true;
                Console.WriteLine((errorMessage.Width / 2) - (this.Width / 2));
                amount = "";
                pinNumberTextBox.Text = amount;
            }
            else if (Convert.ToDouble(amount) < 5)
            {
                errorMessage.Text = "Minimum deposit amount is $5";
                Console.WriteLine((errorMessage.Width / 2) - (this.Width / 2));
                errorMessage.Location = new Point(327, 205);
                errorMessage.Visible = true;
                amount = "";
                pinNumberTextBox.Text = amount;
            }
            else
            {
                errorMessage.Visible = false;

                Transactions transaction = new Transactions(an);
                transaction.Deposit(Convert.ToDouble(amount));

                balance = transaction.CheckBalance();

                ThankYou thank = new ThankYou(balance, cardn);
                this.Close();
                thank.Show();
            }
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            amount = "";
            balance = 0.0;

            AccountSelectionScreen account = new AccountSelectionScreen(cardn, "deposit");
            this.Close();
            account.Show();
        }
    }
}
