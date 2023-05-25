using FifaCardApi.Domain.Request;
using FifaCardApi.Service.Services.Interfaces;
using FifaCardApi.Service.Validators;
using FluentValidation;
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
    public IActionResult GetPlayerCard([FromBody] PlayerCreationRequest request)
    {
        var requestValidator = new PlayerRequestValidator();
        var validationResult = requestValidator.Validate(request.CardAttributes);

        if (!validationResult.IsValid)
            return BadRequest(new
            {
                Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToArray()
            });
        
        return Ok();
    }

    [HttpPost("create")]
    public IActionResult CreatePlayerCard([FromBody] PlayerCreationRequest request)
    {
        var requestValidator = new PlayerRequestValidator();
        var validationResult = requestValidator.Validate(request.CardAttributes);

        if (!validationResult.IsValid)
            return BadRequest(new
            {
                Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToArray()
            });

        return Ok();
    }
    
    [HttpPatch("update")]
    public IActionResult UpdatePlayerCard([FromBody] PlayerCreationRequest request)
    {
        _logger.LogInformation("WIP");
        return Ok();
    }
    
    [HttpDelete("delete")]
    public IActionResult DeletePlayerCard([FromBody] PlayerCreationRequest request)
    {
        _logger.LogInformation("WIP");
        return Ok();
    }
}