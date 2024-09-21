using BlackbirdStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BlackbirdStore.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options): base(options){ }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductsOrderDetail> ProductsOrderDetails { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(a=>a.Address)
                .WithMany(u=>u.Users)
                .HasForeignKey(a=>a.AddressId);

            modelBuilder.Entity<User>()
                .HasOne(o=>o.Order)
                .WithMany(u=>u.Users)
                .HasForeignKey(o=>o.OrderId);

            modelBuilder.Entity<Order>()
                .HasOne(od=>od.OrderDetail)
                .WithMany(o=>o.Orders)
                .HasForeignKey(od=>od.OrderId);
        }
    }
}