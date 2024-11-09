
using DevTest.Domain.Dto;
using DevTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevTest.Controllers;


[Route("api/v1/[controller]")]
[ApiController]
public class polls : ControllerBase
{
    private readonly ILocalPollServices _pollService;
    public polls(ILocalPollServices pollServices)
    {
        _pollService = pollServices;
    }


    [HttpGet("{pollId}")]
    public IActionResult GetPollById(int pollId)
    {
        var poll = _pollService.GetPollById(pollId);
        if(poll == null)
        {

            return NotFound();
            
        }
        return Ok(poll);
    }

    [HttpPost]
    public IActionResult CreatePoll([FromBody] CreatePoll request)
    {
        if(request == null || request.options==null || !request.options.Any())
        {
            return BadRequest("INVALID DATA");
        }
        var poll = _pollService.CreatePoll(request.name, request.options);
       return  Ok(poll);
    }

    [HttpGet] 
    public IActionResult GetAllPolls()
    {
        var polls = _pollService.getAllPolls();
        return Ok(polls);
    }

    [HttpPost("{pollId}/vote")]
    public IActionResult Vote(int pollId, [FromBody] CreateVote request)
    {
        if(_pollService.Vote(pollId, request.OptionId, request.voterEmail))
            return Ok();
        return BadRequest( "Unable to submit the vote.");
    }
}
