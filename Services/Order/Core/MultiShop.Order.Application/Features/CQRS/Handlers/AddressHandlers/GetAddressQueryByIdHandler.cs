using MultiShop.Order.Application.Features.CQRS.Queries.AddressQueries;
using MultiShop.Order.Application.Features.CQRS.Results.AddressResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressQueryByIdHandler
    {
        readonly IRepository<Address> _repository;

        public GetAddressQueryByIdHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task<GetAddressQueryByIdResult> Handle(GetAddressQueryById getAddressQueryById)
        {
            var value = await _repository.GetByIdAsync(getAddressQueryById.id);
            return new GetAddressQueryByIdResult
            {
                AddressId = value.AddressId,
                City = value.City,
                Detail=value.Detail1,
                District = value.District,
                UserId = value.UserId,
               
            };
        }
    }
}
