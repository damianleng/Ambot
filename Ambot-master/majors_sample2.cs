using Ambot.Majors;
using System;
using System.Windows.Forms;

namespace Ambot
{
    public partial class majors_sample2 : UserControl
    {
        public event EventHandler RequestGoBackToHome; // create an event handler for going back home

        public majors_sample2()
        {
            InitializeComponent();

        }

        private void majors_single_Load(object sender, EventArgs e)
        {
            button1.KeyDown += PressDownKey;
            button1.Focus();

        }

        private void PressDownKey(object sender, KeyEventArgs e)
        {

            Form1 form1 = this.ParentForm as Form1;

            switch (e.KeyCode.ToString())
            {
                case Form1.button1Value:
                    // Create and display the News user control (adjust as needed)
                    SingleDegree single = new SingleDegree();
                    form1.SwitchUserControl(single); // switch the user to the news page
                    break;
                case Form1.button2Value:
                    // Create and display the Majors user control (adjust as needed)
                    DualDegree dual = new DualDegree();
                    form1.SwitchUserControl(dual); // switch the user to the majors page
                    break;
                case Form1.button3Value:
                    // Create and display the Contact user control (adjust as needed)
                    Master master = new Master();
                    form1.SwitchUserControl(master); // switch the user to the contact page
                    break;
                // Add more cases for other buttons as needed
                case Form1.button7Value:
                    // Create and display the Contact user control (adjust as needed)
                    home home = new home();
                    form1.SwitchUserControl(home); // switch the user to the contact page
                    break;

                default:
                    break;
            }
        }


    }
}
