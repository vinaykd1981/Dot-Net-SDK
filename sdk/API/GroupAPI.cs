﻿using System;
using LoginRadius.SDK.Http;

namespace LoginRadius.SDK.API
{
    /// <summary>
    /// The Group API is used to get group data from the user’s social account. The data will be normalized into LoginRadius' standard data format.
    /// </summary>
    public class GroupAPI : ILoginRadiusAPI
    {
        HttpClient client = new HttpClient();

        const string Endpoint = "api/v2/group?access_token={0}";
        const string RawEndpoint = "api/v2/group/raw?access_token={0}";

        /// <summary>
        /// The Group API is used to get group data from the user’s social account. The data will be normalized into LoginRadius' standard data format.
        /// </summary>
        /// <param name="token">A valid session token,which is fetch from Access Token API.</param>
        /// <returns></returns>
        public string ExecuteAPI(Guid token)
        {
            string url = string.Format(Constants.APIRootDomain + Endpoint, token);
            return client.Request(url, null, HttpMethod.GET);
        }

        /// <summary>
        /// Get Group data as provided by the provider. The data will not be in a consistent response type and format across providers, so you will have to parse it yourself.
        /// </summary>
        /// <param name="token">A valid session token,which is fetch from Access Token API.</param>
        /// <returns></returns>
        public string ExecuteRawAPI(Guid token)
        {
            string url = string.Format(Constants.APIRootDomain + RawEndpoint, token);
            return client.Request(url, null, HttpMethod.GET);
        }
    }
}
