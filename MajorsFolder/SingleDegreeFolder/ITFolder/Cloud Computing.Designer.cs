namespace Ambot.Majors.SingleDegreeFolder.ITFolder
{
    partial class Cloud_Computing
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
            this.pillButton1 = new Ambot.pillButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pillButton1
            // 
            this.pillButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(38)))), ((int)(((byte)(94)))));
            this.pillButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(38)))), ((int)(((byte)(94)))));
            this.pillButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pillButton1.BorderRadius = 20;
            this.pillButton1.BorderSize = 0;
            this.pillButton1.FlatAppearance.BorderSize = 0;
            this.pillButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pillButton1.ForeColor = System.Drawing.Color.White;
            this.pillButton1.Location = new System.Drawing.Point(0, 546);
            this.pillButton1.Name = "pillButton1";
            this.pillButton1.Size = new System.Drawing.Size(239, 91);
            this.pillButton1.TabIndex = 30;
            this.pillButton1.Text = "Back";
            this.pillButton1.TextColor = System.Drawing.Color.White;
            this.pillButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 73);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cloud";
            // 
            // Cloud_Computing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pillButton1);
            this.Name = "Cloud_Computing";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.Cloud_Computing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pillButton pillButton1;
        private System.Windows.Forms.Label label1;
    }
}
