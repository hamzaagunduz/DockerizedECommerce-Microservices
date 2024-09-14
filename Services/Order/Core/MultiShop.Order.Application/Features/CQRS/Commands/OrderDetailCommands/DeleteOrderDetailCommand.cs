using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands
{
    public class DeleteOrderDetailCommand
    {
        public DeleteOrderDetailCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
