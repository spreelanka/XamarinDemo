using System;
using Splat;

namespace DemoDemo.Core
{
	public class Player:Api.Player
	{
		public IBitmap Avatar{ get; set; }

		public Player (Api.Player player) : base ()
		{
			Name = player.Name;
			Rank = player.Rank;
			AvatarUrl = player.AvatarUrl;

			// TODO: fetch and set Avatar
//			Avatar=player.
		}
	}
}

