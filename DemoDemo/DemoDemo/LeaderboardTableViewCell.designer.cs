// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DemoDemo.iOS
{
	[Register ("LeaderboardTableViewCell")]
	partial class LeaderboardTableViewCell
	{
		[Outlet]
		UIKit.UIImageView AvatarImageView { get; set; }

		[Outlet]
		UIKit.UILabel PlayerNameLabel { get; set; }

		[Outlet]
		UIKit.UILabel RankLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (AvatarImageView != null) {
				AvatarImageView.Dispose ();
				AvatarImageView = null;
			}

			if (RankLabel != null) {
				RankLabel.Dispose ();
				RankLabel = null;
			}

			if (PlayerNameLabel != null) {
				PlayerNameLabel.Dispose ();
				PlayerNameLabel = null;
			}
		}
	}
}
