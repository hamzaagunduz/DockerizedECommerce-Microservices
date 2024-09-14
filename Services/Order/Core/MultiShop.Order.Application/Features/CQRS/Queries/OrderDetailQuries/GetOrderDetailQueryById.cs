using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Queries.OrderDetailQuries
{
    public class GetOrderDetailQueryById
    {
        public GetOrderDetailQueryById(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
