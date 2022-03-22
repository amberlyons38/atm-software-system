
namespace ATM
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.errorMessage = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.pinNumberTextBox = new System.Windows.Forms.TextBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.buttonenter = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttondel = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(628, 252);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 29);
            this.errorMessage.TabIndex = 36;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(368, 187);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(0, 37);
            this.balanceLabel.TabIndex = 35;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.Location = new System.Drawing.Point(362, 134);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(0, 44);
            this.accountLabel.TabIndex = 34;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.LightSlateGray;
            this.backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backbutton.Location = new System.Drawing.Point(555, 660);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(146, 81);
            this.backbutton.TabIndex = 33;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.amountLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.amountLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.amountLabel.Location = new System.Drawing.Point(421, 290);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(414, 29);
            this.amountLabel.TabIndex = 32;
            this.amountLabel.Text = "Please enter the amount for deposit";
            // 
            // pinNumberTextBox
            // 
            this.pinNumberTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.pinNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pinNumberTextBox.Location = new System.Drawing.Point(418, 335);
            this.pinNumberTextBox.Name = "pinNumberTextBox";
            this.pinNumberTextBox.ReadOnly = true;
            this.pinNumberTextBox.Size = new System.Drawing.Size(421, 36);
            this.pinNumberTextBox.TabIndex = 31;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buttonPanel.Controls.Add(this.buttonenter);
            this.buttonPanel.Controls.Add(this.buttonclear);
            this.buttonPanel.Controls.Add(this.buttondel);
            this.buttonPanel.Controls.Add(this.button9);
            this.buttonPanel.Controls.Add(this.button7);
            this.buttonPanel.Controls.Add(this.button6);
            this.buttonPanel.Controls.Add(this.button5);
            this.buttonPanel.Controls.Add(this.button8);
            this.buttonPanel.Controls.Add(this.button4);
            this.buttonPanel.Controls.Add(this.button3);
            this.buttonPanel.Controls.Add(this.button2);
            this.buttonPanel.Controls.Add(this.button1);
            this.buttonPanel.Controls.Add(this.button0);
            this.buttonPanel.Location = new System.Drawing.Point(366, 387);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(524, 265);
            this.buttonPanel.TabIndex = 30;
            // 
            // buttonenter
            // 
            this.buttonenter.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonenter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonenter.Location = new System.Drawing.Point(419, 3);
            this.buttonenter.Name = "buttonenter";
            this.buttonenter.Size = new System.Drawing.Size(98, 254);
            this.buttonenter.TabIndex = 20;
            this.buttonenter.Text = "Enter";
            this.buttonenter.UseVisualStyleBackColor = false;
            this.buttonenter.Click += new System.EventHandler(this.buttonenter_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.BackColor = System.Drawing.Color.Crimson;
            this.buttonclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonclear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonclear.Location = new System.Drawing.Point(315, 176);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(98, 81);
            this.buttonclear.TabIndex = 19;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttondel
            // 
            this.buttondel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttondel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttondel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttondel.Location = new System.Drawing.Point(211, 176);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(98, 81);
            this.buttondel.TabIndex = 18;
            this.buttondel.Text = "Del";
            this.buttondel.UseVisualStyleBackColor = false;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gold;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button9.Location = new System.Drawing.Point(107, 176);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 81);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gold;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(315, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 81);
            this.button7.TabIndex = 16;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gold;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(211, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 81);
            this.button6.TabIndex = 15;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gold;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(107, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 81);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gold;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button8.Location = new System.Drawing.Point(3, 176);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 81);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(3, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 81);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(315, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 81);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(211, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 81);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(107, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Gold;
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.button0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button0.Location = new System.Drawing.Point(3, 3);
            this.button0.Name = "button0";
            this.button0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button0.Size = new System.Drawing.Size(98, 81);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1253, 875);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.pinNumberTextBox);
            this.Controls.Add(this.buttonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZZZ Bank ATM";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label accountLabel;
        protected System.Windows.Forms.Button backbutton;
        protected System.Windows.Forms.Label amountLabel;
        protected System.Windows.Forms.TextBox pinNumberTextBox;
        protected System.Windows.Forms.Panel buttonPanel;
        protected System.Windows.Forms.Button buttonenter;
        protected System.Windows.Forms.Button buttonclear;
        protected System.Windows.Forms.Button buttondel;
        protected System.Windows.Forms.Button button9;
        protected System.Windows.Forms.Button button7;
        protected System.Windows.Forms.Button button6;
        protected System.Windows.Forms.Button button5;
        protected System.Windows.Forms.Button button8;
        protected System.Windows.Forms.Button button4;
        protected System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Button button0;
    }
}