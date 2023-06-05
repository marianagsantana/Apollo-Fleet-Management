using Models;
using MyProject.Data;

namespace Controller{

    public class Brand{
            
        public static void Create(Brand brand){
        
            using (var context = new Context()){
                context.Brands.Add(brand);
                context.SaveChanges();
            }
        }
    

        public static List<Brand> Read()
        {
            using (var context = new Context())
            {
                return context.Brands.ToList();
            }
        }

        public static Brand ReadById(int id)
        {
            using (var context = new Context())
            {
                var brand = context.Brands.Find(id);
                if (brand == null)
                {
                    throw new ArgumentException("Marca não encontrada");
                }
                else
                {
                    return (Brand) brand;
                }
            }

        }

        public static void Update(Brand brand)
        {
            using (var context = new Context())
            {
                context.Brands.Update(brand);
                context.SaveChanges();
            }
        }
        public static void Delete(Brand brand)
        {
            using (var context = new Context())
            {
                context.Brands.Remove(brand);
                context.SaveChanges();
            }
        }
                    
    }
}