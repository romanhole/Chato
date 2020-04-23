using API.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Hubs
{
  public class ChatHub : Hub
  {
    public async Task EnviarMensagem(Mensagem mensagem) =>
      await Clients.All.SendAsync("ReceiveMessage", mensagem);
  }
}
