namespace C968InventoryManagementSystem_Monahan
{
    partial class AddProduct
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
            addProductCandidateView = new DataGridView();
            addProductAssociatedView = new DataGridView();
            addProductCancelBtn = new Button();
            addProductSaveBtn = new Button();
            addProductDeleteBtn = new Button();
            addProductAddBtn = new Button();
            addProductMinLabel = new Label();
            addProductMaxLabel = new Label();
            addProductPriceCostLabel = new Label();
            addProductInventoryLabel = new Label();
            addProductNameLabel = new Label();
            addProductIDLabel = new Label();
            addProductMinBox = new TextBox();
            addProductMaxBox = new TextBox();
            addProductPriceCostBox = new TextBox();
            addProductInventoryBox = new TextBox();
            addProductNameBox = new TextBox();
            addProductIDBox = new TextBox();
            addProductSearchBox = new TextBox();
            addProductSearchBtn = new Button();
            addProductLabel = new Label();
            addProductCandidateLabel = new Label();
            addProductAssociatedLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)addProductCandidateView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addProductAssociatedView).BeginInit();
            SuspendLayout();
            // 
            // addProductCandidateView
            // 
            addProductCandidateView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addProductCandidateView.Location = new Point(412, 107);
            addProductCandidateView.Name = "addProductCandidateView";
            addProductCandidateView.ReadOnly = true;
            addProductCandidateView.RowTemplate.Height = 25;
            addProductCandidateView.Size = new Size(520, 185);
            addProductCandidateView.TabIndex = 0;
            // 
            // addProductAssociatedView
            // 
            addProductAssociatedView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addProductAssociatedView.Location = new Point(412, 408);
            addProductAssociatedView.Name = "addProductAssociatedView";
            addProductAssociatedView.ReadOnly = true;
            addProductAssociatedView.RowTemplate.Height = 25;
            addProductAssociatedView.Size = new Size(520, 185);
            addProductAssociatedView.TabIndex = 1;
            // 
            // addProductCancelBtn
            // 
            addProductCancelBtn.BackColor = SystemColors.ControlDark;
            addProductCancelBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductCancelBtn.ForeColor = SystemColors.ControlLightLight;
            addProductCancelBtn.Location = new Point(789, 677);
            addProductCancelBtn.Name = "addProductCancelBtn";
            addProductCancelBtn.Size = new Size(95, 44);
            addProductCancelBtn.TabIndex = 10;
            addProductCancelBtn.Text = "Cancel";
            addProductCancelBtn.UseVisualStyleBackColor = false;
            addProductCancelBtn.Click += AddProductCancelBtn_Click;
            // 
            // addProductSaveBtn
            // 
            addProductSaveBtn.BackColor = SystemColors.ControlDark;
            addProductSaveBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductSaveBtn.ForeColor = SystemColors.ControlLightLight;
            addProductSaveBtn.Location = new Point(663, 677);
            addProductSaveBtn.Name = "addProductSaveBtn";
            addProductSaveBtn.Size = new Size(95, 44);
            addProductSaveBtn.TabIndex = 9;
            addProductSaveBtn.Text = "Save";
            addProductSaveBtn.UseVisualStyleBackColor = false;
            addProductSaveBtn.Click += AddProductSaveBtn_Click;
            // 
            // addProductDeleteBtn
            // 
            addProductDeleteBtn.BackColor = SystemColors.ControlDark;
            addProductDeleteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductDeleteBtn.ForeColor = SystemColors.ControlLightLight;
            addProductDeleteBtn.Location = new Point(789, 615);
            addProductDeleteBtn.Name = "addProductDeleteBtn";
            addProductDeleteBtn.Size = new Size(95, 44);
            addProductDeleteBtn.TabIndex = 11;
            addProductDeleteBtn.Text = "Delete";
            addProductDeleteBtn.UseVisualStyleBackColor = false;
            addProductDeleteBtn.Click += AddProductDeleteBtn_Click;
            // 
            // addProductAddBtn
            // 
            addProductAddBtn.BackColor = SystemColors.ControlDark;
            addProductAddBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductAddBtn.ForeColor = SystemColors.ControlLightLight;
            addProductAddBtn.Location = new Point(789, 312);
            addProductAddBtn.Name = "addProductAddBtn";
            addProductAddBtn.Size = new Size(95, 44);
            addProductAddBtn.TabIndex = 12;
            addProductAddBtn.Text = "Add";
            addProductAddBtn.UseVisualStyleBackColor = false;
            addProductAddBtn.Click += AddProductAddBtn_Click;
            // 
            // addProductMinLabel
            // 
            addProductMinLabel.AutoSize = true;
            addProductMinLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductMinLabel.ForeColor = SystemColors.ControlLightLight;
            addProductMinLabel.Location = new Point(248, 426);
            addProductMinLabel.Name = "addProductMinLabel";
            addProductMinLabel.Size = new Size(38, 21);
            addProductMinLabel.TabIndex = 27;
            addProductMinLabel.Text = "Min";
            // 
            // addProductMaxLabel
            // 
            addProductMaxLabel.AutoSize = true;
            addProductMaxLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductMaxLabel.ForeColor = SystemColors.ControlLightLight;
            addProductMaxLabel.Location = new Point(60, 426);
            addProductMaxLabel.Name = "addProductMaxLabel";
            addProductMaxLabel.Size = new Size(41, 21);
            addProductMaxLabel.TabIndex = 26;
            addProductMaxLabel.Text = "Max";
            // 
            // addProductPriceCostLabel
            // 
            addProductPriceCostLabel.AutoSize = true;
            addProductPriceCostLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductPriceCostLabel.ForeColor = SystemColors.ControlLightLight;
            addProductPriceCostLabel.Location = new Point(22, 374);
            addProductPriceCostLabel.Name = "addProductPriceCostLabel";
            addProductPriceCostLabel.Size = new Size(94, 21);
            addProductPriceCostLabel.TabIndex = 25;
            addProductPriceCostLabel.Text = "Price / Cost";
            // 
            // addProductInventoryLabel
            // 
            addProductInventoryLabel.AutoSize = true;
            addProductInventoryLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductInventoryLabel.ForeColor = SystemColors.ControlLightLight;
            addProductInventoryLabel.Location = new Point(33, 326);
            addProductInventoryLabel.Name = "addProductInventoryLabel";
            addProductInventoryLabel.Size = new Size(81, 21);
            addProductInventoryLabel.TabIndex = 24;
            addProductInventoryLabel.Text = "Inventory";
            // 
            // addProductNameLabel
            // 
            addProductNameLabel.AutoSize = true;
            addProductNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductNameLabel.ForeColor = SystemColors.ControlLightLight;
            addProductNameLabel.Location = new Point(51, 276);
            addProductNameLabel.Name = "addProductNameLabel";
            addProductNameLabel.Size = new Size(53, 21);
            addProductNameLabel.TabIndex = 23;
            addProductNameLabel.Text = "Name";
            // 
            // addProductIDLabel
            // 
            addProductIDLabel.AutoSize = true;
            addProductIDLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductIDLabel.ForeColor = SystemColors.ControlLightLight;
            addProductIDLabel.Location = new Point(72, 227);
            addProductIDLabel.Name = "addProductIDLabel";
            addProductIDLabel.Size = new Size(26, 21);
            addProductIDLabel.TabIndex = 22;
            addProductIDLabel.Text = "ID";
            // 
            // addProductMinBox
            // 
            addProductMinBox.Location = new Point(293, 428);
            addProductMinBox.Name = "addProductMinBox";
            addProductMinBox.Size = new Size(88, 23);
            addProductMinBox.TabIndex = 21;
            // 
            // addProductMaxBox
            // 
            addProductMaxBox.Location = new Point(114, 428);
            addProductMaxBox.Name = "addProductMaxBox";
            addProductMaxBox.Size = new Size(88, 23);
            addProductMaxBox.TabIndex = 20;
            // 
            // addProductPriceCostBox
            // 
            addProductPriceCostBox.Location = new Point(114, 376);
            addProductPriceCostBox.Name = "addProductPriceCostBox";
            addProductPriceCostBox.Size = new Size(162, 23);
            addProductPriceCostBox.TabIndex = 19;
            // 
            // addProductInventoryBox
            // 
            addProductInventoryBox.Location = new Point(114, 328);
            addProductInventoryBox.Name = "addProductInventoryBox";
            addProductInventoryBox.Size = new Size(162, 23);
            addProductInventoryBox.TabIndex = 18;
            // 
            // addProductNameBox
            // 
            addProductNameBox.Location = new Point(114, 278);
            addProductNameBox.Name = "addProductNameBox";
            addProductNameBox.Size = new Size(162, 23);
            addProductNameBox.TabIndex = 17;
            // 
            // addProductIDBox
            // 
            addProductIDBox.BackColor = SystemColors.ActiveBorder;
            addProductIDBox.Location = new Point(114, 229);
            addProductIDBox.Name = "addProductIDBox";
            addProductIDBox.ReadOnly = true;
            addProductIDBox.Size = new Size(162, 23);
            addProductIDBox.TabIndex = 16;
            // 
            // addProductSearchBox
            // 
            addProductSearchBox.Location = new Point(707, 57);
            addProductSearchBox.Name = "addProductSearchBox";
            addProductSearchBox.Size = new Size(225, 23);
            addProductSearchBox.TabIndex = 29;
            // 
            // addProductSearchBtn
            // 
            addProductSearchBtn.BackColor = SystemColors.ControlDark;
            addProductSearchBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductSearchBtn.ForeColor = SystemColors.ControlLightLight;
            addProductSearchBtn.Location = new Point(607, 57);
            addProductSearchBtn.Name = "addProductSearchBtn";
            addProductSearchBtn.Size = new Size(82, 32);
            addProductSearchBtn.TabIndex = 28;
            addProductSearchBtn.Text = "Search";
            addProductSearchBtn.UseVisualStyleBackColor = false;
            addProductSearchBtn.Click += AddProductSearchBtn_Click;
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.BorderStyle = BorderStyle.Fixed3D;
            addProductLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addProductLabel.ForeColor = SystemColors.ControlLightLight;
            addProductLabel.Location = new Point(33, 24);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(150, 34);
            addProductLabel.TabIndex = 30;
            addProductLabel.Text = "Add Product";
            // 
            // addProductCandidateLabel
            // 
            addProductCandidateLabel.AutoSize = true;
            addProductCandidateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductCandidateLabel.ForeColor = SystemColors.ControlLightLight;
            addProductCandidateLabel.Location = new Point(412, 68);
            addProductCandidateLabel.Name = "addProductCandidateLabel";
            addProductCandidateLabel.Size = new Size(147, 21);
            addProductCandidateLabel.TabIndex = 31;
            addProductCandidateLabel.Text = "All Candidate Parts";
            // 
            // addProductAssociatedLabel
            // 
            addProductAssociatedLabel.AutoSize = true;
            addProductAssociatedLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductAssociatedLabel.ForeColor = SystemColors.ControlLightLight;
            addProductAssociatedLabel.Location = new Point(412, 365);
            addProductAssociatedLabel.Name = "addProductAssociatedLabel";
            addProductAssociatedLabel.Size = new Size(257, 21);
            addProductAssociatedLabel.TabIndex = 32;
            addProductAssociatedLabel.Text = "Parts Associated with this Product";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1008, 733);
            Controls.Add(addProductAssociatedLabel);
            Controls.Add(addProductCandidateLabel);
            Controls.Add(addProductLabel);
            Controls.Add(addProductSearchBox);
            Controls.Add(addProductSearchBtn);
            Controls.Add(addProductMinLabel);
            Controls.Add(addProductMaxLabel);
            Controls.Add(addProductPriceCostLabel);
            Controls.Add(addProductInventoryLabel);
            Controls.Add(addProductNameLabel);
            Controls.Add(addProductIDLabel);
            Controls.Add(addProductMinBox);
            Controls.Add(addProductMaxBox);
            Controls.Add(addProductPriceCostBox);
            Controls.Add(addProductInventoryBox);
            Controls.Add(addProductNameBox);
            Controls.Add(addProductIDBox);
            Controls.Add(addProductAddBtn);
            Controls.Add(addProductDeleteBtn);
            Controls.Add(addProductCancelBtn);
            Controls.Add(addProductSaveBtn);
            Controls.Add(addProductAssociatedView);
            Controls.Add(addProductCandidateView);
            Name = "AddProduct";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)addProductCandidateView).EndInit();
            ((System.ComponentModel.ISupportInitialize)addProductAssociatedView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView addProductCandidateView;
        private DataGridView addProductAssociatedView;
        private Button addProductCancelBtn;
        private Button addProductSaveBtn;
        private Button addProductDeleteBtn;
        private Button addProductAddBtn;
        private Label addProductMinLabel;
        private Label addProductMaxLabel;
        private Label addProductPriceCostLabel;
        private Label addProductInventoryLabel;
        private Label addProductNameLabel;
        private Label addProductIDLabel;
        private TextBox addProductMinBox;
        private TextBox addProductMaxBox;
        private TextBox addProductPriceCostBox;
        private TextBox addProductInventoryBox;
        private TextBox addProductNameBox;
        private TextBox addProductIDBox;
        private TextBox addProductSearchBox;
        private Button addProductSearchBtn;
        private Label addProductLabel;
        private Label addProductCandidateLabel;
        private Label addProductAssociatedLabel;
    }
}