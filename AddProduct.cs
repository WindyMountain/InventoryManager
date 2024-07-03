using System.ComponentModel;

namespace C968InventoryManagementSystem_Monahan
{
    public partial class AddProduct : Form
    {
        BindingList<Part> initParts = new BindingList<Part>();

        public AddProduct()
        {
            InitializeComponent();

            var candidateView = new BindingSource();
            candidateView.DataSource = Inventory.AllParts;

            addProductCandidateView.DataSource = candidateView;

            var associatedView = new BindingSource();
            associatedView.DataSource = initParts;

            addProductAssociatedView.DataSource = associatedView;
        }

        private void AddProductCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddProductDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult productConfirmation = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo);

            if (productConfirmation == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in addProductAssociatedView.SelectedRows)
                {
                    addProductAssociatedView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }

        private void AddProductSearchBtn_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(addProductSearchBox.Text);
            Part matchingPart = Inventory.LookupPart(partID);

            foreach (DataGridViewRow row in addProductCandidateView.Rows)
            {
                row.Selected = false;
            }

            foreach (DataGridViewRow row in addProductCandidateView.Rows)
            {
                Part activePart = (Part)row.DataBoundItem;
                if (activePart.PartID == matchingPart.PartID)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void AddProductAddBtn_Click(object sender, EventArgs e)
        {
            Part addedPart = (Part)addProductCandidateView.CurrentRow.DataBoundItem;

            initParts.Add(addedPart);
        }

        private void AddProductSaveBtn_Click(object sender, EventArgs e)
        {
            decimal price;
            int inStock;
            int max;
            int min;

            try
            {
                price = decimal.Parse(addProductPriceCostBox.Text);
                inStock = int.Parse(addProductInventoryBox.Text);
                max = int.Parse(addProductMaxBox.Text);
                min = int.Parse(addProductMinBox.Text);
            }
            catch
            {
                MessageBox.Show("InStock, Price, Max, and Min must only contain numbers");
                return;
            }

            string name = addProductNameBox.Text;
            price = decimal.Parse(addProductPriceCostBox.Text);
            inStock = int.Parse(addProductInventoryBox.Text);
            min = int.Parse(addProductMinBox.Text);
            max = int.Parse(addProductMaxBox.Text);

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

            Product activeProduct = new Product((Inventory.Products.Count + 1), name, price, inStock, max, min);

            Inventory.AddProduct(activeProduct);

            foreach (Part part in initParts)
            {
                activeProduct.AddAssociatedPart(part);
            }
            Close();
        }
    }
}
