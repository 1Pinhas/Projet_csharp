using Microsoft.AspNetCore.Mvc;
using ProjetCsharp.Models;
using ProjetCsharp.Service.Impl;

namespace ProjetCsharp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ComptableController : ControllerBase
{
    private readonly ComptableService _comptableService;

    public ComptableController(ComptableService comptableService)
    {
        _comptableService = comptableService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Comptable>> GetAllComptables()
    {
        var comptables = _comptableService.GetAllComptables();
        return Ok(comptables);
    }

    [HttpGet("{id}")]
    public ActionResult<Comptable> GetComptableById(int id)
    {
        var comptable = _comptableService.GetComptableById(id);
        if (comptable == null)
        {
            return NotFound();
        }
        return Ok(comptable);
    }

    [HttpPost]
    public ActionResult AddComptable(Comptable comptable)
    {
        _comptableService.AddComptable(com
