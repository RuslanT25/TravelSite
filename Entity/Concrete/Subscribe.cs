using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Subscribe : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
