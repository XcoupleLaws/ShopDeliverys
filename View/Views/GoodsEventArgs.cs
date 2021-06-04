using System;
using System.Collections.Generic;
using Domain.GoodsDomain;

namespace View
{
    public class GoodsEventArgs : EventArgs
    {
        public List<GoodsModel> SelectedGoods { get; set; }
    }
}