namespace GameModelSetup {
    partial class UseToolsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseToolsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pbTool1 = new System.Windows.Forms.PictureBox();
            this.pbTool2 = new System.Windows.Forms.PictureBox();
            this.pbTool3 = new System.Windows.Forms.PictureBox();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblValue3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTool1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTool2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTool3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which tool would you like to use? ";
            // 
            // pbTool1
            // 
            this.pbTool1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTool1.Image = ((System.Drawing.Image)(resources.GetObject("pbTool1.Image")));
            this.pbTool1.InitialImage = null;
            this.pbTool1.Location = new System.Drawing.Point(83, 44);
            this.pbTool1.Name = "pbTool1";
            this.pbTool1.Size = new System.Drawing.Size(109, 83);
            this.pbTool1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTool1.TabIndex = 1;
            this.pbTool1.TabStop = false;
            this.pbTool1.Click += new System.EventHandler(this.pbToolClick);
            // 
            // pbTool2
            // 
            this.pbTool2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTool2.Image = ((System.Drawing.Image)(resources.GetObject("pbTool2.Image")));
            this.pbTool2.InitialImage = null;
            this.pbTool2.Location = new System.Drawing.Point(83, 149);
            this.pbTool2.Name = "pbTool2";
            this.pbTool2.Size = new System.Drawing.Size(109, 83);
            this.pbTool2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTool2.TabIndex = 2;
            this.pbTool2.TabStop = false;
            this.pbTool2.Click += new System.EventHandler(this.pbToolClick);
            // 
            // pbTool3
            // 
            this.pbTool3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTool3.Image = ((System.Drawing.Image)(resources.GetObject("pbTool3.Image")));
            this.pbTool3.InitialImage = null;
            this.pbTool3.Location = new System.Drawing.Point(83, 253);
            this.pbTool3.Name = "pbTool3";
            this.pbTool3.Size = new System.Drawing.Size(109, 83);
            this.pbTool3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTool3.TabIndex = 3;
            this.pbTool3.TabStop = false;
            this.pbTool3.Click += new System.EventHandler(this.pbToolClick);
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.BackColor = System.Drawing.Color.Transparent;
            this.lblValue1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue1.Location = new System.Drawing.Point(169, 44);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(23, 26);
            this.lblValue1.TabIndex = 4;
            this.lblValue1.Text = "4";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.BackColor = System.Drawing.Color.Transparent;
            this.lblValue2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue2.Location = new System.Drawing.Point(169, 149);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(23, 26);
            this.lblValue2.TabIndex = 5;
            this.lblValue2.Text = "4";
            // 
            // lblValue3
            // 
            this.lblValue3.AutoSize = true;
            this.lblValue3.BackColor = System.Drawing.Color.Transparent;
            this.lblValue3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValue3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue3.Location = new System.Drawing.Point(169, 253);
            this.lblValue3.Name = "lblValue3";
            this.lblValue3.Size = new System.Drawing.Size(23, 26);
            this.lblValue3.TabIndex = 6;
            this.lblValue3.Text = "4";
            // 
            // UseToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 351);
            this.Controls.Add(this.lblValue3);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue1);
            this.Controls.Add(this.pbTool3);
            this.Controls.Add(this.pbTool2);
            this.Controls.Add(this.pbTool1);
            this.Controls.Add(this.label1);
            this.Name = "UseToolsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UseToolsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbTool1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTool2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTool3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbTool1;
        private System.Windows.Forms.PictureBox pbTool2;
        private System.Windows.Forms.PictureBox pbTool3;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblValue3;
    }
}