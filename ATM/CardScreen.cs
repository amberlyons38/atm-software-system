using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class CardScreen : System.Windows.Forms.Form
    {
        public String cardnumber = "";
        public CardScreen()
        {
            InitializeComponent();
        }

        private void CardScreen_Load(object sender, EventArgs e)
        {
            cardnumber = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (cardnumber.Length < 16)
            {
                cardnumber = cardnumber + 0;
            }
            cardNumTextBox.Text = cardnumber;
            Console.Write(cardnumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cardnumber.Length < 16)
            {
                cardnumber = cardnumber + 1;
            }
            cardNumTextBox.Text = cardnumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cardnumber.Length < 16)
            {
                cardnumber = cardnumber + 2;
            }
            cardNumTextBox.Text = cardnumber;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cardnumber.Length < 16)
            {
                cardnumber = cardnumber + 3;
            }
            cardNumTextBox.Text = cardnumber;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cardnumber.Length < 16)
            {
                cardnumber = cardnumber + 4;
            }
            cardNumTextBox.Text = cardnumber;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cardnumber.Length < 16)
            {
                cardnumber = cardnumber + 5;
            }
            cardNumTextBox.Text = cardnumber;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cardnumber.Length < 16)
            {
                cardnumber = cardnumber + 6;
            }
            cardNumTextBox.Text = cardnumber;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cardnumber.Length < 16)
            {
                cardnumber = cardnumber + 7;
            }
            cardNumTextBox.Text = cardnumber;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cardnumber.Length < 16)
            {
                cardnumber = cardnumber + 8;
            }
            cardNumTextBox.Text = cardnumber;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cardnumber.Length < 16)
            {
                cardnumber = cardnumber + 9;
            }
            cardNumTextBox.Text = cardnumber;
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            if (cardnumber.Length > 0)
            {
                cardnumber = cardnumber.Substring(0, cardnumber.Length - 1);
                cardNumTextBox.Text = cardnumber;
            }
            errorMessage.Visible = false;
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            cardnumber = "";
            cardNumTextBox.Text = "";
            errorMessage.Visible = false;
        }

        private void buttonenter_Click(object sender, EventArgs e)
        {
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            int found = 0;

            try
            {
                conn.Open();
                string sql = "SELECT EXISTS(SELECT * FROM lyonsaccount WHERE cardNum= '"+cardnumber+"')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                found = (int)cmd.ExecuteScalar();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            if(found == 1)
            {
                errorMessage.Visible = false;
                PINScreen pINScreen = new PINScreen(cardnumber);
                this.Hide();
                pINScreen.Show();
            }
            else
            {
                errorMessage.Visible = true;
                cardnumber = "";
                cardNumTextBox.Text = cardnumber;
            }
        }
    }
}
