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
    public partial class MemberSelection : Form
    {
        private String memberNum;
        private String an;
        private String toAc;

        public MemberSelection(string acN)
        {
            InitializeComponent();
            an = acN;
        }

        private void MemberSelection_Load(object sender, EventArgs e)
        {
            memberNum = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (memberNum.Length < 16)
            {
                memberNum = memberNum + 0;
            }
            pinNumberTextBox.Text = memberNum;
            Console.Write(memberNum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (memberNum.Length < 16)
            {
                memberNum = memberNum + 1;
            }
            pinNumberTextBox.Text = memberNum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (memberNum.Length < 16)
            {
                memberNum = memberNum + 2;
            }
            pinNumberTextBox.Text = memberNum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (memberNum.Length < 16)
            {
                memberNum = memberNum + 3;
            }
            pinNumberTextBox.Text = memberNum;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (memberNum.Length < 16)
            {
                memberNum = memberNum + 4;
            }
            pinNumberTextBox.Text = memberNum;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (memberNum.Length < 16)
            {
                memberNum = memberNum + 5;
            }
            pinNumberTextBox.Text = memberNum;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (memberNum.Length < 16)
            {
                memberNum = memberNum + 6;
            }
            pinNumberTextBox.Text = memberNum;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (memberNum.Length < 16)
            {
                memberNum = memberNum + 7;
            }
            pinNumberTextBox.Text = memberNum;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (memberNum.Length < 16)
            {
                memberNum = memberNum + 8;
            }
            pinNumberTextBox.Text = memberNum;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (memberNum.Length < 16)
            {
                memberNum = memberNum + 9;
            }
            pinNumberTextBox.Text = memberNum;
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            if (memberNum.Length > 0)
            {
                memberNum = memberNum.Substring(0, memberNum.Length - 1);
                pinNumberTextBox.Text = memberNum;
            }
            errorMessage.Visible = false;
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            memberNum = "";
            pinNumberTextBox.Text = "";
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
                string sql = "SELECT EXISTS(SELECT * FROM lyonsaccount WHERE cardNum=" + memberNum + ")";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                found = (int)cmd.ExecuteScalar();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            if (found == 0)
            {
                errorMessage.Visible = true;
                memberNum = "";
                pinNumberTextBox.Text = memberNum;
            }
            else
            {

                string sql2 = "SELECT accountNum FROM lyonsaccountinfo WHERE cardNum = '" + memberNum + "' AND accountType = 'Savings';";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                toAc = (String)cmd2.ExecuteScalar();

                Console.WriteLine(toAc);

                conn.Close();
                errorMessage.Visible = false;
                Transfer transfer = new Transfer("Savings", an, toAc);
                this.Close();
                transfer.Show();
            }
        }
    }
}
