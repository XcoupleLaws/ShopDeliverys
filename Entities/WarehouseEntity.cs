namespace Entities
{
    public class WarehouseEntity : IEntity
    {
        public int Id { get; set; }

        public int RelativeDistance { get; set; }
        public string CompanyName { get; set; }
    }
}