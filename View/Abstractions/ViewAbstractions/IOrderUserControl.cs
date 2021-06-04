using System;
using System.Collections.Generic;
using Domain.GoodsDomain;

namespace View.Abstractions.ViewAbstractions
{
    public interface IOrderUserControl
    {
        public event EventHandler DataRequested;
        void UpdateChanges();
        void ShowAllGoods(List<GoodsModel> goods);

    }
}