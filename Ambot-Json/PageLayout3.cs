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
    public partial class PageLayout3 : UserControl
    {
        private JsonObject.Root data = JsonObject.Root.Deserialize();
        private string pageName = mainPanel.currentPage;
        mainPanel form = new mainPanel();

        public string ConvertToBulletPoints(string description)
        {
            string[] items = description.Split(',');
            string bulletList = string.Join("\n", items.Select(item => "• " + item.Trim()));
            return bulletList;
        }


        public PageLayout3()
        {
            InitializeComponent();

            //Home button
            Image image = ImageLoader.LoadImage("Resources/ico/home_icon.png");
            buttonFullRadius1.Image = image;
            //Back Button
            buttonRadiusRight2.Text = data.Pages[pageName].Button.buttonText["5"];
            Image image2 = ImageLoader.LoadImage("Resources/ico/arrow.png");
            buttonRadiusRight2.Image = image2;

            label1.Text = data.Pages[pageName].Contents.title;
            label2.Text = data.Pages[pageName].Contents.subtitle1;

            Image image3 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image1);
            pictureBox1.Image = image3;

            if (pageName == "OverviewPage")
            {
                label3.Text = data.Pages[pageName].Contents.description1;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            }
            else if (pageName == "MissionPage")
            {
                label2.Text = data.Pages[pageName].Contents.subtitle1;
                panel2.Visible = false;
                label3.Text = data.Pages[pageName].Contents.description1;
                label3.Location = new Point(1015, 380);
                label4.Text = data.Pages[pageName].Contents.subtitle2;
                label5.Text = data.Pages[pageName].Contents.description2;
                label6.Text = data.Pages[pageName].Contents.subtitle3;
                label7.Text = ConvertToBulletPoints(data.Pages[pageName].Contents.description3);

            }

        }

        private void PageLayout3_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
