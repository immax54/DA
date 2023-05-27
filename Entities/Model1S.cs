using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace informationSystem.Entities
{
    public partial class Model1S : DbContext
    {
        public Model1S()
            : base("name=Model1S")
        {
        }

        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderProduct> OrderProduct { get; set; }
        public virtual DbSet<PickupPoint> PickupPoint { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(e => e.OrderPickupPoint)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderProduct)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PickupPoint>()
                .Property(e => e.PickupPointId)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PickupPoint>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.PickupPoint)
                .HasForeignKey(e => e.OrderPickupPoint);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderProduct)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.UserRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Order)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.OrderClient)
                .WillCascadeOnDelete();
        }
    }
}
