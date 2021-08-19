using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace LegacyApi
{
  public class CustomPageHandlerFactory : PageHandlerFactory
  {
    public override IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated)
    {
      if (context.Request.Path.StartsWith("/WebForm.aspx", StringComparison.OrdinalIgnoreCase))
      {
        return null;
      }

      return base.GetHandler(context, requestType, url, pathTranslated);
    }
  }
}