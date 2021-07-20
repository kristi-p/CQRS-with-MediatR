using DemoLibrary.Models;
using MediatR;
using System.Collections.Generic;

namespace DemoLibrary.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;

    // The record syntax simplifies the declaration of a whole class
    //public class GetPersonListQueryClass : IRequest<List<PersonModel>>;
    //{

    //}
}