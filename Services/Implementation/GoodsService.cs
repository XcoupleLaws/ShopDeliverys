using System.Collections.Generic;
using System.Linq;
using DAL.UnitOfWork;
using Domain.GoodsDomain;
using Mappers;
using Services.Abstractions;

namespace Services.Implementation
{
    public class GoodsService: IGoodsService
    {
	    
	   private readonly IUnitOfWork _unitOfWork;
	   
        private readonly GoodsMapper _goodsMapper;
        public GoodsService(IUnitOfWork unitOfWork,GoodsMapper goodsMapper)
        {
	        _goodsMapper = goodsMapper;
	        _unitOfWork  = unitOfWork;
        }
        
        public List<GoodsModel> GetAll() =>
	        _unitOfWork.Goods.GetAll()
                .Select(goods => _goodsMapper.ToModel(goods))
                .ToList();

    }
}