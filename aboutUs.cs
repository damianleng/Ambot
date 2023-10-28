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

    public partial class aboutUs : UserControl
    {
        public event EventHandler RequestGoBackToHome; // create an event handler for going back home
        public aboutUs()
        {
            InitializeComponent();
        }

        private void aboutUs_Load(object sender, EventArgs e)
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
                case Form1.button4Value:
                    history history = new history();
                    form1.SwitchUserControl(history); // switch the user to the contact page
                    break;
                case Form1.button5Value:
                    home back = new home();
                    form1.SwitchUserControl(back); // switch the user to the contact page
                    break;
                case Form1.button8Value:
                    vmv vmv = new vmv();
                    form1.SwitchUserControl(vmv); // switch the user to the contact page
                    break;
                case Form1.button1Value:
                    home home = new home();
                    form1.SwitchUserControl(home); // switch the user to the contact page
                    break;
                default:
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void transparentLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
