namespace FormsApp.Models{
    public class Repository{
        private static readonly List<Product> _products = new(); //verileri gizliye alır.
        private static readonly List<Category> _categories = new();

        static Repository(){
            _categories.Add(new Category{CategoryId = 1, Name = "Telefon"});
            _categories.Add(new Category{CategoryId = 2, Name = "Bilgisayar"});

            _products.Add(new Product{Id= 1, Name = "Iphone 15", Price=40000, Stock= 50});
            _products.Add(new Product{Id= 2, Name = "Iphone 15 Pro Max", Price=80000, Stock= 20});
            _products.Add(new Product{Id= 3, Name = "Macbook Air", Price=20000, Stock= 100});
            _products.Add(new Product{Id= 4, Name = "Macbook Pro", Price=50000, Stock= 49});
        }
        public static List<Product> Products{get{return _products;}} //verileri görmeyi ama dışarıdan müdahale etmeyi engeller.
        public static void CreateProduct(Product entity){
            _products.Add(entity);
        }        
        public static List<Category> Categories{get{return _categories;}}
 

    }
}