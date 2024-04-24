using System.Text.Json;

namespace JsonSerialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Zaman";
            product.Surname = "Safarov";
            product.Position = "Middle Front";

            // Serialize the product to JSON
            ProductToJSON(product);

            // Deserialize the product from JSON
            Product deserializedProduct = JSONToProduct();
            Console.WriteLine(deserializedProduct);
        }
        public static void ProductToJSON(Product product)
        {
            string path = "D:\\Users\\User\\Desktop\\data.json";

            // Use 'using' statement for proper resource disposal
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                JsonSerializer.Serialize(stream,product);
            }
        }

        public static Product JSONToProduct()
        {
            string path = "D:\\Users\\User\\Desktop\\data.json";

            // Use 'using' statement for proper resource disposal
            using (Stream stream = new FileStream(path, FileMode.Open))
            {
               
                return JsonSerializer.Deserialize<Product>(stream);
            }
        }
    }
}
