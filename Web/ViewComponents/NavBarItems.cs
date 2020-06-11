using Core.Business.Details;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Utilities;

namespace Web.ViewComponents
{
    public class NavBarItemsViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync(UserSession.CompanyId);
            return View(items);
        }

        private Task<List<NavItemDetails>> GetItemsAsync(int companyId)
        {
            List<NavItemDetails> navs = Core.Business.Navigation.HomepageNav(companyId);

            return Task.FromResult<List<NavItemDetails>>(navs);

        }
    }
}
