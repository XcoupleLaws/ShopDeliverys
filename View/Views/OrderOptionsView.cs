using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Domain.GoodsDomain;
using Domain.WarehouseDomain;
using View.Abstractions;
using View.Abstractions.ViewAbstractions;

namespace View.Views
{
    public class OrderOptionsView : UserControl, IOrderOptionsView
    {
        public event EventHandler DataRequested;

        private MainMenuView ParentView { get; set; }
        

        public OrderOptionsView(MainMenuView parentView)
        {
            InitializeComponent();
            ParentView = parentView;
        }


        public void UpdateChanges()
        {
            Refresh();
        }

        public void ShowAllWarehouses(List<WarehouseModel> warehouses)
        {
            warehousesClb.DataSource = warehouses;
            warehousesClb.Size = warehousesClb.PreferredSize;

        }

        public void ShowAllGoods(List<GoodsModel> goods)
        {
            goodsClb.DataSource = goods;
            goodsClb.Size = goodsClb.PreferredSize;
        }

        public void PresenterCreated()
        {
            DataRequested.Invoke(this, EventArgs.Empty);
        }

        public void SetSelectedGoods(List<GoodsModel> goods)
        {
            ParentView.SelectedGoods.AddRange(goods);
        }

        public void SetSelectedWarehouse(WarehouseModel warehouse)
        {
            ParentView.SelectedWarehouse = warehouse;
        }

        private void RefreshBtnClick(object sender, EventArgs args)
        {
            DataRequested.Invoke(this, new EventArgs());
        }

        private void AddGoodsBtnClick(object sender, EventArgs args)
        {
            var selectedGoods = new List<GoodsModel>(goodsClb.CheckedItems.Cast<GoodsModel>());
            SetSelectedGoods(selectedGoods);
        }

        private void AddWarehouseBtnClick(object sender, EventArgs args)
        {
            var selectedWarehouse = warehousesClb.SelectedItem as WarehouseModel;
            SetSelectedWarehouse(selectedWarehouse);
        }

        private void InitializeComponent()
        {
            goodsLbl = new Label();
            goodsClb = new CheckedListBox();
            warehousesLbl = new Label();
            warehousesClb = new CheckedListBox();
            refreshBtn = new Button();
            addGoodsBtn = new Button();
            warehouseSelectionBtn = new Button();
            SuspendLayout();
            // 
            // goodsLbl
            // 
            goodsLbl.AutoSize = true;
            goodsLbl.Location = new System.Drawing.Point(10, 5);
            goodsLbl.Margin = new Padding(4, 0, 4, 0);
            goodsLbl.Name = "goodsLbl";
            goodsLbl.Size = new System.Drawing.Size(59, 13);
            goodsLbl.TabIndex = 12;
            goodsLbl.Text = "Our goods:";
            // 
            // goodsClb
            // 
            goodsClb.FormattingEnabled = true;
            goodsClb.Location = new System.Drawing.Point(9, 31);
            goodsClb.Name = "goodsClb";
            goodsClb.Size = new System.Drawing.Size(300, 79);
            goodsClb.TabIndex = 16;
            goodsClb.AutoSize = true;
            // 
            // warehousesLbl
            // 
            warehousesLbl.AutoSize = true;
            warehousesLbl.Location = new System.Drawing.Point(9, 160);
            warehousesLbl.Margin = new Padding(4, 0, 4, 0);
            warehousesLbl.Name = "warehousesLbl";
            warehousesLbl.Size = new System.Drawing.Size(139, 13);
            warehousesLbl.TabIndex = 14;
            warehousesLbl.Text = "Choose one of warehouses:";
            // 
            // warehousesClb
            // 
            warehousesClb.FormattingEnabled = true;
            warehousesClb.Location = new System.Drawing.Point(17, 188);
            warehousesClb.Name = "warehousesClb";
            warehousesClb.Size = new System.Drawing.Size(300, 79);
            warehousesClb.TabIndex = 15;
            warehousesClb.SelectionMode = SelectionMode.One;
            warehousesClb.AutoSize = true;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new System.Drawing.Point(135, 341);;
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new System.Drawing.Size(75, 23);
            refreshBtn.TabIndex = 18;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += RefreshBtnClick;
            // 
            // addGoodsBtn
            // 
            addGoodsBtn.Location = new System.Drawing.Point(450, 44);
            addGoodsBtn.Margin = new Padding(4);
            addGoodsBtn.Name = "addGoodsBtn";
            addGoodsBtn.Size = new System.Drawing.Size(170, 34);
            addGoodsBtn.TabIndex = 13;
            addGoodsBtn.Text = "Add selected to order";
            addGoodsBtn.UseVisualStyleBackColor = true;
            addGoodsBtn.Click += AddGoodsBtnClick;
            // 
            // warehouseSelectionBtn
            // 
            warehouseSelectionBtn.Location = new System.Drawing.Point(350, 188);
            warehouseSelectionBtn.Margin = new Padding(4);
            warehouseSelectionBtn.Name = "warehouseSelectionBtn";
            warehouseSelectionBtn.Size = new System.Drawing.Size(170, 34);
            warehouseSelectionBtn.TabIndex = 19;
            warehouseSelectionBtn.Text = "Set order warehouse";
            warehouseSelectionBtn.UseVisualStyleBackColor = true;
            warehouseSelectionBtn.Click += AddWarehouseBtnClick;
            // 
            // orderOptionsMenuView
            // 
            Controls.Add(warehouseSelectionBtn);
            Controls.Add(goodsLbl);
            Controls.Add(goodsClb);
            Controls.Add(warehousesLbl);
            Controls.Add(warehousesClb);
            Controls.Add(refreshBtn);
            Controls.Add(addGoodsBtn);
            Name = "orderOptionsMenuView";
            Size = new System.Drawing.Size(770, 394);
            ResumeLayout(false);
            PerformLayout();
        }
        private Label goodsLbl;
        private CheckedListBox goodsClb;
        private Button processOrderBtn;
        private Label warehousesLbl;
        private CheckedListBox warehousesClb;
        private Button refreshBtn;
        private Button addGoodsBtn;
        private Button warehouseSelectionBtn;
    }
}