using System.Web.Mvc;
using Orchard.Themes;

namespace Codesanook.SessionAssistant.Controllers {

    [Themed]
    public class ClipboardController : Controller {
        public ActionResult Index() {
            return View();
        }
    }
}