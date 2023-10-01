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
    public partial class home : UserControl
    {
        public event EventHandler<string> ButtonClicked;  // event handler to record user clicking different buttons
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void newsBtn_Click(object sender, EventArgs e)
        {
            // Raise the custom event with the name of the button ("News" in this case)
            ButtonClicked?.Invoke(this, "News");
        }

        private void majorsBtn_Click(object sender, EventArgs e)
        {
            // Raise the custom event with the name of the button ("Majors" in this case)
            ButtonClicked?.Invoke(this, "Majors");
        }
    }
}
