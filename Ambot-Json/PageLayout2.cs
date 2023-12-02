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
    public partial class PageLayout2 : UserControl
    {
        private JsonObject.Root data = JsonObject.Root.Deserialize();

        public PageLayout2()
        {
            InitializeComponent();

            string pageName = mainPanel.currentPage;

            //Home button
            Image image1 = ImageLoader.LoadImage("Resources/ico/home_icon.png");
            buttonFullRadius1.Image = image1;
            //Back Button
            buttonRadiusRight2.Text = data.Pages[pageName].Button.buttonText["5"];
            Image image = ImageLoader.LoadImage("Resources/ico/arrow.png");
            buttonRadiusRight2.Image = image;


            buttonRadiusRight1.Text = data.Pages[pageName].Button.buttonText["4"];
            buttonRadiusRight3.Text = data.Pages[pageName].Button.buttonText["3"];

            label1.Text = data.Pages[pageName].Contents.title;
            label2.Text = data.Pages[pageName].Contents.subtitle1;

            Image image3 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image1);
            overviewPic.Image = image3;
            Image image4 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image2);
            vmvPic.Image = image4;

            Image avatar = ImageLoader.LoadImage(data.Pages[pageName].Avatar.avatar_image);
    

            avatarPic.Image = avatar;


        }

        private void PageNo2_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
