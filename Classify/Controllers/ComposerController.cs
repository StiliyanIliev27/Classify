using Classify.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Classify.Web.Controllers
{
    public class ComposerController : Controller
    {
        private readonly IComposerService composerService;

        public ComposerController(IComposerService composerService)
        {
            this.composerService = composerService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await composerService.AllDisplayAsync();
            
            return View(model);
        }
    }
}
