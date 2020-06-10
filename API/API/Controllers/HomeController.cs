using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;
using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [EnableCors("myPolicy")]
  public class HomeController : Controller
  {
    private readonly AppDbContext _context;
    public HomeController(AppDbContext context)
    {
      _context = context;
    }

    [HttpGet("{idConversa}")]
    public ActionResult<List<ConversaMensagem>> GetAll(int idConversa)
    {
      try
      {
        return Ok(_context.ConversaMensagem
                    .Where(o => o.idConversa == idConversa)
                    .OrderBy(o => o.dataEnvio)
                    .ToList());
      }
      catch (Exception e) { return NotFound(e.Message); }
    }

    [HttpGet]
    public ActionResult<List<Usuario>> GetAll()
    {
      try
      {
        return Ok(_context.Usuario
        .OrderBy(o => o.idUsuario)
        .ToList());
      }
      catch (Exception e) { return NotFound(e.Message); }
    }

    [HttpGet("/api/home/login/{emailUsuario}")]
    public ActionResult<List<Usuario>> Get(string emailUsuario)
    {
      try
      {
        var result = _context.Usuario
          .Where(o => o.email == emailUsuario)
          .OrderBy(o => o.idUsuario)
          .ToList();

        return Ok(result);
      }
      catch(Exception e) { return NotFound(e.Message); }
    }

    [HttpGet("{idConversa}/{ultimaData}")]
    public ActionResult<List<ConversaMensagem>> Get(int idConversa, DateTime ultimaData)
    {
      try
      {
        var result = _context.ConversaMensagem
            .Where(o => o.idConversa == idConversa && o.dataEnvio.CompareTo(ultimaData) > 0)
            .OrderBy(o => o.dataEnvio)
            .ToList();

        return Ok(result);
      }
      catch
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no acesso ao banco de dados");
      }
    }


    [HttpPost]
    public ActionResult post([FromBody]ConversaMensagem model)
    {
      try
      {
        _context.ConversaMensagem.Add(model);
        _context.SaveChanges();
        return Ok(model);
      }
      catch
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no acesso ao banco de dados.");
      }
    }

    [HttpPost("/api/home/cadastro")]
    public ActionResult post([FromBody] Usuario model)
    {
      try
      {
        var userDb = _context.Usuario.FirstOrDefault(
            o => o.email == model.email);
        if (userDb != null)
          return NotFound();

        _context.Usuario.Add(model);
        _context.SaveChanges();
        return Ok(model);
      }
      catch
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no acesso ao banco de dados.");
      }
    }


    [HttpPut("{idConversaMensagem}")]
    public async Task<IActionResult> put(int idConversaMensagem, ConversaMensagem model)
    {
      try
      {
        var result = await _context.ConversaMensagem.FindAsync(idConversaMensagem);
        if (idConversaMensagem != result.idConversaMensagem) { return BadRequest(); }
        result.idConversaMensagem = model.idConversaMensagem;
        result.idUsuario = model.idUsuario;
        result.idConversa = model.idConversa;
        result.Mensagem = model.Mensagem;
        result.dataEnvio = model.dataEnvio;

        await _context.SaveChangesAsync();
        return NoContent();
      }
      catch
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no acesso ao banco de dados.");
      }
    }

    [HttpDelete("{idConversaMensagem}")]
    public async Task<IActionResult> delete(int idConversaMensagem)
    {
      try
      {
        var mensagem = await _context.ConversaMensagem.FindAsync(idConversaMensagem);

        if (mensagem == null) { return NotFound(); }

        _context.Remove(mensagem);
        await _context.SaveChangesAsync();

        return NoContent();
      }
      catch
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no acesso ao banco de dados.");
      }
    }

  }
}
