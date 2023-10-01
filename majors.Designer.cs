namespace Ambot
{
    partial class majors
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homeBtn = new Ambot.pillButton();
            this.singleBtn = new Ambot.pillButton();
            this.SuspendLayout();
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(38)))), ((int)(((byte)(94)))));
            this.homeBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(38)))), ((int)(((byte)(94)))));
            this.homeBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.homeBtn.BorderRadius = 20;
            this.homeBtn.BorderSize = 0;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Location = new System.Drawing.Point(182, 181);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(239, 91);
            this.homeBtn.TabIndex = 20;
            this.homeBtn.Text = "Go back to Home Page";
            this.homeBtn.TextColor = System.Drawing.Color.White;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // singleBtn
            // 
            this.singleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(38)))), ((int)(((byte)(94)))));
            this.singleBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(38)))), ((int)(((byte)(94)))));
            this.singleBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.singleBtn.BorderRadius = 20;
            this.singleBtn.BorderSize = 0;
            this.singleBtn.FlatAppearance.BorderSize = 0;
            this.singleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singleBtn.ForeColor = System.Drawing.Color.White;
            this.singleBtn.Location = new System.Drawing.Point(565, 181);
            this.singleBtn.Name = "singleBtn";
            this.singleBtn.Size = new System.Drawing.Size(239, 91);
            this.singleBtn.TabIndex = 21;
            this.singleBtn.Text = "Single Degree";
            this.singleBtn.TextColor = System.Drawing.Color.White;
            this.singleBtn.UseVisualStyleBackColor = false;
            this.singleBtn.Click += new System.EventHandler(this.singleBtn_Click);
            // 
            // majors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.singleBtn);
            this.Controls.Add(this.homeBtn);
            this.Name = "majors";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.majors_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private pillButton homeBtn;
        private pillButton singleBtn;
    }
}
