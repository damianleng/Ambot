using Ambot.Majors.SingleDegreeFolder.ITFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambot.Majors.SingleDegreeFolder
{
    public partial class Information_Technology : UserControl
    {

        public Information_Technology()
        {
            InitializeComponent();
        }

        private void Information_Technology_Load(object sender, EventArgs e)
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
                    ICT ict = new ICT();
                    form1.SwitchUserControl(ict); // switch the user to the news page
                    break;
                case Form1.button2Value:
                    // Create and display the News user control (adjust as needed)
                    Software_Development software = new Software_Development();
                    form1.SwitchUserControl(software); // switch the user to the news page
                    break;
                case Form1.button3Value:
                    // Create and display the News user control (adjust as needed)
                    Cyber_Security Cyber = new Cyber_Security();
                    form1.SwitchUserControl(Cyber); // switch the user to the news page
                    break;
                case Form1.button4Value:
                    // Create and display the News user control (adjust as needed)
                    Cloud_Computing cloud = new Cloud_Computing();
                    form1.SwitchUserControl(cloud); // switch the user to the news page
                    break;
                case Form1.button7Value:
                    // Create and display the News user control (adjust as needed)
                    SingleDegree single = new SingleDegree();
                    form1.SwitchUserControl(single); // switch the user to the news page
                    break;
                default:
                    break;
            }
        }
    }
}
