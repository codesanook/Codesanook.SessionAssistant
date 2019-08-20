using Microsoft.AspNet.SignalR;

namespace Codesanook.SessionAssistant.Hubs {
    public class PushMessageHub: Hub<IPushMessageOperation> {
        public void Send(string message) {
            Clients.All.addNewMessage(message);
        }
    }
}