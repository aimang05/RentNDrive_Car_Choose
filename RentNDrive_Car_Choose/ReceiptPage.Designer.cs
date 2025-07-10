namespace RentNDrive_Car_Choose
{
    partial class ReceiptPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtReceipt
            this.txtReceipt.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtReceipt.Location = new System.Drawing.Point(20, 20);
            this.txtReceipt.Multiline = true;
            this.txtReceipt.ReadOnly = true;
            this.txtReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceipt.Size = new System.Drawing.Size(400, 320);
            this.txtReceipt.Name = "txtReceipt";

            // btnClose
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(170, 360);
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ReceiptPage
            this.ClientSize = new System.Drawing.Size(450, 420);
            this.Controls.Add(this.txtReceipt);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReceiptPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
