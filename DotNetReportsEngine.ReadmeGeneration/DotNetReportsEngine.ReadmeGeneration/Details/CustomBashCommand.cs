using System.Collections.Generic;

namespace DotNetReportsEngine.ReadmeGeneration.Details
{
    public class CustomBashCommand
    {
        public CustomBashCommand()
        {
            BashCommands = new List<string>();
        }
        public string Title { get; set; }
        public List<string> BashCommands { get; set; }
    }
}
