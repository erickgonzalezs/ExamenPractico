namespace ExamenPracticoApi.Dtos
{
  using Models;
  using System.Collections.Generic;
  public class VentaMensualDetalleDto : VentaMensualDto
  {
    public List<string> ventas { get; set; }
    public VentaMensualDetalleDto(Cliente cte, DomicilioCliente dom, List<SpGetVentaMensual_Result> listaventas) : base(
      cte, dom, listaventas)
    {
      ventas = new List<string>();
      foreach (var v in listaventas)
      {
        ventas.Add($"{v.Mes}: {v.VentaMes}");
      }
    }

  }
}