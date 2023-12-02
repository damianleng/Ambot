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
        //Initialize the json data
        private JsonObject.Root data = JsonObject.Root.Deserialize();

        public PageLayout1()
        {
            InitializeComponent();
            //get the current page name which can dynamically changekbv
            string pageName = mainPanel.currentPage;

            //left side button
            buttonRadiusRight1.Text = data.Pages[pageName].Button.buttonText["2"];
            buttonRadiusRight2.Text = data.Pages[pageName].Button.buttonText["3"];
            buttonRadiusRight3.Text = data.Pages[pageName].Button.buttonText["4"];
            buttonRadiusRight4.Text = data.Pages[pageName].Button.buttonText["5"];

            //right side button
            buttonRadiusLeft1.Text = data.Pages[pageName].Button.buttonText["6"];
            buttonRadiusLeft2.Text = data.Pages[pageName].Button.buttonText["7"];
            buttonRadiusLeft3.Text = data.Pages[pageName].Button.buttonText["8"];

            //images
            Image AuppLogo = ImageLoader.LoadImage(data.Pages[pageName].Contents.logo);
            Image SpeechBubble = ImageLoader.LoadImage("resources/speech bubble.png");
            Image Avatar = ImageLoader.LoadImage(data.Pages[pageName].Avatar.avatar_image);
            AUPPLogo.Image = AuppLogo;
            Speechbubble.Image = SpeechBubble;
            AvatarPic.Image = Avatar;

            //bubble text
            bubbleText.Text = data.Pages[pageName].Avatar.bubble_text1;
        }

        private void PageNo1_Load(object sender, EventArgs e)
        {
            this.Focus();

        }
    }
}
