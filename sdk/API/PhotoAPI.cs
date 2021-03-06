﻿using System;
using LoginRadius.SDK.Http;

namespace LoginRadius.SDK.API
{
    /// <summary>
    /// The Photo API is used to get photo data from the user’s social account. The data will be normalized into LoginRadius' standard data format.
    /// </summary>
    public class PhotoAPI : ILoginRadiusAPI
    {
        /// <summary>
        /// A valid albumId, it return album photos
        /// </summary>
        public string AlbumId { get; set; }

        HttpClient client = new HttpClient();

        const string Endpoint = "api/v2/photo?access_token={0}&albumid={1}";
        const string RawEndpoint = "api/v2/photo/raw?access_token={0}&albumid={1}";

        /// <summary>
        /// The Photo API is used to get photo data from the user’s social account. The data will be normalized into LoginRadius' standard data format
        /// </summary>
        /// <param name="token">A valid session token,which is fetch from Access Token API.</param>
        /// <returns></returns>
        public string ExecuteAPI(Guid token)
        {
            string url = string.Format(Constants.APIRootDomain + Endpoint, token, AlbumId);
            return client.Request(url, null, HttpMethod.GET);
        }

        /// <summary>
        /// Get user photo data as provided by the provider. The data will not be in a consistent response type and format across providers, so you will have to parse it yourself.
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
