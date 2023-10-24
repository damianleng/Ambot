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
            Form1 form1 = this.ParentForm as Form1;
            switch (btnValue)
            {
                case Form1.button5Value:
                    home back = new home();
                    form1.SwitchUserControl(back); // switch the user to the contact page
                    break;
                case Form1.button9Value:
                    home home = new home();
                    form1.SwitchUserControl(home); // switch the user to the contact page
                    break;
                default:
                    break;
            }
        }

    }
}
