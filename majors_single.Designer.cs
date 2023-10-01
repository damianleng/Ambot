namespace Ambot
{
    partial class majors_single
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.homeBtn.Location = new System.Drawing.Point(236, 195);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(239, 91);
            this.homeBtn.TabIndex = 21;
            this.homeBtn.Text = "Go back to Home Page";
            this.homeBtn.TextColor = System.Drawing.Color.White;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "This is the single degree program";
            // 
            // majors_single
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homeBtn);
            this.Name = "majors_single";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.majors_single_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pillButton homeBtn;
        private System.Windows.Forms.Label label1;
    }
}
