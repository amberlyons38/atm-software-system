
namespace ATM
{
    partial class TransferAccountSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferAccountSelection));
            this.transferbutton = new System.Windows.Forms.Button();
            this.savingsbutton = new System.Windows.Forms.Button();
            this.checkingbutton = new System.Windows.Forms.Button();
            this.transferLabel = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transferbutton
            // 
            this.transferbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.transferbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferbutton.Location = new System.Drawing.Point(254, 461);
            this.transferbutton.Name = "transferbutton";
            this.transferbutton.Size = new System.Drawing.Size(745, 101);
            this.transferbutton.TabIndex = 0;
            this.transferbutton.Text = "Transfer to Another Member\'s Account";
            this.transferbutton.UseVisualStyleBackColor = false;
            this.transferbutton.Click += new System.EventHandler(this.transferbutton_Click);
            // 
            // savingsbutton
            // 
            this.savingsbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.savingsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsbutton.Location = new System.Drawing.Point(254, 354);
            this.savingsbutton.Name = "savingsbutton";
            this.savingsbutton.Size = new System.Drawing.Size(745, 101);
            this.savingsbutton.TabIndex = 1;
            this.savingsbutton.Text = "Savings";
            this.savingsbutton.UseVisualStyleBackColor = false;
            this.savingsbutton.Click += new System.EventHandler(this.savingsbutton_Click);
            // 
            // checkingbutton
            // 
            this.checkingbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.checkingbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingbutton.Location = new System.Drawing.Point(254, 247);
            this.checkingbutton.Name = "checkingbutton";
            this.checkingbutton.Size = new System.Drawing.Size(745, 101);
            this.checkingbutton.TabIndex = 2;
            this.checkingbutton.Text = "Checking";
            this.checkingbutton.UseVisualStyleBackColor = false;
            this.checkingbutton.Click += new System.EventHandler(this.checkingbutton_Click);
            // 
            // transferLabel
            // 
            this.transferLabel.AutoSize = true;
            this.transferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferLabel.Location = new System.Drawing.Point(404, 196);
            this.transferLabel.Name = "transferLabel";
            this.transferLabel.Size = new System.Drawing.Size(444, 29);
            this.transferLabel.TabIndex = 3;
            this.transferLabel.Text = "Please select an account to transfer to";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.LightSlateGray;
            this.backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backbutton.Location = new System.Drawing.Point(553, 597);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(146, 81);
            this.backbutton.TabIndex = 34;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // TransferAccountSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1253, 875);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.transferLabel);
            this.Controls.Add(this.checkingbutton);
            this.Controls.Add(this.savingsbutton);
            this.Controls.Add(this.transferbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferAccountSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZZZ Bank ATM";
            this.Load += new System.EventHandler(this.TransferAccountSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transferbutton;
        private System.Windows.Forms.Button savingsbutton;
        private System.Windows.Forms.Button checkingbutton;
        private System.Windows.Forms.Label transferLabel;
        protected System.Windows.Forms.Button backbutton;
    }
}