using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EnglishAcademyManage_GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }
        private void InitializeCustomComponents()
        {
            this.Text = "Login";
            this.Size = new Size(600, 400); // Form size
            this.StartPosition = FormStartPosition.CenterScreen; // Center the form on the screen
            this.MaximizeBox = false; // Hide maximize button
            this.MinimizeBox = false; // Hide minimize button
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Fixed border style

            // Add Panel to contain the PictureBox for better layout
            Panel logoPanel = new Panel
            {
                Size = new Size(250, 250), // Size of the panel
                Location = new Point(20, 20), // Position of the panel
                BackColor = Color.LightGray, // Background color for the panel
                BorderStyle = BorderStyle.FixedSingle // Optional border around the panel
            };

            // Add PictureBox to display image
            PictureBox logoPictureBox = new PictureBox
            {
                Image = Image.FromFile("C:\\Users\\maidi\\OneDrive\\Desktop\\Mai Diệu Mi\\EnglishAcademyManage\\EnglishAcademyManage_GUI\\Images\\ISELogin.jpg"), // Path to image
                SizeMode = PictureBoxSizeMode.Zoom, // Maintain aspect ratio
                Size = new Size(250, 250), // Size to match the panel
                Location = new Point(0, 0) // Position within the panel
            };

            // Add PictureBox to the panel
            logoPanel.Controls.Add(logoPictureBox);

            // Add the panel to the form
            this.Controls.Add(logoPanel);



            // Title
            SiticoneButton titleButton = new SiticoneButton
            {
                Text = "Login",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                Location = new Point(300, 20), // Centered
                Size = new Size(200, 40), // Increased size for better appearance
                BorderRadius = 10, // Rounded corners
                FillColor = Color.Transparent,
                ForeColor = Color.Black,
                HoverState = { FillColor = Color.Transparent } // Ensure background color when hover
            };

            titleButton.Click += (s, e) => { /* No action needed on click */ };
            this.Controls.Add(titleButton);

            // Username
            SiticoneTextBox usernameTextBox = new SiticoneTextBox
            {
                PlaceholderText = "Username",
                Size = new Size(250, 40),
                Location = new Point(300, 80),
                BorderRadius = 8,
                BorderColor = Color.Gray,
                PlaceholderForeColor = Color.Gray,
                ForeColor = Color.Black,
            };
            this.Controls.Add(usernameTextBox);

            string eyeOpenIconPath = "C:\\Users\\maidi\\OneDrive\\Desktop\\Mai Diệu Mi\\EnglishAcademyManage\\EnglishAcademyManage_GUI\\Images\\eye_open.png"; // Eye open icon
            string eyeClosedIconPath = "C:\\Users\\maidi\\OneDrive\\Desktop\\Mai Diệu Mi\\EnglishAcademyManage\\EnglishAcademyManage_GUI\\Images\\eye_closed.png"; // Eye closed icon

            // Password
            SiticoneTextBox passwordTextBox = new SiticoneTextBox
            {
                PlaceholderText = "Password",
                Size = new Size(250, 40),
                Location = new Point(300, 130),
                BorderRadius = 8,
                BorderColor = Color.Gray,
                PlaceholderForeColor = Color.Gray,
                ForeColor = Color.Black,
                UseSystemPasswordChar = true,
                IconRight = Image.FromFile(eyeClosedIconPath), // Set initial icon to eye closed
                IconRightSize = new Size(20, 20)
            };

            // Event handler to toggle password visibility
            bool isPasswordVisible = false;
            passwordTextBox.IconRightClick += (s, e) =>
            {
                isPasswordVisible = !isPasswordVisible;
                passwordTextBox.UseSystemPasswordChar = !isPasswordVisible;

                // Toggle the icon based on visibility
                passwordTextBox.IconRight = isPasswordVisible
                    ? Image.FromFile(eyeOpenIconPath) // Show password icon
                    : Image.FromFile(eyeClosedIconPath); // Hide password icon
            };
            this.Controls.Add(passwordTextBox);

            // ComboBox to select user role
            SiticoneComboBox roleComboBox = new SiticoneComboBox
            {
                Size = new Size(250, 40),
                Location = new Point(300, 180),
                BorderRadius = 8,
                ForeColor = Color.Black
            };
            roleComboBox.Items.AddRange(new string[] { "Administrator", "Employee", "Teacher", "Student" });
            roleComboBox.SelectedIndex = 0; // Default select "Administrator"
            this.Controls.Add(roleComboBox);

            // Remember password checkbox
            SiticoneCheckBox rememberCheckBox = new SiticoneCheckBox
            {
                Text = "Remember password",
                Location = new Point(300, 230),
                AutoSize = true,
                ForeColor = Color.Black // Text color
            };
            this.Controls.Add(rememberCheckBox);

            // Login button
            SiticoneButton loginButton = new SiticoneButton
            {
                Text = "Login",
                Size = new Size(100, 40),
                Location = new Point(300, 270),
                BorderRadius = 10,
                FillColor = Color.Blue,
                ForeColor = Color.White,
                HoverState = { FillColor = Color.DarkBlue } // Change background color on hover
            };
            loginButton.Click += (s, e) =>
            {
                // Validate login information
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;
                string selectedRole = roleComboBox.SelectedItem.ToString();

                // Perform login validation
                if (IsLoginValid(username, password, selectedRole))
                {
                    MessageBox.Show($"Login successful with role: {selectedRole}");
                    // Open main form here
                    // FormMain mainForm = new FormMain(selectedRole);
                    // mainForm.Show();
                    // this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            this.Controls.Add(loginButton);

            // Forgot password button
            SiticoneButton forgotPasswordButton = new SiticoneButton
            {
                Text = "Forgot password?",
                Size = new Size(130, 30),
                Location = new Point(420, 230),
                BorderRadius = 10,
                FillColor = Color.Transparent,
                ForeColor = Color.Blue,
                HoverState = { FillColor = Color.LightBlue } // Change background color on hover
            };
            forgotPasswordButton.Click += (s, e) =>
            {
                // Handle forgot password event
                MessageBox.Show("Please contact the administrator to retrieve your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            this.Controls.Add(forgotPasswordButton);

            // Exit button
            SiticoneButton exitButton = new SiticoneButton
            {
                Text = "Exit",
                Size = new Size(100, 40),
                Location = new Point(420, 270),
                BorderRadius = 10,
                FillColor = Color.BlueViolet,
                ForeColor = Color.White,
                HoverState = { FillColor = Color.DarkRed } // Change background color on hover
            };
            exitButton.Click += (s, e) =>
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    this.Close(); // Close the application
                }
            };
            this.Controls.Add(exitButton);
        }

        // Method to validate login information
        private bool IsLoginValid(string username, string password, string role)
        {
            // You can modify the login validation logic as needed
            // Below is a simple example:

            // Sample list of valid login information
            var validUsers = new[]
            {
                new { Username = "admin", Password = "admin123", Role = "Administrator" },
                new { Username = "teacher", Password = "teacher123", Role = "Teacher" },
                new { Username = "student", Password = "student123", Role = "Student" },
                new { Username = "employee", Password = "employee123", Role = "Employee" },
            };

            // Validate login information
            foreach (var user in validUsers)
            {
                if (user.Username == username && user.Password == password && user.Role == role)
                {
                    return true; // Login successful
                }
            }
            return false; // Login failed
        }
    }
}

//PictureBox logoPictureBox = new PictureBox
//{
//    Image = Image.FromFile("C:\\Users\\maidi\\OneDrive\\Desktop\\Mai Diệu Mi\\EnglishAcademyManage\\EnglishAcademyManage_GUI\\Images\\ISELogin.jpg"), // Đường dẫn đến hình ảnh
//    SizeMode = PictureBoxSizeMode.Zoom, // Giữ tỉ lệ hình ảnh
//    Size = new Size(200, 200), // Kích thước hình ảnh
//    Location = new Point(10, 10) // Vị trí hình ảnh
//};
//this.Controls.Add(logoPictureBox);


