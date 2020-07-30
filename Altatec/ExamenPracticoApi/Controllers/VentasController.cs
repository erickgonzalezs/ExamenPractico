namespace ExamenPracticoApi.Controllers
{
  using Dtos;
  using Models;
  using System;
  using System.Collections.Generic;
  using System.Data.Entity;
  using System.Linq;
  using System.Net;
  using System.Threading.Tasks;
  using System.Web.Http;

  public class VentasController : ApiController
  {
    private readonly ExamenPracticoEntities _db = new ExamenPracticoEntities();
    [Route("api/examenPracticoAltatec/ventamensual")]
    public async Task<IHttpActionResult> GetVenta(int clienteId, bool array)
    {
      try
      {
        Cliente cliente = await _db.Cliente.FirstOrDefaultAsync(x => x.ClienteId == clienteId);
        if (cliente == null)
          return StatusCode(HttpStatusCode.NoContent);
        DomicilioCliente domicilio = cliente.DomicilioCliente.FirstOrDefault();
        List<SpGetVentaMensual_Result> r = _db.SpGetVentaMensual(clienteId).ToList();
        if (array) return Json(new VentaMensualDetalleDto(cliente, domicilio, r));
        return Json(new VentaMensualListaDetalleDto(cliente, domicilio, r));
      }
      catch (Exception e)
      {
        ErrorAltatecResponseDto err = new ErrorAltatecResponseDto
        {
          error = $"Problema al ejecutar Controller...",
          detalle = e.Message
        };
        return StatusCode(HttpStatusCode.InternalServerError);
      }

    }

  }
}