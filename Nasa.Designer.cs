
namespace Project
{
    partial class Nasa
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
            this.datePOTD = new System.Windows.Forms.DateTimePicker();
            this.buttonPOTD = new System.Windows.Forms.Button();
            this.buttonMRP = new System.Windows.Forms.Button();
            this.dateMRP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // datePOTD
            // 
            this.datePOTD.Location = new System.Drawing.Point(0, 0);
            this.datePOTD.Name = "datePOTD";
            this.datePOTD.Size = new System.Drawing.Size(200, 20);
            this.datePOTD.TabIndex = 0;
            // 
            // buttonPOTD
            // 
            this.buttonPOTD.Location = new System.Drawing.Point(0, 20);
            this.buttonPOTD.Name = "buttonPOTD";
            this.buttonPOTD.Size = new System.Drawing.Size(200, 20);
            this.buttonPOTD.TabIndex = 1;
            this.buttonPOTD.Text = "GET POTD";
            this.buttonPOTD.UseVisualStyleBackColor = true;
            this.buttonPOTD.Click += new System.EventHandler(this.buttonPOTD_Click);
            // 
            // buttonMRP
            // 
            this.buttonMRP.Location = new System.Drawing.Point(0, 77);
            this.buttonMRP.Name = "buttonMRP";
            this.buttonMRP.Size = new System.Drawing.Size(200, 20);
            this.buttonMRP.TabIndex = 3;
            this.buttonMRP.Text = "GET MRP";
            this.buttonMRP.UseVisualStyleBackColor = true;
            this.buttonMRP.Click += new System.EventHandler(this.buttonMRP_Click);
            // 
            // dateMRP
            // 
            this.dateMRP.Location = new System.Drawing.Point(0, 57);
            this.dateMRP.Name = "dateMRP";
            this.dateMRP.Size = new System.Drawing.Size(200, 20);
            this.dateMRP.TabIndex = 2;
            // 
            // Nasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMRP);
            this.Controls.Add(this.dateMRP);
            this.Controls.Add(this.buttonPOTD);
            this.Controls.Add(this.datePOTD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Nasa";
            this.Text = "Nasa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePOTD;
        private System.Windows.Forms.Button buttonPOTD;
        private System.Windows.Forms.Button buttonMRP;
        private System.Windows.Forms.DateTimePicker dateMRP;
    }
}

