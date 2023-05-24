using FifaCardApi.Domain.Request;
using FifaCardApi.Service.Services.Interfaces;
using FifaCardApi.Service.Validators;
using Microsoft.AspNetCore.Mvc;

namespace FifaCardApi.Controllers;

[ApiController]
[Route("fifa/card")]
public class CardController : ControllerBase
{
    private readonly ILogger<CardController> _logger;
    private readonly ICardService _cardService;

    public CardController(ILogger<CardController> logger, ICardService cardService)
    {
        _logger = logger;
        _cardService = cardService;
    }

    [HttpGet("get")]
    public IActionResult GetPlayerCard([FromBody] PlayerRequest request)
    {
        var requestValidator = new PlayerRequestValidator();
        var validationResult = requestValidator.Validate(request);

        if (!validationResult.IsValid)
            return BadRequest(new
            {
                Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToArray()
            });
        
        var response = _cardService.ReturnPlayerCard(request);
        return Ok(response);
    }

    [HttpPost("create")]
    public IActionResult CreatePlayerCard([FromBody] PlayerRequest request)
    {
        _logger.LogInformation("WIP");
        return Ok();
    }
    
    [HttpPatch("update")]
    public IActionResult UpdatePlayerCard([FromBody] PlayerRequest request)
    {
        _logger.LogInformation("WIP");
        return Ok();
    }
    
    [HttpDelete("delete")]
    public IActionResult DeletePlayerCard([FromBody] PlayerRequest request)
    {
        _logger.LogInformation("WIP");
        return Ok();
    }
}