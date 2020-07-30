namespace ExamenPracticoApi.Models.CustonExceptions
{
  using System;
  public class AltatecCustomExceptionModel : Exception
  {
    public AltatecCustomExceptionModel(string message) : base(message)
    {
      //Acciones a realizar cada vez que esta excepción sucede... por ejemplo registrar log...
    }
    public AltatecCustomExceptionModel()
    {
    }
  }
}