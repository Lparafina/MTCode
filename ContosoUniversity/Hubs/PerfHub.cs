using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ContosoUniversity.Hubs
{
    public class PerfHub : Hub
    {
        public void Send(string name, string message)
        {
            //please go to all the client that is connected
            /*Clients.All.newMessage(
                Context.User.Identity.Name + " says " + message
                );*/
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}