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
            Image image = ImageLoader.LoadImage("Resources/back.png");
            buttonFullRadius1.Image = image;
            //Back Button
            buttonRadiusRight2.Text = data.Pages[pageName].Button.buttonText["5"];
            Image image2 = ImageLoader.LoadImage("Resources/arrow.png");
            buttonRadiusRight2.Image = image2;

            label1.Text = data.Pages[pageName].Contents.title;
            label2.Text = data.Pages[pageName].Contents.subtitle1;

            Image image3 = ImageLoader.LoadImage(data.Pages[pageName].Contents.image1);
            pictureBox1.Image = image3;

            if (pageName == "HistoryPage")
            {

                Label label4 = form.CreateDefaultLabel();
                label4.Text = data.Pages[pageName].Contents.description1;
                label4.Location = new Point(1021, 400);
                this.Controls.Add(label4);

            }
            else if (pageName == "MissionPage")
            {
                panel2.Visible = false;

                Label label4 = form.CreateDefaultLabel();
                label4.Text = data.Pages[pageName].Contents.description1;
                label4.Location = new Point(1021, 380);
                Controls.Add(label4);

                Label label5 = form.CreateDefaultLabel();
                label5.Text = data.Pages[pageName].Contents.subtitle2;
                label5.Location = new Point(1008, 480);
                label5.Font = new Font("Futura BdCn BT", 36);
                Controls.Add(label5);

                Label label6 = form.CreateDefaultLabel();
                label6.Text = data.Pages[pageName].Contents.description2;
                label6.Location = new Point(1021, 550);
                Controls.Add(label6);

                Label label7 = form.CreateDefaultLabel();
                label7.Text = data.Pages[pageName].Contents.subtitle3;
                label7.Location = new Point(1008, 700);
                label7.Font = new Font("Futura BdCn BT", 36);
                Controls.Add(label7);

                Label label8 = form.CreateDefaultLabel();
                label8.Text = ConvertToBulletPoints(data.Pages[pageName].Contents.description3);
                label8.Location = new Point(1021, 780);
                Controls.Add(label8);
            }

        }

        private void PageLayout3_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
