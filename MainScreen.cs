namespace C968InventoryManagementSystem_Monahan
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            Inventory.Filler();

            var partView = new BindingSource();
            partView.DataSource = Inventory.AllParts;

            mainPartView.DataSource = partView;

            var productView = new BindingSource();
            productView.DataSource = Inventory.Products;

            mainProductView.DataSource = productView;
        }

        //Parts

        private void MainPartAddBtn_Click(object sender, EventArgs e)
        {
            new AddPart().ShowDialog();
        }

        private void MainPartModifyBtn_Click(object sender, EventArgs e)
        {
            if (mainPartView.CurrentRow.DataBoundItem.GetType() == typeof(C968InventoryManagementSystem_Monahan.InhousePart))
            {
                InhousePart inhousePart = (InhousePart)mainPartView.CurrentRow.DataBoundItem;

                new ModifyPart(inhousePart).ShowDialog();
            }
            else
            {
                OutsourcedPart outsourcedPart = (OutsourcedPart)mainPartView.CurrentRow.DataBoundItem;

                new ModifyPart(outsourcedPart).ShowDialog();
            }
        }

        private void MainPartDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult partConfirmation = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo);

            if (partConfirmation == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in mainPartView.SelectedRows)
                {
                    mainPartView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }

        private void MainPartSearchBtn_Click(object sender, EventArgs e)
        {
            Part matchingPart = Inventory.LookupPart(int.Parse(mainPartSearchBox.Text));

            foreach (DataGridViewRow row in mainPartView.Rows)
            {
                row.Selected = false;
            }

            foreach (DataGridViewRow row in mainPartView.Rows)
            {
                Part activePart = (Part)row.DataBoundItem;

                if (activePart.PartID == matchingPart.PartID)
                {
                    row.Selected = true;
                }
            }
        }

        //Products

        private void MainAddProductBtn_Click(object sender, EventArgs e)
        {
            new AddProduct().ShowDialog();
        }

        private void MainModifyProductBtn_Click(object sender, EventArgs e)
        {
            Product selectedProd = (Product)mainProductView.CurrentRow.DataBoundItem;

            new ModifyProduct(selectedProd).ShowDialog();
        }

        private void MainProductDeleteProductBtn_Click(object sender, EventArgs e)
        {
            DialogResult productConfirmation = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo);

            if (productConfirmation == DialogResult.Yes)
            {
                Product activeProduct = (Product)mainProductView.CurrentRow.DataBoundItem;

                if (activeProduct.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Remove parts attached to this product before deleting");
                    return;
                }

                foreach (DataGridViewRow row in mainProductView.SelectedRows)
                {
                    mainProductView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
        private void MainProductSearchBtn_Click(object sender, EventArgs e)
        {
            Product matchingProduct = Inventory.LookupProduct(int.Parse(mainProductSearchBox.Text));

            foreach (DataGridViewRow row in mainProductView.Rows)
            {
                row.Selected = false;
            }

            foreach (DataGridViewRow row in mainProductView.Rows)
            {
                Product activeProduct = (Product)row.DataBoundItem;

                if (activeProduct.ProductID == matchingProduct.ProductID)
                {
                    row.Selected = true;
                    break;
                }
            }
        }
        private void MainExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}