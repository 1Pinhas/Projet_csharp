using Microsoft.AspNetCore.Mvc;
using ProjetCsharp.Models;
using ProjetCsharp.Service.Impl;

namespace ProjetCsharp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RSController : ControllerBase
{
    private readonly RsService _rsService;

    public RSController(RsService rsService)
    {
        _rsService = rsService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<RS>> GetAllRS()
    {
        var rsList = _rsService.GetAllRS();
        return Ok(rsList);
    }

    [HttpGet("{id}")]
    public ActionResult<RS> GetRSById(int id)
    {
        var rs = _rsService.GetRSById(id);
        if (rs == null)
        {
            return NotFound();
        }
        return Ok(rs);
    }

    [HttpPost]
    public ActionResult AddRS(RS rs)
    {
        _rsService.AddRS(rs);
        return CreatedAtAction(nameof(GetRSById), new { id = rs.RSId }, rs);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateRS(int id, RS rs)
    {
        if (id != rs.RSId)
        {
            return BadRequest();
        }
        _rsService.UpdateRS(rs);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteRS(int id)
    {
        _rsService.DeleteRS(id);
        return NoContent();
    }
}

