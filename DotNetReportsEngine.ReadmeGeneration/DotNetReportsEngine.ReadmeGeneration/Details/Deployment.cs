using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetReportsEngine.ReadmeGeneration.Details
{
    public class Deployment
    {
        public Deployment()
        {
            Bashes = new List<string>();
        }
        public string Description { get; internal set; }
        public List<string> Bashes { get; internal set; }
    }
}
