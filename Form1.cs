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
        public const string button9Value = "D9";


        //global variable for size, but need to consider because of the content design
        public const int Width = 1920;
        public const int Height = 1080;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Add(homePage);
            homePage.Focus();
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
