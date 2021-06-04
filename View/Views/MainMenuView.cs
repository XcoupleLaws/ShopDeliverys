using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.GoodsDomain;
using Domain.WarehouseDomain;
using View.Abstractions;
using View.Abstractions.ViewAbstractions;
using View.Presenters;
using View.Views;

namespace View
{
    public partial class MainMenuView : Form , IMainView
    {
        public event EventHandler OrderOptionsMenuSelected = delegate { };
        public event EventHandler OrderInfoMenuSelected = delegate { };

        public List<GoodsModel> SelectedGoods { get; set; } = new();
        public WarehouseModel SelectedWarehouse { get; set; }

        
        public MainMenuView()
        {
            InitializeComponent();
        }

        private void OrderComponentsBtnClick(object sender, EventArgs args)
        {
            var optionsMenuView = new OrderOptionsView(this);
            ChangeMainUserControl(optionsMenuView);
            
            OrderOptionsMenuSelected.Invoke(optionsMenuView, new EventArgs());
        }

        private void OrderInfoMenuBtnClick(object sender, EventArgs args)
        {
            var infoMenuView = new OrderInfoView(this);
            ChangeMainUserControl(infoMenuView);

            OrderInfoMenuSelected.Invoke(infoMenuView, new EventArgs());
        }

        private void ChangeMainUserControl(UserControl control)
        {
            DisposeMainPanelControls();
            mainPanel.Controls.Add(control);
        }

        private void DisposeMainPanelControls()
        {
            foreach (Control control in mainPanel.Controls)
            {
                control.Dispose();
            }
        }

        private void orderOptionsBtn_Click(object sender, EventArgs e)
        {
            OrderComponentsBtnClick(sender,e);
        }

        private void orderInfoBtn_Click(object sender, EventArgs e)
        {
            OrderInfoMenuBtnClick(sender,e);
        }
    }
}