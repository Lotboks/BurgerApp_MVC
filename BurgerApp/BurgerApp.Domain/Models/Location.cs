using BurgerApp.Domain.Enums;

namespace BurgerApp.Domain.Models
{
    public class Location : BaseEntity
    {

        public StoreAddressEnum StoreLocation { get; set; }

        public string Name { get; set; } = string.Empty;

        public TimeSpan OpensAt { get; set; }

        public TimeSpan ClosesAt { get; set; }

    }
}