using SportsVenueBookings.Data;
using Microsoft.AspNetCore.Identity;

namespace SportsVenueBookings.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<SportsVenueBookingsUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<SportsVenueBookingsUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
