using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace odev_2_extensions_gereniz.Infrastructure
{
    public class LoginFilter : Attribute, IActionFilter
    {

        private string _user;

        public LoginFilter(string user)
        {
            _user = user;
        }
        //Metot bitişi
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        //Metot başlangıcı
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if(_user == "Developer" || _user == "Analyst")
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Privacy" }));
                return;
            }
            return;
        }
    }
}
