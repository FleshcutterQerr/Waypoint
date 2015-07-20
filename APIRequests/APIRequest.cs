using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waypoint.Enums;
using Waypoint.Enums.v2;

namespace Waypoint.APIRequests
{
    class APIRequest : IAPIRequest
    {
        APIEndpoints _endpoint;
        string _apiKey;

        /// <summary>
        /// A new request to Guild Wars 2
        /// </summary>
        /// <param name="apiKey">The ANet provided API Key</param>
        /// <param name="endpoint"></param>
        public APIRequest(string apiKey, APIEndpoints endpoint)
        {
            _apiKey = apiKey;
            _endpoint = endpoint;
        }

        internal IAPIResponse MakeRequest()
        {
            // make the request on the _endpooint and return a response.

            throw new NotImplementedException();
        }
    }
}
