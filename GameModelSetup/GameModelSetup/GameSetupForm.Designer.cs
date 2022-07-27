namespace GameModelSetup
{
    partial class Players
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
            this.Players2 = new System.Windows.Forms.Button();
            this.Players3 = new System.Windows.Forms.Button();
            this.Players4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Players2
            // 
            this.Players2.Location = new System.Drawing.Point(56, 94);
            this.Players2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Players2.Name = "Players2";
            this.Players2.Size = new System.Drawing.Size(60, 26);
            this.Players2.TabIndex = 0;
            this.Players2.Text = "2";
            this.Players2.UseVisualStyleBackColor = true;
            this.Players2.Click += new System.EventHandler(this.Players2_Click);
            // 
            // Players3
            // 
            this.Players3.Location = new System.Drawing.Point(202, 94);
            this.Players3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Players3.Name = "Players3";
            this.Players3.Size = new System.Drawing.Size(60, 26);
            this.Players3.TabIndex = 1;
            this.Players3.Text = "3";
            this.Players3.UseVisualStyleBackColor = true;
            this.Players3.Click += new System.EventHandler(this.Players3_Click);
            // 
            // Players4
            // 
            this.Players4.Location = new System.Drawing.Point(345, 94);
            this.Players4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Players4.Name = "Players4";
            this.Players4.Size = new System.Drawing.Size(60, 26);
            this.Players4.TabIndex = 2;
            this.Players4.Text = "4";
            this.Players4.UseVisualStyleBackColor = true;
            this.Players4.Click += new System.EventHandler(this.Players4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "How many players?";
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Players4);
            this.Controls.Add(this.Players3);
            this.Controls.Add(this.Players2);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Players";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Count";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Players2;
        private System.Windows.Forms.Button Players3;
        private System.Windows.Forms.Button Players4;
        private System.Windows.Forms.Label label1;
    }
}