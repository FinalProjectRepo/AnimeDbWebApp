using Microsoft.AspNetCore.SignalR;

using System;
using System.Threading.Tasks;

using AnimeDbWebApp.ViewModels.Home;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Hubs
{
	public class ChatHub : Hub
	{
		public async Task SendMessage(string user, string message)
		{
			var tuple = new Tuple<string, string>(user, message);
			MessageHistory.Messages.Add(tuple);

			await Clients.All.SendAsync(ReceiveMessageMethodName, user, message, MessageHistory.Messages.Count);
		}
	}
}