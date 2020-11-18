using System.Collections.Generic;
using Primeiro.Data.VO;

namespace Primeiro.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO Update(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        void Delete(long id);
    }
}
