using Core.DataAccess.Concrete;
using DAL.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.Ef
{
    public class EfTravelCostDal : BaseRepository<TravelCost, CNBlogContext>, ITravelCostDal
    {
    }
}
