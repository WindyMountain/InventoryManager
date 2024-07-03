namespace C968InventoryManagementSystem_Monahan
{
    public partial class ModifyPart : Form
    {
        MainScreen ActiveView = (MainScreen)Application.OpenForms["MainScreen"];

        public ModifyPart(InhousePart part)
        {
            InitializeComponent();

            modifyPartIDBox.Text = part.PartID.ToString();
            modifyPartNameBox.Text = part.Name;
            modifyPartInventoryBox.Text = part.InStock.ToString();
            modifyPartPriceCostBox.Text = part.Price.Substring(1).ToString();
            modifyPartMaxBox.Text = part.Max.ToString();
            modifyPartMinBox.Text = part.Min.ToString();
            modifyPartDynamicBox.Text = part.MachineID.ToString();
        }

        public ModifyPart(OutsourcedPart part)
        {
            InitializeComponent();

            modifyPartIDBox.Text = part.PartID.ToString();
            modifyPartNameBox.Text = part.Name;
            modifyPartInventoryBox.Text = part.InStock.ToString();
            modifyPartPriceCostBox.Text = part.Price.Substring(1).ToString();
            modifyPartMaxBox.Text = part.Max.ToString();
            modifyPartMinBox.Text = part.Min.ToString();
            modifyPartDynamicBox.Text = part.CompanyName;

            modifyPartOutsourcedRad.Checked = true;
        }

        private void ModifyPartOutsourcedRad_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartDynamicLabel.Text = "Company Name";
        }

        private void ModifyPartInhouseRad_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartDynamicLabel.Text = "Machine ID";
        }

        private void modifyPartSaveBtn_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inStock;
            decimal price;

            try
            {
                min = int.Parse(modifyPartMinBox.Text);
                max = int.Parse(modifyPartMaxBox.Text);
                inStock = int.Parse(modifyPartInventoryBox.Text);
                price = decimal.Parse(modifyPartPriceCostBox.Text);
            }

            catch
            {
                MessageBox.Show("InStock, Price, Max, and Min must only contain numbers");
                return;
            }

            if (modifyPartDynamicLabel.Text == "Machine ID")
            {
                try
                {
                    int.Parse(modifyPartDynamicBox.Text);
                }

                catch
                {
                    MessageBox.Show("Machine ID may only contain whole numbers");
                    return;
                }
            }

            int id = int.Parse(modifyPartIDBox.Text);
            string name = modifyPartNameBox.Text;
            price = decimal.Parse(modifyPartPriceCostBox.Text);
            min = int.Parse(modifyPartMinBox.Text);
            max = int.Parse(modifyPartMaxBox.Text);
            inStock = int.Parse(modifyPartInventoryBox.Text);

            if (modifyPartInhouseRad.Checked == false && modifyPartOutsourcedRad.Checked == false)
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

            if (modifyPartInhouseRad.Checked)
            {
                InhousePart inPart = new InhousePart(id, name, price, inStock, max, min, int.Parse(modifyPartDynamicBox.Text));
                Inventory.UpdatePart(id, inPart);
                modifyPartInhouseRad.Checked = true;
            }

            else
            {
                OutsourcedPart outPart = new OutsourcedPart(id, name, price, inStock, max, min, modifyPartDynamicBox.Text);
                Inventory.UpdatePart(id, outPart);
                modifyPartOutsourcedRad.Checked = true;
            }

            Close();
            ActiveView.mainPartView.Update();
            ActiveView.mainPartView.Refresh();
        }

        private void ModifyPartCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
