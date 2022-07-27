namespace GameModelSetup
{
    partial class Start
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.Start_Button = new System.Windows.Forms.Button();
            this.pbStartLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(362, 336);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(122, 44);
            this.Start_Button.TabIndex = 0;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbStartLogo
            // 
            this.pbStartLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbStartLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbStartLogo.Image")));
            this.pbStartLogo.Location = new System.Drawing.Point(10, 10);
            this.pbStartLogo.Margin = new System.Windows.Forms.Padding(1);
            this.pbStartLogo.Name = "pbStartLogo";
            this.pbStartLogo.Size = new System.Drawing.Size(817, 324);
            this.pbStartLogo.TabIndex = 1;
            this.pbStartLogo.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 389);
            this.Controls.Add(this.pbStartLogo);
            this.Controls.Add(this.Start_Button);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Scrum Age";
            ((System.ComponentModel.ISupportInitialize)(this.pbStartLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.PictureBox pbStartLogo;
    }
}