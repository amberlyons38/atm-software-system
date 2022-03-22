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
    public partial class TransferAccountSelection : Form
    {
        private String acN;
        private String toAccount;
        private String c;
        private String t;
        public TransferAccountSelection(string an, String cn, String ty)
        {
            InitializeComponent();
            acN = an;
            c = cn;
            t = ty;
        }
        private void TransferAccountSelection_Load(object sender, EventArgs e)
        {
        
        }
        private void transferbutton_Click(object sender, EventArgs e)
        {
            MemberSelection member = new MemberSelection(acN);
            this.Close();
            member.Show();
        }
        private void savingsbutton_Click(object sender, EventArgs e)
        {

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql = "SELECT accountNum FROM lyonsaccountinfo WHERE cardNum=" + c + " AND accountType= 'Savings'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                toAccount = (String)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            Transfer transfer = new Transfer("Savings", acN, toAccount);
            this.Close();
            transfer.Show();
        }
        private void checkingbutton_Click(object sender, EventArgs e)
        {
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql = "SELECT accountNum FROM lyonsaccountinfo WHERE cardNum=" + c + " AND accountType= 'Checking'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                toAccount = (String)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            Transfer transfer = new Transfer("Checking", acN, toAccount);
            this.Close();
            transfer.Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            toAccount = "";

            CheckBalance check = new CheckBalance(t, acN, c, "yes");
            this.Close();
            check.Show();
        }
    }
}
