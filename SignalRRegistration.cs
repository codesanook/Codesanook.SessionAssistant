using System.Collections.Generic;
using Orchard.Owin;
using Owin;

namespace Codesanook.SessionAssistant {
    public class SignalRRegistration : IOwinMiddlewareProvider {
        public IEnumerable<OwinMiddlewareRegistration> GetOwinMiddlewares() {
            return new List<OwinMiddlewareRegistration> {
                new OwinMiddlewareRegistration {
                    Priority = "10",
                    Configure = app => {
                        app.MapSignalR();
                    }
                }
            };

        }
    }
}

