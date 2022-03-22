
namespace ATM
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.logoutbutton = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.withdrawbutton = new System.Windows.Forms.Button();
            this.depositbutton = new System.Windows.Forms.Button();
            this.balancebutton = new System.Windows.Forms.Button();
            this.transferbutton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.logoutbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.logoutbutton, "logoutbutton");
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // menuLabel
            // 
            resources.ApplyResources(this.menuLabel, "menuLabel");
            this.menuLabel.Name = "menuLabel";
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.Name = "title";
            // 
            // withdrawbutton
            // 
            this.withdrawbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.withdrawbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.withdrawbutton, "withdrawbutton");
            this.withdrawbutton.Name = "withdrawbutton";
            this.withdrawbutton.UseVisualStyleBackColor = false;
            this.withdrawbutton.Click += new System.EventHandler(this.withdrawbutton_Click);
            // 
            // depositbutton
            // 
            this.depositbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.depositbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.depositbutton, "depositbutton");
            this.depositbutton.Name = "depositbutton";
            this.depositbutton.UseVisualStyleBackColor = false;
            this.depositbutton.Click += new System.EventHandler(this.depositbutton_Click);
            // 
            // balancebutton
            // 
            this.balancebutton.BackColor = System.Drawing.Color.Goldenrod;
            this.balancebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.balancebutton, "balancebutton");
            this.balancebutton.Name = "balancebutton";
            this.balancebutton.UseVisualStyleBackColor = false;
            this.balancebutton.Click += new System.EventHandler(this.balancebutton_Click);
            // 
            // transferbutton
            // 
            this.transferbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.transferbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.transferbutton, "transferbutton");
            this.transferbutton.Name = "transferbutton";
            this.transferbutton.UseVisualStyleBackColor = false;
            this.transferbutton.Click += new System.EventHandler(this.transferbutton_Click);
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameLabel.Name = "nameLabel";
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.transferbutton);
            this.Controls.Add(this.balancebutton);
            this.Controls.Add(this.depositbutton);
            this.Controls.Add(this.withdrawbutton);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.title);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button logoutbutton;
        protected System.Windows.Forms.Label menuLabel;
        protected System.Windows.Forms.Label title;
        protected System.Windows.Forms.Button withdrawbutton;
        protected System.Windows.Forms.Button depositbutton;
        protected System.Windows.Forms.Button balancebutton;
        protected System.Windows.Forms.Button transferbutton;
        private System.Windows.Forms.Label nameLabel;
    }
}