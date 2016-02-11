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
        public object Any(Hello request)
        {
            return new HelloResponse { Result = "Hello, {0}!".Fmt(request.Name) };
        }
        public object Any(LeaderboardRequest request)
        {
            return new LeaderboardResponse {
                Players = new List<Player>(new[]
                {
                    new Player{ Name = "aaa", Rank = 1, AvatarUrl = string.Empty },
                    new Player{ Name = "bbb", Rank = 2, AvatarUrl = string.Empty },
                    new Player{ Name = "ccc", Rank = 3, AvatarUrl = string.Empty }
                })
            };
        }
    }
}