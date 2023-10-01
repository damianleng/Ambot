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
    public partial class news : UserControl
    {
        public event EventHandler RequestGoBackToHome; // create an event handler for going back home
        public news()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            // Raise a custom event to signal the request to go back to the home page
            RequestGoBackToHome?.Invoke(this, EventArgs.Empty); 
        }

        private void news_Load(object sender, EventArgs e)
        {

        }
    }
}
