namespace BurgerApp.Domain.Models
{
    public class Order : BaseEntity
    {

        public string FullName { get; set; }

        public string Address { get; set; }

        public bool IsDelivered { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }

        public List<BurgerOrder> BurgerOrders { get; set; } = new List<BurgerOrder>();

    }
}
