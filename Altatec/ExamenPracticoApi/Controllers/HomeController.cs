namespace ExamenPracticoApi.Controllers
{
  using Filters;
  using Models.CustonExceptions;
  using System;
  using System.Web.Http;
  [ExcepcionAltatecFilter]
  public class HomeController : ApiController
  {
    [Route("")]
    [Route("api")]
    [Route("api/examenPracticoAltatec")]
    public IHttpActionResult GetHome()
    {
      try
      {
        return Json("Examen práctico Altatec Erick González Sánchez");
      }
      catch (Exception e)
      {
        throw new AltatecCustomExceptionModel(e.Message);
      }
    }
  }
}
