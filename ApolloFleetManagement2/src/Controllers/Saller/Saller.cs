// using Models;
// using Repository;


// namespace Controller{

//     public class Saller{
        
//         public static void Create(Saller saller){
        
//             using (var context = new Context()){
//                 context.Sallers.Add(saller);
//                 context.SaveChanges();
//             }
//         }
    

//         public static List<Saller> Read()
//         {
//             using (var context = new Context())
//             {
//                 return context.Sallers.ToList();
//             }
//         }

//         public static Saller ReadById(int id)
//         {
//             using (var context = new Context())
//             {
//                 var saller = context.Sallers.Find(id);
//                 if (saller == null)
//                 {
//                     throw new ArgumentException("Vendedor não encontrado");
//                 }
//                 else
//                 {
//                     return (Saller) saller;
//                 }
//             }

//         }

//         public static void Update(Saller saller)
//         {
//             using (var context = new Context())
//             {
//                 context.Sallers.Update(saller);
//                 context.SaveChanges();
//             }
//         }
//         public static void Delete(Saller saller)
//         {
//             using (var context = new Context())
//             {
//                 context.Sallers.Remove(saller);
//                 context.SaveChanges();
//             }
//         }
        
//     }
// }
