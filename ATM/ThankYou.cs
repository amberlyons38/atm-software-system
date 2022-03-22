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
    public partial class ThankYou : Form
    {
        private double b;
        private String c;
        public ThankYou(double balance, string cardn)
        {
            InitializeComponent();
            b = balance;
            c = cardn;
        }
        private void ThankYou_Load(object sender, EventArgs e)
        {
            String b2 = "$" + b;
            if (b2.Substring(b2.IndexOf(".")).Length < 3)
            {
                b2 = b2 + "0";
            }

            label3.Text = "New Balance: " + b2;
            label3.Location = new Point(327, 544);

            async Task UseDelay()
            {
                await Task.Delay(3000);
                AnotherPrompt another = new AnotherPrompt(c, "Other");
                this.Close();
                another.Show();
            }

            _ = UseDelay();
        }
    }
}
