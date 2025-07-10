namespace RentNDrive_Car_Choose
{
    partial class PAYMENT_PAGE
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPayment;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPayment = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // lblCustomer
            // 
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomer.Location = new System.Drawing.Point(20, 20);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(350, 100);
            this.lblCustomer.TabIndex = 0;

            // 
            // lblCar
            // 
            this.lblCar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCar.Location = new System.Drawing.Point(20, 130);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(350, 60);
            this.lblCar.TabIndex = 1;

            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(20, 200);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(350, 30);
            this.lblPrice.TabIndex = 2;

            // 
            // lblPayment
            // 
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPayment.Location = new System.Drawing.Point(20, 240);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(150, 23);
            this.lblPayment.TabIndex = 3;
            this.lblPayment.Text = "Payment Method:";

            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
                "Cash",
                "Online"
            });
            this.cmbPaymentMethod.Location = new System.Drawing.Point(170, 238);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(180, 23);
            this.cmbPaymentMethod.TabIndex = 4;

            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(110, 280);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 40);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm Booking";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            // 
            // PAYMENT_PAGE
            // 
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PAYMENT_PAGE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Summary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PAYMENT_PAGE_FormClosed);
            this.Load += new System.EventHandler(this.PAYMENT_PAGE_Load);
            this.ResumeLayout(false);
        }
    }
}
