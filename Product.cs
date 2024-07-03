using System.ComponentModel;

namespace C968InventoryManagementSystem_Monahan
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        private int productID;
        private string? name;
        private decimal price;
        private int inStock;
        private int max;
        private int min;

        public int ProductID { get; set; }
        public string? Name { get; set; }
        public string Price
        {
            get { return price.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {
                    price = decimal.Parse(value.Substring(1));
                }
                else
                {
                    price = decimal.Parse(value);
                }
            }
        }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

        public Product() { }

        public Product(int prodID, string name, decimal price, int inStock, int max, int min)
        {
            ProductID = prodID;
            Name = name;
            Price = price.ToString();
            InStock = inStock;
            Max = max;
            Min = min;
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            bool isRemoved = false;

            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return isRemoved = true;
                }
                else
                {
                    isRemoved = false;
                }
            }
            return isRemoved;
        }

        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }

            InhousePart proxyInhousePart = new InhousePart();
            return proxyInhousePart;
        }
    }
}
