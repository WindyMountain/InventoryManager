namespace C968InventoryManagementSystem_Monahan
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void AddPartInhouseRad_CheckedChanged(object sender, EventArgs e)
        {
            addPartDynamicLabel.Text = "Machine ID";
        }

        private void AddPartOutsourcedRad_CheckedChanged(object sender, EventArgs e)
        {
            addPartDynamicLabel.Text = "Company Name";
        }

        private void AddPartSaveBtn_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inStock;
            decimal price;

            try
            {
                min = int.Parse(addPartMinBox.Text);
                max = int.Parse(addPartMaxBox.Text);
                inStock = int.Parse(addPartInventoryBox.Text);
                price = decimal.Parse(addPartPriceCostBox.Text);
            }

            catch
            {
                MessageBox.Show("InStock, Price, Max, and Min must only contain numbers");
                return;
            }

            if (addPartDynamicLabel.Text == "Machine ID")
            {
                try
                {
                    int.Parse(addPartDynamicBox.Text);
                }

                catch
                {
                    MessageBox.Show("Machine ID may only contain whole numbers");
                    return;
                }
            }

            string name = addPartNameBox.Text;
            price = decimal.Parse(addPartPriceCostBox.Text);
            min = int.Parse(addPartMinBox.Text);
            max = int.Parse(addPartMaxBox.Text);
            inStock = int.Parse(addPartInventoryBox.Text);

            if (addPartInhouseRad.Checked == false && addPartOutsourcedRad.Checked == false)
            {
                MessageBox.Show("In-House or Outsourced must be selected");
                return;
            }

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

            if (addPartInhouseRad.Checked)
            {
                InhousePart inPart = new InhousePart((Inventory.AllParts.Count + 1), name, price, inStock, max, min, int.Parse(addPartDynamicBox.Text));
                Inventory.AddPart(inPart);
            }

            else
            {
                OutsourcedPart outPart = new OutsourcedPart((Inventory.AllParts.Count + 1), name, price, inStock, max, min, addPartDynamicBox.Text);
                Inventory.AddPart(outPart);
            }

            Close();
        }

        private void AddPartCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
