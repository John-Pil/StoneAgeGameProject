
namespace GameModelSetup
{
    partial class ResourceSelectionForm
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
            this.woodText = new System.Windows.Forms.TextBox();
            this.woodCounter = new System.Windows.Forms.NumericUpDown();
            this.stoneCounter = new System.Windows.Forms.NumericUpDown();
            this.stoneText = new System.Windows.Forms.TextBox();
            this.clayCounter = new System.Windows.Forms.NumericUpDown();
            this.clayText = new System.Windows.Forms.TextBox();
            this.goldCounter = new System.Windows.Forms.NumericUpDown();
            this.goldText = new System.Windows.Forms.TextBox();
            this.AccButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.woodCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clayCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // woodText
            // 
            this.woodText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.woodText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woodText.Location = new System.Drawing.Point(12, 12);
            this.woodText.Name = "woodText";
            this.woodText.ReadOnly = true;
            this.woodText.Size = new System.Drawing.Size(110, 22);
            this.woodText.TabIndex = 0;
            this.woodText.TabStop = false;
            this.woodText.Text = "Wood";
            this.woodText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // woodCounter
            // 
            this.woodCounter.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woodCounter.Location = new System.Drawing.Point(12, 59);
            this.woodCounter.Name = "woodCounter";
            this.woodCounter.Size = new System.Drawing.Size(110, 55);
            this.woodCounter.TabIndex = 0;
            this.woodCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.woodCounter.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.woodCounter.ValueChanged += new System.EventHandler(this.woodCounter_ValueChanged);
            // 
            // stoneCounter
            // 
            this.stoneCounter.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoneCounter.Location = new System.Drawing.Point(128, 59);
            this.stoneCounter.Name = "stoneCounter";
            this.stoneCounter.Size = new System.Drawing.Size(110, 55);
            this.stoneCounter.TabIndex = 1;
            this.stoneCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stoneCounter.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.stoneCounter.ValueChanged += new System.EventHandler(this.stoneCounter_ValueChanged);
            // 
            // stoneText
            // 
            this.stoneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stoneText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoneText.Location = new System.Drawing.Point(128, 12);
            this.stoneText.Name = "stoneText";
            this.stoneText.ReadOnly = true;
            this.stoneText.Size = new System.Drawing.Size(110, 22);
            this.stoneText.TabIndex = 2;
            this.stoneText.TabStop = false;
            this.stoneText.Text = "Stone";
            this.stoneText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clayCounter
            // 
            this.clayCounter.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clayCounter.Location = new System.Drawing.Point(244, 59);
            this.clayCounter.Name = "clayCounter";
            this.clayCounter.Size = new System.Drawing.Size(110, 55);
            this.clayCounter.TabIndex = 2;
            this.clayCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clayCounter.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.clayCounter.ValueChanged += new System.EventHandler(this.clayCounter_ValueChanged);
            // 
            // clayText
            // 
            this.clayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clayText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clayText.Location = new System.Drawing.Point(244, 12);
            this.clayText.Name = "clayText";
            this.clayText.ReadOnly = true;
            this.clayText.Size = new System.Drawing.Size(110, 22);
            this.clayText.TabIndex = 4;
            this.clayText.TabStop = false;
            this.clayText.Text = "Clay";
            this.clayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goldCounter
            // 
            this.goldCounter.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldCounter.Location = new System.Drawing.Point(360, 59);
            this.goldCounter.Name = "goldCounter";
            this.goldCounter.Size = new System.Drawing.Size(110, 55);
            this.goldCounter.TabIndex = 3;
            this.goldCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.goldCounter.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.goldCounter.ValueChanged += new System.EventHandler(this.goldCounter_ValueChanged);
            // 
            // goldText
            // 
            this.goldText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goldText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldText.Location = new System.Drawing.Point(360, 12);
            this.goldText.Name = "goldText";
            this.goldText.ReadOnly = true;
            this.goldText.Size = new System.Drawing.Size(110, 22);
            this.goldText.TabIndex = 6;
            this.goldText.TabStop = false;
            this.goldText.Text = "Gold";
            this.goldText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AccButton
            // 
            this.AccButton.Enabled = false;
            this.AccButton.Location = new System.Drawing.Point(12, 135);
            this.AccButton.Name = "AccButton";
            this.AccButton.Size = new System.Drawing.Size(226, 41);
            this.AccButton.TabIndex = 4;
            this.AccButton.Text = "Accept";
            this.AccButton.UseVisualStyleBackColor = true;
            this.AccButton.Click += new System.EventHandler(this.AccButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EndButton.Location = new System.Drawing.Point(244, 135);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(226, 41);
            this.EndButton.TabIndex = 5;
            this.EndButton.Text = "Cancel";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ResourceSelectionForm
            // 
            this.AcceptButton = this.AccButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.EndButton;
            this.ClientSize = new System.Drawing.Size(481, 188);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.AccButton);
            this.Controls.Add(this.goldCounter);
            this.Controls.Add(this.goldText);
            this.Controls.Add(this.clayCounter);
            this.Controls.Add(this.clayText);
            this.Controls.Add(this.stoneCounter);
            this.Controls.Add(this.stoneText);
            this.Controls.Add(this.woodCounter);
            this.Controls.Add(this.woodText);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(672, 319);
            this.MinimizeBox = false;
            this.Name = "ResourceSelectionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Resources";
            ((System.ComponentModel.ISupportInitialize)(this.woodCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clayCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox woodText;
        private System.Windows.Forms.NumericUpDown woodCounter;
        private System.Windows.Forms.NumericUpDown stoneCounter;
        private System.Windows.Forms.TextBox stoneText;
        private System.Windows.Forms.NumericUpDown clayCounter;
        private System.Windows.Forms.TextBox clayText;
        private System.Windows.Forms.NumericUpDown goldCounter;
        private System.Windows.Forms.TextBox goldText;
        private System.Windows.Forms.Button AccButton;
        private System.Windows.Forms.Button EndButton;
    }
}