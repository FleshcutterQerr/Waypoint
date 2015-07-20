using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waypoint.APIRequests
{
    interface IAPIRequest
    {
        IAPIResponse MakeRequest();
    }
}
