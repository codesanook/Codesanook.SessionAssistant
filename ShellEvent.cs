using Orchard.Environment;
using React;

namespace Codesanook.SessionAssistant {
    public class ShellEvent : IOrchardShellEvents {
        public void Activated() {
            ReactSiteConfiguration.Configuration
                .SetLoadBabel(false)
                .AddScriptWithoutTransform("~/modules/codesanook.sessionassistant/scripts/codesanook-session-assistant.js");
        }

        public void Terminating() {
        }
    }
}