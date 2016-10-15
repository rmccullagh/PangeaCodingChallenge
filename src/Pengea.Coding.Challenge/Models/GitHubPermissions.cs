using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pangea.Coding.Challenge.Models
{
    public class GitHubPermissions
    {
        public int GitHubPermissionsId { get; set; }
        public bool admin { get; set; }
        public bool push { get; set; }
        public bool pull { get; set; }
    }
}
