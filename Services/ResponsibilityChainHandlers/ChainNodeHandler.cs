using Domain.EmployeesDomain;
using Domain.OrderDomain;

namespace Services.ResponsibilityChainHandlers
{
    public abstract class ChainNodeHandler
    {
        public EmployeeModel ProcessingInstance { get; set; }
        protected ChainNodeHandler NextNodeHandler { get; set; }

        public ChainNodeHandler SetNextHandler(ChainNodeHandler nodeHandler)
        {
            NextNodeHandler = nodeHandler;
            return nodeHandler;
        }

        public abstract OrderModel ProcessOrder(OrderModel order);
    }
}