using RestWithASPNETUdemy.Data.Converter.Implementation;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new Converter();
        }

        public List<PersonVO> FindAll()
        {

            return _repository.FindAll();
        }

        public PersonVO FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public PersonVO Create(PersonVO person)
        {
            return _repository.Create(person);
        }
        public PersonVO Update(PersonVO person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);

        }
    }
}
