using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace JOBZONE.Models
{
    public class AdminAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            var userManager = context.HttpContext.RequestServices.GetRequiredService<UserManager<UserModel>>();
            var user = userManager.GetUserAsync(context.HttpContext.User).Result;

            if (user == null || !user.isAdmin)
            {
                context.Result = new ForbidResult();
            }
        }
    }
}
