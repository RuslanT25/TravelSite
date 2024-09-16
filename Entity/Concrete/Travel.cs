using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Travel : BaseEntity
    {
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public List<TravelCategory> TravelCategories { get; set; }

        public List<Image> Images { get; set; }

        public List<Article> Articles { get; set; }

        public List<TravelCost> TravelCosts { get; set; }
    }
}
