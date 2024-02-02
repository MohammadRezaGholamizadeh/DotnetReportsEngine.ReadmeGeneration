using DotNetReportsEngine.ReadmeGeneration.Details;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DotNetReportsEngine.ReadmeGeneration
{
    public class ReadmeResource
    {
        public ReadmeResource()
        {
            Assemblies = new List<Assembly>();
            Acknowledgements = new List<Acknowledgement>();
            Appendix = new List<Appendix>();
            Authors = new List<Author>();
            Demo = new List<string>();
            DeploymentDetails = new List<Deployment>();
            Documentations = new List<Documentation>();
            FAQ = new List<FAQ>();
            Features = new List<string>();
            GitHub_Links = new List<GitHubLink>();
            InstallationDetails = new List<InstallationDetail>();
            CustomBashCommands = new List<CustomBashCommand>();
            CustomTexts = new List<CustomText>();
            Badges = new List<Badge>();
        }

        public List<Assembly> Assemblies { get; internal set; }
        public List<Type> Types => Assemblies.SelectMany(_ => _.GetTypes()).ToList();
        public ProjectDetail ProjectDetail { get; internal set; }
        public List<Acknowledgement> Acknowledgements { get; internal set; }
        public List<Type> Controllers => Types.Where(_ => _.BaseType == typeof(ControllerBase)).ToList();
        public List<Appendix> Appendix { get; internal set; }
        public List<Author> Authors { get; internal set; }
        public string ContributingDescription { get; internal set; }
        public List<string> Demo { get; internal set; }
        public List<Deployment> DeploymentDetails { get; internal set; }
        public List<Documentation> Documentations { get; internal set; }
        public List<FAQ> FAQ { get; internal set; }
        public List<string> Features { get; internal set; }
        public string FeedBackDetail { get; internal set; }
        public string GitHub_AboutMe { get; internal set; }
        public string GitHub_Introduction { get; internal set; }
        public List<GitHubLink> GitHub_Links { get; internal set; }
        public List<InstallationDetail> InstallationDetails { get; internal set; }
        public License License { get; internal set; }
        public Logo Logo { get; internal set; }
        public List<RelatedProject> RelatedProjects { get; internal set; }
        public List<CustomBashCommand> CustomBashCommands { get; internal set; }
        public List<CustomText> CustomTexts { get; internal set; }
        public List<Badge> Badges { get; internal set; }
    }
}
