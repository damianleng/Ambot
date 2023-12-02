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
    public partial class PageLayout5 : UserControl
    {
        private JsonObject.Root data = JsonObject.Root.Deserialize();
        public PageLayout5()
        {
            InitializeComponent();
            string pageName = mainPanel.currentPage;

            if(pageName == "ScholarshipsPage")
            {
                buttonRadiusRight1.Hide();
            }

            buttonRadiusRight1.Text = data.Pages[pageName].Button.buttonText["4"];
            buttonRadiusRight2.Text = data.Pages[pageName].Button.buttonText["3"];
            buttonRadiusRight3.Text = data.Pages[pageName].Button.buttonText["2"];
            backBtn.Text = data.Pages[pageName].Button.buttonText["5"];

            Image imageBanner = ImageLoader.LoadImage(data.Pages[pageName].Contents.image);
            Image imageAvatar = ImageLoader.LoadImage(data.Pages[pageName].Avatar.avatar_image);

            pictureBox2.Image = imageBanner;
            pictureBox1.Image = imageAvatar;

            label2.Text = data.Pages[pageName].Avatar.bubble_text1;
            label2.BackColor = Color.White;

        }

        private void buttonRadiusRight2_Click(object sender, EventArgs e)
        {

        }

        private void Majors_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
