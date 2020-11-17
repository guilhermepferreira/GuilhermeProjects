using Primeiro.Model;
using Primeiro.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Primeiro.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private MySqlContext _context;

        public PersonServiceImplementation(MySqlContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try{
                _context.Add(person);
                _context.SaveChanges();
            } catch (Exception ex) {
                throw ex;
            }

            return person;
        }

        public void Delete(long id)
        {
            var personResult = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            if (personResult != null)
            {
                try
                {
                    _context.Remove(personResult);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Update(Person person)
        {
            if (!Exists(person.Id)) return new Person();
            var personResult = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));
            if(personResult!=null)
            {
                try
                {
                    _context.Entry(personResult).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return person;
        }

        private bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
