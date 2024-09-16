using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public List<Image> Images { get; set; }

        public List<Comment>? Comments { get; set; }
    }
}
