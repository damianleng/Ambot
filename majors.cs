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

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            // Raise a custom event to signal the request to go back to the home page
            RequestGoBackToHome?.Invoke(this, EventArgs.Empty);
        }

        private void singleBtn_Click(object sender, EventArgs e)
        {
            RequestNavigateToSingle?.Invoke(this, EventArgs.Empty);
        }
    }
}
