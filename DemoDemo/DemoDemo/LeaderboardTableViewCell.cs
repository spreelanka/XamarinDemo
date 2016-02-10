using System;
using Foundation;
using UIKit;
using DemoDemo.Core;
using Splat;

namespace DemoDemo.iOS
{
	public partial class LeaderboardTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("LeaderboardTableViewCell");
		public static readonly UINib Nib;

		static LeaderboardTableViewCell ()
		{
			Nib = UINib.FromName ("LeaderboardTableViewCell", NSBundle.MainBundle);
		}

		public LeaderboardTableViewCell (IntPtr handle) : base (handle)
		{
		}

		public LeaderboardTableViewCell () : base ()
		{
		}

		public void Setup (Player player)
		{
			PlayerNameLabel.Text = player.Name;
			RankLabel.Text = player.Rank.ToString ();
			if (player.Avatar != null) {
				AvatarImageView.Image = player.Avatar.ToNative ();
			} else {
				AvatarImageView.Image = null;
			}
				
		}
	}
}
