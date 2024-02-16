using DotNetReportsEngine.ReadmeGeneration.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DotNetReportsEngine.ReadmeGeneration
{
    [RenderInReadmeFile]
    public static class DotnetReportResourceExtensionMethods
    {
        public static ReadmeGenerator AddAssemblyOfType<T>
            (this ReadmeGenerator generator) where T : class
        {
            generator.Resource.Assemblies.Add(typeof(T).Assembly);
            return generator;
        }

        public static ReadmeGenerator AddAssembly
             (this ReadmeGenerator generator, Assembly assembly)
        {
            generator.Resource.Assemblies.Add(assembly);
            return generator;
        }

        public static ReadmeGenerator AddAssemblies
            (this ReadmeGenerator generator,
             IEnumerable<Assembly> assemblies)
        {
            generator.Resource.Assemblies.AddRange(assemblies);
            return generator;
        }


        public static ReadmeGenerator RenderAllAssembliesToText
            (this ReadmeGenerator generator)
        {
            generator.GenerateCodeForTypes();
            return generator;
        }

        public static ReadmeGenerator SetProjectDetail
            (this ReadmeGenerator generator,
             string title,
             string? description = null)
        {
            generator.Resource.ProjectDetail = new ProjectDetail()
            {
                Title = title,
                Description = description
            };
            generator.GenerateCodeForProjectDetail(title, description);

            return generator;
        }
        public static ReadmeGenerator AddAcknowledgement
            (this ReadmeGenerator generator,
            Acknowledgement acknowledgement)
        {
            generator.Resource.Acknowledgements.Add(acknowledgement);
            generator.GenerateCodeForAcknowledgement(
                acknowledgement.Title,
                acknowledgement.Link);

            return generator;
        }

        public static ReadmeGenerator AddAcknowledgement
             (this ReadmeGenerator generator,
              string title,
              string link)
        {
            generator.Resource
                     .Acknowledgements
                     .Add(new Acknowledgement()
                     {
                         Title = title,
                         Link = link
                     });
            generator.GenerateCodeForAcknowledgement(title, link);
            return generator;
        }

        public static ReadmeGenerator AddAcknowledgements
            (this ReadmeGenerator generator,
             IEnumerable<Acknowledgement> acknowledgements)
        {
            generator.Resource.Acknowledgements.AddRange(acknowledgements);
            generator.GenerateCodeForAcknowledgements(acknowledgements);

            return generator;
        }

        public static ReadmeGenerator AddAppendix
            (this ReadmeGenerator generator,
            Appendix appendix)
        {
            generator.Resource.Appendix.Add(appendix);
            generator.GenerateCodeForAppendix(appendix.DescriptionOrScript);
            return generator;
        }

        public static ReadmeGenerator AddAppendix
             (this ReadmeGenerator generator,
              string descriptionOrScript)
        {
            generator.Resource
                     .Appendix
                     .Add(new Appendix()
                     {
                         DescriptionOrScript = descriptionOrScript
                     });
            generator.GenerateCodeForAppendix(descriptionOrScript);
            return generator;
        }

        public static ReadmeGenerator AddAppendixes
            (this ReadmeGenerator generator,
             IEnumerable<Appendix> appendixes)
        {
            generator.Resource.Appendix.AddRange(appendixes);
            generator.GenerateCodeForAppendixes(appendixes);
            return generator;
        }

        public static ReadmeGenerator AddAuthor
            (this ReadmeGenerator generator,
            Author author)
        {
            generator.Resource.Authors.Add(author);
            generator.GenerateCodeForAuthor(
                author.Name,
                author.Link);
            return generator;
        }

        public static ReadmeGenerator AddAuthor
             (this ReadmeGenerator generator,
              string name,
              string? link)
        {
            generator.Resource
                     .Authors
                     .Add(new Author()
                     {
                         Name = name,
                         Link = link
                     });
            generator.GenerateCodeForAuthor(
                      name,
                      link);

            return generator;
        }

        public static ReadmeGenerator AddAuthors
            (this ReadmeGenerator generator,
             IEnumerable<Author> authors)
        {
            generator.Resource.Authors.AddRange(authors);
            generator.GenerateCodeForAuthors(authors);
            return generator;
        }

        public static ReadmeGenerator SetContributingDescription
           (this ReadmeGenerator generator,
            string contributingDescription)
        {
            generator.Resource
                     .ContributingDescription = contributingDescription;
            generator.GenerateCodeForContributingDescription(contributingDescription);
            return generator;
        }

        public static ReadmeGenerator AddColor
            (this ReadmeGenerator generator,
             string colorTitle,
             string hex)
        {
            generator.Resource
                     .Colors
                     .Add(new ColorReference()
                     {
                         ColorTitle = colorTitle,
                         Hex = hex
                     });
            generator.GenerateCodeForColor(
                      colorTitle,
                      hex);

            return generator;
        }
        public static ReadmeGenerator AddCcolor
            (this ReadmeGenerator generator,
             ColorReference colorReference)
        {
            generator.Resource
                     .Colors
                     .Add(colorReference);
            generator.GenerateCodeForColor(
                                  colorReference.ColorTitle,
                                  colorReference.Hex);

            return generator;
        }
        public static ReadmeGenerator AddColors
           (this ReadmeGenerator generator,
            IEnumerable<ColorReference> colors)
        {
            generator.Resource
                     .Colors
                     .AddRange(colors);

            generator.GenerateCodeForColors(colors);

            return generator;
        }

        public static ReadmeGenerator AddDemoLink
            (this ReadmeGenerator generator,
             string link)
        {
            generator.Resource.Demo.Add(link);
            return generator;
        }

        public static ReadmeGenerator AddDemoLinks
            (this ReadmeGenerator generator,
             IEnumerable<string> links)
        {
            generator.Resource.Demo.AddRange(links);
            generator.GenerateCodeForDemoLinks(links);

            return generator;
        }

        public static ReadmeGenerator AddDeploymentDetail
            (this ReadmeGenerator generator,
             string description,
             params string[] bashCommand)
        {
            generator.Resource
                     .DeploymentDetails
                     .Add(new Deployment()
                     {
                         Description = description,
                         Bashes = bashCommand.ToList()
                     });
            generator.GenerateCodeForDeploymentDetail(description, bashCommand);
            return generator;
        }
        public static ReadmeGenerator AddDeploymentDetails
            (this ReadmeGenerator generator,
             IEnumerable<Deployment> deploymentsDetails)
        {
            generator.Resource
                     .DeploymentDetails
                     .AddRange(deploymentsDetails);

            generator.GenerateCodeForDeploymentDetails(deploymentsDetails);
            return generator;
        }

        public static ReadmeGenerator AddFAQ
            (this ReadmeGenerator generator,
            string question,
            string answer)
        {
            generator.Resource
                     .FAQ
                     .Add(new FAQ()
                     {
                         Answer = answer,
                         Question = question
                     });

            generator.GenerateCodeForFAQ(question, answer);

            return generator;
        }
        public static ReadmeGenerator AddFAQs
           (this ReadmeGenerator generator,
           IEnumerable<FAQ> faqs)
        {
            generator.Resource
                     .FAQ
                     .AddRange(faqs);

            generator.GenerateCodeForFAQs(faqs);

            return generator;
        }

        public static ReadmeGenerator AddFeature
            (this ReadmeGenerator generator,
             string feature)
        {
            generator.Resource
                     .Features
                     .Add(feature);
            generator.GenerateCodeForFeature(feature);
            return generator;
        }
        public static ReadmeGenerator AddFeatures
           (this ReadmeGenerator generator,
            params string[] features)
        {
            generator.Resource
                     .Features
                     .AddRange(features);

            generator.GenerateCodeForFeatures(features);

            return generator;
        }

        public static ReadmeGenerator SetFeedBackDetail
            (this ReadmeGenerator generator,
             string feedBackDetail)
        {
            generator.Resource.FeedBackDetail = feedBackDetail;

            generator.GenerateCodeForFeedBackDetail(feedBackDetail);
            return generator;
        }

        public static ReadmeGenerator SetGitHub_AboutMe
            (this ReadmeGenerator generator,
             string gitHub_AboutMe)
        {
            generator.Resource.GitHub_AboutMe = gitHub_AboutMe;
            generator.GenerateCodeForGitHub_AboutMe(gitHub_AboutMe);
            return generator;
        }

        public static ReadmeGenerator SetGitHub_Introduction
            (this ReadmeGenerator generator,
             string gitHub_Introduction)
        {
            generator.Resource.GitHub_Introduction = gitHub_Introduction;
            generator.GenerateCodeForGitHub_Introduction(gitHub_Introduction);
            return generator;
        }

        public static ReadmeGenerator AddGitHub_Link
           (this ReadmeGenerator generator,
            GitHubLink gitHub_links)
        {
            generator.Resource.GitHub_Links.Add(gitHub_links);
            generator.GenerateCodeForGitHub_Link(gitHub_links);

            return generator;
        }

        public static ReadmeGenerator AddGitHub_Link
           (this ReadmeGenerator generator,
            string title,
            string link,
            LogoLinkType logoLinkType,
            string logoLink)
        {
            generator.Resource.GitHub_Links.Add(new GitHubLink()
            {
                Link = link,
                Title = title,
                LogoLink = logoLink,
                LogoType = logoLinkType
            });

            generator.GenerateCodeForGitHub_Link(title, link, logoLinkType, logoLink);

            return generator;
        }

        public static ReadmeGenerator AddGitHub_Link
           (this ReadmeGenerator generator,
            string title,
            string link)
        {
            generator.Resource.GitHub_Links.Add(new GitHubLink()
            {
                Link = link,
                Title = title
            });
            generator.GenerateCodeForGitHub_Link(title, link);
            return generator;
        }

        public static ReadmeGenerator AddGitHub_Links
           (this ReadmeGenerator generator,
            IEnumerable<GitHubLink> links)
        {
            generator.Resource.GitHub_Links.AddRange(links);
            generator.GenerateCodeForGitHub_Link(links);

            return generator;
        }

        public static ReadmeGenerator SetLicense
           (this ReadmeGenerator generator,
            License license)
        {
            generator.Resource.License = license;
            generator.GenerateCodeForLicense(license);
            return generator;
        }
        public static ReadmeGenerator SetLicense
           (this ReadmeGenerator generator,
            string title, string link)
        {
            generator.Resource.License = new License()
            {
                Title = title,
                LicenseLink = link
            };
            generator.GenerateCodeForLicense(new License()
            {
                Title = title,
                LicenseLink = link
            });
            return generator;
        }

        public static ReadmeGenerator SetLogo
           (this ReadmeGenerator generator,
            Logo logo)
        {
            generator.Resource.Logo = logo;
            generator.GenerateCodeForLogo(logo);
            return generator;
        }

        public static ReadmeGenerator SetLogo
           (this ReadmeGenerator generator,
            string title, string link)
        {
            generator.Resource.Logo = new Logo()
            {
                Title = title,
                LogoLink = link
            };
            generator.GenerateCodeForLogo(new Logo()
            {
                Title = title,
                LogoLink = link
            });
            return generator;
        }

        public static ReadmeGenerator AddRelatedProject
           (this ReadmeGenerator generator,
            string title,
            string link)
        {
            generator.Resource.RelatedProjects.Add(new RelatedProject()
            {
                Title = title,
                ProjectLink = link
            });
            generator.GenerateCodeForRelatedProject(new RelatedProject()
            {
                Title = title,
                ProjectLink = link
            });
            return generator;
        }

        public static ReadmeGenerator AddRelatedProject
          (this ReadmeGenerator generator,
           RelatedProject relatedProject)
        {
            generator.Resource.RelatedProjects.Add(relatedProject);
            generator.GenerateCodeForRelatedProject(relatedProject);
            return generator;
        }

        public static ReadmeGenerator AddRelatedProjects
          (this ReadmeGenerator generator,
           IEnumerable<RelatedProject> relatedProjects)
        {
            generator.Resource.RelatedProjects.AddRange(relatedProjects);
            generator.GenerateCodeForRelatedProjects(relatedProjects);
            return generator;
        }

        public static ReadmeGenerator AddCustomBashCommand
           (this ReadmeGenerator generator,
            string title,
            params string[] bashCommands)
        {
            generator.Resource
                     .CustomBashCommands
                     .Add(new CustomBashCommand()
                     {
                         Title = title,
                         BashCommands = bashCommands.ToList()
                     });
            generator.GenerateCodeForCustomBashCommand(
                new CustomBashCommand()
                {
                    Title = title,
                    BashCommands = bashCommands.ToList()
                });
            return generator;
        }

        public static ReadmeGenerator AddCustomBashCommand
          (this ReadmeGenerator generator,
           CustomBashCommand bashcommand)
        {
            generator.Resource.CustomBashCommands.Add(bashcommand);
            generator.GenerateCodeForCustomBashCommand(bashcommand);

            return generator;
        }
        public static ReadmeGenerator AddCustomBashCommand
          (this ReadmeGenerator generator,
           IEnumerable<CustomBashCommand> bashCommands)
        {
            generator.Resource.CustomBashCommands.AddRange(bashCommands);
            generator.GenerateCodeForCustomBashCommands(bashCommands);

            return generator;
        }

        public static ReadmeGenerator AddCustomText
           (this ReadmeGenerator generator,
            string title,
            string description)
        {
            generator.Resource
                     .CustomTexts
                     .Add(new CustomText()
                     {
                         Title = title,
                         Description = description
                     });
            generator.GenerateCodeForCustomText(new CustomText()
            {
                Title = title,
                Description = description
            });
            return generator;
        }

        public static ReadmeGenerator AddCustomText
          (this ReadmeGenerator generator,
           CustomText customText)
        {
            generator.Resource.CustomTexts.Add(customText);
            generator.GenerateCodeForCustomText(customText);
            return generator;
        }
        public static ReadmeGenerator AddCustomTexts
          (this ReadmeGenerator generator,
           IEnumerable<CustomText> customTexts)
        {
            generator.Resource.CustomTexts
                .AddRange(customTexts);
            generator.GenerateCodeForCustomTexts(customTexts);
            return generator;
        }

        public static ReadmeGenerator AddBadge
           (this ReadmeGenerator generator,
            string title,
            string badgeLink,
            string redirectLink)
        {
            generator.Resource
                     .Badges
                     .Add(new Badge()
                     {
                         Title = title,
                         BadgeLink = badgeLink,
                         RedirectLink = redirectLink
                     });
            generator.GenerateCodeForBadge(new Badge()
            {
                Title = title,
                BadgeLink = badgeLink,
                RedirectLink = redirectLink
            });
            return generator;
        }

        public static ReadmeGenerator AddBadge
          (this ReadmeGenerator generator,
           Badge badge)
        {
            generator.Resource.Badges.Add(badge);
            generator.GenerateCodeForBadge(badge);
            return generator;
        }
        public static ReadmeGenerator AddBadges
          (this ReadmeGenerator generator,
           IEnumerable<Badge> badges)
        {
            generator.Resource.Badges.AddRange(badges);
            generator.GenerateCodeForBadges(badges);
            return generator;
        }

        public static ReadmeGenerator AddCustomCode
         (this ReadmeGenerator generator,
            string language,
            string CodeBody)
        {
            generator.Resource.CustomCodes.Add(language, CodeBody);
            generator.GenerateCodeForCustomCode(language, CodeBody);
            return generator;
        }


    }

}
