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
    public partial class AnotherPrompt : Form
    {
        private String cardn;
        private String ty;
        public AnotherPrompt(string cn, string type)
        {
            InitializeComponent();
            cardn = cn;
            ty = type;
        }
        private void AnotherPrompt_Load(object sender, EventArgs e)
        {
            anotherbutton.Enabled = false;
            anotherbutton.Visible = false;

            if(ty.Equals("check balance"))
            {
                anotherbutton.Enabled = true;
                anotherbutton.Visible = true;
            }
        }
        private void yesbutton_Click(object sender, EventArgs e)
        {
            ty = "";
            MainMenu mainMenu = new MainMenu(cardn);
            this.Close();
            mainMenu.Show();
        }

        private void nobutton_Click(object sender, EventArgs e)
        {
            ty = "";
            cardn = "";
            LogoutScreen logoutScreen = new LogoutScreen();
            this.Close();
            logoutScreen.Show();
        }
        private void anotherbutton_Click(object sender, EventArgs e)
        {
            AccountSelectionScreen selectionScreen = new AccountSelectionScreen(cardn, "check balance");
            this.Close();
            selectionScreen.Show();
        }
    }
}
