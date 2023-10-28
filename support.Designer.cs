namespace Ambot
{
    partial class support
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(support));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRadiusRight1 = new Ambot.ButtonRadius.ButtonRadiusRight();
            this.pillButton1 = new Ambot.pillButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(38)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 150);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura-Bold", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(762, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 90);
            this.label1.TabIndex = 35;
            this.label1.Text = "IT SUPPORT";
            // 
            // buttonRadiusRight1
            // 
            this.buttonRadiusRight1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(13)))), ((int)(((byte)(29)))));
            this.buttonRadiusRight1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(13)))), ((int)(((byte)(29)))));
            this.buttonRadiusRight1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonRadiusRight1.BorderRadius = 20;
            this.buttonRadiusRight1.BorderSize = 0;
            this.buttonRadiusRight1.FlatAppearance.BorderSize = 0;
            this.buttonRadiusRight1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRadiusRight1.Font = new System.Drawing.Font("Proxima Nova Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRadiusRight1.ForeColor = System.Drawing.Color.White;
            this.buttonRadiusRight1.Image = ((System.Drawing.Image)(resources.GetObject("buttonRadiusRight1.Image")));
            this.buttonRadiusRight1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRadiusRight1.Location = new System.Drawing.Point(-2, 990);
            this.buttonRadiusRight1.Name = "buttonRadiusRight1";
            this.buttonRadiusRight1.Size = new System.Drawing.Size(240, 90);
            this.buttonRadiusRight1.TabIndex = 48;
            this.buttonRadiusRight1.Text = "BACK";
            this.buttonRadiusRight1.TextColor = System.Drawing.Color.White;
            this.buttonRadiusRight1.UseVisualStyleBackColor = false;
            // 
            // pillButton1
            // 
            this.pillButton1.BackColor = System.Drawing.Color.Black;
            this.pillButton1.BackgroundColor = System.Drawing.Color.Black;
            this.pillButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pillButton1.BorderRadius = 20;
            this.pillButton1.BorderSize = 0;
            this.pillButton1.FlatAppearance.BorderSize = 0;
            this.pillButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pillButton1.ForeColor = System.Drawing.Color.White;
            this.pillButton1.Image = ((System.Drawing.Image)(resources.GetObject("pillButton1.Image")));
            this.pillButton1.Location = new System.Drawing.Point(810, 1002);
            this.pillButton1.Name = "pillButton1";
            this.pillButton1.Size = new System.Drawing.Size(240, 90);
            this.pillButton1.TabIndex = 49;
            this.pillButton1.TextColor = System.Drawing.Color.White;
            this.pillButton1.UseVisualStyleBackColor = false;
            // 
            // support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pillButton1);
            this.Controls.Add(this.buttonRadiusRight1);
            this.Controls.Add(this.panel1);
            this.Name = "support";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.support_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ButtonRadius.ButtonRadiusRight buttonRadiusRight1;
        private pillButton pillButton1;
    }
}
