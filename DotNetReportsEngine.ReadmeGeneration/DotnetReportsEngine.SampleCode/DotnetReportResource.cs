using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DotnetReportsEngine.SampleCode
{
    public class DotnetReportResourcesss
    {
        public DotnetReportResourcesss()
        {
            Assemblies = new List<Assembly>();
        }
        public List<Assembly> Assemblies { get; private set; }
        public List<Type> Types => Assemblies.SelectMany(_ => _.GetTypes()).ToList();
    }
}
