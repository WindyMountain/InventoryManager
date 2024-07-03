namespace C968InventoryManagementSystem_Monahan
{
    public class OutsourcedPart : Part
    {
        private string companyName;
        public string CompanyName { get; set; }
        public OutsourcedPart() { }

        public OutsourcedPart(int partID, string name, decimal price, int inStock, int max, int min)
        {
            PartID = partID;
            Name = name;
            Price = price.ToString();
            InStock = inStock;
            Max = max;
            Min = min;
        }

        public OutsourcedPart(int partID, string name, decimal price, int inStock, int max, int min, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price.ToString();
            InStock = inStock;
            Max = max;
            Min = min;
            CompanyName = companyName;
        }
    }
}
