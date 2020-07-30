namespace ExamenPracticoApi.Dtos
{
  using System;
  public class ErrorAltatecResponseDto
  {
    public DateTime fecha { get; set; }
    public string error { get; set; }
    public string detalle { get; set; }
    public ErrorAltatecResponseDto()
    {
      fecha = DateTime.Now;
    }
  }
}