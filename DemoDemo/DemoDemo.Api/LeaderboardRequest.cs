using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace DemoDemo.ApiServer.ServiceModel
{
    [Route("/leaderboard")]
    public class LeaderboardRequest : IReturn<LeaderboardResponse>
    {   
    }
}
