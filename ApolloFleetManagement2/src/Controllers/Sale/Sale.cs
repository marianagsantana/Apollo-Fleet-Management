// using Models;
// using Repository;


// namespace Controller{

//     public class Sale{
        
//         public static void Create(Sale sale){
        
//             using (var context = new Context()){
//                 context.Sales.Add(Sale sale);
//                 context.SaveChanges();
//             }
//         }
    

//         public static List<Sale> Read()
//         {
//             using (var context = new Context())
//             {
//                 return context.Sales.ToList();
//             }
//         }

//         public static Sale ReadById(int id)
//         {
//             using (var context = new Context())
//             {
//                 var sale = context.Sales.Find(id);
//                 if (sale == null)
//                 {
//                     throw new ArgumentException("Venda não encontrada");
//                 }
//                 else
//                 {
//                     return (Sale) sale;
//                 }
//             }

//         }

//         public static void Update(Sale sale)
//         {
//             using (var context = new Context())
//             {
//                 context.Sales.Update(sale);
//                 context.SaveChanges();
//             }
//         }
//         public static void Delete(Sale sale)
//         {
//             using (var context = new Context())
//             {
//                 context.Sales.Remove(sale);
//                 context.SaveChanges();
//             }
//         }
            
//     }
// }