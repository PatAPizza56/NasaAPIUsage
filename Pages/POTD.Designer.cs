
namespace Project
{
    partial class POTD
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
            this.pictureURL = new System.Windows.Forms.PictureBox();
            this.labelExplanation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURL)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureURL
            // 
            this.pictureURL.Location = new System.Drawing.Point(12, 12);
            this.pictureURL.Name = "pictureURL";
            this.pictureURL.Size = new System.Drawing.Size(420, 426);
            this.pictureURL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureURL.TabIndex = 0;
            this.pictureURL.TabStop = false;
            // 
            // labelExplanation
            // 
            this.labelExplanation.Location = new System.Drawing.Point(438, 12);
            this.labelExplanation.Name = "labelExplanation";
            this.labelExplanation.Size = new System.Drawing.Size(350, 426);
            this.labelExplanation.TabIndex = 1;
            // 
            // POTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelExplanation);
            this.Controls.Add(this.pictureURL);
            this.Name = "POTD";
            this.Text = "POTD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureURL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureURL;
        private System.Windows.Forms.Label labelExplanation;
    }
}