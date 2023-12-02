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
    public partial class PageLayout13 : UserControl
    {
        private JsonObject.Root data = JsonObject.Root.Deserialize();
        public PageLayout13()
        {
            InitializeComponent();

            string pageName = mainPanel.currentPage;

            //Home button
            Image image1 = ImageLoader.LoadImage("resources/ico/home_icon.png");
            buttonFullRadius1.Image = image1;

            //Back Button
            buttonRadiusRight5.Text = data.Pages[pageName].Button.buttonText["5"];
            Image image = ImageLoader.LoadImage("resources/ico/arrow.png");
            buttonRadiusRight5.Image = image;


            //Other buttons
            buttonRadiusRight3.Text = data.Pages[pageName].Button.buttonText["3"];
            buttonRadiusRight4.Text = data.Pages[pageName].Button.buttonText["4"];
            buttonRadiusLeft7.Text = data.Pages[pageName].Button.buttonText["7"];
            buttonRadiusLeft8.Text = data.Pages[pageName].Button.buttonText["8"];
            buttonRadiusLeft9.Text = data.Pages[pageName].Button.buttonText["9"];

            if (data.Pages[pageName].Button.buttonText["9"] == "")
            {
                buttonRadiusLeft9.Visible = false;
            }


            //Title
            label1.Text = data.Pages[pageName].Contents.title;


            Image image2 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image1);
            pictureBox1.BackgroundImage = image2;
            Image image3 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image2);
            pictureBox2.BackgroundImage = image3;
            Image image4 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image3);
            pictureBox3.BackgroundImage = image4;
            Image image5 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image4);
            pictureBox4.BackgroundImage = image5;


        }

        private void PageLayout13_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
