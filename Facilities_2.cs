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
    public partial class Facilities_2 : UserControl
    {
        public Facilities_2()
        {
            InitializeComponent();
        }

        private void Facilities_2_Load(object sender, EventArgs e)
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
                    finance finance = new finance();
                    form1.SwitchUserControl(finance); // switch the user to the contact page
                    break;
                case Form1.button4Value:
                    support support = new support();
                    form1.SwitchUserControl(support); // switch the user to the contact page
                    break;
                case Form1.button7Value:    
                    csi csi = new csi();
                    form1.SwitchUserControl(csi); // switch the user to the contact page
                    break;
                case Form1.button8Value:
                    clinic clinic = new clinic();
                    form1.SwitchUserControl(clinic); // switch the user to the contact page
                    break;
                case Form1.button5Value:
                    Facilities back = new Facilities();
                    form1.SwitchUserControl(back); // switch the user to the contact page
                    break;
                default:
                    break;
            }
        }

    }
}