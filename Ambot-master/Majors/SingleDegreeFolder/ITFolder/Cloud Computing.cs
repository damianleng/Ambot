using Ambot.Majors.DualDegreeFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambot.Majors.SingleDegreeFolder.ITFolder
{
    public partial class Cloud_Computing : UserControl
    {
        public Cloud_Computing()
        {
            InitializeComponent();
        }

        private void Cloud_Computing_Load(object sender, EventArgs e)
        {
            pillButton1.KeyDown += PressDownKey;
            pillButton1.Focus();
        }

        private void PressDownKey(object sender, KeyEventArgs e)
        {

            Form1 form1 = this.ParentForm as Form1;

            switch (e.KeyCode.ToString())
            {
                // Add more cases for other buttons as needed
                case Form1.button7Value:
                    // Create and display the Contact user control (adjust as needed)
                    SingleDegree single = new SingleDegree();
                    form1.SwitchUserControl(single); // switch the user to the contact page
                    break;

                default:
                    break;
            }
        }
    }
}
