namespace ExamenPracticoApi.Dtos
{
  using System.Collections.Generic;
  using System.Linq;
  using Models;
  public class VentaMensualDto
  {
    public string cliente { get; set; }
    public string direccion { get; set; }
    public string telefono { get; set; }
    public string email { get; set; }
    public string email2 { get; set; }
    public decimal totaldeventa { get; set; }
    public int? numerodecompras { get; set; }
    public VentaMensualDto(Cliente cte, DomicilioCliente dom, List<SpGetVentaMensual_Result> listaventas)
    {
      decimal ventatotal = listaventas.Sum(x => x.VentaMes) ?? 0;
      cliente = $"{cte.Nombre} {cte.ApellidoPaterno} {cte.ApellidoPaterno}";
      direccion =
        $"{dom.Calle} {dom.NumeroExterior}, Colonia: {dom.Colonia}, CP: {dom.CodigoPostal}, {dom.Ciudad}, {dom.Estado}, {dom.Pais}";
      telefono = dom.Telefono;
      email = dom.EmailPrincipal;
      email2 = dom.EmailSecundario;
      totaldeventa = ventatotal;
      numerodecompras = cte.DomicilioCliente.Sum(x => x.ContadorCompras);
    }
  }
}