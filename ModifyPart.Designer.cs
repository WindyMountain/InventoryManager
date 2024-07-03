namespace C968InventoryManagementSystem_Monahan
{
    partial class ModifyPart
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
            modifyPartDynamicLabel = new Label();
            modifyPartDynamicBox = new TextBox();
            modifyPartInhouseRad = new RadioButton();
            modifyPartOutsourcedRad = new RadioButton();
            modifyPartCancelBtn = new Button();
            modifyPartSaveBtn = new Button();
            modifyPartLabel = new Label();
            modifyPartMinLabel = new Label();
            modifyPartMaxLabel = new Label();
            modifyPartPriceCostLabel = new Label();
            modifyPartInventoryLabel = new Label();
            modifyPartNameLabel = new Label();
            modifyPartIDLabel = new Label();
            modifyPartMinBox = new TextBox();
            modifyPartMaxBox = new TextBox();
            modifyPartPriceCostBox = new TextBox();
            modifyPartInventoryBox = new TextBox();
            modifyPartNameBox = new TextBox();
            modifyPartIDBox = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // modifyPartDynamicLabel
            // 
            modifyPartDynamicLabel.AutoSize = true;
            modifyPartDynamicLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyPartDynamicLabel.ForeColor = SystemColors.ControlLightLight;
            modifyPartDynamicLabel.Location = new Point(15, 351);
            modifyPartDynamicLabel.Name = "modifyPartDynamicLabel";
            modifyPartDynamicLabel.Size = new Size(126, 21);
            modifyPartDynamicLabel.TabIndex = 70;
            modifyPartDynamicLabel.Text = "Company Name";
            // 
            // modifyPartDynamicBox
            // 
            modifyPartDynamicBox.Location = new Point(168, 347);
            modifyPartDynamicBox.Name = "modifyPartDynamicBox";
            modifyPartDynamicBox.Size = new Size(162, 23);
            modifyPartDynamicBox.TabIndex = 69;
            // 
            // modifyPartInhouseRad
            // 
            modifyPartInhouseRad.AutoSize = true;
            modifyPartInhouseRad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyPartInhouseRad.ForeColor = SystemColors.ControlLightLight;
            modifyPartInhouseRad.Location = new Point(6, 22);
            modifyPartInhouseRad.Name = "modifyPartInhouseRad";
            modifyPartInhouseRad.Size = new Size(95, 25);
            modifyPartInhouseRad.TabIndex = 68;
            modifyPartInhouseRad.Text = "In-House";
            modifyPartInhouseRad.UseVisualStyleBackColor = true;
            modifyPartInhouseRad.CheckedChanged += ModifyPartInhouseRad_CheckedChanged;
            // 
            // modifyPartOutsourcedRad
            // 
            modifyPartOutsourcedRad.AutoSize = true;
            modifyPartOutsourcedRad.Checked = true;
            modifyPartOutsourcedRad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyPartOutsourcedRad.ForeColor = SystemColors.ControlLightLight;
            modifyPartOutsourcedRad.Location = new Point(107, 22);
            modifyPartOutsourcedRad.Name = "modifyPartOutsourcedRad";
            modifyPartOutsourcedRad.Size = new Size(114, 25);
            modifyPartOutsourcedRad.TabIndex = 67;
            modifyPartOutsourcedRad.TabStop = true;
            modifyPartOutsourcedRad.Text = "Outsourced";
            modifyPartOutsourcedRad.UseVisualStyleBackColor = true;
            modifyPartOutsourcedRad.CheckedChanged += ModifyPartOutsourcedRad_CheckedChanged;
            // 
            // modifyPartCancelBtn
            // 
            modifyPartCancelBtn.BackColor = SystemColors.ControlDark;
            modifyPartCancelBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyPartCancelBtn.ForeColor = SystemColors.ControlLightLight;
            modifyPartCancelBtn.Location = new Point(347, 400);
            modifyPartCancelBtn.Name = "modifyPartCancelBtn";
            modifyPartCancelBtn.Size = new Size(95, 44);
            modifyPartCancelBtn.TabIndex = 66;
            modifyPartCancelBtn.Text = "Cancel";
            modifyPartCancelBtn.UseVisualStyleBackColor = false;
            modifyPartCancelBtn.Click += ModifyPartCancelBtn_Click;
            // 
            // modifyPartSaveBtn
            // 
            modifyPartSaveBtn.BackColor = SystemColors.ControlDark;
            modifyPartSaveBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyPartSaveBtn.ForeColor = SystemColors.ControlLightLight;
            modifyPartSaveBtn.Location = new Point(221, 400);
            modifyPartSaveBtn.Name = "modifyPartSaveBtn";
            modifyPartSaveBtn.Size = new Size(95, 44);
            modifyPartSaveBtn.TabIndex = 65;
            modifyPartSaveBtn.Text = "Save";
            modifyPartSaveBtn.UseVisualStyleBackColor = false;
            modifyPartSaveBtn.Click += modifyPartSaveBtn_Click;
            // 
            // modifyPartLabel
            // 
            modifyPartLabel.AutoSize = true;
            modifyPartLabel.BorderStyle = BorderStyle.Fixed3D;
            modifyPartLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            modifyPartLabel.ForeColor = SystemColors.ControlLightLight;
            modifyPartLabel.Location = new Point(11, 10);
            modifyPartLabel.Name = "modifyPartLabel";
            modifyPartLabel.Size = new Size(142, 34);
            modifyPartLabel.TabIndex = 64;
            modifyPartLabel.Text = "Modify Part";
            // 
            // modifyPartMinLabel
            // 
            modifyPartMinLabel.AutoSize = true;
            modifyPartMinLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyPartMinLabel.ForeColor = SystemColors.ControlLightLight;
            modifyPartMinLabel.Location = new Point(291, 294);
            modifyPartMinLabel.Name = "modifyPartMinLabel";
            modifyPartMinLabel.Size = new Size(38, 21);
            modifyPartMinLabel.TabIndex = 63;
            modifyPartMinLabel.Text = "Min";
            // 
            // modifyPartMaxLabel
            // 
            modifyPartMaxLabel.AutoSize = true;
            modifyPartMaxLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyPartMaxLabel.ForeColor = SystemColors.ControlLightLight;
            modifyPartMaxLabel.Location = new Point(103, 294);
            modifyPartMaxLabel.Name = "modifyPartMaxLabel";
            modifyPartMaxLabel.Size = new Size(41, 21);
            modifyPartMaxLabel.TabIndex = 62;
            modifyPartMaxLabel.Text = "Max";
            // 
            // modifyPartPriceCostLabel
            // 
            modifyPartPriceCostLabel.AutoSize = true;
            modifyPartPriceCostLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyPartPriceCostLabel.ForeColor = SystemColors.ControlLightLight;
            modifyPartPriceCostLabel.Location = new Point(65, 242);
            modifyPartPriceCostLabel.Name = "modifyPartPriceCostLabel";
            modifyPartPriceCostLabel.Size = new Size(94, 21);
            modifyPartPriceCostLabel.TabIndex = 61;
            modifyPartPriceCostLabel.Text = "Price / Cost";
            // 
            // modifyPartInventoryLabel
            // 
            modifyPartInventoryLabel.AutoSize = true;
            modifyPartInventoryLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyPartInventoryLabel.ForeColor = SystemColors.ControlLightLight;
            modifyPartInventoryLabel.Location = new Point(76, 194);
            modifyPartInventoryLabel.Name = "modifyPartInventoryLabel";
            modifyPartInventoryLabel.Size = new Size(81, 21);
            modifyPartInventoryLabel.TabIndex = 60;
            modifyPartInventoryLabel.Text = "Inventory";
            // 
            // modifyPartNameLabel
            // 
            modifyPartNameLabel.AutoSize = true;
            modifyPartNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyPartNameLabel.ForeColor = SystemColors.ControlLightLight;
            modifyPartNameLabel.Location = new Point(94, 144);
            modifyPartNameLabel.Name = "modifyPartNameLabel";
            modifyPartNameLabel.Size = new Size(53, 21);
            modifyPartNameLabel.TabIndex = 59;
            modifyPartNameLabel.Text = "Name";
            // 
            // modifyPartIDLabel
            // 
            modifyPartIDLabel.AutoSize = true;
            modifyPartIDLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyPartIDLabel.ForeColor = SystemColors.ControlLightLight;
            modifyPartIDLabel.Location = new Point(115, 95);
            modifyPartIDLabel.Name = "modifyPartIDLabel";
            modifyPartIDLabel.Size = new Size(26, 21);
            modifyPartIDLabel.TabIndex = 58;
            modifyPartIDLabel.Text = "ID";
            // 
            // modifyPartMinBox
            // 
            modifyPartMinBox.Location = new Point(347, 294);
            modifyPartMinBox.Name = "modifyPartMinBox";
            modifyPartMinBox.Size = new Size(88, 23);
            modifyPartMinBox.TabIndex = 57;
            // 
            // modifyPartMaxBox
            // 
            modifyPartMaxBox.Location = new Point(168, 294);
            modifyPartMaxBox.Name = "modifyPartMaxBox";
            modifyPartMaxBox.Size = new Size(88, 23);
            modifyPartMaxBox.TabIndex = 56;
            // 
            // modifyPartPriceCostBox
            // 
            modifyPartPriceCostBox.Location = new Point(168, 242);
            modifyPartPriceCostBox.Name = "modifyPartPriceCostBox";
            modifyPartPriceCostBox.Size = new Size(162, 23);
            modifyPartPriceCostBox.TabIndex = 55;
            // 
            // modifyPartInventoryBox
            // 
            modifyPartInventoryBox.Location = new Point(168, 194);
            modifyPartInventoryBox.Name = "modifyPartInventoryBox";
            modifyPartInventoryBox.Size = new Size(162, 23);
            modifyPartInventoryBox.TabIndex = 54;
            // 
            // modifyPartNameBox
            // 
            modifyPartNameBox.Location = new Point(168, 144);
            modifyPartNameBox.Name = "modifyPartNameBox";
            modifyPartNameBox.Size = new Size(162, 23);
            modifyPartNameBox.TabIndex = 53;
            // 
            // modifyPartIDBox
            // 
            modifyPartIDBox.BackColor = SystemColors.ActiveBorder;
            modifyPartIDBox.Location = new Point(168, 97);
            modifyPartIDBox.Name = "modifyPartIDBox";
            modifyPartIDBox.ReadOnly = true;
            modifyPartIDBox.Size = new Size(162, 23);
            modifyPartIDBox.TabIndex = 52;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(modifyPartOutsourcedRad);
            groupBox1.Controls.Add(modifyPartInhouseRad);
            groupBox1.Location = new Point(168, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 59);
            groupBox1.TabIndex = 71;
            groupBox1.TabStop = false;
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(466, 467);
            Controls.Add(groupBox1);
            Controls.Add(modifyPartDynamicLabel);
            Controls.Add(modifyPartDynamicBox);
            Controls.Add(modifyPartCancelBtn);
            Controls.Add(modifyPartSaveBtn);
            Controls.Add(modifyPartLabel);
            Controls.Add(modifyPartMinLabel);
            Controls.Add(modifyPartMaxLabel);
            Controls.Add(modifyPartPriceCostLabel);
            Controls.Add(modifyPartInventoryLabel);
            Controls.Add(modifyPartNameLabel);
            Controls.Add(modifyPartIDLabel);
            Controls.Add(modifyPartMinBox);
            Controls.Add(modifyPartMaxBox);
            Controls.Add(modifyPartPriceCostBox);
            Controls.Add(modifyPartInventoryBox);
            Controls.Add(modifyPartNameBox);
            Controls.Add(modifyPartIDBox);
            Name = "ModifyPart";
            Text = "Part";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label modifyPartDynamicLabel;
        private TextBox modifyPartDynamicBox;
        private RadioButton modifyPartInhouseRad;
        private RadioButton modifyPartOutsourcedRad;
        private Button modifyPartCancelBtn;
        private Button modifyPartSaveBtn;
        private Label modifyPartLabel;
        private Label modifyPartMinLabel;
        private Label modifyPartMaxLabel;
        private Label modifyPartPriceCostLabel;
        private Label modifyPartInventoryLabel;
        private Label modifyPartNameLabel;
        private Label modifyPartIDLabel;
        private TextBox modifyPartMinBox;
        private TextBox modifyPartMaxBox;
        private TextBox modifyPartPriceCostBox;
        private TextBox modifyPartInventoryBox;
        private TextBox modifyPartNameBox;
        private TextBox modifyPartIDBox;
        private GroupBox groupBox1;
    }
}