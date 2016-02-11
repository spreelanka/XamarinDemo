using DemoDemo.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDemo.ApiServer.ServiceModel
{
    public class LeaderboardResponse
    {
        public List<Player> Players { get; set; }
    }
}
