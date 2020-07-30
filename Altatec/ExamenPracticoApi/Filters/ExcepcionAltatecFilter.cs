namespace ExamenPracticoApi.Filters
{
  using Dtos;
  using System.Net;
  using System.Net.Http;
  using System.Net.Http.Formatting;
  using System.Web.Http.Filters;
  public class ExcepcionAltatecFilter : ExceptionFilterAttribute
  {
    private ErrorAltatecResponseDto errordetail { get; set; }
    public override void OnException(HttpActionExecutedContext context)
    {
      var exceptionType = context.Exception.GetType();
      errordetail = new ErrorAltatecResponseDto
      {
        detalle = $"{exceptionType.Name}... Aquí se presentaría el detalle... ", 
        error = "Error al procesar la información."
      };
      HttpStatusCode status = HttpStatusCode.InternalServerError;
      ObjectContent data = new ObjectContent<ErrorAltatecResponseDto>(errordetail, 
                                                                      new JsonMediaTypeFormatter(), "application/json");
      context.Response = new HttpResponseMessage { StatusCode = status, Content = data };
      base.OnException(context);
    }
  }
}