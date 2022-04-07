﻿using System.Collections.Generic;
using EventSourcing.API.Dtos;
using MediatR;

namespace EventSourcing.API.Queries
{
    public class GetProductAllListByUserIdQuery : IRequest<List<ProductDto>>
    {
        public int UserId { get; set; }
    }
}