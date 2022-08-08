﻿using MediatR;
using System;
using System.Collections.Generic;

namespace Ordering.Application.Features.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQuery : IRequest<List<OrderVm>>
    {
        public string UserName { get; set; }

        public GetOrdersListQuery(string username)
        {
            this.UserName = username ?? throw new ArgumentNullException(nameof(username));
        }
    }
}
