
namespace GameModelSetup
{
    partial class CivCard
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
            this.resourceMultiplier = new System.Windows.Forms.TextBox();
            this.resourcePictureOne = new System.Windows.Forms.PictureBox();
            this.resourcePictureTwo = new System.Windows.Forms.PictureBox();
            this.scoreMultiplier = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.altUpperPanel = new System.Windows.Forms.Panel();
            this.altBottomPanel = new System.Windows.Forms.Panel();
            this.cultureTypePicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resourcePictureOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcePictureTwo)).BeginInit();
            this.altUpperPanel.SuspendLayout();
            this.altBottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cultureTypePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // resourceMultiplier
            // 
            this.resourceMultiplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resourceMultiplier.Enabled = false;
            this.resourceMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceMultiplier.Location = new System.Drawing.Point(135, 42);
            this.resourceMultiplier.Name = "resourceMultiplier";
            this.resourceMultiplier.ReadOnly = true;
            this.resourceMultiplier.Size = new System.Drawing.Size(112, 33);
            this.resourceMultiplier.TabIndex = 0;
            this.resourceMultiplier.Text = "X 02";
            this.resourceMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resourcePictureOne
            // 
            this.resourcePictureOne.Location = new System.Drawing.Point(12, 12);
            this.resourcePictureOne.Name = "resourcePictureOne";
            this.resourcePictureOne.Size = new System.Drawing.Size(100, 97);
            this.resourcePictureOne.TabIndex = 1;
            this.resourcePictureOne.TabStop = false;
            // 
            // resourcePictureTwo
            // 
            this.resourcePictureTwo.Location = new System.Drawing.Point(12, 137);
            this.resourcePictureTwo.Name = "resourcePictureTwo";
            this.resourcePictureTwo.Size = new System.Drawing.Size(100, 97);
            this.resourcePictureTwo.TabIndex = 3;
            this.resourcePictureTwo.TabStop = false;
            // 
            // scoreMultiplier
            // 
            this.scoreMultiplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreMultiplier.Enabled = false;
            this.scoreMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreMultiplier.Location = new System.Drawing.Point(135, 167);
            this.scoreMultiplier.Name = "scoreMultiplier";
            this.scoreMultiplier.ReadOnly = true;
            this.scoreMultiplier.Size = new System.Drawing.Size(112, 33);
            this.scoreMultiplier.TabIndex = 2;
            this.scoreMultiplier.Text = "X 02";
            this.scoreMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(12, 257);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(235, 46);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // altUpperPanel
            // 
            this.altUpperPanel.Controls.Add(this.pictureBox1);
            this.altUpperPanel.Location = new System.Drawing.Point(0, 126);
            this.altUpperPanel.Name = "altUpperPanel";
            this.altUpperPanel.Size = new System.Drawing.Size(259, 120);
            this.altUpperPanel.TabIndex = 5;
            this.altUpperPanel.Visible = false;
            // 
            // altBottomPanel
            // 
            this.altBottomPanel.Controls.Add(this.cultureTypePicture);
            this.altBottomPanel.Location = new System.Drawing.Point(0, 0);
            this.altBottomPanel.Name = "altBottomPanel";
            this.altBottomPanel.Size = new System.Drawing.Size(259, 120);
            this.altBottomPanel.TabIndex = 6;
            this.altBottomPanel.Visible = false;
            // 
            // cultureTypePicture
            // 
            this.cultureTypePicture.Location = new System.Drawing.Point(79, 12);
            this.cultureTypePicture.Name = "cultureTypePicture";
            this.cultureTypePicture.Size = new System.Drawing.Size(100, 97);
            this.cultureTypePicture.TabIndex = 0;
            this.cultureTypePicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 114);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CivCard
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(259, 315);
            this.ControlBox = false;
            this.Controls.Add(this.altBottomPanel);
            this.Controls.Add(this.altUpperPanel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.resourcePictureTwo);
            this.Controls.Add(this.scoreMultiplier);
            this.Controls.Add(this.resourcePictureOne);
            this.Controls.Add(this.resourceMultiplier);
            this.MaximumSize = new System.Drawing.Size(275, 331);
            this.MinimumSize = new System.Drawing.Size(275, 331);
            this.Name = "CivCard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.resourcePictureOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcePictureTwo)).EndInit();
            this.altUpperPanel.ResumeLayout(false);
            this.altBottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cultureTypePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resourceMultiplier;
        private System.Windows.Forms.PictureBox resourcePictureOne;
        private System.Windows.Forms.PictureBox resourcePictureTwo;
        private System.Windows.Forms.TextBox scoreMultiplier;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel altUpperPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel altBottomPanel;
        private System.Windows.Forms.PictureBox cultureTypePicture;
    }
}