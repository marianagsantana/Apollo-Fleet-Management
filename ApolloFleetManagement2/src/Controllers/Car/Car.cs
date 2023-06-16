// using Models;
// using Repository;


// namespace Controller{

//     public class Car{
        
//         public static void Create(Car car){
           
//             using (var context = new Context()){
//                 context.Cars.Add(car);
//                 context.SaveChanges();
//             }
//         }
    

//         public static List<Car> Read()
//         {
//             using (var context = new Context())
//             {
//                 return context.Cars.ToList();
//             }
//         }

//         public static Car ReadById(int id)
//         {
//             using (var context = new Context())
//             {
//                 var car = context.Cars.Find(id);
//                 if (car == null)
//                 {
//                     throw new ArgumentException("Carro não encontrado");
//                 }
//                 else
//                 {
//                     return (Car) car;
//                 }
//             }

//         }

//         public static void Update(Car car)
//         {
//             using (var context = new Context())
//             {
//                 context.Cars.Update(car);
//                 context.SaveChanges();
//             }
//         }
//         public static void Delete(Car car)
//         {
//             using (var context = new Context())
//             {
//                 context.Cars.Remove(car);
//                 context.SaveChanges();
//             }
//         }
        
//     }

// }