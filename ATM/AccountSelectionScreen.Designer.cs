
namespace ATM
{
    partial class AccountSelectionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSelectionScreen));
            this.transactionLabel = new System.Windows.Forms.Label();
            this.checkingbutton = new System.Windows.Forms.Button();
            this.savingsbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transactionLabel
            // 
            this.transactionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionLabel.Location = new System.Drawing.Point(626, 241);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(0, 29);
            this.transactionLabel.TabIndex = 0;
            // 
            // checkingbutton
            // 
            this.checkingbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.checkingbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkingbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingbutton.Location = new System.Drawing.Point(407, 297);
            this.checkingbutton.Name = "checkingbutton";
            this.checkingbutton.Size = new System.Drawing.Size(438, 102);
            this.checkingbutton.TabIndex = 1;
            this.checkingbutton.Text = "Checking";
            this.checkingbutton.UseVisualStyleBackColor = false;
            this.checkingbutton.Click += new System.EventHandler(this.checkingbutton_Click);
            // 
            // savingsbutton
            // 
            this.savingsbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.savingsbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savingsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsbutton.Location = new System.Drawing.Point(407, 405);
            this.savingsbutton.Name = "savingsbutton";
            this.savingsbutton.Size = new System.Drawing.Size(438, 102);
            this.savingsbutton.TabIndex = 2;
            this.savingsbutton.Text = "Savings";
            this.savingsbutton.UseVisualStyleBackColor = false;
            this.savingsbutton.Click += new System.EventHandler(this.savingsbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.LightSlateGray;
            this.backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backbutton.Location = new System.Drawing.Point(553, 553);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(146, 81);
            this.backbutton.TabIndex = 22;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // AccountSelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1253, 875);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.savingsbutton);
            this.Controls.Add(this.checkingbutton);
            this.Controls.Add(this.transactionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountSelectionScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZZZ Bank ATM";
            this.Load += new System.EventHandler(this.AccountSelectionScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Button checkingbutton;
        private System.Windows.Forms.Button savingsbutton;
        protected System.Windows.Forms.Button backbutton;
    }
}