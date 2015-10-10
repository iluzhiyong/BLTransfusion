namespace BLTransfusion
{
    partial class ImageDispForm
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
            this.pB_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_Image
            // 
            this.pB_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pB_Image.Location = new System.Drawing.Point(12, 12);
            this.pB_Image.Name = "pB_Image";
            this.pB_Image.Size = new System.Drawing.Size(600, 418);
            this.pB_Image.TabIndex = 10;
            this.pB_Image.TabStop = false;
            // 
            // ImageDispForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.ControlBox = false;
            this.Controls.Add(this.pB_Image);
            this.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ImageDispForm";
            this.Text = "相机实时采集窗口";
            ((System.ComponentModel.ISupportInitialize)(this.pB_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pB_Image;
    }
}