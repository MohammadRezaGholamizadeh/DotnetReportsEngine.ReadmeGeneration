using DotNetReportsEngine.ReadmeGeneration.Details;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetReportsEngine.ReadmeGeneration
{
    public static class ReadmeComponent
    {
        public static ReadmeGenerator GenerateCodeForProjectDetail
           (this ReadmeGenerator generator,
            string title,
            string? description = null)
        {
            var projectDetailTemplate =
                $"# {title}"
                + Environment.NewLine;
            if (description != null)
            {
                projectDetailTemplate += description + Environment.NewLine;
            }
            generator.AppendText(projectDetailTemplate);

            return generator;
        }
        public static ReadmeGenerator GenerateCodeForAcknowledgement
             (this ReadmeGenerator generator,
              string title,
              string link)
        {
            var acknowledgementTemplate =
                 $"## Acknowledgements" + Environment.NewLine +
                 $"- [{title}]({link})" + Environment.NewLine;
            generator.AppendText(acknowledgementTemplate);
            return generator;
        }
        public static ReadmeGenerator GenerateCodeForAcknowledgements
           (this ReadmeGenerator generator,
            IEnumerable<Acknowledgement> acknowledgements)
        {
            var acknowledgementTemplate =
                 $"## Acknowledgements" + Environment.NewLine;
            foreach (var acknowledgement in acknowledgements)
            {
                acknowledgementTemplate += 
                 $"- [{acknowledgement.Title}]({acknowledgement.Link})" + Environment.NewLine;
            }
            generator.AppendText(acknowledgementTemplate);
            return generator;
        }
        public static ReadmeGenerator GenerateCodeForAppendix
            (this ReadmeGenerator generator,
             string description)
        {
            var appendixTemplate =
                 $"## Appendix" + Environment.NewLine +
                 $"- {description}" + Environment.NewLine;
            generator.AppendText(appendixTemplate);
            return generator;
        }

        public static ReadmeGenerator GenerateCodeForAppendixes
            (this ReadmeGenerator generator,
             IEnumerable<Appendix> appendixes)
        {
            var appendixTemplate =
                 $"## Appendix" + Environment.NewLine;
            foreach (var appendix in appendixes)
            {
                appendixTemplate +=
                 $"- {appendix.DescriptionOrScript}" + Environment.NewLine;
            }
            generator.AppendText(appendixTemplate);
            return generator;
        }
    }
}
