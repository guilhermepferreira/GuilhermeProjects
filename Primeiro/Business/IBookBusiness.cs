using System.Collections.Generic;
using Primeiro.Model;

namespace Primeiro.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO person);
        BookVO Update(BookVO person);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        void Delete(long id);
    }
}
