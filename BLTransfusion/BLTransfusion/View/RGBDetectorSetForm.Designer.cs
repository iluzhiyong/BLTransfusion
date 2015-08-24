namespace BLTransfusion.View
{
    partial class RGBDetectorSetForm
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
            this.tbRedMaxGray = new System.Windows.Forms.TextBox();
            this.tbRedMinGray = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMinArea = new System.Windows.Forms.TextBox();
            this.tbMaxArea = new System.Windows.Forms.TextBox();
            this.tbnProc = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGreenMinGray = new System.Windows.Forms.TextBox();
            this.tbGreenMaxGray = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBlueMinGray = new System.Windows.Forms.TextBox();
            this.tbBlueMaxGray = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbRedMaxGray
            // 
            this.tbRedMaxGray.Location = new System.Drawing.Point(123, 51);
            this.tbRedMaxGray.Name = "tbRedMaxGray";
            this.tbRedMaxGray.Size = new System.Drawing.Size(100, 21);
            this.tbRedMaxGray.TabIndex = 4;
            // 
            // tbRedMinGray
            // 
            this.tbRedMinGray.Location = new System.Drawing.Point(123, 24);
            this.tbRedMinGray.Name = "tbRedMinGray";
            this.tbRedMinGray.Size = new System.Drawing.Size(100, 21);
            this.tbRedMinGray.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "红色最大灰度值";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "红色最小灰度值";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(234, 48);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(69, 24);
            this.btnRed.TabIndex = 6;
            this.btnRed.Text = "红色检测";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(234, 114);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(69, 24);
            this.btnGreen.TabIndex = 6;
            this.btnGreen.Text = "绿色检测";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(234, 180);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(69, 24);
            this.btnBlue.TabIndex = 6;
            this.btnBlue.Text = "蓝色检测";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "最小面积";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "最大面积";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbMinArea
            // 
            this.tbMinArea.Location = new System.Drawing.Point(123, 226);
            this.tbMinArea.Name = "tbMinArea";
            this.tbMinArea.Size = new System.Drawing.Size(100, 21);
            this.tbMinArea.TabIndex = 5;
            // 
            // tbMaxArea
            // 
            this.tbMaxArea.Location = new System.Drawing.Point(123, 255);
            this.tbMaxArea.Name = "tbMaxArea";
            this.tbMaxArea.Size = new System.Drawing.Size(100, 21);
            this.tbMaxArea.TabIndex = 4;
            // 
            // tbnProc
            // 
            this.tbnProc.Location = new System.Drawing.Point(234, 252);
            this.tbnProc.Name = "tbnProc";
            this.tbnProc.Size = new System.Drawing.Size(69, 24);
            this.tbnProc.TabIndex = 6;
            this.tbnProc.Text = "处理图像";
            this.tbnProc.UseVisualStyleBackColor = true;
            this.tbnProc.Click += new System.EventHandler(this.tbnProc_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(136, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "绿色最小灰度值";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "绿色最大灰度值";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbGreenMinGray
            // 
            this.tbGreenMinGray.Location = new System.Drawing.Point(123, 89);
            this.tbGreenMinGray.Name = "tbGreenMinGray";
            this.tbGreenMinGray.Size = new System.Drawing.Size(100, 21);
            this.tbGreenMinGray.TabIndex = 5;
            // 
            // tbGreenMaxGray
            // 
            this.tbGreenMaxGray.Location = new System.Drawing.Point(123, 116);
            this.tbGreenMaxGray.Name = "tbGreenMaxGray";
            this.tbGreenMaxGray.Size = new System.Drawing.Size(100, 21);
            this.tbGreenMaxGray.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "蓝色最小灰度值";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "蓝色最大灰度值";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbBlueMinGray
            // 
            this.tbBlueMinGray.Location = new System.Drawing.Point(123, 156);
            this.tbBlueMinGray.Name = "tbBlueMinGray";
            this.tbBlueMinGray.Size = new System.Drawing.Size(100, 21);
            this.tbBlueMinGray.TabIndex = 5;
            // 
            // tbBlueMaxGray
            // 
            this.tbBlueMaxGray.Location = new System.Drawing.Point(123, 183);
            this.tbBlueMaxGray.Name = "tbBlueMaxGray";
            this.tbBlueMaxGray.Size = new System.Drawing.Size(100, 21);
            this.tbBlueMaxGray.TabIndex = 4;
            // 
            // RGBDetectorSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 361);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbnProc);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.tbMaxArea);
            this.Controls.Add(this.tbMinArea);
            this.Controls.Add(this.tbBlueMaxGray);
            this.Controls.Add(this.tbGreenMaxGray);
            this.Controls.Add(this.tbBlueMinGray);
            this.Controls.Add(this.tbRedMaxGray);
            this.Controls.Add(this.tbGreenMinGray);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbRedMinGray);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RGBDetectorSetForm";
            this.Text = "RGB检测设定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRedMaxGray;
        private System.Windows.Forms.TextBox tbRedMinGray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMinArea;
        private System.Windows.Forms.TextBox tbMaxArea;
        private System.Windows.Forms.Button tbnProc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGreenMinGray;
        private System.Windows.Forms.TextBox tbGreenMaxGray;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBlueMinGray;
        private System.Windows.Forms.TextBox tbBlueMaxGray;
    }
}