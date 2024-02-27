namespace Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCustomerName = new Label();
            lblAddress = new Label();
            lblProvince = new Label();
            lblCity = new Label();
            lblEmail = new Label();
            lblCellPhone = new Label();
            lblHomePhone = new Label();
            lblPostalCode = new Label();
            tbCustomerName = new TextBox();
            tbAddress = new TextBox();
            tbProvince = new TextBox();
            tbCity = new TextBox();
            tbEmail = new TextBox();
            tbCellPhone = new TextBox();
            tbHomePhone = new TextBox();
            tbPostalCode = new TextBox();
            lblErrorMessage = new Label();
            lblMakeModel = new Label();
            lblYear = new Label();
            lblApptDate = new Label();
            tbMakeModel = new TextBox();
            tbYear = new TextBox();
            dateApptPicker = new DateTimePicker();
            lblProblem = new Label();
            richtbProblem = new RichTextBox();
            btnBookAppt = new Button();
            btnReset = new Button();
            btnClose = new Button();
            btnPrefill = new Button();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F);
            lblCustomerName.Location = new Point(19, 21);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(127, 21);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F);
            lblAddress.Location = new Point(77, 65);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 21);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address:";
            // 
            // lblProvince
            // 
            lblProvince.AutoSize = true;
            lblProvince.Font = new Font("Segoe UI", 12F);
            lblProvince.Location = new Point(73, 153);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new Size(73, 21);
            lblProvince.TabIndex = 3;
            lblProvince.Text = "Province:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 12F);
            lblCity.Location = new Point(106, 109);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(40, 21);
            lblCity.TabIndex = 2;
            lblCity.Text = "City:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(95, 329);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblCellPhone
            // 
            lblCellPhone.AutoSize = true;
            lblCellPhone.Font = new Font("Segoe UI", 12F);
            lblCellPhone.Location = new Point(59, 285);
            lblCellPhone.Name = "lblCellPhone";
            lblCellPhone.Size = new Size(87, 21);
            lblCellPhone.TabIndex = 6;
            lblCellPhone.Text = "Cell Phone:";
            // 
            // lblHomePhone
            // 
            lblHomePhone.AutoSize = true;
            lblHomePhone.Font = new Font("Segoe UI", 12F);
            lblHomePhone.Location = new Point(43, 241);
            lblHomePhone.Name = "lblHomePhone";
            lblHomePhone.Size = new Size(103, 21);
            lblHomePhone.TabIndex = 5;
            lblHomePhone.Text = "Home Phone:";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Font = new Font("Segoe UI", 12F);
            lblPostalCode.Location = new Point(52, 197);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(94, 21);
            lblPostalCode.TabIndex = 4;
            lblPostalCode.Text = "Postal Code:";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Font = new Font("Segoe UI", 12F);
            tbCustomerName.Location = new Point(152, 13);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(250, 29);
            tbCustomerName.TabIndex = 8;
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI", 12F);
            tbAddress.Location = new Point(152, 57);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(250, 29);
            tbAddress.TabIndex = 9;
            // 
            // tbProvince
            // 
            tbProvince.Font = new Font("Segoe UI", 12F);
            tbProvince.Location = new Point(152, 145);
            tbProvince.Name = "tbProvince";
            tbProvince.Size = new Size(250, 29);
            tbProvince.TabIndex = 11;
            // 
            // tbCity
            // 
            tbCity.Font = new Font("Segoe UI", 12F);
            tbCity.Location = new Point(152, 101);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(250, 29);
            tbCity.TabIndex = 10;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 12F);
            tbEmail.Location = new Point(152, 321);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(250, 29);
            tbEmail.TabIndex = 15;
            // 
            // tbCellPhone
            // 
            tbCellPhone.Font = new Font("Segoe UI", 12F);
            tbCellPhone.Location = new Point(152, 277);
            tbCellPhone.Name = "tbCellPhone";
            tbCellPhone.Size = new Size(250, 29);
            tbCellPhone.TabIndex = 14;
            // 
            // tbHomePhone
            // 
            tbHomePhone.Font = new Font("Segoe UI", 12F);
            tbHomePhone.Location = new Point(152, 233);
            tbHomePhone.Name = "tbHomePhone";
            tbHomePhone.Size = new Size(250, 29);
            tbHomePhone.TabIndex = 13;
            // 
            // tbPostalCode
            // 
            tbPostalCode.Font = new Font("Segoe UI", 12F);
            tbPostalCode.Location = new Point(152, 189);
            tbPostalCode.Name = "tbPostalCode";
            tbPostalCode.Size = new Size(250, 29);
            tbPostalCode.TabIndex = 12;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.Font = new Font("Segoe UI", 10F);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(19, 371);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(407, 92);
            lblErrorMessage.TabIndex = 16;
            lblErrorMessage.Text = "Error Messages";
            lblErrorMessage.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblMakeModel
            // 
            lblMakeModel.AutoSize = true;
            lblMakeModel.Font = new Font("Segoe UI", 12F);
            lblMakeModel.Location = new Point(463, 21);
            lblMakeModel.Name = "lblMakeModel";
            lblMakeModel.Size = new Size(129, 21);
            lblMakeModel.TabIndex = 17;
            lblMakeModel.Text = "Make and Model:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 12F);
            lblYear.Location = new Point(549, 65);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(43, 21);
            lblYear.TabIndex = 18;
            lblYear.Text = "Year:";
            // 
            // lblApptDate
            // 
            lblApptDate.AutoSize = true;
            lblApptDate.Font = new Font("Segoe UI", 12F);
            lblApptDate.Location = new Point(452, 109);
            lblApptDate.Name = "lblApptDate";
            lblApptDate.Size = new Size(140, 21);
            lblApptDate.TabIndex = 19;
            lblApptDate.Text = "Appointment Date:";
            // 
            // tbMakeModel
            // 
            tbMakeModel.Font = new Font("Segoe UI", 12F);
            tbMakeModel.Location = new Point(598, 13);
            tbMakeModel.Name = "tbMakeModel";
            tbMakeModel.Size = new Size(250, 29);
            tbMakeModel.TabIndex = 20;
            // 
            // tbYear
            // 
            tbYear.Font = new Font("Segoe UI", 12F);
            tbYear.Location = new Point(598, 57);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(250, 29);
            tbYear.TabIndex = 21;
            // 
            // dateApptPicker
            // 
            dateApptPicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateApptPicker.Location = new Point(598, 101);
            dateApptPicker.Name = "dateApptPicker";
            dateApptPicker.Size = new Size(250, 29);
            dateApptPicker.TabIndex = 22;
            // 
            // lblProblem
            // 
            lblProblem.AutoSize = true;
            lblProblem.Font = new Font("Segoe UI", 12F);
            lblProblem.Location = new Point(452, 153);
            lblProblem.Name = "lblProblem";
            lblProblem.Size = new Size(72, 21);
            lblProblem.TabIndex = 23;
            lblProblem.Text = "Problem:";
            // 
            // richtbProblem
            // 
            richtbProblem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richtbProblem.Location = new Point(452, 177);
            richtbProblem.Name = "richtbProblem";
            richtbProblem.Size = new Size(396, 230);
            richtbProblem.TabIndex = 24;
            richtbProblem.Text = "";
            // 
            // btnBookAppt
            // 
            btnBookAppt.AutoSize = true;
            btnBookAppt.Font = new Font("Segoe UI", 12F);
            btnBookAppt.Location = new Point(452, 423);
            btnBookAppt.Name = "btnBookAppt";
            btnBookAppt.Size = new Size(150, 40);
            btnBookAppt.TabIndex = 25;
            btnBookAppt.Text = "Book Appointment";
            btnBookAppt.UseVisualStyleBackColor = true;
            btnBookAppt.Click += btnBookAppt_Click;
            // 
            // btnReset
            // 
            btnReset.AutoSize = true;
            btnReset.Font = new Font("Segoe UI", 12F);
            btnReset.Location = new Point(608, 423);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(70, 40);
            btnReset.TabIndex = 26;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Location = new Point(684, 423);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(69, 40);
            btnClose.TabIndex = 27;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnPrefill
            // 
            btnPrefill.AutoSize = true;
            btnPrefill.Font = new Font("Segoe UI", 12F);
            btnPrefill.Location = new Point(759, 423);
            btnPrefill.Name = "btnPrefill";
            btnPrefill.Size = new Size(89, 40);
            btnPrefill.TabIndex = 28;
            btnPrefill.Text = "Pre-fill";
            btnPrefill.UseVisualStyleBackColor = true;
            btnPrefill.Click += btnPrefill_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 475);
            Controls.Add(btnPrefill);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(btnBookAppt);
            Controls.Add(richtbProblem);
            Controls.Add(lblProblem);
            Controls.Add(dateApptPicker);
            Controls.Add(tbYear);
            Controls.Add(tbMakeModel);
            Controls.Add(lblApptDate);
            Controls.Add(lblYear);
            Controls.Add(lblMakeModel);
            Controls.Add(lblErrorMessage);
            Controls.Add(tbEmail);
            Controls.Add(tbCellPhone);
            Controls.Add(tbHomePhone);
            Controls.Add(tbPostalCode);
            Controls.Add(tbProvince);
            Controls.Add(tbCity);
            Controls.Add(tbAddress);
            Controls.Add(tbCustomerName);
            Controls.Add(lblEmail);
            Controls.Add(lblCellPhone);
            Controls.Add(lblHomePhone);
            Controls.Add(lblPostalCode);
            Controls.Add(lblProvince);
            Controls.Add(lblCity);
            Controls.Add(lblAddress);
            Controls.Add(lblCustomerName);
            Name = "Form1";
            Text = "Car Maintenance Booking System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private Label lblAddress;
        private Label lblProvince;
        private Label lblCity;
        private Label lblEmail;
        private Label lblCellPhone;
        private Label lblHomePhone;
        private Label lblPostalCode;
        private TextBox tbCustomerName;
        private TextBox tbAddress;
        private TextBox tbProvince;
        private TextBox tbCity;
        private TextBox tbEmail;
        private TextBox tbCellPhone;
        private TextBox tbHomePhone;
        private TextBox tbPostalCode;
        private Label lblErrorMessage;
        private Label lblMakeModel;
        private Label lblYear;
        private Label lblApptDate;
        private TextBox tbMakeModel;
        private TextBox tbYear;
        private DateTimePicker dateApptPicker;
        private Label lblProblem;
        private RichTextBox richtbProblem;
        private Button btnBookAppt;
        private Button btnReset;
        private Button btnClose;
        private Button btnPrefill;
    }
}
