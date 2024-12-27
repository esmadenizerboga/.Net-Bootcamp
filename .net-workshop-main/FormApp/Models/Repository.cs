namespace FormApp.Models{

    public class Repository{

        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository(){
            _categories.Add(new Category{CategoryId = 1, Name = "Telefon"});
            _categories.Add(new Category{CategoryId = 2, Name = "Bilgisayar"});

            _products.Add(new Product{ProductId = 1, Name = "Iphone 16", Price = 100000, IsActive = true, Image = "3.jpg",CategoryId = 1});
            _products.Add(new Product{ProductId = 2, Name = "Iphone 15", Price = 80000, IsActive = true, Image = "4.jpg",CategoryId = 1});
            _products.Add(new Product{ProductId = 3, Name = "Macbook", Price = 80000, IsActive = true, Image = "1.jpg",CategoryId = 2});
            _products.Add(new Product{ProductId = 4, Name = "Macbook Air", Price = 90000, IsActive = true, Image = "2.jpeg",CategoryId = 2});
        }
        public static List<Product> Products{
            get{
                return _products;
            }
        }

        public static void CreateProduct(Product entity){
            _products.Add(entity);
        }
        public static void EditProduct(Product updateProduct){
            var entity = _products.FirstOrDefault(p=>p.ProductId == updateProduct.ProductId);

            if(entity != null){
                entity.Name = updateProduct.Name;
                entity.Price = updateProduct.Price;
                entity.Image = updateProduct.Image;
                entity.IsActive = updateProduct.IsActive;
                entity.CategoryId = updateProduct.CategoryId;
            }
        }

        public static void DeleteProduct(Product entity){
            var Prdentity = _products.FirstOrDefault(p=>p.ProductId == entity.ProductId);

            if(Prdentity != null){
                _products.Remove(Prdentity);
            }
        }
        public static List<Category> Categories{
            get{
                return _categories;
            }
        }
    }
}