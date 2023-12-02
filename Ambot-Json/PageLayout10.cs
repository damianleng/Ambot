using Ambot_Json.CustomButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambot_Json
{
    public partial class PageLayout10 : UserControl
    {
        private JsonObject.Root data = JsonObject.Root.Deserialize();

        public PageLayout10()
        {
            InitializeComponent();

            string pageName = mainPanel.currentPage;

            //Home button
            Image image = ImageLoader.LoadImage("resources/ico/home_icon.png");
            buttonFullRadius1.Image = image;

            //Back Button
            buttonRadiusRight1.Text = data.Pages[pageName].Button.buttonText["5"];
            Image image1 = ImageLoader.LoadImage("resources/ico/arrow.png");
            buttonRadiusRight1.Image = image1;

            //content description
            title1.Text = data.Pages[pageName].Contents.title1;
            title2.Text = data.Pages[pageName].Contents.title2;
            title3.Text = data.Pages[pageName].Contents.title3;

            subtitle1.Text = data.Pages[pageName].Contents.subtitle1;
            subtitle2.Text = data.Pages[pageName].Contents.subtitle2;
            subtitle3.Text = data.Pages[pageName].Contents.subtitle3;

            label1.Text = data.Pages[pageName].Contents.description1;
            label2.Text = data.Pages[pageName].Contents.description2;
            label3.Text = data.Pages[pageName].Contents.description3;

            Image image2 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image1);
            pictureBox1.Image = image2;
        }

        private void PageLayout10_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
