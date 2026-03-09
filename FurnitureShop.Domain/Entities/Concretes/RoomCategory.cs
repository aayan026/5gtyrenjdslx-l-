namespace FurnitureShop.Domain.Entities.Concretes
{
    public class RoomCategory:Category
    {
        public ICollection<Collection> Collections { get; set; }

    }
}