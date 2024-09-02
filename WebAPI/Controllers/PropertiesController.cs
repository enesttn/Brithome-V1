using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PropertiesController : ControllerBase
{
    IPropertyService _propertyService;
    public PropertiesController(IPropertyService propertyService)
    {
        _propertyService = propertyService;
    }
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _propertyService.GetAll();
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("add")]
    public IActionResult Add(Property property)
    {
        var result = _propertyService.Add(property);
        if (result.Success)
        {
            return Ok(result);

        }
        return BadRequest(result);

    }

    [HttpGet("getbyid")]
    public IActionResult Get(int id)
    {
        var result = _propertyService.GetById(id);
        if (result.Success)
        {
            return Ok(result);

        }
        return BadRequest(result);
    }

}