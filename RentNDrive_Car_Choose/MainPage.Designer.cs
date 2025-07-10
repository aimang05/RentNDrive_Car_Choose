namespace RentNDrive_Car_Choose
{
    partial class MainPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBookCar;
        private System.Windows.Forms.Button btnAdmin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBookCar = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(26, 51);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(386, 89);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, !";
            // 
            // btnBookCar
            // 
            this.btnBookCar.Font = new System.Drawing.Font("Segoe UI", 38F);
            this.btnBookCar.Location = new System.Drawing.Point(126, 177);
            this.btnBookCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookCar.Name = "btnBookCar";
            this.btnBookCar.Size = new System.Drawing.Size(335, 96);
            this.btnBookCar.TabIndex = 1;
            this.btnBookCar.Text = "Book a Car";
            this.btnBookCar.UseVisualStyleBackColor = true;
            this.btnBookCar.Click += new System.EventHandler(this.btnBookCar_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnAdmin.Location = new System.Drawing.Point(207, 297);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(194, 47);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin Panel";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 430);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnBookCar);
            this.Controls.Add(this.lblWelcome);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
