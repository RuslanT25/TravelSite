using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public List<Image> Images { get; set; }

        public int TravelId { get; set; }
        public Travel Travel { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
