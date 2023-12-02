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
    public partial class PageLayout8 : UserControl
    {
        private JsonObject.Root data = JsonObject.Root.Deserialize();
        public PageLayout8()
        {
            InitializeComponent();
            string pageName = mainPanel.currentPage;
            backBtn.Text = data.Pages[pageName].Button.buttonText["5"];
            label1.Text = data.Pages[pageName].Contents.title;
            label2.Text = data.Pages[pageName].Contents.subtitle1;
            label3.Text = data.Pages[pageName].Contents.description1;
            label4.Text = data.Pages[pageName].Contents.QR_description;

            Image image = ImageLoader.LoadImage(data.Pages[pageName].Contents.image1);
            Image qrImage = ImageLoader.LoadImage(data.Pages[pageName].Contents.QR_image);
            pictureBox1.Image = image;
            pictureBox2.Image = qrImage;
        }

        private void PageLayout8_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
