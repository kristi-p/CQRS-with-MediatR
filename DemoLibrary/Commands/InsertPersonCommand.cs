using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Commands
{
    public record InsertPersonCommand(string firstname, string lastName) : IRequest<PersonModel>;

    // The record syntax simplifies the declaration of a whole class
    //public class InsertPersonCommandClass
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    public InsertPersonCommandClass(string firstname, string lastName)
    //    {
    //        FirstName = firstname;
    //        LastName = lastName;
    //    }
    //}
}
