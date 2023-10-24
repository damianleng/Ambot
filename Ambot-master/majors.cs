using Ambot.Majors;
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
    public partial class majors : UserControl
    {
        public event EventHandler RequestGoBackToHome; // create an event handler for going back home
        public event EventHandler RequestNavigateToSingle; // create an event handle to go to single degree

        public majors()
        {
            InitializeComponent();
        }

        private void majors_Load(object sender, EventArgs e)
        {
            // Set the Tag property of each button to the name of the page that you want to navigate to when the button is clicked.
            button1.Tag = "SingleDegree";
            button2.Tag = "DualDegree";
            button3.Tag = "Master";
            button4.Tag = "Home";

            // Subscribe to the Click event of each button.
            button1.Click += ButtonClicked;
            button2.Click += ButtonClicked;
            button3.Click += ButtonClicked;

        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Form1 form1 = this.ParentForm as Form1;

            // Get the name of the page that you want to navigate to from the Tag property of the sender button.
            string buttonName = (sender as Button).Tag.ToString();

            // Navigate to the page.
            switch (buttonName)
            {
                case "SingleDegree":
                    // Create and display the News user control (adjust as needed)
                    SingleDegree single = new SingleDegree();
                    form1.SwitchUserControl(single); // switch the user to the news page
                    break;
                case "DualDegree":
                    // Create and display the Majors user control (adjust as needed)
                    DualDegree dual = new DualDegree();
                    form1.SwitchUserControl(dual); // switch the user to the majors page
                    break;
                case "Master":
                    // Create and display the Contact user control (adjust as needed)
                    Master master = new Master();
                    form1.SwitchUserControl(master); // switch the user to the contact page
                    break;
                    // Add more cases for other buttons as needed
            }
        }

    }
}
