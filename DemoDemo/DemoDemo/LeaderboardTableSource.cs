using System;
using UIKit;
using DemoDemo.Core;
using Autofac;
using System.Collections.Generic;
using System.Linq;

namespace DemoDemo.iOS
{
	public class LeaderboardTableSource:UITableViewSource
	{
		protected PlayerService PlayerService{ get; set; }

		List<Player> Players{ get; set; }

		public LeaderboardTableSource () : base ()
		{
			PlayerService = Core.IoC.Container.Resolve<PlayerService> ();
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			Players = PlayerService.GetLeaderboard ().ToList ();
			return Players.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var player = Players [indexPath.Row];
			var cell = tableView.DequeueReusableCell (LeaderboardTableViewCell.Key) as LeaderboardTableViewCell;
			if (cell == null) {
				cell = new LeaderboardTableViewCell ();
			}
			cell.Setup (player);
			return cell;
		}
	}
}
