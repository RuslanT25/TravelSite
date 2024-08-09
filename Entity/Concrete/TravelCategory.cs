using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class TravelCategory : BaseEntity
    {
        public int TravelId { get; set; }
        public Travel Travel { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
