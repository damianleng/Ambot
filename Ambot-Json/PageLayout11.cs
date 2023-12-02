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
    public partial class PageLayout11 : UserControl
    {
        private JsonObject.Root data = JsonObject.Root.Deserialize();

        public PageLayout11()
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
            subtitle1.Text = data.Pages[pageName].Contents.subtitle1;
            subtitle2.Text = data.Pages[pageName].Contents.subtitle2;

            desc1.Text = data.Pages[pageName].Contents.description1;
            desc2.Text = data.Pages[pageName].Contents.description2;
            desc3.Text = data.Pages[pageName].Contents.description3;

            label4.Text = data.Pages[pageName].Contents.description4;
            label5.Text = data.Pages[pageName].Contents.description5;
            label6.Text = data.Pages[pageName].Contents.description6;

            //image1
            Image image3 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image1);
            pictureBox1.Image = image3;

            //QR content
            QRtext.Text = data.Pages[pageName].Contents.QR_description;

            Image image4 = ImageLoader.LoadImage(data.Pages[pageName].Contents.QR_image);
            pictureBox2.Image = image4;

            if (data.Pages[pageName].Contents.description7 != null)
            {
                //no more next button
                buttonRadiusLeft1.Visible = false;

                //contents
                label7.Text = data.Pages[pageName].Contents.description7;
                label8.Text = data.Pages[pageName].Contents.description8;

            }
            else
            {
                label7.Visible = false;
                label8.Visible = false;

                //Next button
                buttonRadiusLeft1.Text = data.Pages[pageName].Button.buttonText["9"];
                Image image2 = ImageLoader.LoadImage("resources/ico/right.png");
                buttonRadiusLeft1.Image = image2;
            }
        }

        private void PageLayout11_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
