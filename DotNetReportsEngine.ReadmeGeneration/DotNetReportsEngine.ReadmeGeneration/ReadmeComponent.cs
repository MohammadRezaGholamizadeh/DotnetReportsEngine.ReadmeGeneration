using DotNetReportsEngine.ReadmeGeneration.Details;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public static ReadmeGenerator GenerateCodeForAuthor
            (this ReadmeGenerator generator,
             string name,
             string? link)
        {
            var authorTemplate =
                 $"## Authors" + Environment.NewLine +
                 $"- [{name}]";
            if (link != null)
            {
                authorTemplate += $"({link})";
            }
            authorTemplate += Environment.NewLine;

            generator.AppendText(authorTemplate);
            return generator;
        }

        public static ReadmeGenerator GenerateCodeForAuthors
            (this ReadmeGenerator generator,
             IEnumerable<Author> authors)
        {
            var authorTemplate =
                 $"## Authors" + Environment.NewLine;
            foreach (var author in authors)
            {
                authorTemplate +=
                 $"- [{author.Name}]";
                if (author.Link != null)
                {
                    authorTemplate += $"({author.Link})";
                }
                authorTemplate += Environment.NewLine;
            };
            generator.AppendText(authorTemplate);
            return generator;
        }

        public static ReadmeGenerator GenerateCodeForColor
            (this ReadmeGenerator generator,
             string colorName,
             string hex)
        {
            var colorTemplate =
                 $"## Color Referencec" + Environment.NewLine +
                 $"| Color             |Hex                           |" + Environment.NewLine +
                 $"| ----------------- | ----------------------------- |" + Environment.NewLine +
                 $"| {colorName} | ![#{hex}](https://via.placeholder.com/10/{hex}?text=+) #{hex} |" + Environment.NewLine;
            colorTemplate += Environment.NewLine;
            generator.AppendText(colorTemplate);
            return generator;
        }

        public static ReadmeGenerator GenerateCodeForColors
            (this ReadmeGenerator generator,
             IEnumerable<ColorReference> colors)
        {
            var colorTemplate =
                 $"## Color Referencec" + Environment.NewLine +
                 $"| Color             |Hex                           |" + Environment.NewLine +
                 $"| ----------------- | ----------------------------- |" + Environment.NewLine;
            foreach (var color in colors)
            {
                colorTemplate += $"| {color.ColorTitle} | ![#{color.Hex}](https://via.placeholder.com/10/{color.Hex}?text=+) #{color.Hex} |" + Environment.NewLine;
            }
            colorTemplate += Environment.NewLine;
            generator.AppendText(colorTemplate);
            return generator;
        }

        public static ReadmeGenerator GenerateCodeForContributingDescription
            (this ReadmeGenerator generator,
             string contributingDescription)
        {
            var appendixTemplate =
                 $"## Contributing" + Environment.NewLine +
                 $"{contributingDescription}" + Environment.NewLine;

            generator.AppendText(appendixTemplate);
            return generator;
        }

        public static ReadmeGenerator GenerateCodeForDemoLink
            (this ReadmeGenerator generator,
             string link)
        {
            var appendixTemplate =
                $"## Demo" + Environment.NewLine +
                $"- [Get Started With Demo]({link})" + Environment.NewLine;

            generator.AppendText(appendixTemplate);
            return generator;
        }

        public static ReadmeGenerator GenerateCodeForDemoLinks
            (this ReadmeGenerator generator,
             IEnumerable<string> links)
        {
            var demoTemplate =
                $"## Demo" + Environment.NewLine +
                $"- [Get Started With Demo]" + Environment.NewLine;
            foreach (var link in links)
            {
                demoTemplate += $"- {link}" + Environment.NewLine;
            }
            generator.AppendText(demoTemplate);

            return generator;

        }

        public static ReadmeGenerator GenerateCodeForDeploymentDetail
            (this ReadmeGenerator generator,
             string description,
             params string[] bashCommand)
        {
            var bashCommandTemplate =
                $"## Deployment" + Environment.NewLine +
                $"{description}" + Environment.NewLine;
            foreach (var command in bashCommand)
            {
                bashCommandTemplate +=
                    $"```bash" + Environment.NewLine +
                    $" {command}" + Environment.NewLine +
                    $"```" + Environment.NewLine;
            }
            generator.AppendText(bashCommandTemplate);
            return generator;
        }

        public static ReadmeGenerator GenerateCodeForDeploymentDetails
            (this ReadmeGenerator generator,
             IEnumerable<Deployment> deployments)
        {
            var template =
                $"## Deployment" + Environment.NewLine;
            foreach (var deployment in deployments)
            {
                template +=
                    $"{deployment.Description}" + Environment.NewLine;
                foreach (var command in deployment.Bashes)
                {
                    template +=
                        $"```bash" + Environment.NewLine +
                        $" {command}" + Environment.NewLine +
                        $"```" + Environment.NewLine;
                }
                template += Environment.NewLine;
            }

            generator.AppendText(template);
            return generator;
        }


        public static ReadmeGenerator GenerateCodeForFAQ
          (this ReadmeGenerator generator,
          string question,
          string answer)
        {
            var template =
                $"## FAQ" + Environment.NewLine +
                $"### {question}" + Environment.NewLine +
                $"#### {answer}" + Environment.NewLine;

            generator.AppendText(template);
            return generator;
        }
        public static ReadmeGenerator GenerateCodeForFAQs
           (this ReadmeGenerator generator,
           IEnumerable<FAQ> faqs)
        {
            var template =
               $"## FAQ" + Environment.NewLine;

            foreach (var faq in faqs)
            {
                template +=
                     $"### {faq.Question}" + Environment.NewLine +
                     $"#### {faq.Answer}" + Environment.NewLine;
            }
            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForFeature
           (this ReadmeGenerator generator,
            string feature)
        {
            var template =
              $"## Features" + Environment.NewLine +
              $"- {feature}" + Environment.NewLine;

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForFeatures
           (this ReadmeGenerator generator,
            params string[] features)
        {
            var featureTemplate =
              $"## Features" + Environment.NewLine;

            foreach (var feature in features)
            {
                featureTemplate += $"- {feature}" + Environment.NewLine;
            }

            featureTemplate += Environment.NewLine;

            generator.AppendText(featureTemplate);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForFeedBackDetail
           (this ReadmeGenerator generator,
            string feadBack)
        {
            var featureTemplate =
              $"## Feedback" + Environment.NewLine +
              $"- {feadBack}" + Environment.NewLine;

            featureTemplate += Environment.NewLine;

            generator.AppendText(featureTemplate);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForGitHub_AboutMe
           (this ReadmeGenerator generator,
            string gitHub_AboutMe)
        {
            var featureTemplate =
              $"## 🚀 About Me" + Environment.NewLine +
              $"{gitHub_AboutMe}" + Environment.NewLine;

            featureTemplate += Environment.NewLine;

            generator.AppendText(featureTemplate);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForGitHub_Introduction
           (this ReadmeGenerator generator,
            string gitHub_Introduction)
        {
            var template =
              $"# 👋 Hi" + Environment.NewLine +
              $"{gitHub_Introduction}" + Environment.NewLine;

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForGitHub_Link
          (this ReadmeGenerator generator,
           GitHubLink gitHub_links)
        {
            var logolink = GitHubLogoLinkGenerator(gitHub_links.LogoType, gitHub_links.Title);
            logolink = logolink != "CustomLink" ? logolink : gitHub_links.LogoLink;
            var template =
              $"## 🔗 Links" + Environment.NewLine +
              $@"[![{gitHub_links.Title}]({logolink})]({gitHub_links.Link})" + Environment.NewLine;

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        private static string GitHubLogoLinkGenerator(LogoLinkType logoLinkType, string title)
        {
            title = title.Replace(" ", "_");
            switch (logoLinkType)
            {
                case LogoLinkType.Github:
                    return $"https://img.shields.io/badge/{title}-000?style=for-the-badge&logo=github&logoColor=white";
                case LogoLinkType.LinkedIn:
                    return $"https://img.shields.io/badge/{title}-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white";
                case LogoLinkType.OpenAi:
                    return $"https://img.shields.io/badge/{title}-3fd2c7?style=for-the-badge&logo=openai&logoColor=white";
                case LogoLinkType.Meta:
                    return $"https://img.shields.io/badge/{title}-0000ff?style=for-the-badge&logo=meta&logoColor=white";
                case LogoLinkType.WhatsApp:
                    return $"https://img.shields.io/badge/{title}-0A66C2?style=for-the-badge&logo=whatsapp&logoColor=white";
                case LogoLinkType.Telegram:
                    return $"https://img.shields.io/badge/{title}-1ac5ff?style=for-the-badge&logo=telegram&logoColor=white";
                case LogoLinkType.Viber:
                    return $"https://img.shields.io/badge/{title}-8a2be2?style=for-the-badge&logo=viber&logoColor=white";
                case LogoLinkType.FaceBook:
                    return $"https://img.shields.io/badge/{title}-14134e?style=for-the-badge&logo=facebook&logoColor=white";
                case LogoLinkType.X:
                    return $"https://img.shields.io/badge/{title}-000?style=for-the-badge&logo=x&logoColor=white";
                case LogoLinkType.Nuget:
                    return $"https://img.shields.io/badge/{title}-4974a5?style=for-the-badge&logo=nuget&logoColor=white";
                case LogoLinkType.Gmail:
                    return $"https://img.shields.io/badge/{title}-ad1714?style=for-the-badge&logo=gmail&logoColor=white";
                case LogoLinkType.Google:
                    return $"https://img.shields.io/badge/{title}-ad1714?style=for-the-badge&logo=google&logoColor=white";
                case LogoLinkType.CustomLink:
                    return $"CustomLink";
                default:
                    return "CustomLink";
            }
        }

        public static ReadmeGenerator GenerateCodeForGitHub_Link
           (this ReadmeGenerator generator,
            string title,
            string link,
            LogoLinkType logoLinkType,
            string customLogoLink)
        {
            var logolink = GitHubLogoLinkGenerator(logoLinkType, title);
            logolink = logolink != "CustomLink" ? logolink : customLogoLink;
            var template =
              $"## 🔗 Links" + Environment.NewLine +
              $@"[![{title}]({logolink})]({link})" + Environment.NewLine;

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForGitHub_Link
            (this ReadmeGenerator generator,
             string title,
             string link)
        {
            var template =
              $"## 🔗 Links" + Environment.NewLine +
              $@"* [{title}]({link})" + Environment.NewLine;

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForGitHub_Link
            (this ReadmeGenerator generator,
             IEnumerable<GitHubLink> gitHub_links)
        {
            var template =
              $"## 🔗 Links" + Environment.NewLine;

            foreach (var link in gitHub_links)
            {
                var logolink = GitHubLogoLinkGenerator(link.LogoType, link.Title);
                logolink = logolink != "CustomLink" ? logolink : link.LogoLink;
                template +=
                  $@"[![{link.Title}]({logolink})]({link.Link})" + Environment.NewLine;
            }

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForLicense
          (this ReadmeGenerator generator,
            License license)
        {
            var template =
              $"## Licenses" + Environment.NewLine +
              $@"* [{license.Title}]({license.LicenseLink})" + Environment.NewLine;

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForLogo
          (this ReadmeGenerator generator,
            Logo logo)
        {
            var template =
              $@"![{logo.Title}]({logo.LogoLink})" + Environment.NewLine;

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForRelatedProject
         (this ReadmeGenerator generator,
           RelatedProject relatedProject)
        {
            var template =
              $"## Related Projects" + Environment.NewLine +
              $"Here are some related projects" + Environment.NewLine +
              $"* [{relatedProject.Title}]({relatedProject.ProjectLink})" + Environment.NewLine;

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForRelatedProjects
         (this ReadmeGenerator generator,
            IEnumerable<RelatedProject> relatedProjects)
        {
            var template =
                $"## Related Projects" + Environment.NewLine +
                $"Here are some related projects" + Environment.NewLine;
            foreach (var project in relatedProjects)
            {
                template += $"* [{project.Title}]({project.ProjectLink})" + Environment.NewLine;
            }

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForCustomBashCommand
            (this ReadmeGenerator generator,
              CustomBashCommand customBashCommand)
        {
            var template =
              $"## Commands" + Environment.NewLine +
              $"{customBashCommand.Title}" + Environment.NewLine;

            foreach (var bash in customBashCommand.BashCommands)
            {
                template +=
                    @$"```bash" + Environment.NewLine +
                    $@"{bash}" + Environment.NewLine +
                    $@"```" + Environment.NewLine;
            }

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForCustomBashCommands
            (this ReadmeGenerator generator,
              IEnumerable<CustomBashCommand> customBashCommands)
        {
            var template =
              $"## Commands" + Environment.NewLine;

            foreach (var customBashCommand in customBashCommands)
            {
                template += $"{customBashCommand.Title}" + Environment.NewLine;
                foreach (var bash in customBashCommand.BashCommands)
                {
                    template +=
                        @$"```bash" + Environment.NewLine +
                        $@"{bash}" + Environment.NewLine +
                        $@"```" + Environment.NewLine;
                }
            }

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForCustomTexts
            (this ReadmeGenerator generator,
              IEnumerable<CustomText> texts)
        {
            foreach (var text in texts)
            {
                var template =
                    $"## {text.Title}" + Environment.NewLine +
                    $"{text.Description}" + Environment.NewLine;

                template += Environment.NewLine;

                generator.AppendText(template);
            }

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForCustomText
            (this ReadmeGenerator generator,
              CustomText text)
        {
            var template =
              $"## {text.Title}" + Environment.NewLine +
              $"{text.Description}" + Environment.NewLine;

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForBadge
           (this ReadmeGenerator generator,
            Badge badge)
        {
            var template =
                $@"[![{badge.Title}]({badge.BadgeLink})]({badge.RedirectLink})";

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForCustomCode
          (this ReadmeGenerator generator,
            string language,
            string codeBody)
        {
            var template =
                $"```{language}" + Environment.NewLine +
                $"{codeBody}" + Environment.NewLine +
                $"```";

            template += Environment.NewLine;

            generator.AppendText(template);

            return generator;
        }

        public static ReadmeGenerator GenerateCodeForBadges
           (this ReadmeGenerator generator,
            IEnumerable<Badge> badges)
        {
            foreach (var badge in badges)
            {
                var template =
                $@"[![{badge.Title}]({badge.BadgeLink})]({badge.RedirectLink})";

                template += Environment.NewLine;

                generator.AppendText(template);
            }

            return generator;
        }
        private static string GetNormalizedLastPartOfText(string text)
        {
            return text.Split(".").Last();
        }
        public static ReadmeGenerator GenerateCodeForTypes
           (this ReadmeGenerator generator)
        {
            var template =
                $@"# Class And Method Implementation" + Environment.NewLine;
            foreach (var type in generator.Resource.Types)
            {
                template += @$"## Type : {type.Name}" + Environment.NewLine;
                if (type.GetConstructors().Length > 0)
                {
                    template += $"### This Type Has {type.GetConstructors().Length} Custom Constructor : " + Environment.NewLine;
                }
                for (int i = 0; i < type.GetConstructors().Length; i++)
                {
                    if (type.GetConstructors()[i].GetParameters().Length > 0)
                    {
                        template += $"* Constructor Number {i + 1} : " + Environment.NewLine;
                        template += $@"| Parameter | Type     | Description                |" + Environment.NewLine +
                            $@"| :-------- | :------- | :------------------------- |" + Environment.NewLine;
                    }
                    else
                    {
                        template += $"* Constructor Number {i + 1} : [ Void ] " + Environment.NewLine;
                    }
                    foreach (var parameter in type.GetConstructors()[i].GetParameters())
                    {
                        var typeName = "";
                        if (parameter.ParameterType.IsGenericType)
                        {
                            typeName = parameter.ParameterType.Name.Split("`").First();
                            var genericParameterNames = "";
                            for (int l = 0; l < parameter.ParameterType.GetGenericArguments().Length; l++)
                            {
                                genericParameterNames += parameter.ParameterType.GetGenericArguments()[l].Name.Split("`").First();
                                if (l < parameter.ParameterType.GetGenericArguments().Length - 1)
                                {
                                    genericParameterNames += ", ";
                                }
                            }
                            foreach (var genericParameter in parameter.ParameterType.GetGenericArguments())
                            {
                            }
                            typeName = $"{typeName}<{genericParameterNames}>";
                        }
                        else
                        {
                            typeName = parameter.ParameterType.Name;
                        }
                        var description = "";
                        if (parameter.CustomAttributes.Any(_ => _.AttributeType.Name.Contains("Nullable")))
                        {
                            description = "** **Not Required.** ";
                        }
                        else
                        {
                            description = "** **Required.**";
                        }
                        template += $@"| `{parameter.Name}` | `{typeName}` | {description}                    |" + Environment.NewLine;
                    }
                }
                template += $"### {type.Name} Methods : " + Environment.NewLine;

                foreach (var method in type.GetMethods()
                                           .Where(_ => _.IsPublic
                                                    && _.DeclaringType == type
                                                    && !_.Name.Contains("get_")
                                                    && !_.Name.Contains("set_")))
                {
                    var methodParameterNames = "";
                    for (int i = 0; i < method.GetParameters().Length; i++)
                    {
                        methodParameterNames += $"{method.GetParameters()[i].Name}";
                        if (i < method.GetParameters().Length - 1)
                        {
                            methodParameterNames += ", ";
                        }
                    }

                    template += $"* {method.Name}({methodParameterNames})" + Environment.NewLine;

                    if (method.GetParameters().Length > 0)
                    {
                        template += $@"| Parameter | Type     | Description                |" + Environment.NewLine +
                            $@"| :-------- | :------- | :------------------------- |" + Environment.NewLine;
                    }
                    foreach (var parameter in method.GetParameters())
                    {
                        var typeName = "";
                        if (parameter.ParameterType.IsGenericType)
                        {
                            typeName = parameter.ParameterType.Name.Split("`").First();
                            var genericParameterNames = "";
                            for (int l = 0; l < parameter.ParameterType.GetGenericArguments().Length; l++)
                            {
                                genericParameterNames += parameter.ParameterType.GetGenericArguments()[l].Name.Split("`").First();
                                if (l < parameter.ParameterType.GetGenericArguments().Length - 1)
                                {
                                    genericParameterNames += ", ";
                                }
                            }
                            foreach (var genericParameter in parameter.ParameterType.GetGenericArguments())
                            {
                            }
                            typeName = $"{typeName}<{genericParameterNames}>";
                        }
                        else
                        {
                            typeName = parameter.ParameterType.Name;
                        }
                        var description = "";
                        if (parameter.CustomAttributes.Any(_ => _.AttributeType.Name.ToLower().Contains("nullableattribute")))
                        {
                            description = "** **Not Required.** ";
                        }
                        else
                        {
                            description = "** **Required.**";
                        }
                        template += $@"| `{parameter.Name}` | `{typeName}` | {description}                      |" + Environment.NewLine;
                    }
                }

                template += Environment.NewLine;

                generator.AppendText(template);
            }

            return generator;
        }
    }
}
