using System;
using System.Collections.Generic;
using DemoDemo.Api;
using System.Linq;

namespace DemoDemo.Core
{
	public class PlayerService
	{
		protected ApiClient ApiClient{ get; set; }

		public PlayerService (ApiClient apiClient)
		{
			ApiClient = apiClient;
		}

		// TODO
		public IEnumerable<Player> GetLeaderboard ()
		{
			var apiPlayers = ApiClient.GetLeaderboard ();
			return apiPlayers.Select ((p) => {
				return new  Core.Player (p);
			});
		}
	}
}

