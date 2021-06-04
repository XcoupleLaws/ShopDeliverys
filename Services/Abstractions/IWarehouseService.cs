using System.Collections.Generic;
using Domain.WarehouseDomain;

namespace Services.Abstractions
{
    public interface IWarehouseService
    { 
	    List<WarehouseModel> GetAll();
    }
}