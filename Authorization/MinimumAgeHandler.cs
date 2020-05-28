using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;

namespace authdemo.Authorization
{
    public class MinimumAgeHandler : AuthorizationHandler<MinimumAgeRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumAgeRequirement requirement)
        {
            var claim = context.User.FindFirst("age");

            if (claim != null)
            {
                var age = Convert.ToInt32(claim.Value);
                if (age >= requirement.MinimumAge)
                    context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
