using System.Collections.Generic;
using Domain.GoodsDomain;

namespace Services.Abstractions
{
    public interface IGoodsService
    {
	    List<GoodsModel> GetAll();
    }
}