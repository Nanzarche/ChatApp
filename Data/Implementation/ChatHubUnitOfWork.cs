using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class ChatHubUnitOfWork: Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, "SignalR Users");
            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            await base.OnDisconnectedAsync(exception);
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async Task SendMessageToCaller(string user, string message)
        {
            await Clients.Caller.SendAsync("ReceiveMessage", user, message);
        }
        public async Task SendMessageToGroup(string user, string message)
        { 
            await Clients.Group("SignalR Users").SendAsync("ReceiveMessage", user, message); 
        }
        [HubMethodName("SendMessageToUser")]
        public async Task DirectMessage(string user, string message)
        {
            await Clients.User(user).SendAsync("ReceiveMessage", user, message);
        }
        public Task ThrowException()
        {
            throw new HubException("This error will be sent to the client!");
        }

    }
}
