using System.Text;

/*
 * Assignment 2 - PROG1965
 * 
 * March 16th, 2024
 * 
 * Fernando Carvalho de Souza
 * Mauricio Lechuga
 */

namespace Assignment2
{
    /// <summary>
    /// 
    /// 1.  When the email is entered, Capitalize() is not working on the rest of inputs.
    ///     The email validation function is not working even though I checked the regex.
    ///     
    /// 2.  I am not sure where to place the SaveToFile method so it only saves when everything is valid.
    ///     I know it must be somewhere in the first IF, but it's confusing with so many checks.
    ///     
    /// </summary>
    public partial class Form1 : Form
    {
        private string fileName = "appointments.txt";

        public Form1()
        {
            InitializeComponent();
            dateApptPicker.Value = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e) // Clears the error label
        {
            lblErrorMessage.Text = string.Empty;
        }

        private void btnBookAppt_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = string.Empty;   // Clear error messages

            StringBuilder errorMessages = new StringBuilder();

            if (!string.IsNullOrEmpty(tbCustomerName.Text))     // Validate customer name
            {
                tbCustomerName.Text = ValidationHelper.Capitalize(tbCustomerName.Text);
            }
            else
            {
                errorMessages.AppendLine("A customer name is required to book an appointment.");
                tbCustomerName.Focus();
            }

            if (string.IsNullOrEmpty(tbEmail.Text))     // If empty require adress, city, postal and province codes
            {
                if (string.IsNullOrEmpty(tbAddress.Text)) // Address
                {
                    errorMessages.AppendLine("A valid Canadian address is required.");
                    tbAddress.Focus();
                }
                else
                {
                    tbAddress.Text = ValidationHelper.Capitalize(tbAddress.Text);
                }

                if (string.IsNullOrEmpty(tbCity.Text))  // City
                {
                    errorMessages.AppendLine("A valid Canadian city is required.");
                    tbCity.Focus();
                }
                else
                {
                    tbCity.Text = ValidationHelper.Capitalize(tbCity.Text);
                }

                if (string.IsNullOrEmpty(tbProvince.Text))  // Province code
                {
                    errorMessages.AppendLine("A valid Canadian two-letter province code is required.");
                    tbProvince.Focus();
                }
                else
                {
                    string provinceCode = tbProvince.Text;
                    bool isProvinceValid = ValidationHelper.IsValidProvinceCode(provinceCode);
                    if (isProvinceValid)
                    {
                        tbProvince.Text = provinceCode.ToUpper();
                    }
                    else
                    {
                        errorMessages.AppendLine("A valid Canadian two-letter province code is required.");
                        tbProvince.Focus();
                    }
                }

                if (string.IsNullOrEmpty(tbPostalCode.Text))    // Postal code
                {
                    errorMessages.AppendLine("A valid Canadian 6-character postal code is required.");
                    tbPostalCode.Focus();
                }
                else
                {
                    string postalCode = tbPostalCode.Text;  // Validates Postal Code
                    bool isPostalValid = ValidationHelper.IsValidPostalCode(postalCode, out string reformatPostalCode);
                    if (isPostalValid)
                    {
                        tbPostalCode.Text = reformatPostalCode;
                    }
                    else
                    {
                        errorMessages.AppendLine("A valid Canadian 6-character postal code is required.");
                        tbPostalCode.Focus();
                    }
                }
            }
            else
            {
                string email = tbEmail.Text;    // Validates email
                bool isEmailValid = ValidationHelper.IsEmailValid(email, out string reformatEmail);
                if (isEmailValid)
                {
                    tbEmail.Text = reformatEmail;
                }
            }

            // Validates that at least one of the phone numbers are entered
            if (string.IsNullOrEmpty(tbHomePhone.Text) && string.IsNullOrEmpty(tbCellPhone.Text))
            {
                errorMessages.AppendLine("Please provide a home phone or a cell phone number.");
            }

            string homePhone = tbHomePhone.Text;    // Validating home phone
            bool isHomePhoneValid = ValidationHelper.IsValidPhoneNumber(homePhone, out string reformatHomePhone);
            if (isHomePhoneValid)
            {
                tbHomePhone.Text = reformatHomePhone;
            }

            string cellPhone = tbCellPhone.Text;    // Validating cell phone
            bool isCellPhoneValid = ValidationHelper.IsValidPhoneNumber(cellPhone, out string reformatCellPhone);
            if (isCellPhoneValid)
            {
                tbCellPhone.Text = reformatCellPhone;
            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////
            
            if (string.IsNullOrEmpty(tbMakeModel.Text)) // Validates make and model
            {
                errorMessages.AppendLine("Make and model of car are required.");
                tbMakeModel.Focus();
            }
            else
            {
                tbMakeModel.Text = ValidationHelper.Capitalize(tbMakeModel.Text);
            }

            string yearInput = tbYear.Text; // Validates that year follows current year + 1
            bool isYearValid = ValidationHelper.IsYearValid(yearInput);
            if (isYearValid)
            {
                tbYear.Text = yearInput;
            }
            else
            {
                errorMessages.AppendLine("That is not a valid year.");
                tbYear.Focus();
            }

            DateTime selectedDate = dateApptPicker.Value;   // Validates that date is in the future
            if (ValidationHelper.IsDateFuture(selectedDate))
            {
                dateApptPicker.Value = selectedDate;
            }
            else
            {
                errorMessages.AppendLine("Appointment date is required and must be in the future.");
                tbYear.Focus();
            }
            
            string errorMessage  = errorMessages.ToString().Trim(); // Prints all the errors for missing information.

            if (!string.IsNullOrEmpty(errorMessage))
            {
                lblErrorMessage.Text = errorMessage;
            }
            else
            {
                lblErrorMessage.Text = string.Empty;
            }

            string appointmentInfo = GetAppointmentInfo();

            SaveToFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName), appointmentInfo);

            string GetAppointmentInfo()
            {
                return $"Date: {dateApptPicker.Value}, Name: {tbCustomerName.Text}, Address: {tbAddress.Text}, {tbCity.Text}, {tbProvince.Text}, {tbPostalCode.Text}, Phones: {tbHomePhone.Text} / {tbCellPhone.Text}, Email: {tbEmail.Text}, Car Info: {tbYear.Text} {tbMakeModel.Text}";
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
            tbPostalCode.Text = "n2l4n7";
            tbHomePhone.Text = "1234567890";
            tbCellPhone.Text = "9876543210";
            tbEmail.Text = "random@name.com";
            tbMakeModel.Text = "subaru forester";
            tbYear.Text = "2020";
        }

        // Closes the program
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Saves the info to file
        public void SaveToFile(string filePath, string content)
        {
            try
            {
                content = content.Replace(Environment.NewLine, "|");    // To manage multiline issues

                bool fileExists = File.Exists(filePath);    // Checks if the file exists

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    if (!fileExists)
                    {
                        sw.WriteLine("Date | Name | Address | Phones | Email | Car info");
                    }
                    sw.WriteLine(content);
                }
                MessageBox.Show($"Appointment saved to: {filePath}", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving appointment: {ex.Message}", "Error");
            }
        }

    }
}
