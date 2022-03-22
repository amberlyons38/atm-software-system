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
    public partial class CheckBalance : Form
    {
        private String at;
        private String an;
        private String cn;
        private String ifT;
        public CheckBalance(string accType, string acNum, String cardn, String t)
        {
            InitializeComponent();
            at = accType;
            an = acNum;
            cn = cardn;
            ifT = t;
        }

        private void CheckBalance_Load(object sender, EventArgs e)
        {
            okButton.Text = "OK";

            Transactions transactions = new Transactions(an);
            double balance = transactions.CheckBalance();

            accountLabel.Text = at + " - " + an;

            Console.WriteLine(at);

            String b = "$" + balance;
            Console.WriteLine(b);
            if(b.Substring(b.IndexOf(".")).Length < 3)
            {
                b = b + "0";
            }

            balanceLabel.Text = "Balance: " + b;

            if (ifT.Equals("yes"))
            {
                okButton.Text = "Next";
            }
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            if (ifT.Equals("yes"))
            {
                TransferAccountSelection transfer = new TransferAccountSelection(an, cn, at);
                this.Close();
                transfer.Show();
            }
            else
            {
                at = "";
                an = "";

                AnotherPrompt another = new AnotherPrompt(cn, "check balance");
                this.Close();
                another.Show();
            }       
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            AccountSelectionScreen selectionScreen = new AccountSelectionScreen(cn, "check balance");
            this.Close();
            selectionScreen.Show();
        }
    }
}
