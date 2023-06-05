using Models;
using MyProject.Data;

namespace Controller{

    public class Document{
            
        public static void Create(Document document){
        
            using (var context = new Context()){
                context.Documents.Add(document);
                context.SaveChanges();
            }
        }
    

        public static List<Document> Read()
        {
            using (var context = new Context())
            {
                return context.Documents.ToList();
            }
        }

        public static Document ReadById(int id)
        {
            using (var context = new Context())
            {
                var document = context.Documents.Find(id);
                if (document == null)
                {
                    throw new ArgumentException("Documento não encontrado");
                }
                else
                {
                    return (Document) document;
                }
            }

        }

        public static void Update(Document document)
        {
            using (var context = new Context())
            {
                context.Documents.Update(document);
                context.SaveChanges();
            }
        }
        public static void Delete(Document document)
        {
            using (var context = new Context())
            {
                context.Documents.Remove(document);
                context.SaveChanges();
            }
        }
            
    }
}