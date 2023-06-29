
namespace BurgerApp.DataAccess.DataContext
{
    using BurgerApp.Domain.Enums;
    using BurgerApp.Domain.Models;
    using Microsoft.EntityFrameworkCore;

    public class BurgerAppDbContext : DbContext
    {
        public BurgerAppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {

        }

        public DbSet<Burger> Burgers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Burger>()
                .HasMany(x => x.BurgerOrders)
                .WithOne(x => x.Burger)
                .HasForeignKey(x => x.BurgerId);

            modelBuilder.Entity<Order>()
                .HasMany(x => x.BurgerOrders)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);

            modelBuilder.Entity<Burger>()
                .HasData(new Burger()
                {
                    Id = 1,
                    Name = "Classic Burger",
                    Price = 140,
                    IsVegetarian = false,
                    IsVegan = false,
                    HasFries = true,
                },
                new Burger()
                {
                    Id = 2,
                    Name = "CheeseBurger",
                    Price = 150,
                    IsVegetarian = false,
                    IsVegan = false,
                    HasFries = true,
                },
                new Burger()
                {
                    Id = 3,
                    Name = "SpicyBurger",
                    Price = 145,
                    IsVegetarian = false,
                    IsVegan = false,
                    HasFries = true,
                },
                new Burger()
                {
                    Id = 4,
                    Name = "VeggieBurger",
                    Price = 180,
                    IsVegetarian = true,
                    IsVegan = true,
                    HasFries = true,
                },
                new Burger()
                {
                    Id = 5,
                    Name = "Vegan Burger",
                    Price = 175,
                    IsVegetarian = false,
                    IsVegan = true,
                    HasFries = true,
                });

            modelBuilder.Entity<Order>()
                .HasData(new Order()
                {
                    Id = 1,
                    FullName = "Stojadin Stojkov",
                    Address = "Novo Lisice",
                    IsDelivered = true,
                    LocationId = 2
                },
                new Order()
                {
                    Id = 2,
                    FullName = "Tom Kruz",
                    Address = "Aerodrom",
                    IsDelivered = true,
                    LocationId = 1
                },
                new Order()
                {
                    Id = 3,
                    FullName = "Marjanka Marievska",
                    Address = "Karposh 3",
                    IsDelivered = true,
                    LocationId = 3
                },
                new Order()
                {
                    Id = 4,
                    FullName = "Yugo Kostov",
                    Address = "Idrizovo zatvor",
                    IsDelivered = false,
                    LocationId = 1
                },
                new Order()
                {
                    Id = 5,
                    FullName = "Petre Petkov",
                    Address = "Taftalidze",
                    IsDelivered = false,
                    LocationId = 3
                });

            modelBuilder.Entity<BurgerOrder>()
                .HasData(new BurgerOrder()
                {
                    Id = 1,
                    BurgerId = 1,
                    OrderId = 1
                },
                new BurgerOrder()
                {
                    Id = 2,
                    BurgerId = 3,
                    OrderId = 1
                },
                new BurgerOrder()
                {
                    Id = 3,
                    BurgerId = 5,
                    OrderId = 3
                },
                new BurgerOrder()
                {
                    Id = 4,
                    BurgerId = 2,
                    OrderId = 2
                });

            modelBuilder.Entity<Location>()
                .HasData(new Location()
                {
                   Id = 1,
                   Name = "Valid Burgers",
                   StoreLocation = StoreAddressEnum.Aerodrom,
                   OpensAt = new TimeSpan(9, 0, 0),
                   ClosesAt = new TimeSpan(21, 0, 0)
                },
                new Location()
                {
                    Id = 2,
                    Name = "Valid Burgers NL",
                    StoreLocation = StoreAddressEnum.NovoLisice,
                    OpensAt = new TimeSpan(9, 0, 0),
                    ClosesAt = new TimeSpan(21, 0, 0)
                },
                new Location()
                {
                    Id = 3,
                    Name = "Valid Burgers Centar",
                    StoreLocation = StoreAddressEnum.Centar,
                    OpensAt = new TimeSpan(8, 0, 0),
                    ClosesAt = new TimeSpan(23, 0, 0)
                });

        }




    }
}
