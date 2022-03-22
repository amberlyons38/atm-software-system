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
    public partial class MainMenu : Form
    {
        private String cardn;
        private String name;
        private String trans;
        public MainMenu(string cn)
        {
            InitializeComponent();
            cardn = cn;
        }

        private void withdrawbutton_Click(object sender, EventArgs e)
        {
            trans = "withdraw";

            AccountSelectionScreen accountSelectionScreen = new AccountSelectionScreen(cardn, trans);
            this.Close();
            accountSelectionScreen.Show();
        }
        private void depositbutton_Click(object sender, EventArgs e)
        {
            trans = "deposit";

            AccountSelectionScreen accountSelectionScreen = new AccountSelectionScreen(cardn, trans);
            this.Close();
            accountSelectionScreen.Show();
        }
        private void balancebutton_Click(object sender, EventArgs e)
        {
            trans = "check balance";

            AccountSelectionScreen accountSelectionScreen = new AccountSelectionScreen(cardn, trans);
            this.Close();
            accountSelectionScreen.Show();
        }
        private void transferbutton_Click(object sender, EventArgs e)
        {
            trans = "transfer";

            AccountSelectionScreen accountSelectionScreen = new AccountSelectionScreen(cardn, trans);
            this.Close();
            accountSelectionScreen.Show();
        }
        private void logoutbutton_Click(object sender, EventArgs e)
        {
            cardn = "";
            name = "";
            trans = "";
            LogoutScreen logoutScreen = new LogoutScreen();
            this.Close();
            logoutScreen.Show();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            trans = "";

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql = "SELECT name FROM lyonsaccount WHERE cardNum= '" + cardn + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                name = (String)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            nameLabel.Text = name;
            conn.Close();
        }
    }
}
