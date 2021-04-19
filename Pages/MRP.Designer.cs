
namespace Project
{
    partial class MRP
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
            this.labelCameraName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURL)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureURL
            // 
            this.pictureURL.Location = new System.Drawing.Point(12, 12);
            this.pictureURL.Name = "pictureURL";
            this.pictureURL.Size = new System.Drawing.Size(420, 426);
            this.pictureURL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureURL.TabIndex = 1;
            this.pictureURL.TabStop = false;
            // 
            // labelCameraName
            // 
            this.labelCameraName.Location = new System.Drawing.Point(438, 9);
            this.labelCameraName.Name = "labelCameraName";
            this.labelCameraName.Size = new System.Drawing.Size(350, 426);
            this.labelCameraName.TabIndex = 2;
            // 
            // MRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCameraName);
            this.Controls.Add(this.pictureURL);
            this.Name = "MRP";
            this.Text = "MRP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureURL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureURL;
        private System.Windows.Forms.Label labelCameraName;
    }
}