using MicroServicesApp.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace MicroServicesApp.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        
        }
        public DbSet<Coupon> Coupones { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode="10TY",
                DiscountAmount = 3,
                MinAmount=10

            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "20TY",
                DiscountAmount = 5,
                MinAmount = 15
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 3,
                CouponCode="30TY",
                DiscountAmount = 15,
                MinAmount=30
            });
        
        }


    }
}
