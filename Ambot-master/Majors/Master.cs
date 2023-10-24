using Ambot.Majors.MasterFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambot.Majors
{
    public partial class Master : UserControl
    {
        public Master()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)
        {
            pillButton1.KeyDown += PressDownKey;
            pillButton1.Focus();
        }

        private void PressDownKey(object sender, KeyEventArgs e)
        {

            Form1 form1 = this.ParentForm as Form1;

            switch (e.KeyCode.ToString())
            {
                case Form1.button1Value:
                    // Create and display the News user control (adjust as needed)
                    Business_Administration business = new Business_Administration();
                    form1.SwitchUserControl(business); // switch the user to the news page
                    break;
                case Form1.button2Value:
                    // Create and display the Majors user control (adjust as needed)
                    Legal_Studies legal = new Legal_Studies();
                    form1.SwitchUserControl(legal); // switch the user to the majors page
                    break;
                case Form1.button3Value:
                    // Create and display the Contact user control (adjust as needed)
                    MasterLaw law = new MasterLaw();
                    form1.SwitchUserControl(law); // switch the user to the contact page
                    break;
                // Add more cases for other buttons as needed
                case Form1.button4Value:
                    // Create and display the Contact user control (adjust as needed)
                    majors_sample2 major = new majors_sample2();
                    form1.SwitchUserControl(major); // switch the user to the contact page
                    break;

                default:
                    break;
            }
        }
    }
}
