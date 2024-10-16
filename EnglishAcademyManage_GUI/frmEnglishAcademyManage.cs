using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;


namespace EnglishAcademyManage_GUI
{
    public partial class frmEnglishAcademyManage : Form
    {
        public frmEnglishAcademyManage(string role)
        {
            InitializeComponent();
            CustomizeUIBasedOnRole(role);
        }

        private void CustomizeUIBasedOnRole(string role)
        {
            if (role == "admin")
            {
                // Hiển thị các tính năng cho admin
            }
            else if (role == "employee")
            {
                // Hiển thị các tính năng cho employee
            }
            else if (role == "teacher")
            {
                // Hiển thị các tính năng cho teacher
            }
            else if (role == "student")
            {
                // Hiển thị các tính năng cho student
            }

        }
    }
}
