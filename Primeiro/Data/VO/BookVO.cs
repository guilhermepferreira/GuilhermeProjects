using System.Text.Json.Serialization;

namespace Primeiro.Model
{


    public class BookVO
    {
       
        public long Id { get; set; }
        
        public string Title { get; set; }

        public decimal Price { get; set; }

        public string Type { get; set; }

        public string Author { get; set; }
    }
}
