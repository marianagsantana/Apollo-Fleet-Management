// using Models;
// using Repository;

// namespace Controller{

//     public class Client{

//         public static void Create(Client client){
           
//             using (var context = new Context()){
//                 context.Clients.Add(client);
//                 context.SaveChanges();
//             }
//         }
    

//         public static List<Client> Read()
//         {
//             using (var context = new Context())
//             {
//                 return context.Clients.ToList();
//             }
//         }

//         public static Client ReadById(int id)
//         {
//             using (var context = new Context())
//             {
//                 var client = context.Clients.Find(id);
//                 if (client == null)
//                 {
//                     throw new ArgumentException("Cliente não encontrado");
//                 }
//                 else
//                 {
//                     return (Client) client;
//                 }
//             }

//         }

//         public static void Update(Client client)
//         {
//             using (var context = new Context())
//             {
//                 context.Clients.Update(client);
//                 context.SaveChanges();
//             }
//         }
//         public static void Delete(Client client)
//         {
//             using (var context = new Context())
//             {
//                 context.Clients.Remove(client);
//                 context.SaveChanges();
//             }
//         }
        
//     }
// }