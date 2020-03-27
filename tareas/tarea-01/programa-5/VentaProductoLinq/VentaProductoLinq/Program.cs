using System;
using System.Linq;

namespace VentaProductos
{
    class Program
    {
        static void Main(string[] args)
        {
            int response = 0;
            do
            {
                SellList list = new SellList();
                ConsoleMessage.Print(list.ToString(), 3);
                response = Data.GetIntegerByConsole("Escribe 1 para volver a ejecutar: ");
            } while (response == 1);
        }
    }

    class SellList
    {
        private ProductSellList[] list;
        private int quantity;
        private double total;
        private int bestSellingProductIndex;
        private ProductSellList bestSellingProduct;
        private double averaguePriceProducts;
        public SellList()
        {
            total = 0;
            bestSellingProductIndex = 0;
            averaguePriceProducts = 0;
            do
            {
                this.quantity = Data.GetIntegerByConsole("Cuantos productos conforman la lista? : ");
                if (this.quantity < 1) ConsoleMessage.Print("Cantidad Invalida", 3);
            } while (this.quantity < 1);
            list = new ProductSellList[quantity];
            Fill();
            SetData();
        }

        public void Fill()
        {
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"-> Producto {i+1} <-");
                list[i] = new ProductSellList();
            }
        }

        // Fill restand properties
        public void SetData()
        {
            total = Math.Round(list.Select(product => product.GetTotal()).ToList().Sum(), 2);
            bestSellingProduct = list.OrderBy(product => product.GetProduct().GetPrice()).ToList().First();
            averaguePriceProducts = list.Average(product => product.GetProduct().GetPrice());
            /*for (int i = 0; i < list.Length; i++)
            {
                ProductSellList product = list[i]; // total current product
                total += product.GetTotal(); // add to total list
                averaguePriceProducts += product.GetProduct().GetPrice();
                if (product.GetQuantity() > list[bestSellingProductIndex].GetQuantity())
                    bestSellingProductIndex = i;
            }

            averaguePriceProducts /= quantity;*/
        }

        public override string ToString()
        {
            String objectString = ".:Lista de Productos: ";
            foreach (ProductSellList product in list)
                objectString += $"\n-> {product.ToString()}";

            objectString += $"\nTotal de venta: ${total}";
            objectString += $"\nProducto mas vendido: {bestSellingProduct.GetProduct().GetName()} ";
            objectString += $"\nPromedio de precios: ${averaguePriceProducts}";
            return objectString;
        }
    }
    class ProductSellList
    {
        private Product product;
        private int quantity;
        private double total;

        public ProductSellList()
        {
            this.product = new Product();
            do
            {
                this.quantity = Data.GetIntegerByConsole("Escribe la cantidad de este producto: ");
                if (quantity <= 0) ConsoleMessage.Print("Cantidad invalida!!!", 3);
            } while (this.quantity < 0);
            CalculateTotal();
        }

        private void CalculateTotal() { total = Math.Round(product.GetPrice() * this.quantity, 2); }
        public Product GetProduct() { return product;}
        public int GetQuantity() { return quantity;}
        public double GetTotal() { return total;}
        public override string ToString()
        {
            return $"{product.ToString()} * {quantity} = ${total}";
        }
    }
    
    class Product
    {
        public Product()
        {
            this.Fill();
        }

        private string Name { get; set; }
        private double Price { get; set; }

        public void Fill()
        {
            
            this.Name = Data.GetStringByConsole("Escribe el nombre del producto: ");
            do
            {
                Price = Data.GetDoubleByConsole("Escribe el precio del producto: $");
                if (Price <= 0 ) ConsoleMessage.Print("Precio no valido!!!", 3);
            } while (Price < 0);
        }
        public String GetName() { return this.Name; }
        public double GetPrice() { return this.Price; }
        
        public override string ToString() { return $"{Name} $ {Price}"; }
    }
    
    class Data
    {
        public static int GetIntegerByConsole(String message)
        {
            try
            {
                int number;
                ConsoleMessage.Print(message, 1);
                number = int.Parse(Console.ReadLine());
                return number;
            }
            catch (Exception e)
            {
                ConsoleMessage.Print("Entrada invalida", 3);
                return GetIntegerByConsole(message);
            }
        }
        public static double GetDoubleByConsole(String message)
        {
            try
            {
                double number;
                ConsoleMessage.Print(message, 1);
                number = double.Parse(Console.ReadLine());
                return number;
            }
            catch (Exception e)
            {
                ConsoleMessage.Print("Entrada invalida", 3);
                return GetDoubleByConsole(message);
            }
        }

        public static String GetStringByConsole(String message)
        {
            String data;
            do
            {
                ConsoleMessage.Print(message, 1);
                data = Console.ReadLine();
            } while (data == "");

            return data;
        }
    }

    class ConsoleMessage
    {
        // print message in console 
        // @Param message: text 
        // @Param type: 1: inline, 2: oneLine, 3: decorate
        public static void Print(String message, int type)
        {
            switch (type)
            {
                case 1: 
                    Console.Write(message);
                    break;
                case 2:
                    Console.WriteLine(message);
                    break;
                default:
                    message = $"*********************************\n{message}\n*****************************";
                    Console.WriteLine(message);
                    break;
            }
        }
    }
}