using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands
{
    public class DeleteAddressCommand
    {
        public DeleteAddressCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
