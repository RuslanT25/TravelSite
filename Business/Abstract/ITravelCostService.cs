using Core.Helpers.Results.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITravelCostService
    {
        IResult Add(TravelCost travelCost);
        IResult Update(TravelCost travelCost);
        IResult Delete(TravelCost travelCost);
        IDataResult<List<TravelCost>> GetAllTravelCosts();
        IDataResult<TravelCost> GetTravelCost(TravelCost travelCost);
    }
}
