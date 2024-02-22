using System.Text;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        private const int MinYear = 1900;
        private const int MaxYear = 9999;

        public Form1()
        {
            InitializeComponent();
            dateApptPicker.Value = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBookAppt_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = string.Empty;   // Clear error messages

            StringBuilder errorMessages = new StringBuilder();

            /////////////////////////////// CHECK VALIDATIONS AND ADD ERRORS TO STRINGBUILDER ///////////
            // Validate customer name
            if (!string.IsNullOrEmpty(tbCustomerName.Text))
            {
                tbCustomerName.Text = ValidationHelper.Capitalize(tbCustomerName.Text);
            }
            else
            {
                errorMessages.AppendLine("A customer name is required to book an appointment.");
            }

            // Validate email and address information
            if (!string.IsNullOrEmpty(tbEmail.Text))
            {
                // Email provided, address information optional
                tbAddress.Text = ValidationHelper.Capitalize(tbAddress.Text);
                tbCity.Text = ValidationHelper.Capitalize(tbCity.Text);
                
                // Validating list of provinces and reformatting if needed
                string provinceCode = tbProvince.Text;
                bool isProvinceValid = ValidationHelper.IsValidProvinceCode(provinceCode);
                if (isProvinceValid)
                {
                    tbProvince.Text = provinceCode.ToUpper();
                }

                // Validating and reformatting Postal Code
                string postalCode = tbPostalCode.Text;
                bool isPostalValid = ValidationHelper.IsValidPostalCode(postalCode, out string reformatPostalCode);
                if (isPostalValid)
                {
                    tbPostalCode.Text = reformatPostalCode;
                }
                else 
                {
                    lblErrorMessage.Text = "A valid Canadian postal code is required.";
                }

                // Validating home phone
                string homePhone = tbHomePhone.Text;
                bool isHomePhoneValid = ValidationHelper.IsValidPhoneNumber(homePhone, out string reformatHomePhone);
                if (isHomePhoneValid)
                {
                    tbHomePhone.Text = reformatHomePhone;
                }
                else
                {
                    lblErrorMessage.Text = "A proper 10-digit phone is required.";
                }

                // Validating cell phone
                string cellPhone = tbCellPhone.Text;
                bool isCellPhoneValid = ValidationHelper.IsValidPhoneNumber(cellPhone, out string reformatCellPhone);
                if (isCellPhoneValid)
                {
                    tbCellPhone.Text = reformatCellPhone;
                }
                else
                {
                    lblErrorMessage.Text = "A proper 10-digit phone is required.";
                }
            }

            string errorMessage  = errorMessages.ToString().Trim();

            if (!string.IsNullOrEmpty(errorMessage))
            {
                lblErrorMessage.Text = errorMessage;
            }
            else
            {
                lblErrorMessage.Text = string.Empty;
            }
        }

        // Clears all fields and message box
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbCustomerName.Text= string.Empty;
            tbAddress.Text= string.Empty;
            tbCity.Text= string.Empty;
            tbProvince.Text= string.Empty;
            tbPostalCode.Text= string.Empty;
            tbHomePhone.Text= string.Empty;
            tbCellPhone.Text= string.Empty;
            tbEmail.Text = string.Empty;
            tbMakeModel.Text= string.Empty;
            tbYear.Text= string.Empty;
            lblErrorMessage.Text = string.Empty;
            dateApptPicker.Value = DateTime.Now;
        }

        // Fills some inputs in form with predefined data
        private void btnPrefill_Click(object sender, EventArgs e)
        {
            tbCustomerName.Text = "random name";
            tbAddress.Text = "123 rainbow road";
            tbCity.Text = "waterloo";
            tbProvince.Text = "on";
            tbPostalCode.Text = "N2L4N7";
            tbHomePhone.Text = "1234567890";
            tbCellPhone.Text = "9876543210";
            tbEmail.Text = "random@name.com";
            tbMakeModel.Text = "subaru forester";
            tbYear.Text = "2024";
        }

        // Closes the program
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
