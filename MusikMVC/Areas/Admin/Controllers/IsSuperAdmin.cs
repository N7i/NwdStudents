using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace MusikMVC.Areas.Admin.Controllers
{
    class IsSuperAdminAttribute : ActionFilterAttribute
    {
        override public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(filterContext.HttpContext.User.Identity.Name != "SuperAdmin")
            {
                filterContext.Result = new HttpNotFoundResult();
            }
        }
    }
}
