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
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        //method that override key event in UserControl that make it work
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData >= Keys.A && keyData <= Keys.Z || keyData >= Keys.D0 && keyData <= Keys.D9)
            {
                SwitchCondition(keyData.ToString());
                // Handle the key press
                return true;
            }
            else
            {
                //if somehow the key event does not work, call the base method
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void SwitchCondition(String btnValue)
        {
            //create form1 object to be able to call method from FORM1
            Form1 form1 = this.ParentForm as Form1;

            switch (btnValue)
            {
                case Form1.button2Value:
                    // Create and display the News user control (adjust as needed)
                    aboutUs aboutUs = new aboutUs();
                    form1.SwitchUserControl(aboutUs); // switch the user to the news page
                    break;
                case Form1.button3Value:
                    // Create and display the News user control (adjust as needed)
                    newsAndEvent news = new newsAndEvent();
                    form1.SwitchUserControl(news);
                    break;
                case Form1.button4Value:
                    // Create and display the News user control (adjust as needed)
                    majors majors = new majors();
                    form1.SwitchUserControl(majors); // switch the user to the news page
                    break;
                case Form1.button5Value:
                    // Create and display the News user control (adjust as needed)
                    scholarships scholarships = new scholarships();
                    form1.SwitchUserControl(scholarships); // switch the user to the news page
                    break;
                case Form1.button6Value:
                    // Create and display the News user control (adjust as needed)
                    enrollment enrollment = new enrollment();
                    form1.SwitchUserControl(enrollment); // switch the user to the news page
                    break;
                case Form1.button7Value:
                    // Create and display the News user control (adjust as needed)
                    partnership partnership = new partnership();
                    form1.SwitchUserControl(partnership); // switch the user to the news page
                    break;
                case Form1.button8Value:
                    // Create and display the News user control (adjust as needed)
                    Facilities facilities = new Facilities();
                    form1.SwitchUserControl(facilities); // switch the user to the news page
                    break;
                default:
                    //if no button or condition needed, do nothing
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRadiusLeft4_Click(object sender, EventArgs e)
        {

        }

        private void buttonRadiusRight2_Click(object sender, EventArgs e)
        {

        }
    }
}
