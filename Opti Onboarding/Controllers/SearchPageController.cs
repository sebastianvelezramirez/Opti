using Microsoft.AspNetCore.Mvc;
using Opti_Onboarding.Models.Pages;
using Opti_Onboarding.Models.ViewModels;

namespace Opti_Onboarding.Controllers
{
    public class SearchPageController : PageControllerBase<SearchPage>
    {
        public ViewResult Index(SearchPage currentPage, string q)
        {
            var model = new SearchContentModel(currentPage)
            {
                Hits = Enumerable.Empty<SearchContentModel.SearchHit>(),
                NumberOfHits = 0,
                SearchServiceDisabled = true,
                SearchedQuery = q
            };

            return View(model);
        }
    }
}
