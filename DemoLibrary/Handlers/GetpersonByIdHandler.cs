﻿using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetpersonByIdHandler : IRequestHandler<GetpersonByIdQuery, PersonModel>
    {
        private readonly IMediator _mediator;

        public GetpersonByIdHandler(IMediator mediator)
        {
            this._mediator = mediator;
        }
        public async Task<PersonModel> Handle(GetpersonByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetPersonListQuery());

            var output = result.FirstOrDefault(x => x.Id == request.Id);

            return output;
        }
    }
}