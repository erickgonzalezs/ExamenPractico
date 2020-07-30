namespace ExamenPracticoApi.Dtos
{
  using Models;
  using System.Collections.Generic;
  public class VentaMensualListaDetalleDto : VentaMensualDto
  {
    public List<SpGetVentaMensual_Result> ventas { get; set; }
    public VentaMensualListaDetalleDto(Cliente cte, DomicilioCliente dom, List<SpGetVentaMensual_Result> listaventas) :
      base(cte, dom, listaventas)
    {
      ventas = new List<SpGetVentaMensual_Result>();
      ventas = listaventas;
    }
  }
}