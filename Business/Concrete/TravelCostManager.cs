using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.Aspects.Autofac.Validation.FluentValidation;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete;
using DAL.Abstract;
using DAL.Concrete.Ef;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TravelCostManager : ITravelCostService
    {
        private readonly ITravelCostDal _travelCostDal;
        public TravelCostManager(ITravelCostDal travelCostDal)
        {
            _travelCostDal = travelCostDal ?? throw new ArgumentNullException(nameof(travelCostDal));
        }

        [ValidationAspect<TravelCost>(typeof(TravelCostValidator))]
        public IResult Add(TravelCost travelCost)
        {
            _travelCostDal.Add(travelCost);
            return new SuccessResult("travelCost elave olundu");
        }

        public IResult Delete(TravelCost travelCost)
        {
            TravelCost deleteTravelCost = null;
            TravelCost resultTravelCost = _travelCostDal.Get(p => p.IsDelete == false && p.Id == travelCost.Id);
            if (resultTravelCost != null)
                deleteTravelCost = resultTravelCost;
            deleteTravelCost.IsDelete = true;
            _travelCostDal.Delete(deleteTravelCost);
            return new SuccessResult();

        }

        public IDataResult<List<TravelCost>> GetAllTravelCosts()
        {
            var travelCosts = _travelCostDal.GetAll(p => p.IsDelete == false).ToList();
            if (travelCosts.Count > 0)
                return new SuccessDataResult<List<TravelCost>>(travelCosts);
            else return new ErrorDataResult<List<TravelCost>>("xeta bash verdi");
        }

        public IDataResult<TravelCost> GetTravelCost(TravelCost travelCost)
        {
            TravelCost getTravelCost = _travelCostDal.Get(p => p.Id == travelCost.Id);

            return new SuccessDataResult<TravelCost>(travelCost, "get travelCost loaded");
        }

        public IResult Update(TravelCost travelCost)
        {
            TravelCost updateTravelCost;
            updateTravelCost = _travelCostDal.Get(p => p.Id == travelCost.Id && p.IsDelete == false);
            updateTravelCost.Description = travelCost.Description;
            updateTravelCost.Title = travelCost.Title;
            _travelCostDal.Update(travelCost);
            return new SuccessResult();
        }
    }
}
