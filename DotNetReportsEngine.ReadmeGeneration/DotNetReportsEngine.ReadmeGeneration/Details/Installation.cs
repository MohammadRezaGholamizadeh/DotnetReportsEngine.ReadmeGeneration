using System.Collections.Generic;

namespace DotNetReportsEngine.ReadmeGeneration.Details
{
    public class InstallationDetail
    {
        public InstallationDetail()
        {
            BashCommands = new List<string>();
        }
        public string Title { get; internal set; }
        public List<string> BashCommands { get; internal set; }
    }
}
