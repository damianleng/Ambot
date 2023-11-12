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
    public partial class PageLayout1 : UserControl
    {
        private JsonObject.Root data = JsonObject.Root.Deserialize();

        public PageLayout1()
        {
            InitializeComponent();

            string pageName = mainPanel.currentPage;

            buttonRadiusRight1.Text = data.Pages[pageName].Button.buttonText["2"];
            buttonRadiusRight2.Text = data.Pages[pageName].Button.buttonText["3"];
            buttonRadiusRight3.Text = data.Pages[pageName].Button.buttonText["4"];
            buttonRadiusRight4.Text = data.Pages[pageName].Button.buttonText["5"];

            buttonRadiusLeft1.Text = data.Pages[pageName].Button.buttonText["6"];
            buttonRadiusLeft2.Text = data.Pages[pageName].Button.buttonText["7"];
            buttonRadiusLeft3.Text = data.Pages[pageName].Button.buttonText["8"];
            buttonRadiusLeft4.Text = data.Pages[pageName].Button.buttonText["9"];

            Image image = ImageLoader.LoadImage(data.Pages[pageName].Contents.logo);
            this.pictureBox1.Image = image;

            label1.Text = data.Pages[pageName].Contents.title;
            label2.Text = data.Pages[pageName].Contents.description1;
            label3.Text = data.Pages[pageName].Contents.instruction;


        }

        private void PageNo1_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
