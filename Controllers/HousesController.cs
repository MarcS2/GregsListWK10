
using GregsListWk10.Models;
using GregsListWk10.Services;

namespace GregsListWk10.Controllers;
[ApiController]
[Route("api/[controller]")]

public class HousesController : ControllerBase
{
    private readonly HousesService _housesService;

    public HousesController(HousesService housesService)
    {
        _housesService = housesService;
    }

    [HttpGet]
    public ActionResult<List<House>> GetHouses()
    {
        try
        {
            List<House> houses = _housesService.GetHouses();
            return Ok(houses);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }
}