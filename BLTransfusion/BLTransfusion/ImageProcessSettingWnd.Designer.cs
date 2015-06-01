﻿namespace BLTransfusion
{
    partial class ImageProcessSettingWnd
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRoiMinGray = new System.Windows.Forms.TextBox();
            this.tbRoiMaxGray = new System.Windows.Forms.TextBox();
            this.tbRoiMinArea = new System.Windows.Forms.TextBox();
            this.tbRoiMaxArea = new System.Windows.Forms.TextBox();
            this.tbMaskWidth = new System.Windows.Forms.TextBox();
            this.tbMaskHeight = new System.Windows.Forms.TextBox();
            this.tbDynThrehOffset = new System.Windows.Forms.TextBox();
            this.tbDilaEroRadius = new System.Windows.Forms.TextBox();
            this.tbTartgetMinArea = new System.Windows.Forms.TextBox();
            this.tbTargetMaxArea = new System.Windows.Forms.TextBox();
            this.SelectRoiBtn = new System.Windows.Forms.Button();
            this.DoProcBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROI Min Gray";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectRoiBtn);
            this.groupBox1.Controls.Add(this.tbRoiMaxArea);
            this.groupBox1.Controls.Add(this.tbRoiMinArea);
            this.groupBox1.Controls.Add(this.tbRoiMaxGray);
            this.groupBox1.Controls.Add(this.tbRoiMinGray);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select ROI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ROI Max Gray";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "ROI Min Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "ROI Max Area";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DoProcBtn);
            this.groupBox2.Controls.Add(this.tbTargetMaxArea);
            this.groupBox2.Controls.Add(this.tbTartgetMinArea);
            this.groupBox2.Controls.Add(this.tbDilaEroRadius);
            this.groupBox2.Controls.Add(this.tbDynThrehOffset);
            this.groupBox2.Controls.Add(this.tbMaskHeight);
            this.groupBox2.Controls.Add(this.tbMaskWidth);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 185);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Process";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mask Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mask Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dyn Threh Offset";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dilation Erosion Radius";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Target Min Area";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Target Max Area";
            // 
            // tbRoiMinGray
            // 
            this.tbRoiMinGray.Location = new System.Drawing.Point(177, 23);
            this.tbRoiMinGray.Name = "tbRoiMinGray";
            this.tbRoiMinGray.Size = new System.Drawing.Size(100, 21);
            this.tbRoiMinGray.TabIndex = 1;
            // 
            // tbRoiMaxGray
            // 
            this.tbRoiMaxGray.Location = new System.Drawing.Point(177, 52);
            this.tbRoiMaxGray.Name = "tbRoiMaxGray";
            this.tbRoiMaxGray.Size = new System.Drawing.Size(100, 21);
            this.tbRoiMaxGray.TabIndex = 1;
            // 
            // tbRoiMinArea
            // 
            this.tbRoiMinArea.Location = new System.Drawing.Point(177, 81);
            this.tbRoiMinArea.Name = "tbRoiMinArea";
            this.tbRoiMinArea.Size = new System.Drawing.Size(100, 21);
            this.tbRoiMinArea.TabIndex = 1;
            // 
            // tbRoiMaxArea
            // 
            this.tbRoiMaxArea.Location = new System.Drawing.Point(177, 110);
            this.tbRoiMaxArea.Name = "tbRoiMaxArea";
            this.tbRoiMaxArea.Size = new System.Drawing.Size(100, 21);
            this.tbRoiMaxArea.TabIndex = 1;
            // 
            // tbMaskWidth
            // 
            this.tbMaskWidth.Location = new System.Drawing.Point(177, 20);
            this.tbMaskWidth.Name = "tbMaskWidth";
            this.tbMaskWidth.Size = new System.Drawing.Size(100, 21);
            this.tbMaskWidth.TabIndex = 1;
            // 
            // tbMaskHeight
            // 
            this.tbMaskHeight.Location = new System.Drawing.Point(177, 46);
            this.tbMaskHeight.Name = "tbMaskHeight";
            this.tbMaskHeight.Size = new System.Drawing.Size(100, 21);
            this.tbMaskHeight.TabIndex = 1;
            // 
            // tbDynThrehOffset
            // 
            this.tbDynThrehOffset.Location = new System.Drawing.Point(177, 72);
            this.tbDynThrehOffset.Name = "tbDynThrehOffset";
            this.tbDynThrehOffset.Size = new System.Drawing.Size(100, 21);
            this.tbDynThrehOffset.TabIndex = 1;
            // 
            // tbDilaEroRadius
            // 
            this.tbDilaEroRadius.Location = new System.Drawing.Point(177, 98);
            this.tbDilaEroRadius.Name = "tbDilaEroRadius";
            this.tbDilaEroRadius.Size = new System.Drawing.Size(100, 21);
            this.tbDilaEroRadius.TabIndex = 1;
            // 
            // tbTartgetMinArea
            // 
            this.tbTartgetMinArea.Location = new System.Drawing.Point(177, 124);
            this.tbTartgetMinArea.Name = "tbTartgetMinArea";
            this.tbTartgetMinArea.Size = new System.Drawing.Size(100, 21);
            this.tbTartgetMinArea.TabIndex = 1;
            // 
            // tbTargetMaxArea
            // 
            this.tbTargetMaxArea.Location = new System.Drawing.Point(177, 150);
            this.tbTargetMaxArea.Name = "tbTargetMaxArea";
            this.tbTargetMaxArea.Size = new System.Drawing.Size(100, 21);
            this.tbTargetMaxArea.TabIndex = 1;
            // 
            // SelectRoiBtn
            // 
            this.SelectRoiBtn.Location = new System.Drawing.Point(296, 74);
            this.SelectRoiBtn.Name = "SelectRoiBtn";
            this.SelectRoiBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectRoiBtn.TabIndex = 2;
            this.SelectRoiBtn.Text = "Do Select";
            this.SelectRoiBtn.UseVisualStyleBackColor = true;
            this.SelectRoiBtn.Click += new System.EventHandler(this.SelectRoiBtn_Click);
            // 
            // DoProcBtn
            // 
            this.DoProcBtn.Location = new System.Drawing.Point(296, 90);
            this.DoProcBtn.Name = "DoProcBtn";
            this.DoProcBtn.Size = new System.Drawing.Size(75, 23);
            this.DoProcBtn.TabIndex = 2;
            this.DoProcBtn.Text = "Do Process";
            this.DoProcBtn.UseVisualStyleBackColor = true;
            this.DoProcBtn.Click += new System.EventHandler(this.DoProcBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(228, 371);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(319, 371);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ImageProcessSettingWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 415);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImageProcessSettingWnd";
            this.Text = "ImageProcessSettingWnd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRoiMinGray;
        private System.Windows.Forms.TextBox tbRoiMaxArea;
        private System.Windows.Forms.TextBox tbRoiMinArea;
        private System.Windows.Forms.TextBox tbRoiMaxGray;
        private System.Windows.Forms.TextBox tbTargetMaxArea;
        private System.Windows.Forms.TextBox tbTartgetMinArea;
        private System.Windows.Forms.TextBox tbDilaEroRadius;
        private System.Windows.Forms.TextBox tbDynThrehOffset;
        private System.Windows.Forms.TextBox tbMaskHeight;
        private System.Windows.Forms.TextBox tbMaskWidth;
        private System.Windows.Forms.Button SelectRoiBtn;
        private System.Windows.Forms.Button DoProcBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}