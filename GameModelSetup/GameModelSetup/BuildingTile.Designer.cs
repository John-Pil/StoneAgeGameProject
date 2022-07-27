
namespace GameModelSetup
{
    partial class BuildingTile
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
            this.BuildingPicture = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.ResourcePictureOne = new System.Windows.Forms.PictureBox();
            this.ResourcePictureTwo = new System.Windows.Forms.PictureBox();
            this.ResourcePictureThree = new System.Windows.Forms.PictureBox();
            this.altResourcePanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ResourceTypes = new System.Windows.Forms.TextBox();
            this.ChoicePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourcePictureOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourcePictureTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourcePictureThree)).BeginInit();
            this.altResourcePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChoicePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BuildingPicture
            // 
            this.BuildingPicture.Location = new System.Drawing.Point(132, 12);
            this.BuildingPicture.Name = "BuildingPicture";
            this.BuildingPicture.Size = new System.Drawing.Size(115, 113);
            this.BuildingPicture.TabIndex = 0;
            this.BuildingPicture.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(114, 33);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "10";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // ResourcePictureOne
            // 
            this.ResourcePictureOne.Location = new System.Drawing.Point(12, 160);
            this.ResourcePictureOne.Name = "ResourcePictureOne";
            this.ResourcePictureOne.Size = new System.Drawing.Size(77, 77);
            this.ResourcePictureOne.TabIndex = 4;
            this.ResourcePictureOne.TabStop = false;
            // 
            // ResourcePictureTwo
            // 
            this.ResourcePictureTwo.Location = new System.Drawing.Point(91, 160);
            this.ResourcePictureTwo.Name = "ResourcePictureTwo";
            this.ResourcePictureTwo.Size = new System.Drawing.Size(77, 77);
            this.ResourcePictureTwo.TabIndex = 5;
            this.ResourcePictureTwo.TabStop = false;
            // 
            // ResourcePictureThree
            // 
            this.ResourcePictureThree.Location = new System.Drawing.Point(170, 160);
            this.ResourcePictureThree.Name = "ResourcePictureThree";
            this.ResourcePictureThree.Size = new System.Drawing.Size(77, 77);
            this.ResourcePictureThree.TabIndex = 6;
            this.ResourcePictureThree.TabStop = false;
            // 
            // altResourcePanel
            // 
            this.altResourcePanel.Controls.Add(this.textBox2);
            this.altResourcePanel.Controls.Add(this.ResourceTypes);
            this.altResourcePanel.Controls.Add(this.ChoicePicture);
            this.altResourcePanel.Location = new System.Drawing.Point(12, 131);
            this.altResourcePanel.Name = "altResourcePanel";
            this.altResourcePanel.Size = new System.Drawing.Size(235, 120);
            this.altResourcePanel.TabIndex = 7;
            this.altResourcePanel.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(120, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(111, 33);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "4 Total";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResourceTypes
            // 
            this.ResourceTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResourceTypes.Enabled = false;
            this.ResourceTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResourceTypes.Location = new System.Drawing.Point(120, 3);
            this.ResourceTypes.Name = "ResourceTypes";
            this.ResourceTypes.ReadOnly = true;
            this.ResourceTypes.Size = new System.Drawing.Size(111, 33);
            this.ResourceTypes.TabIndex = 3;
            this.ResourceTypes.Text = "3 Types";
            this.ResourceTypes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChoicePicture
            // 
            this.ChoicePicture.Location = new System.Drawing.Point(3, 3);
            this.ChoicePicture.Name = "ChoicePicture";
            this.ChoicePicture.Size = new System.Drawing.Size(112, 114);
            this.ChoicePicture.TabIndex = 2;
            this.ChoicePicture.TabStop = false;
            // 
            // BuildingTile
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(259, 315);
            this.ControlBox = false;
            this.Controls.Add(this.altResourcePanel);
            this.Controls.Add(this.ResourcePictureThree);
            this.Controls.Add(this.ResourcePictureTwo);
            this.Controls.Add(this.ResourcePictureOne);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BuildingPicture);
            this.MaximumSize = new System.Drawing.Size(275, 331);
            this.MinimumSize = new System.Drawing.Size(275, 331);
            this.Name = "BuildingTile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.BuildingPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourcePictureOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourcePictureTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourcePictureThree)).EndInit();
            this.altResourcePanel.ResumeLayout(false);
            this.altResourcePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChoicePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BuildingPicture;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox ResourcePictureOne;
        private System.Windows.Forms.PictureBox ResourcePictureTwo;
        private System.Windows.Forms.PictureBox ResourcePictureThree;
        private System.Windows.Forms.Panel altResourcePanel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ResourceTypes;
        private System.Windows.Forms.PictureBox ChoicePicture;
    }
}