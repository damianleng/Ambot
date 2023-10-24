namespace Ambot
{
    partial class master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(master));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRadiusRight1 = new Ambot.ButtonRadius.ButtonRadiusRight();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(38)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 150);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura-Bold", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(695, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(827, 90);
            this.label1.TabIndex = 35;
            this.label1.Text = "MASTER\'S ADMISSION";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura BdCn BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(38)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(986, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 57);
            this.label2.TabIndex = 44;
            this.label2.Text = "Admission Criteria and Process";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(13)))), ((int)(((byte)(29)))));
            this.panel2.Location = new System.Drawing.Point(996, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 3);
            this.panel2.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Proxima Nova Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(992, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Add a little bit of body text";
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
            this.buttonRadiusRight1.TabIndex = 47;
            this.buttonRadiusRight1.Text = "BACK";
            this.buttonRadiusRight1.TextColor = System.Drawing.Color.White;
            this.buttonRadiusRight1.UseVisualStyleBackColor = false;
            // 
            // master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.buttonRadiusRight1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "master";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.master_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private ButtonRadius.ButtonRadiusRight buttonRadiusRight1;
    }
}
