using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambot.ScholarshipsFolder
{
    public partial class FullScholarships : UserControl
    {
        public FullScholarships()
        {
            InitializeComponent();
        }

        private void FullScholarships_Load(object sender, EventArgs e)
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
                case Form1.button5Value:
                    scholarships scholarships = new scholarships();
                    form1.SwitchUserControl(scholarships); // switch the user to the contact page
                    break;
                case Form1.button1Value:
                    home home = new home();
                    form1.SwitchUserControl(home); // switch the user to the contact page
                    break;
                default:
                    break;
            }
        }
    }
}
