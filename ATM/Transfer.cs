using MySql.Data.MySqlClient;
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
    public partial class Transfer : Form
    {
        private String ty;
        private String an;
        private String toa;
        private String amount;
        private double balance;
        public Transfer(string accType, string acNum, string toA)
        {
            InitializeComponent();
            toa = toA;
            an = acNum;
            ty = accType;
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            amount = "";

            Transactions transactions = new Transactions(an);
            balance = transactions.CheckBalance();

            accountLabel.Text = ty + " - " + an;

            Console.WriteLine(ty);

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
                errorMessage.Text = "Maximum transfer amount is $3,000";
                errorMessage.Location = new Point(305, 205);
                errorMessage.Visible = true;
                Console.WriteLine((errorMessage.Width / 2) - (this.Width / 2));
                amount = "";
                pinNumberTextBox.Text = amount;
            }
            else if (Convert.ToDouble(amount) < 5)
            {
                errorMessage.Text = "Minimum transfer amount is $5";
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
                transaction.Transfer(Convert.ToDouble(amount), toa, an);

                balance = transaction.CheckBalance();

                string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                string sql2 = "SELECT cardNum FROM lyonsaccountinfo WHERE accountNum = '" + an + "';";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                String cn = (String)cmd2.ExecuteScalar();

                ThankYou thank = new ThankYou(balance, cn);
                conn.Close();
                this.Close();
                thank.Show();
            }
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            amount = "";
            balance = 0.0;

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();
            string sql2 = "SELECT cardNum FROM lyonsaccountinfo WHERE accountNum = '" + an + "';";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            String cn = (String)cmd2.ExecuteScalar();

            AccountSelectionScreen account = new AccountSelectionScreen(cn, "transfer");
            this.Close();
            account.Show();
        }
    }
}
