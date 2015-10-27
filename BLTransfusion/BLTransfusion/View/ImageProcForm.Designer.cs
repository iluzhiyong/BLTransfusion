namespace BLTransfusion
{
    partial class ImageProcForm
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
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            this.lb_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 1280, 960);
            this.hWindowControl1.Location = new System.Drawing.Point(12, 12);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(600, 418);
            this.hWindowControl1.TabIndex = 9;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(600, 418);
            // 
            // lb_Result
            // 
            this.lb_Result.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Result.Location = new System.Drawing.Point(245, 23);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(97, 30);
            this.lb_Result.TabIndex = 10;
            this.lb_Result.Text = "PASS";
            this.lb_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageProcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.ControlBox = false;
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.hWindowControl1);
            this.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ImageProcForm";
            this.Text = "图像处理窗口";
            this.ResumeLayout(false);

        }

        #endregion

        public HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.Label lb_Result;
    }
}