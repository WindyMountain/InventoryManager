namespace C968InventoryManagementSystem_Monahan
{
    public class InhousePart : Part
    {
        private int machineID;
        public int MachineID { get; set; }

        public InhousePart() { }

        public InhousePart(int partID, string name, decimal price, int inStock, int max, int min)
        {
            PartID = partID;
            Name = name;
            Price = price.ToString();
            InStock = inStock;
            Max = max;
            Min = min;
        }

        public InhousePart(int partID, string name, decimal price, int inStock, int max, int min, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price.ToString();
            InStock = inStock;
            Max = max;
            Min = min;
            MachineID = machineID;
        }
    }
}
