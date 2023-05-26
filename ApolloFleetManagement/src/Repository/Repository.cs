// using Microsoft.EntityFrameworkCore;

// namespace Repository {
//     public class Context : DbContext {
//         public DbSet<Models.Car> Cars { get; set; }
//         public DbSet<Models.Model Models { get; set; }
//         public DbSet<Models.Brand> Brands { get; set; }
//         public DbSet<Models.Client> Clients { get; set; }
//         public DbSet<Models.Sale> Sales { get; set; }
//         public DbSet<Models.Saller> Sallers { get; set; }
//         public DbSet<Models.Document> Documents { get; set; }
//         public string connection = "Server=localhost;User Id=root;Database=apollofleetmanagement";
//         protected override void OnConfiguring(DbContextOptionsBuilder options)
//             => options.UseMySql(connection, ServerVersion.AutoDetect(connection));
//     }
// }
