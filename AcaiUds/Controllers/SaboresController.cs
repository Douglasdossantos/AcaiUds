using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcaiUds.Contexto;
using AcaiUds.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcaiUds.Controllers
{
    [Route("sabores")]
    public class SaboresController : Controller
    {
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Sabores>>> GetbyId( int id, [FromServices]ContextoAcai context)
        {
            var sabor = await context.Sabores.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return Ok(sabor);
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Sabores>>> Get( [FromServices]ContextoAcai context)
        {
            var sabor = await context.Sabores.AsNoTracking().ToListAsync();
            return Ok(sabor);
        }

        [HttpPut]   
        [Route("{id:int}")]
        public async Task<ActionResult<List<Sabores>>> Put(int id, [FromBody]Sabores model, [FromServices]ContextoAcai context)
        {
            if(model.Id != id)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return NotFound(new { mesage = "categoria não encontrada" });
            }
            try
            {
                context.Entry<Sabores>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest(new { message = "O Registo Já Está Atualizado" });
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Não Foi Possivel atualizar o Sabor" });
            }            
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<Sabores>>> Post( [FromBody]Sabores model, [FromServices]ContextoAcai context)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }           
            try
            {
                context.Sabores.Add(model);
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Não  deu certo  na hora de instanciar o  banco" });
            }  
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Sabores>>> Delete(int id, [FromServices]ContextoAcai context)
        {           
            var sabor = await context.Sabores.FirstOrDefaultAsync(x => x.Id == id);
            if (sabor.Equals(null))
            {
                return BadRequest(new { message = "Sabor não Encontrado!" });
            }
            try
            {
                context.Sabores.Remove(sabor);
                await context.SaveChangesAsync();
                return Ok(new { message = "Sabor removido" });
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Não foi  Possivel remover o sabor" });
            }
        }
    }
}