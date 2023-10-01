using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambot
{
    public partial class Form1 : Form
    {
        private home homePage = new home(); // create an object for the home page
        public Form1()
        {
            InitializeComponent();
            homePage.ButtonClicked += HomePage_ButtonClicked; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Add(homePage);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void HomePage_ButtonClicked(object sender, string buttonName) // function for linkig users to other pages
        {
            switch (buttonName)
            {
                case "News":
                    // Create and display the News user control (adjust as needed)
                    news newsControl = new news();
                    newsControl.RequestGoBackToHome += RequestGoBackToHome; // Subscribe to the custom event to go back home
                    SwitchUserControl(newsControl); // switch the user to the news page
                    break;
                case "Majors":
                    // Create and display the Majors user control (adjust as needed)
                    majors majorControl = new majors();
                    majorControl.RequestGoBackToHome += RequestGoBackToHome; // Subscribe to the custom event to go back home
                    majorControl.RequestNavigateToSingle += MajorControl_RequestNavigateToSingle; // Subscribe to the RequestNavigateToSingle event
                    SwitchUserControl(majorControl); // switch the user to the majors page
                    break;
                    // Add more cases for other buttons as needed
            }
        }

        private void MajorControl_RequestNavigateToSingle(object sender, EventArgs e)
        {
            // Create and display the Single user control (adjust as needed)
            majors_single singleControl = new majors_single();
            // Subscribe to the RequestGoBackToHome event
            singleControl.RequestGoBackToHome += RequestGoBackToHome;
            SwitchUserControl(singleControl);
        }

        private void RequestGoBackToHome(object sender, EventArgs e)
        {
            // Create and display the Home user control (adjust as needed)
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(homePage);
            homePage.Dock = DockStyle.Fill;
        }

        // Method to switch between user controls in the mainPanel
        private void SwitchUserControl(UserControl userControl)
        {
            mainPanel.Controls.Clear(); // Clear the mainPanel
            mainPanel.Controls.Add(userControl); // Add the new user control
            userControl.Dock = DockStyle.Fill; // Dock the new user control to fill the mainPanel
        }
    }
}
