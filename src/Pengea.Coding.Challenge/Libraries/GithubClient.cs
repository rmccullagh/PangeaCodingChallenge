using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Pangea.Coding.Challenge.Models;

namespace Pengea.Coding.Challenge.Libraries
{
    public class GithubClient : IGithubClient
    {
        private Task<HttpResponseMessage> _getRepositoryData(string owner)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.github.com/");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");

            return httpClient.GetAsync(owner);
        }

        public async Task<List<GitHubRepository>> FetchRepositories(string owner)
        {
            HttpResponseMessage response = await _getRepositoryData(owner);
            List<GitHubRepository> repos = new List<GitHubRepository>();

            if (response.IsSuccessStatusCode)
            {
                repos = await response.Content.ReadAsAsync<List<GitHubRepository>>();

            }

            return repos;
        }
    }
}
