namespace BLTransfusion
{
    partial class ImgProcSetWnd
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectRoiBtn = new System.Windows.Forms.Button();
            this.tbRoiMaxArea = new System.Windows.Forms.TextBox();
            this.tbRoiMinArea = new System.Windows.Forms.TextBox();
            this.tbRoiMaxGray = new System.Windows.Forms.TextBox();
            this.tbRoiMinGray = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DoProcBtn = new System.Windows.Forms.Button();
            this.tbTargetMaxAnisometry = new System.Windows.Forms.TextBox();
            this.tbTargetMinAnisometry = new System.Windows.Forms.TextBox();
            this.tbTargetMaxArea = new System.Windows.Forms.TextBox();
            this.tbTartgetMinArea = new System.Windows.Forms.TextBox();
            this.tbMaskHeight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbMaskWidth = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSEWidth = new System.Windows.Forms.TextBox();
            this.tbSEHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTargetMinOuterRadius = new System.Windows.Forms.TextBox();
            this.tbTargetMaxOuterRadius = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTargetMinDeviation = new System.Windows.Forms.TextBox();
            this.tbTargetMaxDeviation = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROI最小灰度";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectRoiBtn);
            this.groupBox1.Controls.Add(this.tbRoiMaxArea);
            this.groupBox1.Controls.Add(this.tbRoiMinArea);
            this.groupBox1.Controls.Add(this.tbSEHeight);
            this.groupBox1.Controls.Add(this.tbRoiMaxGray);
            this.groupBox1.Controls.Add(this.tbSEWidth);
            this.groupBox1.Controls.Add(this.tbRoiMinGray);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择ROI";
            // 
            // SelectRoiBtn
            // 
            this.SelectRoiBtn.Location = new System.Drawing.Point(296, 159);
            this.SelectRoiBtn.Name = "SelectRoiBtn";
            this.SelectRoiBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectRoiBtn.TabIndex = 2;
            this.SelectRoiBtn.Text = "选择区域";
            this.SelectRoiBtn.UseVisualStyleBackColor = true;
            this.SelectRoiBtn.Click += new System.EventHandler(this.SelectRoiBtn_Click);
            // 
            // tbRoiMaxArea
            // 
            this.tbRoiMaxArea.Location = new System.Drawing.Point(177, 161);
            this.tbRoiMaxArea.Name = "tbRoiMaxArea";
            this.tbRoiMaxArea.Size = new System.Drawing.Size(100, 21);
            this.tbRoiMaxArea.TabIndex = 1;
            // 
            // tbRoiMinArea
            // 
            this.tbRoiMinArea.Location = new System.Drawing.Point(177, 132);
            this.tbRoiMinArea.Name = "tbRoiMinArea";
            this.tbRoiMinArea.Size = new System.Drawing.Size(100, 21);
            this.tbRoiMinArea.TabIndex = 1;
            // 
            // tbRoiMaxGray
            // 
            this.tbRoiMaxGray.Location = new System.Drawing.Point(177, 103);
            this.tbRoiMaxGray.Name = "tbRoiMaxGray";
            this.tbRoiMaxGray.Size = new System.Drawing.Size(100, 21);
            this.tbRoiMaxGray.TabIndex = 1;
            // 
            // tbRoiMinGray
            // 
            this.tbRoiMinGray.Location = new System.Drawing.Point(177, 74);
            this.tbRoiMinGray.Name = "tbRoiMinGray";
            this.tbRoiMinGray.Size = new System.Drawing.Size(100, 21);
            this.tbRoiMinGray.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "ROI最大面积";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "ROI最小面积";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ROI最大灰度";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DoProcBtn);
            this.groupBox2.Controls.Add(this.tbTargetMaxOuterRadius);
            this.groupBox2.Controls.Add(this.tbTargetMinDeviation);
            this.groupBox2.Controls.Add(this.tbTargetMinOuterRadius);
            this.groupBox2.Controls.Add(this.tbTargetMaxAnisometry);
            this.groupBox2.Controls.Add(this.tbTargetMinAnisometry);
            this.groupBox2.Controls.Add(this.tbTargetMaxArea);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tbTartgetMinArea);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbMaskHeight);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbMaskWidth);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 302);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图像处理";
            // 
            // DoProcBtn
            // 
            this.DoProcBtn.Location = new System.Drawing.Point(296, 265);
            this.DoProcBtn.Name = "DoProcBtn";
            this.DoProcBtn.Size = new System.Drawing.Size(75, 23);
            this.DoProcBtn.TabIndex = 2;
            this.DoProcBtn.Text = "处理图像";
            this.DoProcBtn.UseVisualStyleBackColor = true;
            this.DoProcBtn.Click += new System.EventHandler(this.DoProcBtn_Click);
            // 
            // tbTargetMaxAnisometry
            // 
            this.tbTargetMaxAnisometry.Location = new System.Drawing.Point(177, 158);
            this.tbTargetMaxAnisometry.Name = "tbTargetMaxAnisometry";
            this.tbTargetMaxAnisometry.Size = new System.Drawing.Size(100, 21);
            this.tbTargetMaxAnisometry.TabIndex = 1;
            // 
            // tbTargetMinAnisometry
            // 
            this.tbTargetMinAnisometry.Location = new System.Drawing.Point(177, 131);
            this.tbTargetMinAnisometry.Name = "tbTargetMinAnisometry";
            this.tbTargetMinAnisometry.Size = new System.Drawing.Size(100, 21);
            this.tbTargetMinAnisometry.TabIndex = 1;
            // 
            // tbTargetMaxArea
            // 
            this.tbTargetMaxArea.Location = new System.Drawing.Point(177, 104);
            this.tbTargetMaxArea.Name = "tbTargetMaxArea";
            this.tbTargetMaxArea.Size = new System.Drawing.Size(100, 21);
            this.tbTargetMaxArea.TabIndex = 1;
            // 
            // tbTartgetMinArea
            // 
            this.tbTartgetMinArea.Location = new System.Drawing.Point(177, 77);
            this.tbTartgetMinArea.Name = "tbTartgetMinArea";
            this.tbTartgetMinArea.Size = new System.Drawing.Size(100, 21);
            this.tbTartgetMinArea.TabIndex = 1;
            // 
            // tbMaskHeight
            // 
            this.tbMaskHeight.Location = new System.Drawing.Point(177, 49);
            this.tbMaskHeight.Name = "tbMaskHeight";
            this.tbMaskHeight.Size = new System.Drawing.Size(100, 21);
            this.tbMaskHeight.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "目标最大异向";
            // 
            // tbMaskWidth
            // 
            this.tbMaskWidth.Location = new System.Drawing.Point(177, 20);
            this.tbMaskWidth.Name = "tbMaskWidth";
            this.tbMaskWidth.Size = new System.Drawing.Size(100, 21);
            this.tbMaskWidth.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "目标最小异向";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "目标最大面积";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "目标最小面积";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "结构元素高度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "结构元素宽度";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(214, 540);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "保存参数";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(308, 540);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(118, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "SE宽度";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(118, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "SE高度";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbSEWidth
            // 
            this.tbSEWidth.Location = new System.Drawing.Point(177, 16);
            this.tbSEWidth.Name = "tbSEWidth";
            this.tbSEWidth.Size = new System.Drawing.Size(100, 21);
            this.tbSEWidth.TabIndex = 1;
            // 
            // tbSEHeight
            // 
            this.tbSEHeight.Location = new System.Drawing.Point(177, 45);
            this.tbSEHeight.Name = "tbSEHeight";
            this.tbSEHeight.Size = new System.Drawing.Size(100, 21);
            this.tbSEHeight.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "目标最小外圆";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "目标最大外圆";
            // 
            // tbTargetMinOuterRadius
            // 
            this.tbTargetMinOuterRadius.Location = new System.Drawing.Point(177, 186);
            this.tbTargetMinOuterRadius.Name = "tbTargetMinOuterRadius";
            this.tbTargetMinOuterRadius.Size = new System.Drawing.Size(100, 21);
            this.tbTargetMinOuterRadius.TabIndex = 1;
            // 
            // tbTargetMaxOuterRadius
            // 
            this.tbTargetMaxOuterRadius.Location = new System.Drawing.Point(177, 212);
            this.tbTargetMaxOuterRadius.Name = "tbTargetMaxOuterRadius";
            this.tbTargetMaxOuterRadius.Size = new System.Drawing.Size(100, 21);
            this.tbTargetMaxOuterRadius.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(82, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "目标最小方差";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(82, 269);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "目标最大方差";
            // 
            // tbTargetMinDeviation
            // 
            this.tbTargetMinDeviation.Location = new System.Drawing.Point(177, 240);
            this.tbTargetMinDeviation.Name = "tbTargetMinDeviation";
            this.tbTargetMinDeviation.Size = new System.Drawing.Size(100, 21);
            this.tbTargetMinDeviation.TabIndex = 1;
            // 
            // tbTargetMaxDeviation
            // 
            this.tbTargetMaxDeviation.Location = new System.Drawing.Point(189, 489);
            this.tbTargetMaxDeviation.Name = "tbTargetMaxDeviation";
            this.tbTargetMaxDeviation.Size = new System.Drawing.Size(100, 21);
            this.tbTargetMaxDeviation.TabIndex = 1;
            // 
            // ImgProcSetWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 577);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.tbTargetMaxDeviation);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImgProcSetWnd";
            this.Text = "参数设置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRoiMinGray;
        private System.Windows.Forms.TextBox tbRoiMaxArea;
        private System.Windows.Forms.TextBox tbRoiMinArea;
        private System.Windows.Forms.TextBox tbRoiMaxGray;
        private System.Windows.Forms.TextBox tbTargetMaxArea;
        private System.Windows.Forms.TextBox tbTartgetMinArea;
        private System.Windows.Forms.TextBox tbMaskHeight;
        private System.Windows.Forms.TextBox tbMaskWidth;
        private System.Windows.Forms.Button SelectRoiBtn;
        private System.Windows.Forms.Button DoProcBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox tbTargetMaxAnisometry;
        private System.Windows.Forms.TextBox tbTargetMinAnisometry;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSEHeight;
        private System.Windows.Forms.TextBox tbSEWidth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTargetMaxOuterRadius;
        private System.Windows.Forms.TextBox tbTargetMinOuterRadius;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTargetMinDeviation;
        private System.Windows.Forms.TextBox tbTargetMaxDeviation;
    }
}