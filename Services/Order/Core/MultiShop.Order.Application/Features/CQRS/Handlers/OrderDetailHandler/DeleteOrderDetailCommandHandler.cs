﻿using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandler
{
    public class DeleteOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public DeleteOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(DeleteOrderDetailCommand command)
        {
            var value = await _repository.GetByIdAsync(command.id);
            await _repository.DeleteAsync(value);

        }
    }
}
