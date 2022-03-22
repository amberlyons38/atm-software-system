using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class Transactions : System.Windows.Forms.Form
    {
        private String an;
        private double b;
        private DateTime date;
        public Transactions(string acNum)
        {
            InitializeComponent();
            an = acNum;
        }
        public double CheckBalance()
        {
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql = "SELECT balance FROM lyonsaccountinfo WHERE accountNum= '" + an + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                b = Convert.ToDouble(cmd.ExecuteScalar());
                Console.WriteLine(b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return b;
        }

        public void Withdrawal(double amt)
        {
            double balance = CheckBalance();

            balance = balance - Convert.ToDouble(amt);
            Console.WriteLine(balance.ToString());
            date = DateTime.Now;

            Console.WriteLine(date.ToString());

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql2 = "INSERT INTO lyonstransactions (accountNum, date, transactionType, amount, toAccount) VALUES (@an, @d, @t, @am, @ta);";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

                cmd2.Parameters.AddWithValue("@an", an);
                cmd2.Parameters.AddWithValue("@d", date);
                cmd2.Parameters.AddWithValue("@t", "Withdrawal");
                cmd2.Parameters.AddWithValue("@am", Convert.ToInt32(amt));
                cmd2.Parameters.AddWithValue("@ta", null);

                cmd2.ExecuteNonQuery();

                string sql = "UPDATE lyonsaccountinfo SET balance = @balance WHERE accountNum = '"+an+"';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@balance", balance);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            Console.WriteLine(balance);
        }
        public void Deposit(double amt)
        {
            double balance = CheckBalance();

            balance = balance + Convert.ToDouble(amt);
            Console.WriteLine(balance.ToString());
            date = DateTime.Now;

            Console.WriteLine(date.ToString());

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql2 = "INSERT INTO lyonstransactions (accountNum, date, transactionType, amount, toAccount) VALUES (@an, @d, @t, @am, @ta);";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

                cmd2.Parameters.AddWithValue("@an", an);
                cmd2.Parameters.AddWithValue("@d", date);
                cmd2.Parameters.AddWithValue("@t", "Deposit");
                cmd2.Parameters.AddWithValue("@am", Convert.ToInt32(amt));
                cmd2.Parameters.AddWithValue("@ta", null);

                cmd2.ExecuteNonQuery();

                balance = Math.Floor(balance * 100) / 100;

                string sql = "UPDATE lyonsaccountinfo SET balance = @balance WHERE accountNum = '" + an + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@balance", balance);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            Console.WriteLine(balance);
        }

        public void Transfer(double amt, String toAccount, string an)
        {
            double balance1 = CheckBalance();

            Transactions t = new Transactions(toAccount);
            double balance2 = t.CheckBalance();

            balance1 = balance1 - amt;
            balance2 = balance2 + amt;

            date = DateTime.Now;

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql2 = "INSERT INTO lyonstransactions (accountNum, date, transactionType, amount, toAccount) VALUES (@an, @d, @t, @am, @ta);";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

                Console.WriteLine(toAccount);

                cmd2.Parameters.AddWithValue("@an", an);
                cmd2.Parameters.AddWithValue("@d", date);
                cmd2.Parameters.AddWithValue("@t", "Transfer");
                cmd2.Parameters.AddWithValue("@am", Convert.ToInt32(amt));
                cmd2.Parameters.AddWithValue("@ta", toAccount);

                cmd2.ExecuteNonQuery();

                balance1 = Math.Floor(balance1 * 100) / 100;
                balance2 = Math.Floor(balance2 * 100) / 100;

                string sql = "UPDATE lyonsaccountinfo SET balance = @balance1 WHERE accountNum = '" + an + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@balance1", balance1);

                cmd.ExecuteNonQuery();

                string sql3 = "UPDATE lyonsaccountinfo SET balance = @balance2 WHERE accountNum = '" + toAccount + "';";
                MySqlCommand cmd3 = new MySqlCommand(sql3, conn);

                cmd3.Parameters.AddWithValue("@balance2", balance2);

                cmd3.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
    }
}
