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
    public partial class Facilities : UserControl
    {
        public Facilities()
        {
            InitializeComponent();
        }

        private void Facilities_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

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
                case Form1.button1Value:
                    home home = new home();
                    form1.SwitchUserControl(home); // switch the user to the contact page
                    break;
                case Form1.button3Value:
                    center center = new center();
                    form1.SwitchUserControl(center); // switch the user to the contact page
                    break;
                case Form1.button4Value:
                    library library = new library();
                    form1.SwitchUserControl(library); // switch the user to the contact page
                    break;
                case Form1.button7Value:
                    club club = new club();
                    form1.SwitchUserControl(club); // switch the user to the contact page
                    break;
                case Form1.button8Value:
                    canteen canteen = new canteen();
                    form1.SwitchUserControl(canteen); // switch the user to the contact page
                    break;
                case Form1.button5Value:
                    home back = new home();
                    form1.SwitchUserControl(back); // switch the user to the contact page
                    break;
                case Form1.button9Value:
                    Facilities_2 next = new Facilities_2();
                    form1.SwitchUserControl(next); // switch the user to the contact page
                    break;
                default:
                    break;
            }
        }

        private void buttonRadiusRight2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRadiusLeft4_Click(object sender, EventArgs e)
        {

        }
    }
}
