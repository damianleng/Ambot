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
    public partial class PageLayout6 : UserControl
    {
        private JsonObject.Root data = JsonObject.Root.Deserialize();
        public PageLayout6()
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


            if (pageName == "SinglePage") // if page is single page, display 4 banners
            {
                Image lawBanner = ImageLoader.LoadImage(data.Pages[pageName].Contents.image4);
                pictureBox4.Image = lawBanner;
            }
            Image ITBanner = ImageLoader.LoadImage(data.Pages[pageName].Contents.image1);
            Image businessBanner = ImageLoader.LoadImage(data.Pages[pageName].Contents.image2);
            Image globalBanner = ImageLoader.LoadImage(data.Pages[pageName].Contents.image3);


            pictureBox1.Image = ITBanner;
            pictureBox2.Image = businessBanner;
            pictureBox3.Image = globalBanner;

            //Majors Description
            label1.Text = data.Pages[pageName].Contents.title;
            label2.Text = data.Pages[pageName].Contents.description1;
            label3.Text = data.Pages[pageName].Contents.description2;
            label4.Text = data.Pages[pageName].Contents.description3;
            label5.Text = data.Pages[pageName].Contents.description4;

            Image QR = ImageLoader.LoadImage(data.Pages[pageName].Contents.QR_image);

            pictureBox5.Image = QR;
            label6.Text = data.Pages[pageName].Contents.QR_description;


        }

        private void PageLayput6_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}