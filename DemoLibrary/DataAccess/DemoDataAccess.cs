﻿using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new List<PersonModel>();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Name1", LastName = "Lastname1" });
            people.Add(new PersonModel { Id = 2, FirstName = "Name2", LastName = "Lastname2" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPeople(string firstname, string lastname)
        {
            PersonModel p = new PersonModel() { FirstName = firstname, LastName = lastname, Id = people.Max(x => x.Id) + 1 };
            people.Add(p);
            return p;
        }
    }
}
