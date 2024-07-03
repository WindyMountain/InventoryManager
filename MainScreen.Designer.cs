namespace C968InventoryManagementSystem_Monahan
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainProductAddBtn = new Button();
            mainProductModifyBtn = new Button();
            mainProductDeleteBtn = new Button();
            mainPartDeleteBtn = new Button();
            mainPartModifyBtn = new Button();
            mainPartAddBtn = new Button();
            mainExitBtn = new Button();
            mainPartSearchBtn = new Button();
            mainProductSearchBtn = new Button();
            mainProductSearchBox = new TextBox();
            mainPartSearchBox = new TextBox();
            mainProductLabel = new Label();
            mainPartLabel = new Label();
            mainLabel = new Label();
            mainPartView = new DataGridView();
            mainProductView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)mainPartView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainProductView).BeginInit();
            SuspendLayout();
            // 
            // mainProductAddBtn
            // 
            mainProductAddBtn.BackColor = SystemColors.ControlDark;
            mainProductAddBtn.Location = new Point(580, 343);
            mainProductAddBtn.Name = "mainProductAddBtn";
            mainProductAddBtn.Size = new Size(68, 34);
            mainProductAddBtn.TabIndex = 3;
            mainProductAddBtn.Text = "Add";
            mainProductAddBtn.UseVisualStyleBackColor = false;
            mainProductAddBtn.Click += MainAddProductBtn_Click;
            // 
            // mainProductModifyBtn
            // 
            mainProductModifyBtn.BackColor = SystemColors.ControlDark;
            mainProductModifyBtn.Location = new Point(688, 343);
            mainProductModifyBtn.Name = "mainProductModifyBtn";
            mainProductModifyBtn.Size = new Size(68, 34);
            mainProductModifyBtn.TabIndex = 8;
            mainProductModifyBtn.Text = "Modify";
            mainProductModifyBtn.UseVisualStyleBackColor = false;
            mainProductModifyBtn.Click += MainModifyProductBtn_Click;
            // 
            // mainProductDeleteBtn
            // 
            mainProductDeleteBtn.BackColor = SystemColors.ControlDark;
            mainProductDeleteBtn.Location = new Point(794, 343);
            mainProductDeleteBtn.Name = "mainProductDeleteBtn";
            mainProductDeleteBtn.Size = new Size(68, 34);
            mainProductDeleteBtn.TabIndex = 9;
            mainProductDeleteBtn.Text = "Delete";
            mainProductDeleteBtn.UseVisualStyleBackColor = false;
            mainProductDeleteBtn.Click += MainProductDeleteProductBtn_Click;
            // 
            // mainPartDeleteBtn
            // 
            mainPartDeleteBtn.BackColor = SystemColors.ControlDark;
            mainPartDeleteBtn.Location = new Point(286, 343);
            mainPartDeleteBtn.Name = "mainPartDeleteBtn";
            mainPartDeleteBtn.Size = new Size(68, 34);
            mainPartDeleteBtn.TabIndex = 12;
            mainPartDeleteBtn.Text = "Delete";
            mainPartDeleteBtn.UseVisualStyleBackColor = false;
            mainPartDeleteBtn.Click += MainPartDeleteBtn_Click;
            // 
            // mainPartModifyBtn
            // 
            mainPartModifyBtn.BackColor = SystemColors.ControlDark;
            mainPartModifyBtn.Location = new Point(180, 343);
            mainPartModifyBtn.Name = "mainPartModifyBtn";
            mainPartModifyBtn.Size = new Size(68, 34);
            mainPartModifyBtn.TabIndex = 11;
            mainPartModifyBtn.Text = "Modify";
            mainPartModifyBtn.UseVisualStyleBackColor = false;
            mainPartModifyBtn.Click += MainPartModifyBtn_Click;
            // 
            // mainPartAddBtn
            // 
            mainPartAddBtn.BackColor = SystemColors.ControlDark;
            mainPartAddBtn.Location = new Point(72, 343);
            mainPartAddBtn.Name = "mainPartAddBtn";
            mainPartAddBtn.Size = new Size(68, 34);
            mainPartAddBtn.TabIndex = 10;
            mainPartAddBtn.Text = "Add";
            mainPartAddBtn.UseVisualStyleBackColor = false;
            mainPartAddBtn.Click += MainPartAddBtn_Click;
            // 
            // mainExitBtn
            // 
            mainExitBtn.BackColor = SystemColors.ControlDark;
            mainExitBtn.Location = new Point(924, 388);
            mainExitBtn.Name = "mainExitBtn";
            mainExitBtn.Size = new Size(68, 34);
            mainExitBtn.TabIndex = 13;
            mainExitBtn.Text = "Exit";
            mainExitBtn.UseVisualStyleBackColor = false;
            mainExitBtn.Click += MainExitBtn_Click;
            // 
            // mainPartSearchBtn
            // 
            mainPartSearchBtn.BackColor = SystemColors.ControlDark;
            mainPartSearchBtn.Location = new Point(212, 87);
            mainPartSearchBtn.Name = "mainPartSearchBtn";
            mainPartSearchBtn.Size = new Size(68, 23);
            mainPartSearchBtn.TabIndex = 15;
            mainPartSearchBtn.Text = "Search";
            mainPartSearchBtn.UseVisualStyleBackColor = false;
            mainPartSearchBtn.Click += MainPartSearchBtn_Click;
            // 
            // mainProductSearchBtn
            // 
            mainProductSearchBtn.BackColor = SystemColors.ControlDark;
            mainProductSearchBtn.ForeColor = SystemColors.ActiveCaptionText;
            mainProductSearchBtn.Location = new Point(722, 87);
            mainProductSearchBtn.Name = "mainProductSearchBtn";
            mainProductSearchBtn.Size = new Size(66, 23);
            mainProductSearchBtn.TabIndex = 14;
            mainProductSearchBtn.Text = "Search";
            mainProductSearchBtn.UseVisualStyleBackColor = false;
            mainProductSearchBtn.Click += MainProductSearchBtn_Click;
            // 
            // mainProductSearchBox
            // 
            mainProductSearchBox.Location = new Point(794, 87);
            mainProductSearchBox.Name = "mainProductSearchBox";
            mainProductSearchBox.Size = new Size(198, 23);
            mainProductSearchBox.TabIndex = 16;
            // 
            // mainPartSearchBox
            // 
            mainPartSearchBox.Location = new Point(286, 87);
            mainPartSearchBox.Name = "mainPartSearchBox";
            mainPartSearchBox.Size = new Size(198, 23);
            mainPartSearchBox.TabIndex = 17;
            // 
            // mainProductLabel
            // 
            mainProductLabel.AutoSize = true;
            mainProductLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            mainProductLabel.ForeColor = SystemColors.ControlLightLight;
            mainProductLabel.Location = new Point(570, 78);
            mainProductLabel.Name = "mainProductLabel";
            mainProductLabel.Size = new Size(107, 32);
            mainProductLabel.TabIndex = 18;
            mainProductLabel.Text = "Products";
            // 
            // mainPartLabel
            // 
            mainPartLabel.AutoSize = true;
            mainPartLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            mainPartLabel.ForeColor = SystemColors.ControlLightLight;
            mainPartLabel.Location = new Point(62, 78);
            mainPartLabel.Name = "mainPartLabel";
            mainPartLabel.Size = new Size(69, 32);
            mainPartLabel.TabIndex = 19;
            mainPartLabel.Text = "Parts";
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            mainLabel.ForeColor = SystemColors.ControlLightLight;
            mainLabel.Location = new Point(12, 9);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(347, 32);
            mainLabel.TabIndex = 20;
            mainLabel.Text = "Inventory Management System";
            // 
            // mainPartView
            // 
            mainPartView.AllowUserToAddRows = false;
            mainPartView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainPartView.Location = new Point(72, 116);
            mainPartView.Name = "mainPartView";
            mainPartView.ReadOnly = true;
            mainPartView.RowTemplate.Height = 25;
            mainPartView.Size = new Size(412, 210);
            mainPartView.TabIndex = 21;
            // 
            // mainProductView
            // 
            mainProductView.AllowUserToAddRows = false;
            mainProductView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainProductView.Location = new Point(580, 116);
            mainProductView.Name = "mainProductView";
            mainProductView.ReadOnly = true;
            mainProductView.RowTemplate.Height = 25;
            mainProductView.Size = new Size(412, 210);
            mainProductView.TabIndex = 22;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1035, 450);
            Controls.Add(mainProductView);
            Controls.Add(mainPartView);
            Controls.Add(mainLabel);
            Controls.Add(mainPartLabel);
            Controls.Add(mainProductLabel);
            Controls.Add(mainPartSearchBox);
            Controls.Add(mainProductSearchBox);
            Controls.Add(mainPartSearchBtn);
            Controls.Add(mainProductSearchBtn);
            Controls.Add(mainExitBtn);
            Controls.Add(mainPartDeleteBtn);
            Controls.Add(mainPartModifyBtn);
            Controls.Add(mainPartAddBtn);
            Controls.Add(mainProductDeleteBtn);
            Controls.Add(mainProductModifyBtn);
            Controls.Add(mainProductAddBtn);
            ForeColor = SystemColors.ControlText;
            Name = "MainScreen";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)mainPartView).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainProductView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button mainProductAddBtn;
        private Button mainProductModifyBtn;
        private Button mainProductDeleteBtn;
        private Button mainPartDeleteBtn;
        private Button mainPartModifyBtn;
        private Button mainPartAddBtn;
        private Button mainExitBtn;
        private Button mainPartSearchBtn;
        private Button mainProductSearchBtn;
        private TextBox mainProductSearchBox;
        private TextBox mainPartSearchBox;
        private Label mainProductLabel;
        private Label mainPartLabel;
        private Label mainLabel;
        public DataGridView mainPartView;
        public DataGridView mainProductView;
    }
}