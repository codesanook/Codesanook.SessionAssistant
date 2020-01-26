using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Orchard;
using Orchard.Localization;
using Orchard.UI.Admin;

namespace Codesanook.SessionAssistant.Controllers {

    // URL /Admin/Codesanook.SessionAssistant/
    [Admin]
    public class AdminController : Controller {
        private readonly IOrchardServices orchardServices;
        public Localizer T { get; set; }

        public AdminController(IOrchardServices orchardServices) {
            this.orchardServices = orchardServices;
            T = NullLocalizer.Instance;
        }

        public ActionResult Index() {
            if (!orchardServices.Authorizer.Authorize(Permissions.PushMessage, T("Not authorized to push a message")))
                return new HttpUnauthorizedResult();

            return View();
        }
    }
}