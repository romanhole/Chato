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
    public ActionResult<List<ConversaMensagem>> GetAllMensagens(int idConversa)
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
    public ActionResult<List<Usuario>> GetAllUsuarios()
    {
      try
      {
        return Ok(_context.Usuario
        .OrderBy(o => o.idUsuario)
        .ToList());
      }
      catch (Exception e) { return NotFound(e.Message); }
    }   

    [HttpGet("{idConversa}/{ultimaData}")]
    public ActionResult<List<ConversaMensagem>> GetUltimaMensagem(int idConversa, DateTime ultimaData)
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
    public ActionResult postConversaMensagem([FromBody]ConversaMensagem model)
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
    public ActionResult postCadastro([FromBody] Usuario model)
    {
      try
      {
        var userDb = _context.Usuario.FirstOrDefault(
            o => o.email == model.email);
        if (userDb != null)
          return NotFound("Usuário já existente");

        _context.Usuario.Add(model);
        _context.SaveChanges();
        return Ok(model);
      }
      catch
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no acesso ao banco de dados.");
      }
    }

    [HttpPost("/api/home/login")]
    public ActionResult postLogin([FromBody] Usuario model)
    {
      try
      {
        var userDb = _context.Usuario.FirstOrDefault(
          o => o.email == model.email && o.senha == model.senha);

        if (userDb == null)
          return NotFound("Email ou senha incorretos");

        return Ok(userDb);
      }
      catch (Exception e) { return NotFound(e.Message); }
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
