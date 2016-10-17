using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pangea.Coding.Challenge.Models;

namespace Pangea.Coding.Challenge.Libraries
{
    public interface IGithubClient
    {
        Task<List<GitHubRepository>> FetchRepositories(string owner);
    }
}
