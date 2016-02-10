using System;

using UIKit;

namespace DemoDemo.iOS
{
	public partial class LeaderboardViewController : UIViewController
	{
		public LeaderboardViewController () : base ("LeaderboardViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			TableView.RegisterNibForCellReuse (LeaderboardTableViewCell.Nib, LeaderboardTableViewCell.Key);
			TableView.Source = new LeaderboardTableSource ();
		}
	}
}


