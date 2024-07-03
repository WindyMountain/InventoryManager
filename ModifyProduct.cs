using System.ComponentModel;

namespace C968InventoryManagementSystem_Monahan
{
    public partial class ModifyProduct : Form
    {
        BindingList<Part> initParts = new BindingList<Part>();
        MainScreen ActiveWindow = (MainScreen)Application.OpenForms["MainScreen"];
        public ModifyProduct(Product initProduct)
        {
            InitializeComponent();

            modifyProductIDBox.Text = initProduct.ProductID.ToString();
            modifyProductNameBox.Text = initProduct.Name;
            modifyProductPriceCostBox.Text = initProduct.Price.Substring(1).ToString();
            modifyProductInventoryBox.Text = initProduct.InStock.ToString();
            modifyProductMaxBox.Text = initProduct.Max.ToString();
            modifyProductMinBox.Text = initProduct.Min.ToString();

            var candidateView = new BindingSource();
            candidateView.DataSource = Inventory.AllParts;

            modifyProductCandidateView.DataSource = candidateView;

            foreach (Part newPart in initProduct.AssociatedParts)
            {
                initParts.Add(newPart);
            }
            var associatedView = new BindingSource();
            associatedView.DataSource = initParts;
            modifyProductAssociatedView.DataSource = associatedView;
        }

        private void ModifyProductCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyProductSaveBtn_Click(object sender, EventArgs e)
        {
            decimal price;
            int inStock;
            int max;
            int min;

            try
            {
                price = decimal.Parse(modifyProductPriceCostBox.Text);
                inStock = int.Parse(modifyProductInventoryBox.Text);
                max = int.Parse(modifyProductMaxBox.Text);
                min = int.Parse(modifyProductMinBox.Text);
            }
            catch
            {
                MessageBox.Show("InStock, Price, Max, and Min must only contain numbers");
                return;
            }

            int id = int.Parse(modifyProductIDBox.Text);
            string name = modifyProductNameBox.Text;
            price = decimal.Parse(modifyProductPriceCostBox.Text);
            inStock = int.Parse(modifyProductInventoryBox.Text);
            max = int.Parse(modifyProductMaxBox.Text);
            min = int.Parse(modifyProductMinBox.Text);

            if (min > max)
            {
                MessageBox.Show("Min can't be greater than Max");
                return;
            }

            if (inStock > max || inStock < min)
            {
                MessageBox.Show("InStock must be between Min and Max");
                return;
            }

            Product product = new Product(id, name, price, inStock, max, min);

            foreach (Part part in initParts)
            {
                product.AddAssociatedPart(part);
            }

            Inventory.UpdateProduct(id, product);

            Close();

            ActiveWindow.mainProductView.Update();
            ActiveWindow.mainProductView.Refresh();
        }

        private void ModifyProductAddBtn_Click(object sender, EventArgs e)
        {
            Part part = (Part)modifyProductCandidateView.CurrentRow.DataBoundItem;

            initParts.Add(part);
        }

        private void ModifyProductSearchBtn_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(modifyProductSearchBox.Text);
            Part match = Inventory.LookupPart(partID);

            foreach (DataGridViewRow row in modifyProductCandidateView.Rows)
            {
                row.Selected = false;
            }

            foreach (DataGridViewRow row in modifyProductCandidateView.Rows)
            {
                Part part = (Part)row.DataBoundItem;

                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void ModifyProductDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                Part part = (Part)modifyProductAssociatedView.CurrentRow.DataBoundItem;
                int id = int.Parse(modifyProductIDBox.Text);

                Product product = Inventory.LookupProduct(id);

                product.RemoveAssociatedPart(part.PartID);

                foreach (DataGridViewRow row in modifyProductAssociatedView.SelectedRows)
                {
                    modifyProductAssociatedView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
    }
}
