namespace Ambot.Majors.SingleDegreeFolder
{
    partial class Law
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
            this.label1 = new System.Windows.Forms.Label();
            this.pillButton1 = new Ambot.pillButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 73);
            this.label1.TabIndex = 33;
            this.label1.Text = "Law";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.pillButton1.Location = new System.Drawing.Point(34, 516);
            this.pillButton1.Name = "pillButton1";
            this.pillButton1.Size = new System.Drawing.Size(239, 91);
            this.pillButton1.TabIndex = 34;
            this.pillButton1.Text = "Back";
            this.pillButton1.TextColor = System.Drawing.Color.White;
            this.pillButton1.UseVisualStyleBackColor = false;
            this.pillButton1.Click += new System.EventHandler(this.pillButton1_Click);
            // 
            // Law
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pillButton1);
            this.Controls.Add(this.label1);
            this.Name = "Law";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.Law_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private pillButton pillButton1;
    }
}
