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
    public partial class LogoutScreen : Form
    {
        public LogoutScreen()
        {
            InitializeComponent();
        }
        private void LogoutScreen_Load(object sender, EventArgs e)
        {
            CardScreen cardScreen = new CardScreen();

            async Task UseDelay()
            {
                await Task.Delay(5000);
                Application.Exit();
            }

            _ = UseDelay();

        }
    }
}
