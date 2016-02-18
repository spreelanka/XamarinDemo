using System;
using Splat;
using System.Drawing;
using Autofac;
using System.Net;
using System.IO;
using System.Threading.Tasks;


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
		}
	}
}

