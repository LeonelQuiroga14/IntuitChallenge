using AutoMapper;
using Intuit.Challenge.Core.Models;
using Intuit.Challenge.DataAccess.Contexts;
using IntuitChallenge.DTOs.Request;
using IntuitChallenge.DTOs.Response;
using IntuitChallenge.WebAPI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace IntuitChallenge.Controllers;

[Route("api/[controller]")]
[ApiController]
[ApiKey]
public class ClienteController : ControllerBase
{
    private readonly IntuitAppDbContext _context;
    private readonly IMapper _mapper;
    public ClienteController(IntuitAppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <summary>
    /// Obtiene todos los clientes registrados
    /// </summary>
    /// <returns>Lista de todos los clientes </returns>
    [HttpGet]
    
    [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<ClienteResponse>))]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    
    public async Task<IActionResult> GetAll()
    {
        var clientes = await _context.Clientes.ToListAsync();
        if (clientes.Count == 0) return NoContent();

        return Ok(_mapper.Map<List<ClienteResponse>>(clientes));
    }

    /// <summary>
    /// Obtiene un cliente registrado por id
    /// </summary>
    /// <param name="id">Id del cliente que se quiere consultar</param>
    /// <returns>Retorna el cliente solicitado </returns>
    [HttpGet]
    [Route("{id:int}")]
    [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
    [ProducesResponseType((int)HttpStatusCode.NotFound, Type = typeof(string))]
    [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ClienteResponse))]

    public async Task<IActionResult> Get(int id)
    {
        if (id <= 0) return BadRequest("Id debe ser mayor a 0");
        var cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);

        if (cliente == null) return NotFound($"No hay un cliente registrado con id: {id}");
        return Ok(_mapper.Map<ClienteResponse>(cliente));

    }

    /// <summary>
    /// Obtiene clientes cuyo nombre coincidan con la expresion 
    /// </summary>
    /// <param name="nombre">Expresion que que contiene el nombre del cliente</param>
    /// <returns>Lista de todos los clientes que los nombres contengan la expresion</returns>
    [HttpGet]
    [Route("Search")]
    [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<ClienteResponse>))]
    public async Task<IActionResult> Search([FromQuery] string nombre)
    {

        var clientes = await _context.Clientes.Where(c => EF.Functions.Like(c.Nombre, $"%{nombre}%")).ToListAsync();

        return Ok(_mapper.Map<List<ClienteResponse>>(clientes));
    }



    /// <summary>
    /// Crea un nuevo cliente
    /// </summary>
    /// <param name="request">Informacion del cliente</param>
    /// <returns>Retorna el id del cliente creado</returns>
    [HttpPost]
    [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
    [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(string))]
    public async Task<IActionResult> Insert([FromBody] ClienteRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var entity = _mapper.Map<Cliente>(request);
        _context.Clientes.Add(entity);
        await _context.SaveChangesAsync();
        return Created(nameof(Get), "Registro creado con id:" + entity.Id);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="request">Informacion del cliente que se va a actualizar</param>
    /// <returns>Mensaje con estado de la actualizacion</returns>
    [HttpPut]
    [Route("{id:int}")]
    [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
    [ProducesResponseType((int)HttpStatusCode.NotFound, Type = typeof(string))]
    [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ClienteResponse))]
    public async Task<IActionResult> Update(int id, [FromBody] ClienteRequest request)
    {
        if (id <= 0) return BadRequest("Id debe ser mayor a 0");
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);

        if (cliente == null) return NotFound($"No hay un cliente registrado con id: {id}");

        _context.Entry(cliente).CurrentValues.SetValues(request);
        _context.Entry(cliente).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return Ok($"Se ha actualizado correctamente el cliente id:{id}");
    }

    /// <summary>
    /// Elimina un cliente cuyo id coincida con el solicitado
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Mensaje con estado de la eliminación</returns>
    [HttpDelete]
    [Route("{id:int}")]
    [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
    [ProducesResponseType((int)HttpStatusCode.NotFound, Type = typeof(string))]
    [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(string))]
    public async Task<IActionResult> Delete(int id)
    {
        if (id <= 0) return BadRequest("Id debe ser mayor a 0");


        var cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);

        if (cliente == null) return NotFound($"No hay un cliente registrado con id: {id}");


        _context.Clientes.Remove(cliente);
        await _context.SaveChangesAsync();
        return Ok($"Se ha eliminado correctamente el cliente id:{id}");
    }

}

