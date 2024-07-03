using System.ComponentModel;

namespace C968InventoryManagementSystem_Monahan
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void AddProduct(Product activeProduct)
        {
            Products.Add(activeProduct);
        }

        public bool RemoveProduct(int productID)
        {
            bool isRemoved = false;

            foreach (Product activeProduct in Products)
            {
                if (productID == activeProduct.ProductID)
                {
                    Products.Remove(activeProduct);
                    return isRemoved = true;
                }
                else
                {
                    MessageBox.Show("Product removal failed");
                    return false;
                }
            }
            return isRemoved;
        }

        public static Product LookupProduct(int productID)
        {
            bool productFound = false;

            foreach (Product activeProduct in Products)
            {
                if (activeProduct.ProductID == productID)
                {
                    productFound = true;
                    return activeProduct;
                }
            }

            if (productFound == false)
            {
                MessageBox.Show("Product not found");
            }

            Product proxyProduct = new C968InventoryManagementSystem_Monahan.Product();
            return proxyProduct;
        }

        public static void UpdateProduct(int productID, Product resultingProduct)
        {
            foreach (Product activeProduct in Products)
            {
                if (activeProduct.ProductID == productID)
                {
                    activeProduct.Name = resultingProduct.Name;
                    activeProduct.Price = resultingProduct.Price;
                    activeProduct.InStock = resultingProduct.InStock;
                    activeProduct.Max = resultingProduct.Max;
                    activeProduct.Min = resultingProduct.Min;
                    activeProduct.AssociatedParts = resultingProduct.AssociatedParts;
                    return;
                }
            }
        }

        public static void AddPart(Part activePart)
        {
            AllParts.Add(activePart);
        }

        public bool DeletePart(Part activePart)
        {
            try
            {
                AllParts.Remove(activePart);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Part LookupPart(int partID)
        {
            bool partFound = false;

            foreach (Part activePart in AllParts)
            {
                if (activePart.PartID == partID)
                {
                    partFound = true;
                    return activePart;
                }
            }

            if (partFound == false)
            {
                MessageBox.Show("Part not found");
            }

            Part proxyPart = new InhousePart();
            return proxyPart;
        }

        public static void UpdatePart(int partID, Part resultingPart)
        {
            foreach (Part activePart in AllParts)
            {
                if (activePart.PartID == partID)
                {
                    activePart.Name = resultingPart.Name;
                    activePart.Price = resultingPart.Price;
                    activePart.InStock = resultingPart.InStock;
                    activePart.Max = resultingPart.Max;
                    activePart.Min = resultingPart.Min;
                    return;
                }
            }
        }

        public static void Filler()
        {
            Product productFiller1 = new Product(0, "Deathbeam Laser", 20, 1000, 1000, 5);
            Product productFiller2 = new Product(1, "Angry Beehive", 40, 50, 100, 25);
            Product productFiller3 = new Product(2, "Sentimental Comicbook", 80, 1, 300, 0);
            Products.Add(productFiller1);
            Products.Add(productFiller2);
            Products.Add(productFiller3);

            Part partFiller1 = new InhousePart(0, "Thingamabob", 100, 5, 20, 2, 34);
            Part partFiller2 = new InhousePart(1, "Whatchamacallit", 150, 10, 10, 1, 404);
            Part partFiller3 = new OutsourcedPart(2, "Doohickey", 80, 15, 50, 10, "Confusion Co.");
            Part partFiller4 = new OutsourcedPart(3, "Gadgety Gizmo", 75, 20, 100, 10, "Super Evil Dudes Inc.");

            AllParts.Add(partFiller1);
            AllParts.Add(partFiller2);
            AllParts.Add(partFiller3);
            AllParts.Add(partFiller4);

        }
    }
}
