using Ambot.Majors.DualDegreeFolder;
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
    public partial class DualDegree : UserControl
    {
        public DualDegree()
        {
            InitializeComponent();
        }

        private void DualDegree_Load(object sender, EventArgs e)
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
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void SwitchCondition(String btnValue)
        {

            Form1 form1 = this.ParentForm as Form1;

            switch (btnValue)
            {
                case Form1.button1Value:
                    // Create and display the News user control (adjust as needed)
                    DualBusiness business = new DualBusiness();
                    form1.SwitchUserControl(business); // switch the user to the news page
                    break;
                case Form1.button2Value:
                    // Create and display the Majors user control (adjust as needed)
                    DualITM ITM = new DualITM();
                    form1.SwitchUserControl(ITM); // switch the user to the majors page
                    break;
                case Form1.button3Value:
                    // Create and display the Contact user control (adjust as needed)
                    DualLaw law = new DualLaw();
                    form1.SwitchUserControl(law); // switch the user to the contact page
                    break;
                // Add more cases for other buttons as needed
                case Form1.button7Value:
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
