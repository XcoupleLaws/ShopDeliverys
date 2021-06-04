namespace Domain.WarehouseDomain
{
    public class WarehouseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Distance { get; set; }

        public override string ToString()
        {
            return Id + ") Name: " + Name + " | " +
            " Distance: " + Distance;
        }
    }
}