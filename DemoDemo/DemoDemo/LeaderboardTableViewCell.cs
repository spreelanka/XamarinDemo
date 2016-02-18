using System;
using Foundation;
using UIKit;
using DemoDemo.Core;
using Splat;
using Autofac;
using System.Threading.Tasks;

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
		// TODO
		public void Setup (Player player)
		{
			PlayerNameLabel.Text = player.Name;
			RankLabel.Text = player.Rank.ToString ();
			if (player.Avatar == null) {
				AvatarImageView.Image = null;
				var bitmapLoader = Core.IoC.Container.Resolve<IBitmapLoader> ();
				var downloadService = Core.IoC.Container.Resolve<IImageDataService> ();
				var data = downloadService.DownloadData (player.AvatarUrl);

				var image = new UIImage (NSData.FromArray (data));
				player.Avatar = image.FromNative ();
				AvatarImageView.Image = image;
			} else {
				AvatarImageView.Image = player.Avatar.ToNative ();
			} 
		
		}
	}
}
