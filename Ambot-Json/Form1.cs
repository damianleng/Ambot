using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ambot_Json
{

    public partial class mainPanel : Form
    {

        private JsonObject.Root data = JsonObject.Root.Deserialize();

        // Declare a private static variable to hold the current page
        private static string _currentPage;

        // Create a public static property to get and set the current page
        public static string currentPage
        {
            get { return _currentPage; }
            set { _currentPage = value; }
        }

        public mainPanel()
        {
            InitializeComponent();

        }

        //A function to switch page according to json object Key
        public void LoadUserControl(string key)
        {
            //temporary string to check if user trying to click on the same page
            string temp = currentPage;

            //Get new pagename with the key position of the current pagename
            //e.g. if current page is "HomePage" and key is 1, the new current page will be "AboutUsPage"
            if (key != "0")
            {
                //check if the page that navigate through is empty or not
                if (!string.IsNullOrEmpty(data.Pages[currentPage].Button.buttonNav[key]))
                {
                    currentPage = data.Pages[currentPage].Button.buttonNav[key];
                } else
                {
                    return;
                }
            }
            else
            {
                //Initialize the Home page
                currentPage = "HomePage";
            }

            //Get the usercontrol according to the new current page from json
            string pageLayout = data.Pages[currentPage].PageNav;

            //if the pageLayout is not empty, otherwise prevent user from 
            if (pageLayout != "")
            {

                // Get the type of the user control.
                Type userControlType = Type.GetType($"Ambot_Json.{pageLayout}");

                if (userControlType != null)
                {
                    // Create an instance of the user control.
                    UserControl userControl = (UserControl)Activator.CreateInstance(userControlType);

                    // Clear the current controls of the form.
                    this.Controls.Clear();

                    // Add the user control to the form.
                    this.Controls.Add(userControl);
                    userControl.Dock = DockStyle.Fill;
                }
            } else
            {
                currentPage = temp;
            }

        }

        private void mainPanel_Load(object sender, EventArgs e)
        {

            //Swtich to HomePage Usercontrol, "0" is special case
            LoadUserControl("0");
        }

        //keydown event
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        { 
            if (currentPage != "")
            {
                if (keyData >= Keys.D0 && keyData <= Keys.D9)
                {
                    string tempkey = keyData.ToString().Substring(1);

                    //perform the switch page on keydown
                    LoadUserControl(tempkey);

                    // Handle the key press
                    return true;
                }
                else
                {
                    //if somehow the key event does not work, call the base method
                    return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            else
            {
                return false;
            }
        }
    }
}
