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
    public partial class AccountSelectionScreen : Form
    {
        private String tran;
        private String cn;
        private String acNum;
        private String accType;
        public AccountSelectionScreen(string cardn, string trans)
        {
            InitializeComponent();
            cn = cardn;
            tran = trans;
        }

        private void AccountSelectionScreen_Load(object sender, EventArgs e)
        {
            acNum = "";

            switch (tran)
            {
                case "withdraw":

                    transactionLabel.Text = "Please choose an account to withdraw from";
                    transactionLabel.Location = new Point(285, 198);
                    break;

                case "deposit":

                    transactionLabel.Text = "Please choose an account to deposit into";
                    transactionLabel.Location = new Point(295, 198);
                    break;

                case "check balance":

                    transactionLabel.Text = "Please choose an account to view the balance of";
                    transactionLabel.Location = new Point(261, 198);
                    break;

                case "transfer":

                    transactionLabel.Text = "Please choose an account to transfer from";
                    transactionLabel.Location = new Point(290, 198);
                    break;

                default:
                    break;
            }
        }
        private void savingsbutton_Click(object sender, EventArgs e)
        {
            accType = "Savings";

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql = "SELECT accountNum FROM lyonsaccountinfo WHERE cardNum=" + cn + " AND accountType= 'Savings'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                acNum = (String)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            switch (tran) { 
                case "withdraw":

                    Withdraw withdraw = new Withdraw(accType, acNum, cn);
                    this.Close();
                    withdraw.Show();

                    break;

                case "deposit":

                    Deposit deposit = new Deposit(accType, acNum, cn);
                    this.Close();
                    deposit.Show();

                    break;

                case "check balance":

                    CheckBalance check = new CheckBalance(accType, acNum, cn, "no");
                    this.Close();
                    check.Show();

                    break;

                case "transfer":

                    CheckBalance transfer = new CheckBalance(accType, acNum, cn, "yes");
                    this.Close();
                    transfer.Show();

                    break;

                default:
                        break;
            }
        }
        private void checkingbutton_Click(object sender, EventArgs e)
        {
            accType = "Checking";

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql = "SELECT accountNum FROM lyonsaccountinfo WHERE cardNum=" + cn + " AND accountType= 'Checking'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                acNum = (String)cmd.ExecuteScalar();
                Console.WriteLine(acNum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            switch (tran)
            {
                case "withdraw":

                    Withdraw withdraw = new Withdraw(accType, acNum, cn);
                    this.Close();
                    withdraw.Show();

                    break;

                case "deposit":

                    Deposit deposit = new Deposit(accType, acNum, cn);
                    this.Close();
                    deposit.Show();

                    break;

                case "check balance":

                    CheckBalance check = new CheckBalance(accType, acNum, cn, "no");
                    this.Close();
                    check.Show();

                    break;

                case "transfer":

                    CheckBalance transfer = new CheckBalance(accType, acNum, cn, "yes");
                    this.Close();
                    transfer.Show();

                    break;

                default:
                    break;
            }
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            tran = "";
            acNum = "";
            accType = "";

            MainMenu mainMenu = new MainMenu(cn);
            this.Close();
            mainMenu.Show();
        }
    }
}
