using Ambot_Json.CustomButton;
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
    public partial class PageLayout12 : UserControl
    {
        private JsonObject.Root data = JsonObject.Root.Deserialize();
        public PageLayout12()
        {
            InitializeComponent();

            string pageName = mainPanel.currentPage;

            //Home button
            Image image1 = ImageLoader.LoadImage("resources/ico/home_icon.png");
            buttonFullRadius1.Image = image1;

            //Back Button
            buttonRadiusRight2.Text = data.Pages[pageName].Button.buttonText["5"];
            Image image = ImageLoader.LoadImage("resources/ico/arrow.png");
            buttonRadiusRight2.Image = image;

            //Title

            Image image2 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image3);
            pictureBox3.Image = image2;
            //Subtitles
            label2.Text = data.Pages[pageName].Contents.subtitle1;
            label5.Text = data.Pages[pageName].Contents.subtitle2;
            //descriptions
            label3.Text = data.Pages[pageName].Contents.description1;
            label4.Text = data.Pages[pageName].Contents.description2;

            Image image3 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image1);
            pictureBox1.Image = image3;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Image image4 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image2);
            pictureBox2.Image = image4;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void PageLayout12_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
