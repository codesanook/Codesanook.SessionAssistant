using System.Web.Mvc;
using Orchard.Themes;

namespace Codesanook.SessionAssistant.Controllers {

    // Codesanook.SessionAssistant/PushMessage
    [Themed]
    public class PushMessageController : Controller {
        public ActionResult Index() {
            return View();
        }
    }
}