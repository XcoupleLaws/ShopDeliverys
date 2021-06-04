using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Domain.GoodsDomain;
using Domain.OrderDomain;
using Domain.WarehouseDomain;
using View.Abstractions;
using View.Abstractions.ViewAbstractions;

namespace View.Views
{
    public partial class OrderInfoView : UserControl, IOrderInfoUserControl
    {
        public event EventHandler DataRequested = delegate {  };
        public event EventHandler OrderCommitRequested = delegate {  };
        private IMainView ParentView { get; set; }
        public OrderModel PendingOrder { get; set; }

        public OrderInfoView(IMainView parentView)
        {
            InitializeComponent();
            ParentView = parentView;
            Show();
        }


        public void UpdateChanges()
        {
            Refresh();
        }

        private void OrderCommitRaised(object sender, EventArgs args)
        {
            OrderCommitRequested.Invoke(sender,args);
        }
        
        public WarehouseModel GetSelectedWarehouse()
        {
            return ParentView.SelectedWarehouse;
        }

        public List<GoodsModel> GetSelectedGoods()
        {
            return ParentView.SelectedGoods;
        }

        public void ShowOrder(OrderModel order)
        {
            totalCostLbl.Text += order.TotalCost;
            estimateProcessTimeLbl.Text += $"{order.EstimateProcessTime.Days} d. " +
                                           $"{order.EstimateProcessTime.Hours} h. " +
                                           $"{order.EstimateProcessTime.Minutes} m." ;
            estimateProcessTimeLbl.Size = estimateProcessTimeLbl.PreferredSize;
        }
        
        public void PresenterCreated()
        {
            DataRequested.Invoke(this,new EventArgs());
        }
        
        public void ShowAllGoods(List<GoodsModel> goods)
        {
            selectedGoodsLbx.DataSource = goods;
            selectedGoodsLbx.Size = selectedGoodsLbx.PreferredSize;
        }
        
        public void ShowWarehouse(WarehouseModel warehouse)
        {
            selectedWarehouseLbl.Text = $"Name: {warehouse.Name} \n" +
                                         $"Distance: {warehouse.Distance}";
            selectedWarehouseLbl.Size = selectedWarehouseLbl.PreferredSize;
        }

        private void orderSubmit_Click(object sender, EventArgs e)
        {
            OrderCommitRaised(sender, e);
        }
    }
}