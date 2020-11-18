using Primeiro.Data.Converter.Contract;
using Primeiro.Data.VO;
using Primeiro.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Primeiro.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;
            return new Book
            {
                Id = origin.Id,
                Title = origin.Title,
                Price = origin.Price,
                Type = origin.Type,
                Author = origin.Author
            };
        }
        public BookVO Parse(Book origin)
        {
            if (origin == null) return null;
            return new BookVO
            {
                Id = origin.Id,
                Title = origin.Title,
                Price = origin.Price,
                Type = origin.Type,
                Author = origin.Author
            };
        }
        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
        public List<BookVO> Parse(List<Book> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
