namespace RentNDrive_Car_Choose
{
    partial class CustomerDetails
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIC;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbCarBrand;
        private System.Windows.Forms.ComboBox cmbCarModel;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIC;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblDuration;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIC = new System.Windows.Forms.TextBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbCarBrand = new System.Windows.Forms.ComboBox();
            this.cmbCarModel = new System.Windows.Forms.ComboBox();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.btnPay = new System.Windows.Forms.Button();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIC = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(212, 177);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(285, 38);
            this.txtName.TabIndex = 2;
            // 
            // txtIC
            // 
            this.txtIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIC.Location = new System.Drawing.Point(212, 217);
            this.txtIC.Name = "txtIC";
            this.txtIC.Size = new System.Drawing.Size(285, 38);
            this.txtIC.TabIndex = 4;
            // 
            // txtLicense
            // 
            this.txtLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicense.Location = new System.Drawing.Point(212, 257);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(285, 38);
            this.txtLicense.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(212, 297);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(285, 38);
            this.txtAddress.TabIndex = 8;
            // 
            // cmbCarBrand
            // 
            this.cmbCarBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarBrand.Location = new System.Drawing.Point(212, 337);
            this.cmbCarBrand.Name = "cmbCarBrand";
            this.cmbCarBrand.Size = new System.Drawing.Size(306, 39);
            this.cmbCarBrand.TabIndex = 10;
            this.cmbCarBrand.SelectedIndexChanged += new System.EventHandler(this.cmbCarBrand_SelectedIndexChanged);
            // 
            // cmbCarModel
            // 
            this.cmbCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarModel.Location = new System.Drawing.Point(212, 377);
            this.cmbCarModel.Name = "cmbCarModel";
            this.cmbCarModel.Size = new System.Drawing.Size(306, 39);
            this.cmbCarModel.TabIndex = 12;
            this.cmbCarModel.SelectedIndexChanged += new System.EventHandler(this.cmbCarModel_SelectedIndexChanged);
            // 
            // numDuration
            // 
            this.numDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDuration.Location = new System.Drawing.Point(212, 417);
            this.numDuration.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(305, 38);
            this.numDuration.TabIndex = 14;
            this.numDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(471, 490);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 40);
            this.btnPay.TabIndex = 15;
            this.btnPay.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCar.Location = new System.Drawing.Point(584, 199);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(285, 200);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCar.TabIndex = 16;
            this.pictureBoxCar.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(598, 103);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer Booking";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(56, 179);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblIC
            // 
            this.lblIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIC.Location = new System.Drawing.Point(56, 219);
            this.lblIC.Name = "lblIC";
            this.lblIC.Size = new System.Drawing.Size(136, 37);
            this.lblIC.TabIndex = 3;
            this.lblIC.Text = "IC Number:";
            // 
            // lblLicense
            // 
            this.lblLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.Location = new System.Drawing.Point(56, 259);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(136, 37);
            this.lblLicense.TabIndex = 5;
            this.lblLicense.Text = "License ID:";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(56, 299);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(136, 37);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(56, 339);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(136, 37);
            this.lblBrand.TabIndex = 9;
            this.lblBrand.Text = "Car Brand:";
            // 
            // lblModel
            // 
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(56, 379);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(136, 37);
            this.lblModel.TabIndex = 11;
            this.lblModel.Text = "Car Model:";
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(56, 419);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(136, 37);
            this.lblDuration.TabIndex = 13;
            this.lblDuration.Text = "Duration (days):";
            // 
            // CustomerDetails
            // 
            this.BackgroundImage = global::RentNDrive_Car_Choose.Properties.Resources.Asset_1_3x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 591);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblIC);
            this.Controls.Add(this.txtIC);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.cmbCarBrand);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cmbCarModel);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.pictureBoxCar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerDetails_FormClosed);
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
