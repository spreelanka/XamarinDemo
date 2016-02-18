using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using DemoDemo.ApiServer.ServiceModel;
using DemoDemo.Api;

namespace DemoDemo.ApiServer.ServiceInterface
{
	public class MyServices : Service
	{
		public object Any (Hello request)
		{
			return new HelloResponse { Result = "Hello, {0}!".Fmt (request.Name) };
		}

		// TODO
		public object Any (LeaderboardRequest request)
		{
			return new LeaderboardResponse {
				Players = new List<Player> (new[] {
					new Player {
						Name = "player 1",
						Rank = 1,
						AvatarUrl = "https://avatars.slack-edge.com/2015-11-02/13730672677_12e63b2676006e35c8c8_48.jpg"
					},
					new Player {
						Name = "player 2",
						Rank = 2,
						AvatarUrl = "https://avatars.slack-edge.com/2015-07-28/8334572082_cf32aaa303e81fe38acf_48.jpg"
					},
					new Player {
						Name = "player 3",
						Rank = 3,
						AvatarUrl = "https://avatars.slack-edge.com/2015-03-25/4191418419_0439e15604a6180d161b_48.jpg"
					}
				})
			};
		}
	}
}