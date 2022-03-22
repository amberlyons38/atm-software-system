
namespace ATM
{
    partial class AnotherPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnotherPrompt));
            this.menuLabel = new System.Windows.Forms.Label();
            this.yesbutton = new System.Windows.Forms.Button();
            this.nobutton = new System.Windows.Forms.Button();
            this.anotherbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.menuLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuLabel.Location = new System.Drawing.Point(369, 262);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(514, 29);
            this.menuLabel.TabIndex = 26;
            this.menuLabel.Text = "Would you like to make another transaction?";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesbutton
            // 
            this.yesbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.yesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesbutton.Location = new System.Drawing.Point(413, 322);
            this.yesbutton.Name = "yesbutton";
            this.yesbutton.Size = new System.Drawing.Size(427, 93);
            this.yesbutton.TabIndex = 27;
            this.yesbutton.Text = "Yes";
            this.yesbutton.UseVisualStyleBackColor = false;
            this.yesbutton.Click += new System.EventHandler(this.yesbutton_Click);
            // 
            // nobutton
            // 
            this.nobutton.BackColor = System.Drawing.Color.Goldenrod;
            this.nobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nobutton.Location = new System.Drawing.Point(413, 421);
            this.nobutton.Name = "nobutton";
            this.nobutton.Size = new System.Drawing.Size(427, 93);
            this.nobutton.TabIndex = 28;
            this.nobutton.Text = "No";
            this.nobutton.UseVisualStyleBackColor = false;
            this.nobutton.Click += new System.EventHandler(this.nobutton_Click);
            // 
            // anotherbutton
            // 
            this.anotherbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.anotherbutton.Enabled = false;
            this.anotherbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anotherbutton.Location = new System.Drawing.Point(413, 520);
            this.anotherbutton.Name = "anotherbutton";
            this.anotherbutton.Size = new System.Drawing.Size(427, 93);
            this.anotherbutton.TabIndex = 29;
            this.anotherbutton.Text = "View Another Balance";
            this.anotherbutton.UseVisualStyleBackColor = false;
            this.anotherbutton.Visible = false;
            this.anotherbutton.Click += new System.EventHandler(this.anotherbutton_Click);
            // 
            // AnotherPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1253, 875);
            this.Controls.Add(this.anotherbutton);
            this.Controls.Add(this.nobutton);
            this.Controls.Add(this.yesbutton);
            this.Controls.Add(this.menuLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnotherPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZZZ Bank ATM";
            this.Load += new System.EventHandler(this.AnotherPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Button yesbutton;
        private System.Windows.Forms.Button nobutton;
        private System.Windows.Forms.Button anotherbutton;
    }
}