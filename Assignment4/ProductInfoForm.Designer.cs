namespace Assignment4
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IdLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.OsLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.LcdLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.CpuNumberLabel = new System.Windows.Forms.Label();
            this.GpuLabel = new System.Windows.Forms.Label();
            this.CpuTypeLabel = new System.Windows.Forms.Label();
            this.CpuSpeedLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.CpuSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.GpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.CpuNumberTextBox = new System.Windows.Forms.TextBox();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.HddTextBox = new System.Windows.Forms.TextBox();
            this.LcdTextBox = new System.Windows.Forms.TextBox();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.SelectAnotherButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(26, 45);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(58, 13);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "Product ID";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(222, 45);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(51, 13);
            this.ConditionLabel.TabIndex = 2;
            this.ConditionLabel.Text = "Condition";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(419, 45);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(28, 13);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(5, 26);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(45, 13);
            this.PlatformLabel.TabIndex = 4;
            this.PlatformLabel.Text = "Platform";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(5, 54);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(70, 13);
            this.ManufacturerLabel.TabIndex = 5;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // OsLabel
            // 
            this.OsLabel.AutoSize = true;
            this.OsLabel.Location = new System.Drawing.Point(199, 27);
            this.OsLabel.Name = "OsLabel";
            this.OsLabel.Size = new System.Drawing.Size(22, 13);
            this.OsLabel.TabIndex = 6;
            this.OsLabel.Text = "OS";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(199, 55);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 7;
            this.ModelLabel.Text = "Model";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(20, 21);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(44, 13);
            this.MemoryLabel.TabIndex = 8;
            this.MemoryLabel.Text = "Memory";
            // 
            // LcdLabel
            // 
            this.LcdLabel.AutoSize = true;
            this.LcdLabel.Location = new System.Drawing.Point(197, 21);
            this.LcdLabel.Name = "LcdLabel";
            this.LcdLabel.Size = new System.Drawing.Size(51, 13);
            this.LcdLabel.TabIndex = 9;
            this.LcdLabel.Text = "LCD Size";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(384, 21);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(31, 13);
            this.HDDLabel.TabIndex = 10;
            this.HDDLabel.Text = "HDD";
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Location = new System.Drawing.Point(20, 60);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(60, 13);
            this.BrandLabel.TabIndex = 11;
            this.BrandLabel.Text = "CPU Brand";
            // 
            // CpuNumberLabel
            // 
            this.CpuNumberLabel.AutoSize = true;
            this.CpuNumberLabel.Location = new System.Drawing.Point(197, 60);
            this.CpuNumberLabel.Name = "CpuNumberLabel";
            this.CpuNumberLabel.Size = new System.Drawing.Size(69, 13);
            this.CpuNumberLabel.TabIndex = 12;
            this.CpuNumberLabel.Text = "CPU Number";
            // 
            // GpuLabel
            // 
            this.GpuLabel.AutoSize = true;
            this.GpuLabel.Location = new System.Drawing.Point(384, 60);
            this.GpuLabel.Name = "GpuLabel";
            this.GpuLabel.Size = new System.Drawing.Size(57, 13);
            this.GpuLabel.TabIndex = 13;
            this.GpuLabel.Text = "GPU Type";
            // 
            // CpuTypeLabel
            // 
            this.CpuTypeLabel.AutoSize = true;
            this.CpuTypeLabel.Location = new System.Drawing.Point(20, 102);
            this.CpuTypeLabel.Name = "CpuTypeLabel";
            this.CpuTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.CpuTypeLabel.TabIndex = 14;
            this.CpuTypeLabel.Text = "CPU Type";
            // 
            // CpuSpeedLabel
            // 
            this.CpuSpeedLabel.AutoSize = true;
            this.CpuSpeedLabel.Location = new System.Drawing.Point(197, 102);
            this.CpuSpeedLabel.Name = "CpuSpeedLabel";
            this.CpuSpeedLabel.Size = new System.Drawing.Size(63, 13);
            this.CpuSpeedLabel.TabIndex = 15;
            this.CpuSpeedLabel.Text = "CPU Speed";
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(384, 102);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(51, 13);
            this.WebCamLabel.TabIndex = 16;
            this.WebCamLabel.Text = "WebCam";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OsLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(29, 96);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(505, 100);
            this.ProductInfoGroupBox.TabIndex = 17;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(244, 54);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(233, 20);
            this.ModelTextBox.TabIndex = 25;
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(244, 23);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.ReadOnly = true;
            this.OSTextBox.Size = new System.Drawing.Size(233, 20);
            this.OSTextBox.TabIndex = 24;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(78, 52);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ManufacturerTextBox.TabIndex = 23;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(78, 20);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlatformTextBox.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WebCamTextBox);
            this.groupBox2.Controls.Add(this.CpuSpeedTextBox);
            this.groupBox2.Controls.Add(this.CpuTypeTextBox);
            this.groupBox2.Controls.Add(this.GpuTypeTextBox);
            this.groupBox2.Controls.Add(this.CpuNumberTextBox);
            this.groupBox2.Controls.Add(this.BrandTextBox);
            this.groupBox2.Controls.Add(this.HddTextBox);
            this.groupBox2.Controls.Add(this.LcdTextBox);
            this.groupBox2.Controls.Add(this.MemoryTextBox);
            this.groupBox2.Controls.Add(this.CpuTypeLabel);
            this.groupBox2.Controls.Add(this.MemoryLabel);
            this.groupBox2.Controls.Add(this.WebCamLabel);
            this.groupBox2.Controls.Add(this.LcdLabel);
            this.groupBox2.Controls.Add(this.CpuSpeedLabel);
            this.groupBox2.Controls.Add(this.HDDLabel);
            this.groupBox2.Controls.Add(this.BrandLabel);
            this.groupBox2.Controls.Add(this.GpuLabel);
            this.groupBox2.Controls.Add(this.CpuNumberLabel);
            this.groupBox2.Location = new System.Drawing.Point(29, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 123);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.Location = new System.Drawing.Point(447, 95);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.ReadOnly = true;
            this.WebCamTextBox.Size = new System.Drawing.Size(100, 20);
            this.WebCamTextBox.TabIndex = 34;
            // 
            // CpuSpeedTextBox
            // 
            this.CpuSpeedTextBox.Location = new System.Drawing.Point(266, 95);
            this.CpuSpeedTextBox.Name = "CpuSpeedTextBox";
            this.CpuSpeedTextBox.ReadOnly = true;
            this.CpuSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CpuSpeedTextBox.TabIndex = 33;
            // 
            // CpuTypeTextBox
            // 
            this.CpuTypeTextBox.Location = new System.Drawing.Point(82, 95);
            this.CpuTypeTextBox.Name = "CpuTypeTextBox";
            this.CpuTypeTextBox.ReadOnly = true;
            this.CpuTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.CpuTypeTextBox.TabIndex = 32;
            // 
            // GpuTypeTextBox
            // 
            this.GpuTypeTextBox.Location = new System.Drawing.Point(447, 57);
            this.GpuTypeTextBox.Name = "GpuTypeTextBox";
            this.GpuTypeTextBox.ReadOnly = true;
            this.GpuTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.GpuTypeTextBox.TabIndex = 31;
            // 
            // CpuNumberTextBox
            // 
            this.CpuNumberTextBox.Location = new System.Drawing.Point(266, 53);
            this.CpuNumberTextBox.Name = "CpuNumberTextBox";
            this.CpuNumberTextBox.ReadOnly = true;
            this.CpuNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.CpuNumberTextBox.TabIndex = 30;
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.Location = new System.Drawing.Point(82, 60);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.ReadOnly = true;
            this.BrandTextBox.Size = new System.Drawing.Size(100, 20);
            this.BrandTextBox.TabIndex = 29;
            // 
            // HddTextBox
            // 
            this.HddTextBox.Location = new System.Drawing.Point(447, 18);
            this.HddTextBox.Name = "HddTextBox";
            this.HddTextBox.ReadOnly = true;
            this.HddTextBox.Size = new System.Drawing.Size(100, 20);
            this.HddTextBox.TabIndex = 28;
            // 
            // LcdTextBox
            // 
            this.LcdTextBox.Location = new System.Drawing.Point(266, 18);
            this.LcdTextBox.Name = "LcdTextBox";
            this.LcdTextBox.ReadOnly = true;
            this.LcdTextBox.Size = new System.Drawing.Size(100, 20);
            this.LcdTextBox.TabIndex = 27;
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Location = new System.Drawing.Point(82, 19);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.ReadOnly = true;
            this.MemoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.MemoryTextBox.TabIndex = 26;
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Location = new System.Drawing.Point(88, 41);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.ReadOnly = true;
            this.ProductTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductTextBox.TabIndex = 19;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(275, 41);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConditionTextBox.TabIndex = 20;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(456, 41);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 21;
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Location = new System.Drawing.Point(29, 383);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(181, 13);
            this.ConfirmLabel.TabIndex = 22;
            this.ConfirmLabel.Text = "Click Next To Confirm Your Selection";
            // 
            // SelectAnotherButton
            // 
            this.SelectAnotherButton.Location = new System.Drawing.Point(300, 378);
            this.SelectAnotherButton.Name = "SelectAnotherButton";
            this.SelectAnotherButton.Size = new System.Drawing.Size(137, 23);
            this.SelectAnotherButton.TabIndex = 23;
            this.SelectAnotherButton.Text = "Select Another Product";
            this.SelectAnotherButton.UseVisualStyleBackColor = true;
            this.SelectAnotherButton.Click += new System.EventHandler(this.SelectAnotherButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(443, 378);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(524, 378);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 25;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem1.Text = "Select Another Product";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 410);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectAnotherButton);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.ProductTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label OsLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label LcdLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label CpuNumberLabel;
        private System.Windows.Forms.Label GpuLabel;
        private System.Windows.Forms.Label CpuTypeLabel;
        private System.Windows.Forms.Label CpuSpeedLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.TextBox CpuSpeedTextBox;
        private System.Windows.Forms.TextBox CpuTypeTextBox;
        private System.Windows.Forms.TextBox GpuTypeTextBox;
        private System.Windows.Forms.TextBox CpuNumberTextBox;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.TextBox HddTextBox;
        private System.Windows.Forms.TextBox LcdTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Button SelectAnotherButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}