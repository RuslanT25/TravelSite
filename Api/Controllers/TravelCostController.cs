using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelCostController : ControllerBase
    {
        private readonly ITravelCostService _travelCostService;

        public TravelCostController(ITravelCostService travelCostService)
        {
            _travelCostService = travelCostService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _travelCostService.GetAllTravelCosts();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost]
        public IActionResult Add(TravelCost entity)
        {
            var result = _travelCostService.Add(entity);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        } 
    }
}
