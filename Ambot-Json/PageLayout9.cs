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
    public partial class PageLayout9 : UserControl
    {
        private JsonObject.Root data = JsonObject.Root.Deserialize();

        public PageLayout9()
        {
            InitializeComponent();

            string pageName = mainPanel.currentPage;

            //Home button
            Image image1 = ImageLoader.LoadImage("resources/ico/home_icon.png");
            buttonFullRadius1.Image = image1;

            //Back Button
            buttonRadiusRight1.Text = data.Pages[pageName].Button.buttonText["5"];
            Image image = ImageLoader.LoadImage("resources/ico/arrow.png");
            buttonRadiusRight1.Image = image;

            //content description
            title.Text = data.Pages[pageName].Contents.title;

            subtitle.Text = data.Pages[pageName].Contents.subtitle1;

            desc1.Text = data.Pages[pageName].Contents.description1;

            desc2.Text = data.Pages[pageName].Contents.description2;

            desc3.Text = data.Pages[pageName].Contents.description3;

            //Image
            Image image4 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image1);
            pictureBox2.Image = image4;

            //QR code
            Image image3 = ImageLoader.LoadImage(data.Pages[pageName].Contents.QR_image);
            pictureBox1.Image = image3;

            QRtext.Text = data.Pages[pageName].Contents.QR_description;

            if (data.Pages[pageName].Contents.description4 != null)
            {
                desc4.Text = data.Pages[pageName].Contents.description4;

                //no more next button
                buttonRadiusLeft1.Visible = false;

            }
            else
            {
                label4.Visible = false;
                desc4.Visible = false;

                //Next button
                buttonRadiusLeft1.Text = data.Pages[pageName].Button.buttonText["9"];
                Image image2 = ImageLoader.LoadImage("resources/ico/right.png");
                buttonRadiusLeft1.Image = image2;
            }

        }

        private void PageLayout9_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
