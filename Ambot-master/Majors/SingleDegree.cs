﻿using Ambot.Majors.SingleDegreeFolder;
using System;
using System.Windows.Forms;

namespace Ambot.Majors
{
    public partial class SingleDegree : UserControl

    {
        public SingleDegree()
        {
            InitializeComponent();
        }

        private void SingleDegree_Load(object sender, EventArgs e)
        {
            pillButton1.KeyDown += PressDownKey;
            pillButton1.Focus();
        }

        private void PressDownKey(object sender, KeyEventArgs e)
        {

            Form1 form1 = this.ParentForm as Form1;

            switch (e.KeyCode.ToString())
            {
                case "D1":
                    // Create and display the News user control (adjust as needed)
                    Information_Technology IT = new Information_Technology();
                    form1.SwitchUserControl(IT); // switch the user to the news page
                    break;
                case "D2":
                    // Create and display the News user control (adjust as needed)
                    Business business = new Business();
                    form1.SwitchUserControl(business); // switch the user to the news page
                    break;
                case "D3":
                    // Create and display the News user control (adjust as needed)
                    Global_Affair GA = new Global_Affair();
                    form1.SwitchUserControl(GA); // switch the user to the news page
                    break;
                case "D4":
                    // Create and display the News user control (adjust as needed)
                    Law law = new Law();
                    form1.SwitchUserControl(law); // switch the user to the news page
                    break;
                case "D7":
                    // Create and display the News user control (adjust as needed)
                    majors_sample2 major = new majors_sample2();
                    form1.SwitchUserControl(major); // switch the user to the news page
                    break;
                default: 
                    break;
            }
        }
    }
}