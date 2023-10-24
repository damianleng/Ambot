﻿using System;
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
    public partial class international : UserControl
    {
        public international()
        {
            InitializeComponent();
        }

        private void international_Load(object sender, EventArgs e)
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
                    enrollment back = new enrollment();
                    form1.SwitchUserControl(back); // switch the user to the contact page
                    break;
                case Form1.button1Value:
                    home home = new home();
                    form1.SwitchUserControl(home); // switch the user to the contact page
                    break;
                case Form1.button9Value:
                    criteria criteria = new criteria();
                    form1.SwitchUserControl(criteria); // switch the user to the contact page
                    break;
                default:
                    break;
            }
        }
    }
}