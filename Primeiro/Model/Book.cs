using Primeiro.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro.Model
{
    [Table("books")]

    public class Book : BaseEntity
    {
        [Column("title")]
        public string Title { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Column("author")]
        public string Author { get; set; }
    }
}
