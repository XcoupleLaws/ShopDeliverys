using System.Collections.Generic;
using System.Linq;
using DAL.UnitOfWork;
using Domain.WarehouseDomain;
using Mappers;
using Services.Abstractions;

namespace Services.Implementation
{
    public class WarehouseService : IWarehouseService
    {
	    private readonly IUnitOfWork _unitOfWork;
	    
	    private readonly WarehouseMapper _warehouseMapper;
	    
        public WarehouseService(IUnitOfWork unitOfWork, WarehouseMapper warehouseMapper)
        {
            _unitOfWork = unitOfWork;
            
            _warehouseMapper = warehouseMapper;
        }
        public List<WarehouseModel> GetAll()
        {
            return _unitOfWork.Warehouses.GetAll()
                .Select(warehouse => _warehouseMapper.ToModel(warehouse))
                .ToList();
        }

    }
}