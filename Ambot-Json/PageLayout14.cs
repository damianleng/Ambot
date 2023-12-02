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
    public partial class PageLayout14 : UserControl
    {
        private JsonObject.Root data = JsonObject.Root.Deserialize();
        public PageLayout14()
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


            //Title
            label1.Text = data.Pages[pageName].Contents.title;
            //Subtitle
            label2.Text = data.Pages[pageName].Contents.subtitle1;
            //Description
            label3.Text = data.Pages[pageName].Contents.description1;


            Image image2 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image1);
            pictureBox1.BackgroundImage = image2;
            Image image3 = ImageLoader.LoadImage(data.Pages[pageName].Avatar.avatar_image);
            pictureBox2.BackgroundImage = image3;



        }

        private void PageLayout14_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
