﻿using System;
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
    public partial class Software_Development : UserControl
    {
        public Software_Development()
        {
            InitializeComponent();
        }

        private void Software_Development_Load(object sender, EventArgs e)
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
                // Add more cases for other buttons as needed
                case Form1.button7Value:
                    // Create and display the Contact user control (adjust as needed)
                    Information_Technology IT = new Information_Technology();
                    form1.SwitchUserControl(IT); // switch the user to the contact page
                    break;
                default:
                    break;
            }
        }
    }
}