namespace BLTransfusion.View
{
    partial class ShapeModelDialog
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.inspectShapeModelTabPage = new System.Windows.Forms.TabPage();
            this.createShapeModelTabPage = new System.Windows.Forms.TabPage();
            this.findShapeModelTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.inspectNumLevelsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inspectContrastTextBox = new System.Windows.Forms.TextBox();
            this.inspectShapeModelBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numLevelsAutoCheckBox = new System.Windows.Forms.CheckBox();
            this.numLevelsComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.angleStartTextBox = new System.Windows.Forms.TextBox();
            this.angleExtentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.angleStepAutoCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.angleStepTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ScaleMinTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ScaleMaxTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.scaleStepAutoCheCkBox = new System.Windows.Forms.CheckBox();
            this.scaleStepTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.optimizationComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.metricComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ContrastComboBox = new System.Windows.Forms.ComboBox();
            this.ContrastValueTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.minContrastCheckBox = new System.Windows.Forms.CheckBox();
            this.minContrastTextBox = new System.Windows.Forms.TextBox();
            this.matchScaleMaxTextBox = new System.Windows.Forms.TextBox();
            this.matchScaleMinTextBox = new System.Windows.Forms.TextBox();
            this.matchAngleExtentTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.matchAngleStartTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.minScoreTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numMatchesTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.maxOverlapTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.subPixelComboBox = new System.Windows.Forms.ComboBox();
            this.matchNumLevelsComboBox = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.greedinessTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.TestCreateShapeModelBtn = new System.Windows.Forms.Button();
            this.testFindShapeModelBtn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.inspectShapeModelTabPage.SuspendLayout();
            this.createShapeModelTabPage.SuspendLayout();
            this.findShapeModelTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.inspectShapeModelTabPage);
            this.tabControl.Controls.Add(this.createShapeModelTabPage);
            this.tabControl.Controls.Add(this.findShapeModelTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(363, 327);
            this.tabControl.TabIndex = 0;
            // 
            // inspectShapeModelTabPage
            // 
            this.inspectShapeModelTabPage.Controls.Add(this.inspectShapeModelBtn);
            this.inspectShapeModelTabPage.Controls.Add(this.inspectContrastTextBox);
            this.inspectShapeModelTabPage.Controls.Add(this.label2);
            this.inspectShapeModelTabPage.Controls.Add(this.inspectNumLevelsComboBox);
            this.inspectShapeModelTabPage.Controls.Add(this.label1);
            this.inspectShapeModelTabPage.Location = new System.Drawing.Point(4, 22);
            this.inspectShapeModelTabPage.Name = "inspectShapeModelTabPage";
            this.inspectShapeModelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inspectShapeModelTabPage.Size = new System.Drawing.Size(355, 267);
            this.inspectShapeModelTabPage.TabIndex = 0;
            this.inspectShapeModelTabPage.Text = "Inspect Shape Model";
            this.inspectShapeModelTabPage.UseVisualStyleBackColor = true;
            // 
            // createShapeModelTabPage
            // 
            this.createShapeModelTabPage.Controls.Add(this.TestCreateShapeModelBtn);
            this.createShapeModelTabPage.Controls.Add(this.ContrastValueTextBox);
            this.createShapeModelTabPage.Controls.Add(this.ContrastComboBox);
            this.createShapeModelTabPage.Controls.Add(this.label12);
            this.createShapeModelTabPage.Controls.Add(this.metricComboBox);
            this.createShapeModelTabPage.Controls.Add(this.optimizationComboBox);
            this.createShapeModelTabPage.Controls.Add(this.label11);
            this.createShapeModelTabPage.Controls.Add(this.label10);
            this.createShapeModelTabPage.Controls.Add(this.minContrastTextBox);
            this.createShapeModelTabPage.Controls.Add(this.scaleStepTextBox);
            this.createShapeModelTabPage.Controls.Add(this.angleStepTextBox);
            this.createShapeModelTabPage.Controls.Add(this.minContrastCheckBox);
            this.createShapeModelTabPage.Controls.Add(this.scaleStepAutoCheCkBox);
            this.createShapeModelTabPage.Controls.Add(this.angleStepAutoCheckBox);
            this.createShapeModelTabPage.Controls.Add(this.label13);
            this.createShapeModelTabPage.Controls.Add(this.label9);
            this.createShapeModelTabPage.Controls.Add(this.label6);
            this.createShapeModelTabPage.Controls.Add(this.ScaleMaxTextBox);
            this.createShapeModelTabPage.Controls.Add(this.ScaleMinTextBox);
            this.createShapeModelTabPage.Controls.Add(this.angleExtentTextBox);
            this.createShapeModelTabPage.Controls.Add(this.label8);
            this.createShapeModelTabPage.Controls.Add(this.label7);
            this.createShapeModelTabPage.Controls.Add(this.label5);
            this.createShapeModelTabPage.Controls.Add(this.angleStartTextBox);
            this.createShapeModelTabPage.Controls.Add(this.label4);
            this.createShapeModelTabPage.Controls.Add(this.numLevelsComboBox);
            this.createShapeModelTabPage.Controls.Add(this.numLevelsAutoCheckBox);
            this.createShapeModelTabPage.Controls.Add(this.label3);
            this.createShapeModelTabPage.Location = new System.Drawing.Point(4, 22);
            this.createShapeModelTabPage.Name = "createShapeModelTabPage";
            this.createShapeModelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.createShapeModelTabPage.Size = new System.Drawing.Size(355, 301);
            this.createShapeModelTabPage.TabIndex = 1;
            this.createShapeModelTabPage.Text = "Create Shape Model";
            this.createShapeModelTabPage.UseVisualStyleBackColor = true;
            // 
            // findShapeModelTabPage
            // 
            this.findShapeModelTabPage.Controls.Add(this.testFindShapeModelBtn);
            this.findShapeModelTabPage.Controls.Add(this.matchNumLevelsComboBox);
            this.findShapeModelTabPage.Controls.Add(this.label22);
            this.findShapeModelTabPage.Controls.Add(this.subPixelComboBox);
            this.findShapeModelTabPage.Controls.Add(this.label21);
            this.findShapeModelTabPage.Controls.Add(this.maxOverlapTextBox);
            this.findShapeModelTabPage.Controls.Add(this.numMatchesTextBox);
            this.findShapeModelTabPage.Controls.Add(this.minScoreTextBox);
            this.findShapeModelTabPage.Controls.Add(this.matchScaleMaxTextBox);
            this.findShapeModelTabPage.Controls.Add(this.matchScaleMinTextBox);
            this.findShapeModelTabPage.Controls.Add(this.greedinessTextBox);
            this.findShapeModelTabPage.Controls.Add(this.matchAngleExtentTextBox);
            this.findShapeModelTabPage.Controls.Add(this.label20);
            this.findShapeModelTabPage.Controls.Add(this.label15);
            this.findShapeModelTabPage.Controls.Add(this.label14);
            this.findShapeModelTabPage.Controls.Add(this.label16);
            this.findShapeModelTabPage.Controls.Add(this.label17);
            this.findShapeModelTabPage.Controls.Add(this.label23);
            this.findShapeModelTabPage.Controls.Add(this.label18);
            this.findShapeModelTabPage.Controls.Add(this.matchAngleStartTextBox);
            this.findShapeModelTabPage.Controls.Add(this.label19);
            this.findShapeModelTabPage.Location = new System.Drawing.Point(4, 22);
            this.findShapeModelTabPage.Name = "findShapeModelTabPage";
            this.findShapeModelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.findShapeModelTabPage.Size = new System.Drawing.Size(355, 301);
            this.findShapeModelTabPage.TabIndex = 2;
            this.findShapeModelTabPage.Text = "Find Shape Model";
            this.findShapeModelTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "NumLevels:";
            // 
            // inspectNumLevelsComboBox
            // 
            this.inspectNumLevelsComboBox.FormattingEnabled = true;
            this.inspectNumLevelsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.inspectNumLevelsComboBox.Location = new System.Drawing.Point(26, 46);
            this.inspectNumLevelsComboBox.Name = "inspectNumLevelsComboBox";
            this.inspectNumLevelsComboBox.Size = new System.Drawing.Size(121, 20);
            this.inspectNumLevelsComboBox.TabIndex = 1;
            this.inspectNumLevelsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contrast:";
            // 
            // inspectContrastTextBox
            // 
            this.inspectContrastTextBox.Location = new System.Drawing.Point(190, 46);
            this.inspectContrastTextBox.Name = "inspectContrastTextBox";
            this.inspectContrastTextBox.Size = new System.Drawing.Size(121, 21);
            this.inspectContrastTextBox.TabIndex = 3;
            // 
            // inspectShapeModelBtn
            // 
            this.inspectShapeModelBtn.Location = new System.Drawing.Point(96, 105);
            this.inspectShapeModelBtn.Name = "inspectShapeModelBtn";
            this.inspectShapeModelBtn.Size = new System.Drawing.Size(152, 23);
            this.inspectShapeModelBtn.TabIndex = 4;
            this.inspectShapeModelBtn.Text = "Inspect Shape Model";
            this.inspectShapeModelBtn.UseVisualStyleBackColor = true;
            this.inspectShapeModelBtn.Click += new System.EventHandler(this.inspectShapeModelBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "NumLevels:";
            // 
            // numLevelsAutoCheckBox
            // 
            this.numLevelsAutoCheckBox.AutoSize = true;
            this.numLevelsAutoCheckBox.Location = new System.Drawing.Point(87, 7);
            this.numLevelsAutoCheckBox.Name = "numLevelsAutoCheckBox";
            this.numLevelsAutoCheckBox.Size = new System.Drawing.Size(48, 16);
            this.numLevelsAutoCheckBox.TabIndex = 1;
            this.numLevelsAutoCheckBox.Text = "Auto";
            this.numLevelsAutoCheckBox.UseVisualStyleBackColor = true;
            this.numLevelsAutoCheckBox.CheckedChanged += new System.EventHandler(this.numLevelsAutoCheckBox_CheckedChanged);
            // 
            // numLevelsComboBox
            // 
            this.numLevelsComboBox.FormattingEnabled = true;
            this.numLevelsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.numLevelsComboBox.Location = new System.Drawing.Point(9, 23);
            this.numLevelsComboBox.Name = "numLevelsComboBox";
            this.numLevelsComboBox.Size = new System.Drawing.Size(121, 20);
            this.numLevelsComboBox.TabIndex = 2;
            this.numLevelsComboBox.SelectedIndexChanged += new System.EventHandler(this.NumLevelsComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "AngleStart:";
            // 
            // angleStartTextBox
            // 
            this.angleStartTextBox.Location = new System.Drawing.Point(9, 66);
            this.angleStartTextBox.Name = "angleStartTextBox";
            this.angleStartTextBox.Size = new System.Drawing.Size(121, 21);
            this.angleStartTextBox.TabIndex = 4;
            // 
            // angleExtentTextBox
            // 
            this.angleExtentTextBox.Location = new System.Drawing.Point(9, 106);
            this.angleExtentTextBox.Name = "angleExtentTextBox";
            this.angleExtentTextBox.Size = new System.Drawing.Size(121, 21);
            this.angleExtentTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "AngleExtent:";
            // 
            // angleStepAutoCheckBox
            // 
            this.angleStepAutoCheckBox.AutoSize = true;
            this.angleStepAutoCheckBox.Location = new System.Drawing.Point(87, 130);
            this.angleStepAutoCheckBox.Name = "angleStepAutoCheckBox";
            this.angleStepAutoCheckBox.Size = new System.Drawing.Size(48, 16);
            this.angleStepAutoCheckBox.TabIndex = 8;
            this.angleStepAutoCheckBox.Text = "Auto";
            this.angleStepAutoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "AngleStep:";
            // 
            // angleStepTextBox
            // 
            this.angleStepTextBox.Location = new System.Drawing.Point(9, 146);
            this.angleStepTextBox.Name = "angleStepTextBox";
            this.angleStepTextBox.Size = new System.Drawing.Size(121, 21);
            this.angleStepTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "ScaleMin:";
            // 
            // ScaleMinTextBox
            // 
            this.ScaleMinTextBox.Location = new System.Drawing.Point(9, 186);
            this.ScaleMinTextBox.Name = "ScaleMinTextBox";
            this.ScaleMinTextBox.Size = new System.Drawing.Size(121, 21);
            this.ScaleMinTextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "ScaleMax:";
            // 
            // ScaleMaxTextBox
            // 
            this.ScaleMaxTextBox.Location = new System.Drawing.Point(9, 226);
            this.ScaleMaxTextBox.Name = "ScaleMaxTextBox";
            this.ScaleMaxTextBox.Size = new System.Drawing.Size(121, 21);
            this.ScaleMaxTextBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "ScaleStep:";
            // 
            // scaleStepAutoCheCkBox
            // 
            this.scaleStepAutoCheCkBox.AutoSize = true;
            this.scaleStepAutoCheCkBox.Location = new System.Drawing.Point(274, 7);
            this.scaleStepAutoCheCkBox.Name = "scaleStepAutoCheCkBox";
            this.scaleStepAutoCheCkBox.Size = new System.Drawing.Size(48, 16);
            this.scaleStepAutoCheCkBox.TabIndex = 8;
            this.scaleStepAutoCheCkBox.Text = "Auto";
            this.scaleStepAutoCheCkBox.UseVisualStyleBackColor = true;
            // 
            // scaleStepTextBox
            // 
            this.scaleStepTextBox.Location = new System.Drawing.Point(201, 23);
            this.scaleStepTextBox.Name = "scaleStepTextBox";
            this.scaleStepTextBox.Size = new System.Drawing.Size(121, 21);
            this.scaleStepTextBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "Optimization:";
            // 
            // optimizationComboBox
            // 
            this.optimizationComboBox.FormattingEnabled = true;
            this.optimizationComboBox.Items.AddRange(new object[] {
            "auto",
            "none",
            "point_reduction_low",
            "point_reduction_medium",
            "point_reduction_high",
            "pregeneration",
            "no_pregeneration"});
            this.optimizationComboBox.Location = new System.Drawing.Point(201, 66);
            this.optimizationComboBox.Name = "optimizationComboBox";
            this.optimizationComboBox.Size = new System.Drawing.Size(121, 20);
            this.optimizationComboBox.TabIndex = 11;
            this.optimizationComboBox.SelectedIndexChanged += new System.EventHandler(this.optimizationComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "Metric:";
            // 
            // metricComboBox
            // 
            this.metricComboBox.FormattingEnabled = true;
            this.metricComboBox.Items.AddRange(new object[] {
            "use_polarity",
            "ignore_global_polarity",
            "ignore_local_polarity",
            "ignore_color_polarity"});
            this.metricComboBox.Location = new System.Drawing.Point(201, 105);
            this.metricComboBox.Name = "metricComboBox";
            this.metricComboBox.Size = new System.Drawing.Size(121, 20);
            this.metricComboBox.TabIndex = 11;
            this.metricComboBox.SelectedIndexChanged += new System.EventHandler(this.metricComboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(201, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "Contrast:";
            // 
            // ContrastComboBox
            // 
            this.ContrastComboBox.FormattingEnabled = true;
            this.ContrastComboBox.Items.AddRange(new object[] {
            "auto",
            "auto_contrast",
            "auto_contrast_hyst",
            "auto_min_size",
            "user_defined"});
            this.ContrastComboBox.Location = new System.Drawing.Point(201, 149);
            this.ContrastComboBox.Name = "ContrastComboBox";
            this.ContrastComboBox.Size = new System.Drawing.Size(121, 20);
            this.ContrastComboBox.TabIndex = 13;
            this.ContrastComboBox.SelectedIndexChanged += new System.EventHandler(this.ContrastComboBox_SelectedIndexChanged);
            // 
            // ContrastValueTextBox
            // 
            this.ContrastValueTextBox.Location = new System.Drawing.Point(201, 176);
            this.ContrastValueTextBox.Name = "ContrastValueTextBox";
            this.ContrastValueTextBox.Size = new System.Drawing.Size(121, 21);
            this.ContrastValueTextBox.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(201, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "MinContrast:";
            // 
            // minContrastCheckBox
            // 
            this.minContrastCheckBox.AutoSize = true;
            this.minContrastCheckBox.Location = new System.Drawing.Point(274, 213);
            this.minContrastCheckBox.Name = "minContrastCheckBox";
            this.minContrastCheckBox.Size = new System.Drawing.Size(48, 16);
            this.minContrastCheckBox.TabIndex = 8;
            this.minContrastCheckBox.Text = "Auto";
            this.minContrastCheckBox.UseVisualStyleBackColor = true;
            // 
            // minContrastTextBox
            // 
            this.minContrastTextBox.Location = new System.Drawing.Point(201, 229);
            this.minContrastTextBox.Name = "minContrastTextBox";
            this.minContrastTextBox.Size = new System.Drawing.Size(121, 21);
            this.minContrastTextBox.TabIndex = 9;
            // 
            // matchScaleMaxTextBox
            // 
            this.matchScaleMaxTextBox.Location = new System.Drawing.Point(6, 144);
            this.matchScaleMaxTextBox.Name = "matchScaleMaxTextBox";
            this.matchScaleMaxTextBox.Size = new System.Drawing.Size(121, 21);
            this.matchScaleMaxTextBox.TabIndex = 19;
            // 
            // matchScaleMinTextBox
            // 
            this.matchScaleMinTextBox.Location = new System.Drawing.Point(6, 104);
            this.matchScaleMinTextBox.Name = "matchScaleMinTextBox";
            this.matchScaleMinTextBox.Size = new System.Drawing.Size(121, 21);
            this.matchScaleMinTextBox.TabIndex = 20;
            // 
            // matchAngleExtentTextBox
            // 
            this.matchAngleExtentTextBox.Location = new System.Drawing.Point(6, 64);
            this.matchAngleExtentTextBox.Name = "matchAngleExtentTextBox";
            this.matchAngleExtentTextBox.Size = new System.Drawing.Size(121, 21);
            this.matchAngleExtentTextBox.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 15;
            this.label16.Text = "ScaleMax:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 16;
            this.label17.Text = "ScaleMin:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 12);
            this.label18.TabIndex = 17;
            this.label18.Text = "AngleExtent:";
            // 
            // matchAngleStartTextBox
            // 
            this.matchAngleStartTextBox.Location = new System.Drawing.Point(6, 24);
            this.matchAngleStartTextBox.Name = "matchAngleStartTextBox";
            this.matchAngleStartTextBox.Size = new System.Drawing.Size(121, 21);
            this.matchAngleStartTextBox.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 12);
            this.label19.TabIndex = 13;
            this.label19.Text = "AngleStart:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "MinScore:";
            // 
            // minScoreTextBox
            // 
            this.minScoreTextBox.Location = new System.Drawing.Point(6, 184);
            this.minScoreTextBox.Name = "minScoreTextBox";
            this.minScoreTextBox.Size = new System.Drawing.Size(121, 21);
            this.minScoreTextBox.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(218, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 12);
            this.label15.TabIndex = 15;
            this.label15.Text = "NumMatches:";
            // 
            // numMatchesTextBox
            // 
            this.numMatchesTextBox.Location = new System.Drawing.Point(218, 24);
            this.numMatchesTextBox.Name = "numMatchesTextBox";
            this.numMatchesTextBox.Size = new System.Drawing.Size(121, 21);
            this.numMatchesTextBox.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(218, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 12);
            this.label20.TabIndex = 15;
            this.label20.Text = "MaxOverlap:";
            // 
            // maxOverlapTextBox
            // 
            this.maxOverlapTextBox.Location = new System.Drawing.Point(218, 64);
            this.maxOverlapTextBox.Name = "maxOverlapTextBox";
            this.maxOverlapTextBox.Size = new System.Drawing.Size(121, 21);
            this.maxOverlapTextBox.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(218, 89);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 21;
            this.label21.Text = "SubPixel:";
            // 
            // subPixelComboBox
            // 
            this.subPixelComboBox.FormattingEnabled = true;
            this.subPixelComboBox.Items.AddRange(new object[] {
            " none",
            "interpolation",
            "least_squares",
            "least_squares_high",
            "least_squares_very_high",
            "max_deformation 1",
            "max_deformation 2",
            "max_deformation 3",
            "max_deformation 4",
            "max_deformation 5",
            "max_deformation 6"});
            this.subPixelComboBox.Location = new System.Drawing.Point(218, 105);
            this.subPixelComboBox.Name = "subPixelComboBox";
            this.subPixelComboBox.Size = new System.Drawing.Size(121, 20);
            this.subPixelComboBox.TabIndex = 22;
            this.subPixelComboBox.SelectedIndexChanged += new System.EventHandler(this.subPixelComboBox_SelectedIndexChanged);
            // 
            // matchNumLevelsComboBox
            // 
            this.matchNumLevelsComboBox.FormattingEnabled = true;
            this.matchNumLevelsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.matchNumLevelsComboBox.Location = new System.Drawing.Point(218, 145);
            this.matchNumLevelsComboBox.Name = "matchNumLevelsComboBox";
            this.matchNumLevelsComboBox.Size = new System.Drawing.Size(121, 20);
            this.matchNumLevelsComboBox.TabIndex = 25;
            this.matchNumLevelsComboBox.SelectedIndexChanged += new System.EventHandler(this.matchNumLevelsComboBox_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(218, 129);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 23;
            this.label22.Text = "NumLevels:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(218, 169);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 12);
            this.label23.TabIndex = 17;
            this.label23.Text = "Greediness:";
            // 
            // greedinessTextBox
            // 
            this.greedinessTextBox.Location = new System.Drawing.Point(218, 185);
            this.greedinessTextBox.Name = "greedinessTextBox";
            this.greedinessTextBox.Size = new System.Drawing.Size(121, 21);
            this.greedinessTextBox.TabIndex = 18;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(284, 333);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "OK";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // TestCreateShapeModelBtn
            // 
            this.TestCreateShapeModelBtn.Location = new System.Drawing.Point(69, 266);
            this.TestCreateShapeModelBtn.Name = "TestCreateShapeModelBtn";
            this.TestCreateShapeModelBtn.Size = new System.Drawing.Size(179, 23);
            this.TestCreateShapeModelBtn.TabIndex = 15;
            this.TestCreateShapeModelBtn.Text = "Test Create Shape Model";
            this.TestCreateShapeModelBtn.UseVisualStyleBackColor = true;
            this.TestCreateShapeModelBtn.Click += new System.EventHandler(this.TestCreateShapeModelBtn_Click);
            // 
            // testFindShapeModelBtn
            // 
            this.testFindShapeModelBtn.Location = new System.Drawing.Point(103, 227);
            this.testFindShapeModelBtn.Name = "testFindShapeModelBtn";
            this.testFindShapeModelBtn.Size = new System.Drawing.Size(133, 23);
            this.testFindShapeModelBtn.TabIndex = 26;
            this.testFindShapeModelBtn.Text = "Test Find Shape Model";
            this.testFindShapeModelBtn.UseVisualStyleBackColor = true;
            this.testFindShapeModelBtn.Click += new System.EventHandler(this.testFindShapeModelBtn_Click);
            // 
            // ShapeModelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 366);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.tabControl);
            this.Name = "ShapeModelDialog";
            this.Text = "形状检测参数设定";
            this.tabControl.ResumeLayout(false);
            this.inspectShapeModelTabPage.ResumeLayout(false);
            this.inspectShapeModelTabPage.PerformLayout();
            this.createShapeModelTabPage.ResumeLayout(false);
            this.createShapeModelTabPage.PerformLayout();
            this.findShapeModelTabPage.ResumeLayout(false);
            this.findShapeModelTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage inspectShapeModelTabPage;
        private System.Windows.Forms.TabPage createShapeModelTabPage;
        private System.Windows.Forms.TabPage findShapeModelTabPage;
        private System.Windows.Forms.ComboBox inspectNumLevelsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button inspectShapeModelBtn;
        private System.Windows.Forms.TextBox inspectContrastTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox numLevelsAutoCheckBox;
        private System.Windows.Forms.ComboBox numLevelsComboBox;
        private System.Windows.Forms.TextBox angleStartTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox angleExtentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox angleStepTextBox;
        private System.Windows.Forms.CheckBox angleStepAutoCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ScaleMaxTextBox;
        private System.Windows.Forms.TextBox ScaleMinTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox scaleStepTextBox;
        private System.Windows.Forms.CheckBox scaleStepAutoCheCkBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox optimizationComboBox;
        private System.Windows.Forms.ComboBox metricComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ContrastComboBox;
        private System.Windows.Forms.TextBox ContrastValueTextBox;
        private System.Windows.Forms.TextBox minContrastTextBox;
        private System.Windows.Forms.CheckBox minContrastCheckBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox matchScaleMaxTextBox;
        private System.Windows.Forms.TextBox matchScaleMinTextBox;
        private System.Windows.Forms.TextBox matchAngleExtentTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox matchAngleStartTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox minScoreTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox numMatchesTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox maxOverlapTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox subPixelComboBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox matchNumLevelsComboBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox greedinessTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button TestCreateShapeModelBtn;
        private System.Windows.Forms.Button testFindShapeModelBtn;
    }
}