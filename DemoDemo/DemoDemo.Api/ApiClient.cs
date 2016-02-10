using System;
using System.Collections.Generic;

namespace DemoDemo.Api
{
	public class ApiClient
	{
		public ApiClient ()
		{
		}

		public IEnumerable<Player> GetLeaderboard ()
		{
			return new List<Player> (new [] {
				new Player{ Name = "aaa", Rank = 1, AvatarUrl = string.Empty },
				new Player{ Name = "bbb", Rank = 2, AvatarUrl = string.Empty },
				new Player{ Name = "ccc", Rank = 3, AvatarUrl = string.Empty }
			});
		}
	}
}

