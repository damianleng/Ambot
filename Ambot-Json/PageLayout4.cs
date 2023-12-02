using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambot_Json
{
    public partial class PageLayout4 : UserControl
    {
        private JsonObject.Root data = JsonObject.Root.Deserialize();
        public PageLayout4()
        {
            InitializeComponent();
            string pageName = mainPanel.currentPage;

            backBtn.Text = data.Pages[pageName].Button.buttonText["5"];
            Image image = ImageLoader.LoadImage(data.Pages[pageName].Avatar.avatar_image);
            pictureBox1.Image = image;
            label1.Text = data.Pages[pageName].Contents.title;
            label2.Text = data.Pages[pageName].Avatar.bubble_text1;
            label2.BackColor = Color.White;

            Image imageQR = ImageLoader.LoadImage(data.Pages[pageName].Contents.QR_image);
            pictureBox4.Image = imageQR;

        }

        private void PageLayout4_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
