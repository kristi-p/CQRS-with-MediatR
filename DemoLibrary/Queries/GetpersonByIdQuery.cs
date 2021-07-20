using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Queries
{
    public record GetpersonByIdQuery(int Id) : IRequest<PersonModel>;

    // The record syntax simplifies the declaration of a whole class
    //public class GetpersonByIdQueryClass : IRequest<PersonModel>
    //{
    //    public int Id { get; set; }
    //    public GetpersonByIdQueryClass(int id)
    //    {
    //        Id = id;
    //    }
    //}
}

//namespace System.Runtime.CompilerServices
//{
//    internal static class IsExternalInit { }
//}