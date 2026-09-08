
using Asp.Versioning;
using ice_city.DTOs.REGUEST;
using IceCity.DTOs;
using IceCity.EFCore.Entities;
using IceCity2.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security;

namespace ice_city.Controllers;

[ApiController]
[ApiVersion(1.0)]
[Route("api/v{version:apiVersion}/sensors")]
[Authorize]

public class SensorReadingsController: ControllerBase
{
    private readonly ISensorService _sensorService;
    private readonly ICostService _costService;
    public SensorReadingsController(ISensorService sensorService, ICostService costService)
    {
        _sensorService = sensorService;
        _costService = costService;
    }
    [HttpPost("readings")]
    [MapToApiVersion("1.0")]
    
    [Consumes("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status403Forbidden)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status404NotFound)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status500InternalServerError)]

    public async Task<IActionResult> AddReading([FromBody] AddSensorReadingRequest request, CancellationToken cancellationToken)
    {
        var response = await _sensorService.AddReadingAsync(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet("{houseId}/cost")]
    [MapToApiVersion("1.0")]

    [Consumes("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status403Forbidden)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status404NotFound)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status500InternalServerError)]


    public async Task<IActionResult> GetHouseCost(
    Guid houseId,
    CancellationToken cancellationToken)
    {
        var result = await _costService.GetHouseCostAsync(
            houseId,
            cancellationToken);

        return Ok(result);
    }

}
   

