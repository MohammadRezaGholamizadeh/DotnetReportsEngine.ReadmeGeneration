# Readme Generator 
This Package Was Developed For Generating The Base Readme File To Improve The Speed Of Creating Standard Readme File and Make It Easy to All Developers To Creating Readme File Automatically . Enjoy It
![Logo](https://raw.githubusercontent.com/MohammadRezaGholamizadeh/DotnetReportsEngine.ReadmeGeneration/main/DotNetReportsEngine.ReadmeGeneration/DotNetReportsEngine.ReadmeGeneration/ReadmeLogo.ico)

## Authors
- [@Mohammadreza Gholamizadeh [Phoenix]](https://github.com/MohammadRezaGholamizadeh)
## 🚀 About Me
I MohammadReza Gholamizadeh. I`m Dotnet Software Developer That Always Try To Make All things Easy for Developing. Please Star the Project And Package to Cover.

## 🔗 Links
[![Source Code](https://img.shields.io/badge/Source_Code-000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/MohammadRezaGholamizadeh/DotnetReportsEngine.ReadmeGeneration)
[![MohammadReza Gholamizadeh GitHub](https://img.shields.io/badge/MohammadReza_Gholamizadeh_GitHub-000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/MohammadRezaGholamizadeh)
[![Nuget](https://img.shields.io/badge/Nuget-4974a5?style=for-the-badge&logo=nuget&logoColor=white)](https://www.nuget.org/profiles/MohammadrezaGholamizadeh_Phoenix)

## Licenses
* [AGPL-3.0 license](https://github.com/MohammadRezaGholamizadeh/DotnetReportsEngine.ReadmeGeneration?tab=AGPL-3.0-1-ov-file#)

## Way To Register All Types That You Want To Introduce In Readme File
### For This You Must To Use [ RenderInReadmeFile ] Attribute On Every Class That You Want To Introduce In Readme File. Like This : 

```C#
namespace DotnetReportsEngine.SampleCode
{
    [RenderInReadmeFile]
    public class DotnetReportResourcesss
    {
```
# Class And Method Implementation
## Type : DotnetReportResourceExtensionMethods
### DotnetReportResourceExtensionMethods Methods : 

* AddAssemblyOfType(generator)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |

* AddAssembly(generator, assembly)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `assembly` | `Assembly` | ** **Required.**                      |

* AddAssemblies(generator, assemblies)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `assemblies` | `IEnumerable<Assembly>` | ** **Required.**                      |

* RenderAllAssembliesToText(generator)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |

* ExceptType(generator)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |

* ExceptTypes(generator, types)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `types` | `Type[]` | ** **Required.**                      |

* SetProjectDetail(generator, title, description)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `description` | `String` | ** **Not Required.**                       |

* AddAcknowledgement(generator, acknowledgement)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `acknowledgement` | `Acknowledgement` | ** **Required.**                      |

* AddAcknowledgement(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

* AddAcknowledgements(generator, acknowledgements)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `acknowledgements` | `IEnumerable<Acknowledgement>` | ** **Required.**                      |

* AddAppendix(generator, appendix)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `appendix` | `Appendix` | ** **Required.**                      |

* AddAppendix(generator, descriptionOrScript)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `descriptionOrScript` | `String` | ** **Required.**                      |

* AddAppendixes(generator, appendixes)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `appendixes` | `IEnumerable<Appendix>` | ** **Required.**                      |

* AddAuthor(generator, author)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `author` | `Author` | ** **Required.**                      |

* AddAuthor(generator, name, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `name` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Not Required.**                       |

* AddAuthors(generator, authors)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `authors` | `IEnumerable<Author>` | ** **Required.**                      |

* SetContributingDescription(generator, contributingDescription)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `contributingDescription` | `String` | ** **Required.**                      |

* AddColor(generator, colorTitle, hex)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `colorTitle` | `String` | ** **Required.**                      |
| `hex` | `String` | ** **Required.**                      |

* AddCcolor(generator, colorReference)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `colorReference` | `ColorReference` | ** **Required.**                      |

* AddColors(generator, colors)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `colors` | `IEnumerable<ColorReference>` | ** **Required.**                      |

* AddDemoLink(generator, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

* AddDemoLinks(generator, links)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `links` | `IEnumerable<String>` | ** **Required.**                      |

* AddDeploymentDetail(generator, description, bashCommand)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `description` | `String` | ** **Required.**                      |
| `bashCommand` | `String[]` | ** **Required.**                      |

* AddDeploymentDetails(generator, deploymentsDetails)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `deploymentsDetails` | `IEnumerable<Deployment>` | ** **Required.**                      |

* AddFAQ(generator, question, answer)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `question` | `String` | ** **Required.**                      |
| `answer` | `String` | ** **Required.**                      |

* AddFAQs(generator, faqs)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `faqs` | `IEnumerable<FAQ>` | ** **Required.**                      |

* AddFeature(generator, feature)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `feature` | `String` | ** **Required.**                      |

* AddFeatures(generator, features)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `features` | `String[]` | ** **Required.**                      |

* SetFeedBackDetail(generator, feedBackDetail)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `feedBackDetail` | `String` | ** **Required.**                      |

* SetGitHub_AboutMe(generator, gitHub_AboutMe)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `gitHub_AboutMe` | `String` | ** **Required.**                      |

* SetGitHub_Introduction(generator, gitHub_Introduction)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `gitHub_Introduction` | `String` | ** **Required.**                      |

* AddGitHub_Link(generator, gitHub_links)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `gitHub_links` | `GitHubLink` | ** **Required.**                      |

* AddGitHub_Link(generator, title, link, logoLinkType, logoLink)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |
| `logoLinkType` | `LogoLinkType` | ** **Required.**                      |
| `logoLink` | `String` | ** **Required.**                      |

* AddGitHub_Link(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

* AddGitHub_Links(generator, links)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `links` | `IEnumerable<GitHubLink>` | ** **Required.**                      |

* SetLicense(generator, license)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `license` | `License` | ** **Required.**                      |

* SetLicense(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

* SetLogo(generator, logo)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `logo` | `Logo` | ** **Required.**                      |

* SetLogo(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

* AddRelatedProject(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

* AddRelatedProject(generator, relatedProject)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `relatedProject` | `RelatedProject` | ** **Required.**                      |

* AddRelatedProjects(generator, relatedProjects)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `relatedProjects` | `IEnumerable<RelatedProject>` | ** **Required.**                      |

* AddCustomBashCommand(generator, title, bashCommands)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `bashCommands` | `String[]` | ** **Required.**                      |

* AddCustomBashCommand(generator, bashcommand)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `bashcommand` | `CustomBashCommand` | ** **Required.**                      |

* AddCustomBashCommand(generator, bashCommands)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `bashCommands` | `IEnumerable<CustomBashCommand>` | ** **Required.**                      |

* AddCustomText(generator, title, description)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `description` | `String` | ** **Required.**                      |

* AddCustomText(generator, customText)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `customText` | `CustomText` | ** **Required.**                      |

* AddCustomTexts(generator, customTexts)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `customTexts` | `IEnumerable<CustomText>` | ** **Required.**                      |

* AddBadge(generator, title, badgeLink, redirectLink)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `badgeLink` | `String` | ** **Required.**                      |
| `redirectLink` | `String` | ** **Required.**                      |

* AddBadge(generator, badge)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `badge` | `Badge` | ** **Required.**                      |

* AddBadges(generator, badges)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `badges` | `IEnumerable<Badge>` | ** **Required.**                      |

* AddCustomCode(generator, language, CodeBody)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `language` | `String` | ** **Required.**                      |
| `CodeBody` | `String` | ** **Required.**                      |


# Class And Method Implementation
## Type : DotnetReportResourceExtensionMethods
### DotnetReportResourceExtensionMethods Methods : 

* AddAssemblyOfType(generator)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |

* AddAssembly(generator, assembly)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `assembly` | `Assembly` | ** **Required.**                      |

* AddAssemblies(generator, assemblies)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `assemblies` | `IEnumerable<Assembly>` | ** **Required.**                      |

* RenderAllAssembliesToText(generator)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |

* ExceptType(generator)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |

* ExceptTypes(generator, types)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `types` | `Type[]` | ** **Required.**                      |

* SetProjectDetail(generator, title, description)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `description` | `String` | ** **Not Required.**                       |

* AddAcknowledgement(generator, acknowledgement)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `acknowledgement` | `Acknowledgement` | ** **Required.**                      |

* AddAcknowledgement(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

* AddAcknowledgements(generator, acknowledgements)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `acknowledgements` | `IEnumerable<Acknowledgement>` | ** **Required.**                      |

* AddAppendix(generator, appendix)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `appendix` | `Appendix` | ** **Required.**                      |

* AddAppendix(generator, descriptionOrScript)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `descriptionOrScript` | `String` | ** **Required.**                      |

* AddAppendixes(generator, appendixes)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `appendixes` | `IEnumerable<Appendix>` | ** **Required.**                      |

* AddAuthor(generator, author)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `author` | `Author` | ** **Required.**                      |

* AddAuthor(generator, name, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `name` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Not Required.**                       |

* AddAuthors(generator, authors)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `authors` | `IEnumerable<Author>` | ** **Required.**                      |

* SetContributingDescription(generator, contributingDescription)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `contributingDescription` | `String` | ** **Required.**                      |

* AddColor(generator, colorTitle, hex)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `colorTitle` | `String` | ** **Required.**                      |
| `hex` | `String` | ** **Required.**                      |

* AddCcolor(generator, colorReference)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `colorReference` | `ColorReference` | ** **Required.**                      |

* AddColors(generator, colors)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `colors` | `IEnumerable<ColorReference>` | ** **Required.**                      |

* AddDemoLink(generator, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

* AddDemoLinks(generator, links)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `links` | `IEnumerable<String>` | ** **Required.**                      |

* AddDeploymentDetail(generator, description, bashCommand)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `description` | `String` | ** **Required.**                      |
| `bashCommand` | `String[]` | ** **Required.**                      |

* AddDeploymentDetails(generator, deploymentsDetails)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `deploymentsDetails` | `IEnumerable<Deployment>` | ** **Required.**                      |

* AddFAQ(generator, question, answer)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `question` | `String` | ** **Required.**                      |
| `answer` | `String` | ** **Required.**                      |

* AddFAQs(generator, faqs)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `faqs` | `IEnumerable<FAQ>` | ** **Required.**                      |

* AddFeature(generator, feature)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `feature` | `String` | ** **Required.**                      |

* AddFeatures(generator, features)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `features` | `String[]` | ** **Required.**                      |

* SetFeedBackDetail(generator, feedBackDetail)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `feedBackDetail` | `String` | ** **Required.**                      |

* SetGitHub_AboutMe(generator, gitHub_AboutMe)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `gitHub_AboutMe` | `String` | ** **Required.**                      |

* SetGitHub_Introduction(generator, gitHub_Introduction)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `gitHub_Introduction` | `String` | ** **Required.**                      |

* AddGitHub_Link(generator, gitHub_links)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `gitHub_links` | `GitHubLink` | ** **Required.**                      |

* AddGitHub_Link(generator, title, link, logoLinkType, logoLink)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |
| `logoLinkType` | `LogoLinkType` | ** **Required.**                      |
| `logoLink` | `String` | ** **Required.**                      |

* AddGitHub_Link(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

* AddGitHub_Links(generator, links)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `links` | `IEnumerable<GitHubLink>` | ** **Required.**                      |

* SetLicense(generator, license)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `license` | `License` | ** **Required.**                      |

* SetLicense(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

* SetLogo(generator, logo)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `logo` | `Logo` | ** **Required.**                      |

* SetLogo(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

* AddRelatedProject(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

* AddRelatedProject(generator, relatedProject)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `relatedProject` | `RelatedProject` | ** **Required.**                      |

* AddRelatedProjects(generator, relatedProjects)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `relatedProjects` | `IEnumerable<RelatedProject>` | ** **Required.**                      |

* AddCustomBashCommand(generator, title, bashCommands)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `bashCommands` | `String[]` | ** **Required.**                      |

* AddCustomBashCommand(generator, bashcommand)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `bashcommand` | `CustomBashCommand` | ** **Required.**                      |

* AddCustomBashCommand(generator, bashCommands)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `bashCommands` | `IEnumerable<CustomBashCommand>` | ** **Required.**                      |

* AddCustomText(generator, title, description)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `description` | `String` | ** **Required.**                      |

* AddCustomText(generator, customText)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `customText` | `CustomText` | ** **Required.**                      |

* AddCustomTexts(generator, customTexts)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `customTexts` | `IEnumerable<CustomText>` | ** **Required.**                      |

* AddBadge(generator, title, badgeLink, redirectLink)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `badgeLink` | `String` | ** **Required.**                      |
| `redirectLink` | `String` | ** **Required.**                      |

* AddBadge(generator, badge)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `badge` | `Badge` | ** **Required.**                      |

* AddBadges(generator, badges)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `badges` | `IEnumerable<Badge>` | ** **Required.**                      |

* AddCustomCode(generator, language, CodeBody)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `language` | `String` | ** **Required.**                      |
| `CodeBody` | `String` | ** **Required.**                      |


## Type : ReadmeGenerator
### This Type Has 1 Custom Constructor : 
* Constructor Number 1 : [ Void ] 
### ReadmeGenerator Methods : 

* GetResources()


* GetText()



