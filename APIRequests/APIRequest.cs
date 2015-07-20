using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waypoint.Enums;

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
        /// <param name="endpoint">The selected endpoint to make the request</param>
        public APIRequest(string apiKey, APIEndpoints endpoint)
        {
            _apiKey = apiKey;
            _endpoint = endpoint;
        }

        IAPIResponse IAPIRequest.MakeRequest()
        {

            throw new NotImplementedException();
        }
    }
}
