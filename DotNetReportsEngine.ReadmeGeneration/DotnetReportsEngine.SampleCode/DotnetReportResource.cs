using DotNetReportsEngine.ReadmeGeneration.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DotnetReportsEngine.SampleCode
{
    [RenderInReadmeFile]
    public class DotnetReportResourcesss
    {
        public DotnetReportResourcesss()
        {
            Assemblies = new List<Assembly>();
        }
        public List<Assembly> Assemblies { get; private set; }
        public List<Type> Types => Assemblies.SelectMany(_ => _.GetTypes()).ToList();

        public string GenerateCodeForBadges
           (string generator,
            IEnumerable<Badge> badges)
        {
            foreach (var badge in badges)
            {
                var template =
                $@"[![{badge.Title}]({badge.BadgeLink})]({badge.RedirectLink})";

                template += Environment.NewLine;

            }

            return generator;
        }
    }
}
