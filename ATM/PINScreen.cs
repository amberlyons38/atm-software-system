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
    public partial class PINScreen : Form
    {
        private String pin = "";
        private String cn;
        public int attempts;
        public PINScreen(string cardnumber)
        {
            InitializeComponent();
            cn = cardnumber;
        }

        private void PINScreen_Load(object sender, EventArgs e)
        {
            pin = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (pin.Length < 4)
            {
                pin = pin + 0;
                pinNumberTextBox.Text = pinNumberTextBox.Text + "*";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (pin.Length < 4)
            {
                pin = pin + 1;
                pinNumberTextBox.Text = pinNumberTextBox.Text + "*";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (pin.Length < 4)
            {
                pin = pin + 2;
                pinNumberTextBox.Text = pinNumberTextBox.Text + "*";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (pin.Length < 4)
            {
                pin = pin + 3;
                pinNumberTextBox.Text = pinNumberTextBox.Text + "*";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (pin.Length < 4)
            {
                pin = pin + 4;
                pinNumberTextBox.Text = pinNumberTextBox.Text + "*";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (pin.Length < 4)
            {
                pin = pin + 5;
                pinNumberTextBox.Text = pinNumberTextBox.Text + "*";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (pin.Length < 4)
            {
                pin = pin + 6;
                pinNumberTextBox.Text = pinNumberTextBox.Text + "*";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (pin.Length < 4)
            {
                pin = pin + 7;
                pinNumberTextBox.Text = pinNumberTextBox.Text + "*";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (pin.Length < 4)
            {
                pin = pin + 8;
                pinNumberTextBox.Text = pinNumberTextBox.Text + "*";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (pin.Length < 4)
            {
                pin = pin + 9;
                pinNumberTextBox.Text = pinNumberTextBox.Text + "*";
            }
        }
        private void buttondel_Click(object sender, EventArgs e)
        {
            if (pin.Length > 0)
            {
                pin = pin.Substring(0, pin.Length - 1);
                pinNumberTextBox.Text = pinNumberTextBox.Text.Substring(0, pinNumberTextBox.Text.Length-1);
            }
            errorMessage.Visible = false;
        }
        private void buttonclear_Click(object sender, EventArgs e)
        {
            pin = "";
            pinNumberTextBox.Text = "";
            errorMessage.Visible = false;
        }
        private void buttonback_Click(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
            pin = "";
            cn = "";
            CardScreen cardScreen = new CardScreen();
            this.Close();
            cardScreen.Show();
        }
        private void buttonenter_Click(object sender, EventArgs e)
        {
            errorMessage.Visible = false;

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            String correct = "";

            try
            {
                conn.Open();
                string sql = "SELECT PIN FROM lyonsaccount WHERE cardNum=" + cn + "";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                correct = (String)cmd.ExecuteScalar();
                string sql2 = "SELECT attempts FROM lyonsaccount WHERE cardNum=" + cn + "";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                attempts = Convert.ToInt32(cmd2.ExecuteScalar());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (attempts < 5)
            {
                if (correct == pin)
                {
                    pin = "";
                    errorMessage.Visible = false;
                    MainMenu mainMenu = new MainMenu(cn);
                    this.Close();
                    mainMenu.Show();
                }
                else
                {
                    attempts = attempts + 1;
                    try
                    {
                        string sql3 = "UPDATE lyonsaccount SET attempts = @attempts WHERE cardNum = @cn;";
                        MySqlCommand cmd3 = new MySqlCommand(sql3, conn);

                        cmd3.Parameters.AddWithValue("@attempts", attempts);
                        cmd3.Parameters.AddWithValue("@cn", cn);
                        cmd3.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                    conn.Close();
                    errorMessage.Text = "Invalid PIN number";
                    errorMessage.Visible = true;
                    pin = "";
                    pinNumberTextBox.Text = pin;
                }
            }
            else
            {
                pin = "";
                pinNumberTextBox.Text = pin;
                errorMessage.Location = new Point(127, 195);
                errorMessage.Text = "Maximum number of incorrect PIN entry attempts reached, please try again later.";
                errorMessage.Visible = true;
            }
        }
    }
}
