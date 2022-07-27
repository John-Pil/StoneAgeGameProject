
namespace GameModelSetup {
    partial class RollsForm {
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
            this.lblResults = new System.Windows.Forms.Label();
            this.btnUseTool = new System.Windows.Forms.Button();
            this.lblToolUpdate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(73, 9);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(298, 20);
            this.lblResults.TabIndex = 0;
            this.lblResults.Text = "{0} rolled {1} for {1}/{2} = {3} total {4}";
            // 
            // btnUseTool
            // 
            this.btnUseTool.Location = new System.Drawing.Point(139, 90);
            this.btnUseTool.Name = "btnUseTool";
            this.btnUseTool.Size = new System.Drawing.Size(175, 40);
            this.btnUseTool.TabIndex = 3;
            this.btnUseTool.Text = "Use Tool? ";
            this.btnUseTool.UseVisualStyleBackColor = true;
            this.btnUseTool.Click += new System.EventHandler(this.btnUseTool_Click);
            // 
            // lblToolUpdate
            // 
            this.lblToolUpdate.AutoSize = true;
            this.lblToolUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolUpdate.Location = new System.Drawing.Point(219, 40);
            this.lblToolUpdate.Name = "lblToolUpdate";
            this.lblToolUpdate.Size = new System.Drawing.Size(0, 16);
            this.lblToolUpdate.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(139, 136);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RollsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 188);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblToolUpdate);
            this.Controls.Add(this.btnUseTool);
            this.Controls.Add(this.lblResults);
            this.Name = "RollsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rolls";
            this.Load += new System.EventHandler(this.RollsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnUseTool;
        private System.Windows.Forms.Label lblToolUpdate;
        private System.Windows.Forms.Button btnClose;
    }
}