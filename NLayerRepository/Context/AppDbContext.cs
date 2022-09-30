using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;

namespace NLayerRepository.Context
{
    public class AppDbContext:DbContext
    {
        // DbContext bir classtır ve Entity Framework’un olmazsa olmazıdır.
        // DBContet veritabanımızla uygulamamız arasında sorgulama, güncelleme, silme 
        // gibi işlemleri yapmamız için olanak sağlar. 
        // Yani veritabanı içinde yer alan verilerimizle alakalı olarak her türlü süreçte 
        // iletişimimizi sağlayan bir classtır.
        // DbContext bize ne sağlar?Database bağlantısının yönetimi,Modellerimiz ve database ilişkilerinin yönetimi,
        // Database sorguları yönetimi,Database veri kaydetme işlemleri,Değişikliklerin izlenebilmesi,
        // Transaction (işlem) yönetimi,Caching (Önbellek işlemleri)
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {}
        public Dbset<Product> Products { get; set; } 
        public DbSet<Category> Categories { get; set; }      
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}