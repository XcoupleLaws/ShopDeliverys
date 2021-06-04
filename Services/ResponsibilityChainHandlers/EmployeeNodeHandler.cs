using Domain.EmployeesDomain;
using Domain.OrderDomain;
using Services.ResponsibilityChainHandlers;

namespace Services.ChainHandlers
{
    public class EmployeeNodeHandler : ChainNodeHandler
    {
        public EmployeeNodeHandler(EmployeeModel employee)
        {
            ProcessingInstance = employee;
        }

        public override OrderModel ProcessOrder(OrderModel order)
        {
            ProcessingInstance.ProcessOrder(order);
            return NextNodeHandler != null
                ? NextNodeHandler.ProcessOrder(order)
                : order;
        }
    }
}