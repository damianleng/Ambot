using System;
using System.Windows.Forms;

namespace Ambot
{
    public partial class Form1 : Form
    {
        private home homePage = new home(); // create an object for the home page


        //global button variable
        public const string button1Value = "D1";
        public const string button2Value = "D2";
        public const string button3Value = "D3";
        public const string button4Value = "D4";
        public const string button5Value = "D5";
        public const string button6Value = "D6";
        public const string button7Value = "D7";
        public const string button8Value = "D8";


        //global variable for size, but need to consider because of the content design
        public const int Width = 1920;
        public const int Height = 1080;

        public Form1()
        {
            InitializeComponent();

            homePage.ButtonClicked += HomePage_ButtonClicked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Add(homePage);
        }

        private void HomePage_ButtonClicked(object sender, string buttonName) // function for linkig users to other pages
        {
            switch (buttonName)
            {
                case "News":
                    // Create and display the News user control (adjust as needed)
                    news newsControl = new news();
                    SwitchUserControl(newsControl); // switch the user to the news page
                    break;
                case "Majors":
                    // Create and display the Majors user control (adjust as needed)
                    //majors majorControl = new majors();
                    majors_sample2 majorControl = new majors_sample2();
                    //majorControl.RequestNavigateToSingle += MajorControl_RequestNavigateToSingle; // Subscribe to the RequestNavigateToSingle event
                    SwitchUserControl(majorControl); // switch the user to the majors page
                    break;
                    // Add more cases for other buttons as needed
            }
        }

        // Method to switch between user controls in the mainPanel
        public void SwitchUserControl(UserControl userControl)
        {
            mainPanel.Controls.Clear(); // Clear the mainPanel
            mainPanel.Controls.Add(userControl); // Add the new user control
            userControl.Dock = DockStyle.Fill; // Dock the new user control to fill the mainPanel
        }
    }
}
