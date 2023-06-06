using Models;
using Repository;


namespace Controller{

    public class Model{
            
        public static void Create(Model model){
        
            using (var context = new Context()){
                context.Models.Add(model);
                context.SaveChanges();
            }
        }
    

        public static List<Model> Read()
        {
            using (var context = new Context())
            {
                return context.Models.ToList();
            }
        }

        public static Model ReadById(int id)
        {
            using (var context = new Context())
            {
                var model = context.Models.Find(id);
                if (model == null)
                {
                    throw new ArgumentException("Modelo não encontrado");
                }
                else
                {
                    return (Model) model;
                }
            }

        }

        public static void Update(Model model)
        {
            using (var context = new Context())
            {
                context.Models.Update(model);
                context.SaveChanges();
            }
        }
        public static void Delete(Model model)
        {
            using (var context = new Context())
            {
                context.Models.Remove(model);
                context.SaveChanges();
            }
        }
                
    }
}