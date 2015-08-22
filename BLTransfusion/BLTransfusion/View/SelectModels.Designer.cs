namespace BLTransfusion.View
{
    partial class ModelSetForm
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
            this.modelslistBox = new System.Windows.Forms.ListBox();
            this.loadModelImage = new System.Windows.Forms.Button();
            this.loadExistedModels = new System.Windows.Forms.Button();
            this.addModel = new System.Windows.Forms.Button();
            this.deletedModel = new System.Windows.Forms.Button();
            this.clearModels = new System.Windows.Forms.Button();
            this.displayOneModel = new System.Windows.Forms.Button();
            this.displayALLModel = new System.Windows.Forms.Button();
            this.saveModels = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modelslistBox
            // 
            this.modelslistBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.modelslistBox.FormattingEnabled = true;
            this.modelslistBox.ItemHeight = 12;
            this.modelslistBox.Location = new System.Drawing.Point(14, 11);
            this.modelslistBox.Name = "modelslistBox";
            this.modelslistBox.Size = new System.Drawing.Size(311, 400);
            this.modelslistBox.TabIndex = 0;
            this.modelslistBox.SelectedIndexChanged += new System.EventHandler(this.modelslistBox_SelectedIndexChanged);
            // 
            // loadModelImage
            // 
            this.loadModelImage.Location = new System.Drawing.Point(387, 28);
            this.loadModelImage.Name = "loadModelImage";
            this.loadModelImage.Size = new System.Drawing.Size(123, 23);
            this.loadModelImage.TabIndex = 1;
            this.loadModelImage.Text = "加载模板图像";
            this.loadModelImage.UseVisualStyleBackColor = true;
            this.loadModelImage.Click += new System.EventHandler(this.loadModelImage_Click);
            // 
            // loadExistedModels
            // 
            this.loadExistedModels.Location = new System.Drawing.Point(387, 75);
            this.loadExistedModels.Name = "loadExistedModels";
            this.loadExistedModels.Size = new System.Drawing.Size(123, 23);
            this.loadExistedModels.TabIndex = 2;
            this.loadExistedModels.Text = "加载已有模板";
            this.loadExistedModels.UseVisualStyleBackColor = true;
            this.loadExistedModels.Click += new System.EventHandler(this.loadExistedModels_Click);
            // 
            // addModel
            // 
            this.addModel.Location = new System.Drawing.Point(387, 122);
            this.addModel.Name = "addModel";
            this.addModel.Size = new System.Drawing.Size(123, 23);
            this.addModel.TabIndex = 3;
            this.addModel.Text = "添加模板";
            this.addModel.UseVisualStyleBackColor = true;
            this.addModel.Click += new System.EventHandler(this.addModel_Click);
            // 
            // deletedModel
            // 
            this.deletedModel.Location = new System.Drawing.Point(387, 169);
            this.deletedModel.Name = "deletedModel";
            this.deletedModel.Size = new System.Drawing.Size(123, 23);
            this.deletedModel.TabIndex = 4;
            this.deletedModel.Text = "删除模板";
            this.deletedModel.UseVisualStyleBackColor = true;
            this.deletedModel.Click += new System.EventHandler(this.deletedModel_Click);
            // 
            // clearModels
            // 
            this.clearModels.Location = new System.Drawing.Point(387, 216);
            this.clearModels.Name = "clearModels";
            this.clearModels.Size = new System.Drawing.Size(123, 23);
            this.clearModels.TabIndex = 5;
            this.clearModels.Text = "清空模板";
            this.clearModels.UseVisualStyleBackColor = true;
            this.clearModels.Click += new System.EventHandler(this.clearModels_Click);
            // 
            // displayOneModel
            // 
            this.displayOneModel.Location = new System.Drawing.Point(387, 263);
            this.displayOneModel.Name = "displayOneModel";
            this.displayOneModel.Size = new System.Drawing.Size(123, 23);
            this.displayOneModel.TabIndex = 6;
            this.displayOneModel.Text = "显示模板";
            this.displayOneModel.UseVisualStyleBackColor = true;
            this.displayOneModel.Click += new System.EventHandler(this.displayOneModel_Click);
            // 
            // displayALLModel
            // 
            this.displayALLModel.Location = new System.Drawing.Point(387, 310);
            this.displayALLModel.Name = "displayALLModel";
            this.displayALLModel.Size = new System.Drawing.Size(123, 23);
            this.displayALLModel.TabIndex = 7;
            this.displayALLModel.Text = "显示所有模板";
            this.displayALLModel.UseVisualStyleBackColor = true;
            this.displayALLModel.Click += new System.EventHandler(this.displayALLModel_Click);
            // 
            // saveModels
            // 
            this.saveModels.Location = new System.Drawing.Point(387, 357);
            this.saveModels.Name = "saveModels";
            this.saveModels.Size = new System.Drawing.Size(123, 23);
            this.saveModels.TabIndex = 8;
            this.saveModels.Text = "保存模板";
            this.saveModels.UseVisualStyleBackColor = true;
            this.saveModels.Click += new System.EventHandler(this.saveModels_Click);
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(596, 28);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(164, 23);
            this.settingButton.TabIndex = 9;
            this.settingButton.Text = "参数设定";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.InspectShapeModelBtn_Click);
            // 
            // SelectModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 426);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.saveModels);
            this.Controls.Add(this.displayALLModel);
            this.Controls.Add(this.displayOneModel);
            this.Controls.Add(this.clearModels);
            this.Controls.Add(this.deletedModel);
            this.Controls.Add(this.addModel);
            this.Controls.Add(this.loadExistedModels);
            this.Controls.Add(this.loadModelImage);
            this.Controls.Add(this.modelslistBox);
            this.Name = "SelectModels";
            this.Text = "SelectModels";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox modelslistBox;
        private System.Windows.Forms.Button loadModelImage;
        private System.Windows.Forms.Button loadExistedModels;
        private System.Windows.Forms.Button addModel;
        private System.Windows.Forms.Button deletedModel;
        private System.Windows.Forms.Button clearModels;
        private System.Windows.Forms.Button displayOneModel;
        private System.Windows.Forms.Button displayALLModel;
        private System.Windows.Forms.Button saveModels;
        private System.Windows.Forms.Button settingButton;
    }
}