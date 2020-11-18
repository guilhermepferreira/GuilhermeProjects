using System.ComponentModel.DataAnnotations.Schema;

namespace Primeiro.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
