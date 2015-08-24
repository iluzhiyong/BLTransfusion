namespace BLTransfusion.View
{
    partial class AlgorithmForm
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
            this.CB_Junk = new System.Windows.Forms.CheckBox();
            this.CB_Model = new System.Windows.Forms.CheckBox();
            this.Btn_Junk_Setting = new System.Windows.Forms.Button();
            this.Btn_Model_Setting = new System.Windows.Forms.Button();
            this.CBRgb = new System.Windows.Forms.CheckBox();
            this.btnRgbSetting = new System.Windows.Forms.Button();
            this.btnAlgSave = new System.Windows.Forms.Button();
            this.btnAlgCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Junk
            // 
            this.CB_Junk.AutoSize = true;
            this.CB_Junk.Location = new System.Drawing.Point(21, 31);
            this.CB_Junk.Name = "CB_Junk";
            this.CB_Junk.Size = new System.Drawing.Size(72, 16);
            this.CB_Junk.TabIndex = 0;
            this.CB_Junk.Text = "异物检测";
            this.CB_Junk.UseVisualStyleBackColor = true;
            // 
            // CB_Model
            // 
            this.CB_Model.AutoSize = true;
            this.CB_Model.Location = new System.Drawing.Point(21, 71);
            this.CB_Model.Name = "CB_Model";
            this.CB_Model.Size = new System.Drawing.Size(72, 16);
            this.CB_Model.TabIndex = 0;
            this.CB_Model.Text = "模板匹配";
            this.CB_Model.UseVisualStyleBackColor = true;
            // 
            // Btn_Junk_Setting
            // 
            this.Btn_Junk_Setting.Location = new System.Drawing.Point(134, 28);
            this.Btn_Junk_Setting.Name = "Btn_Junk_Setting";
            this.Btn_Junk_Setting.Size = new System.Drawing.Size(77, 20);
            this.Btn_Junk_Setting.TabIndex = 1;
            this.Btn_Junk_Setting.Text = "算法参数";
            this.Btn_Junk_Setting.UseVisualStyleBackColor = true;
            this.Btn_Junk_Setting.Click += new System.EventHandler(this.Btn_Junk_Setting_Click);
            // 
            // Btn_Model_Setting
            // 
            this.Btn_Model_Setting.Location = new System.Drawing.Point(134, 68);
            this.Btn_Model_Setting.Name = "Btn_Model_Setting";
            this.Btn_Model_Setting.Size = new System.Drawing.Size(77, 20);
            this.Btn_Model_Setting.TabIndex = 1;
            this.Btn_Model_Setting.Text = "算法参数";
            this.Btn_Model_Setting.UseVisualStyleBackColor = true;
            this.Btn_Model_Setting.Click += new System.EventHandler(this.Btn_Model_Setting_Click);
            // 
            // CBRgb
            // 
            this.CBRgb.AutoSize = true;
            this.CBRgb.Location = new System.Drawing.Point(21, 108);
            this.CBRgb.Name = "CBRgb";
            this.CBRgb.Size = new System.Drawing.Size(66, 16);
            this.CBRgb.TabIndex = 0;
            this.CBRgb.Text = "RGB检测";
            this.CBRgb.UseVisualStyleBackColor = true;
            // 
            // btnRgbSetting
            // 
            this.btnRgbSetting.Location = new System.Drawing.Point(134, 105);
            this.btnRgbSetting.Name = "btnRgbSetting";
            this.btnRgbSetting.Size = new System.Drawing.Size(77, 20);
            this.btnRgbSetting.TabIndex = 1;
            this.btnRgbSetting.Text = "算法参数";
            this.btnRgbSetting.UseVisualStyleBackColor = true;
            this.btnRgbSetting.Click += new System.EventHandler(this.btnRgbSetting_Click);
            // 
            // btnAlgSave
            // 
            this.btnAlgSave.Location = new System.Drawing.Point(51, 156);
            this.btnAlgSave.Name = "btnAlgSave";
            this.btnAlgSave.Size = new System.Drawing.Size(77, 20);
            this.btnAlgSave.TabIndex = 1;
            this.btnAlgSave.Text = "保存参数";
            this.btnAlgSave.UseVisualStyleBackColor = true;
            this.btnAlgSave.Click += new System.EventHandler(this.btnAlgSave_Click);
            // 
            // btnAlgCancel
            // 
            this.btnAlgCancel.Location = new System.Drawing.Point(134, 156);
            this.btnAlgCancel.Name = "btnAlgCancel";
            this.btnAlgCancel.Size = new System.Drawing.Size(77, 20);
            this.btnAlgCancel.TabIndex = 1;
            this.btnAlgCancel.Text = "取消";
            this.btnAlgCancel.UseVisualStyleBackColor = true;
            this.btnAlgCancel.Click += new System.EventHandler(this.btnAlgCancel_Click);
            // 
            // AlgorithmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 188);
            this.Controls.Add(this.btnAlgCancel);
            this.Controls.Add(this.btnAlgSave);
            this.Controls.Add(this.btnRgbSetting);
            this.Controls.Add(this.Btn_Model_Setting);
            this.Controls.Add(this.CBRgb);
            this.Controls.Add(this.Btn_Junk_Setting);
            this.Controls.Add(this.CB_Model);
            this.Controls.Add(this.CB_Junk);
            this.Name = "AlgorithmForm";
            this.Text = "算法";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_Junk;
        private System.Windows.Forms.CheckBox CB_Model;
        private System.Windows.Forms.Button Btn_Junk_Setting;
        private System.Windows.Forms.Button Btn_Model_Setting;
        private System.Windows.Forms.CheckBox CBRgb;
        private System.Windows.Forms.Button btnRgbSetting;
        private System.Windows.Forms.Button btnAlgSave;
        private System.Windows.Forms.Button btnAlgCancel;
    }
}