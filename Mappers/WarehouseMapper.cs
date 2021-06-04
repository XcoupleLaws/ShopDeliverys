using Domain.WarehouseDomain;
using Entities;

namespace Mappers
{
    public class WarehouseMapper
    {
        public WarehouseEntity ToEntity(WarehouseModel warehouse)
        {
            return new WarehouseEntity
            {
                Id = warehouse.Id,
                RelativeDistance = warehouse.Distance,
                CompanyName = warehouse.Name
            };
        }

        public WarehouseModel ToModel(WarehouseEntity warehouse)
        {
            return new WarehouseModel
            {
                Id = warehouse.Id,
                Distance = warehouse.RelativeDistance,
                Name = warehouse.CompanyName
            };
        }
    }
}