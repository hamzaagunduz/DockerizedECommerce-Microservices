using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Queries.AddressQueries
{
    public class GetAddressQueryById
    {
        public GetAddressQueryById(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
