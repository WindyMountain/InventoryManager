namespace C968InventoryManagementSystem_Monahan
{
    partial class ModifyProduct
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
            modifyProductLabel = new Label();
            modifyProductSearchBox = new TextBox();
            modifyProductSearchBtn = new Button();
            modifyProductMinLabel = new Label();
            modifyProductMaxLabel = new Label();
            modifyProductPriceCostLabel = new Label();
            modifyProductInventoryLabel = new Label();
            modifyProductNameLabel = new Label();
            modifyProductIDLabel = new Label();
            modifyProductMinBox = new TextBox();
            modifyProductMaxBox = new TextBox();
            modifyProductPriceCostBox = new TextBox();
            modifyProductInventoryBox = new TextBox();
            modifyProductNameBox = new TextBox();
            modifyProductIDBox = new TextBox();
            modifyProductAddBtn = new Button();
            modifyProductDeleteBtn = new Button();
            modifyProductCancelBtn = new Button();
            modifyProductSaveBtn = new Button();
            modifyProductAssociatedView = new DataGridView();
            modifyProductCandidateView = new DataGridView();
            modifyProductCandidateLabel = new Label();
            modifyProductAssociatedLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)modifyProductAssociatedView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modifyProductCandidateView).BeginInit();
            SuspendLayout();
            // 
            // modifyProductLabel
            // 
            modifyProductLabel.AutoSize = true;
            modifyProductLabel.BorderStyle = BorderStyle.Fixed3D;
            modifyProductLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            modifyProductLabel.ForeColor = SystemColors.ControlLightLight;
            modifyProductLabel.Location = new Point(32, 25);
            modifyProductLabel.Name = "modifyProductLabel";
            modifyProductLabel.Size = new Size(180, 34);
            modifyProductLabel.TabIndex = 51;
            modifyProductLabel.Text = "Modify Product";
            // 
            // modifyProductSearchBox
            // 
            modifyProductSearchBox.Location = new Point(706, 58);
            modifyProductSearchBox.Name = "modifyProductSearchBox";
            modifyProductSearchBox.Size = new Size(225, 23);
            modifyProductSearchBox.TabIndex = 50;
            // 
            // modifyProductSearchBtn
            // 
            modifyProductSearchBtn.BackColor = SystemColors.ControlDark;
            modifyProductSearchBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyProductSearchBtn.ForeColor = SystemColors.ControlLightLight;
            modifyProductSearchBtn.Location = new Point(606, 58);
            modifyProductSearchBtn.Name = "modifyProductSearchBtn";
            modifyProductSearchBtn.Size = new Size(82, 32);
            modifyProductSearchBtn.TabIndex = 49;
            modifyProductSearchBtn.Text = "Search";
            modifyProductSearchBtn.UseVisualStyleBackColor = false;
            modifyProductSearchBtn.Click += ModifyProductSearchBtn_Click;
            // 
            // modifyProductMinLabel
            // 
            modifyProductMinLabel.AutoSize = true;
            modifyProductMinLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyProductMinLabel.ForeColor = SystemColors.ControlLightLight;
            modifyProductMinLabel.Location = new Point(247, 427);
            modifyProductMinLabel.Name = "modifyProductMinLabel";
            modifyProductMinLabel.Size = new Size(38, 21);
            modifyProductMinLabel.TabIndex = 48;
            modifyProductMinLabel.Text = "Min";
            // 
            // modifyProductMaxLabel
            // 
            modifyProductMaxLabel.AutoSize = true;
            modifyProductMaxLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyProductMaxLabel.ForeColor = SystemColors.ControlLightLight;
            modifyProductMaxLabel.Location = new Point(59, 427);
            modifyProductMaxLabel.Name = "modifyProductMaxLabel";
            modifyProductMaxLabel.Size = new Size(41, 21);
            modifyProductMaxLabel.TabIndex = 47;
            modifyProductMaxLabel.Text = "Max";
            // 
            // modifyProductPriceCostLabel
            // 
            modifyProductPriceCostLabel.AutoSize = true;
            modifyProductPriceCostLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyProductPriceCostLabel.ForeColor = SystemColors.ControlLightLight;
            modifyProductPriceCostLabel.Location = new Point(21, 375);
            modifyProductPriceCostLabel.Name = "modifyProductPriceCostLabel";
            modifyProductPriceCostLabel.Size = new Size(94, 21);
            modifyProductPriceCostLabel.TabIndex = 46;
            modifyProductPriceCostLabel.Text = "Price / Cost";
            // 
            // modifyProductInventoryLabel
            // 
            modifyProductInventoryLabel.AutoSize = true;
            modifyProductInventoryLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyProductInventoryLabel.ForeColor = SystemColors.ControlLightLight;
            modifyProductInventoryLabel.Location = new Point(32, 327);
            modifyProductInventoryLabel.Name = "modifyProductInventoryLabel";
            modifyProductInventoryLabel.Size = new Size(81, 21);
            modifyProductInventoryLabel.TabIndex = 45;
            modifyProductInventoryLabel.Text = "Inventory";
            // 
            // modifyProductNameLabel
            // 
            modifyProductNameLabel.AutoSize = true;
            modifyProductNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyProductNameLabel.ForeColor = SystemColors.ControlLightLight;
            modifyProductNameLabel.Location = new Point(50, 277);
            modifyProductNameLabel.Name = "modifyProductNameLabel";
            modifyProductNameLabel.Size = new Size(53, 21);
            modifyProductNameLabel.TabIndex = 44;
            modifyProductNameLabel.Text = "Name";
            // 
            // modifyProductIDLabel
            // 
            modifyProductIDLabel.AutoSize = true;
            modifyProductIDLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyProductIDLabel.ForeColor = SystemColors.ControlLightLight;
            modifyProductIDLabel.Location = new Point(71, 228);
            modifyProductIDLabel.Name = "modifyProductIDLabel";
            modifyProductIDLabel.Size = new Size(26, 21);
            modifyProductIDLabel.TabIndex = 43;
            modifyProductIDLabel.Text = "ID";
            // 
            // modifyProductMinBox
            // 
            modifyProductMinBox.Location = new Point(292, 429);
            modifyProductMinBox.Name = "modifyProductMinBox";
            modifyProductMinBox.Size = new Size(88, 23);
            modifyProductMinBox.TabIndex = 42;
            // 
            // modifyProductMaxBox
            // 
            modifyProductMaxBox.Location = new Point(113, 429);
            modifyProductMaxBox.Name = "modifyProductMaxBox";
            modifyProductMaxBox.Size = new Size(88, 23);
            modifyProductMaxBox.TabIndex = 41;
            // 
            // modifyProductPriceCostBox
            // 
            modifyProductPriceCostBox.Location = new Point(113, 377);
            modifyProductPriceCostBox.Name = "modifyProductPriceCostBox";
            modifyProductPriceCostBox.Size = new Size(162, 23);
            modifyProductPriceCostBox.TabIndex = 40;
            // 
            // modifyProductInventoryBox
            // 
            modifyProductInventoryBox.Location = new Point(113, 329);
            modifyProductInventoryBox.Name = "modifyProductInventoryBox";
            modifyProductInventoryBox.Size = new Size(162, 23);
            modifyProductInventoryBox.TabIndex = 39;
            // 
            // modifyProductNameBox
            // 
            modifyProductNameBox.Location = new Point(113, 279);
            modifyProductNameBox.Name = "modifyProductNameBox";
            modifyProductNameBox.Size = new Size(162, 23);
            modifyProductNameBox.TabIndex = 38;
            // 
            // modifyProductIDBox
            // 
            modifyProductIDBox.BackColor = SystemColors.ActiveBorder;
            modifyProductIDBox.Location = new Point(113, 230);
            modifyProductIDBox.Name = "modifyProductIDBox";
            modifyProductIDBox.ReadOnly = true;
            modifyProductIDBox.Size = new Size(162, 23);
            modifyProductIDBox.TabIndex = 37;
            // 
            // modifyProductAddBtn
            // 
            modifyProductAddBtn.BackColor = SystemColors.ControlDark;
            modifyProductAddBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyProductAddBtn.ForeColor = SystemColors.ControlLightLight;
            modifyProductAddBtn.Location = new Point(788, 313);
            modifyProductAddBtn.Name = "modifyProductAddBtn";
            modifyProductAddBtn.Size = new Size(95, 44);
            modifyProductAddBtn.TabIndex = 36;
            modifyProductAddBtn.Text = "Add";
            modifyProductAddBtn.UseVisualStyleBackColor = false;
            modifyProductAddBtn.Click += ModifyProductAddBtn_Click;
            // 
            // modifyProductDeleteBtn
            // 
            modifyProductDeleteBtn.BackColor = SystemColors.ControlDark;
            modifyProductDeleteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyProductDeleteBtn.ForeColor = SystemColors.ControlLightLight;
            modifyProductDeleteBtn.Location = new Point(788, 616);
            modifyProductDeleteBtn.Name = "modifyProductDeleteBtn";
            modifyProductDeleteBtn.Size = new Size(95, 44);
            modifyProductDeleteBtn.TabIndex = 35;
            modifyProductDeleteBtn.Text = "Delete";
            modifyProductDeleteBtn.UseVisualStyleBackColor = false;
            modifyProductDeleteBtn.Click += ModifyProductDeleteBtn_Click;
            // 
            // modifyProductCancelBtn
            // 
            modifyProductCancelBtn.BackColor = SystemColors.ControlDark;
            modifyProductCancelBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyProductCancelBtn.ForeColor = SystemColors.ControlLightLight;
            modifyProductCancelBtn.Location = new Point(788, 678);
            modifyProductCancelBtn.Name = "modifyProductCancelBtn";
            modifyProductCancelBtn.Size = new Size(95, 44);
            modifyProductCancelBtn.TabIndex = 34;
            modifyProductCancelBtn.Text = "Cancel";
            modifyProductCancelBtn.UseVisualStyleBackColor = false;
            modifyProductCancelBtn.Click += ModifyProductCancelBtn_Click;
            // 
            // modifyProductSaveBtn
            // 
            modifyProductSaveBtn.BackColor = SystemColors.ControlDark;
            modifyProductSaveBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyProductSaveBtn.ForeColor = SystemColors.ControlLightLight;
            modifyProductSaveBtn.Location = new Point(662, 678);
            modifyProductSaveBtn.Name = "modifyProductSaveBtn";
            modifyProductSaveBtn.Size = new Size(95, 44);
            modifyProductSaveBtn.TabIndex = 33;
            modifyProductSaveBtn.Text = "Save";
            modifyProductSaveBtn.UseVisualStyleBackColor = false;
            modifyProductSaveBtn.Click += ModifyProductSaveBtn_Click;
            // 
            // modifyProductAssociatedView
            // 
            modifyProductAssociatedView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            modifyProductAssociatedView.Location = new Point(411, 409);
            modifyProductAssociatedView.Name = "modifyProductAssociatedView";
            modifyProductAssociatedView.ReadOnly = true;
            modifyProductAssociatedView.RowTemplate.Height = 25;
            modifyProductAssociatedView.Size = new Size(520, 185);
            modifyProductAssociatedView.TabIndex = 32;
            // 
            // modifyProductCandidateView
            // 
            modifyProductCandidateView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            modifyProductCandidateView.Location = new Point(411, 108);
            modifyProductCandidateView.Name = "modifyProductCandidateView";
            modifyProductCandidateView.ReadOnly = true;
            modifyProductCandidateView.RowTemplate.Height = 25;
            modifyProductCandidateView.Size = new Size(520, 185);
            modifyProductCandidateView.TabIndex = 31;
            // 
            // modifyProductCandidateLabel
            // 
            modifyProductCandidateLabel.AutoSize = true;
            modifyProductCandidateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyProductCandidateLabel.ForeColor = SystemColors.ControlLightLight;
            modifyProductCandidateLabel.Location = new Point(411, 69);
            modifyProductCandidateLabel.Name = "modifyProductCandidateLabel";
            modifyProductCandidateLabel.Size = new Size(147, 21);
            modifyProductCandidateLabel.TabIndex = 52;
            modifyProductCandidateLabel.Text = "All Candidate Parts";
            // 
            // modifyProductAssociatedLabel
            // 
            modifyProductAssociatedLabel.AutoSize = true;
            modifyProductAssociatedLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifyProductAssociatedLabel.ForeColor = SystemColors.ControlLightLight;
            modifyProductAssociatedLabel.Location = new Point(411, 365);
            modifyProductAssociatedLabel.Name = "modifyProductAssociatedLabel";
            modifyProductAssociatedLabel.Size = new Size(257, 21);
            modifyProductAssociatedLabel.TabIndex = 53;
            modifyProductAssociatedLabel.Text = "Parts Associated with this Product";
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1006, 735);
            Controls.Add(modifyProductAssociatedLabel);
            Controls.Add(modifyProductCandidateLabel);
            Controls.Add(modifyProductLabel);
            Controls.Add(modifyProductSearchBox);
            Controls.Add(modifyProductSearchBtn);
            Controls.Add(modifyProductMinLabel);
            Controls.Add(modifyProductMaxLabel);
            Controls.Add(modifyProductPriceCostLabel);
            Controls.Add(modifyProductInventoryLabel);
            Controls.Add(modifyProductNameLabel);
            Controls.Add(modifyProductIDLabel);
            Controls.Add(modifyProductMinBox);
            Controls.Add(modifyProductMaxBox);
            Controls.Add(modifyProductPriceCostBox);
            Controls.Add(modifyProductInventoryBox);
            Controls.Add(modifyProductNameBox);
            Controls.Add(modifyProductIDBox);
            Controls.Add(modifyProductAddBtn);
            Controls.Add(modifyProductDeleteBtn);
            Controls.Add(modifyProductCancelBtn);
            Controls.Add(modifyProductSaveBtn);
            Controls.Add(modifyProductAssociatedView);
            Controls.Add(modifyProductCandidateView);
            Name = "ModifyProduct";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)modifyProductAssociatedView).EndInit();
            ((System.ComponentModel.ISupportInitialize)modifyProductCandidateView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label modifyProductLabel;
        private TextBox modifyProductSearchBox;
        private Button modifyProductSearchBtn;
        private Label modifyProductMinLabel;
        private Label modifyProductMaxLabel;
        private Label modifyProductPriceCostLabel;
        private Label modifyProductInventoryLabel;
        private Label modifyProductNameLabel;
        private Label modifyProductIDLabel;
        private TextBox modifyProductMinBox;
        private TextBox modifyProductMaxBox;
        private TextBox modifyProductPriceCostBox;
        private TextBox modifyProductInventoryBox;
        private TextBox modifyProductNameBox;
        private TextBox modifyProductIDBox;
        private Button modifyProductAddBtn;
        private Button modifyProductDeleteBtn;
        private Button modifyProductCancelBtn;
        private Button modifyProductSaveBtn;
        private DataGridView modifyProductAssociatedView;
        private DataGridView modifyProductCandidateView;
        private Label modifyProductCandidateLabel;
        private Label modifyProductAssociatedLabel;
    }
}