# Readme Generator 
This Package Was Developed For Generating The Base Readme File To Improve The Speed Of Creating Standard Readme File and Make It Easy to All Developers To Creating Readme File Automatically . Enjoy It
![Logo](https://raw.githubusercontent.com/MohammadRezaGholamizadeh/DotnetReportsEngine.ReadmeGeneration/main/DotNetReportsEngine.ReadmeGeneration/DotNetReportsEngine.ReadmeGeneration/ReadmeLogo.ico)

## Authors
- [@Mohammadreza Gholamizadeh [Phoenix]](https://github.com/MohammadRezaGholamizadeh)
## 🚀 About Me
I MohammadReza Gholamizadeh. I`m Dotnet Software Developer That Always Try To Make All things Easy for Developing. Please Star the Project And Package to Cover.

## 🔗 Links
[![Source Code](https://img.shields.io/badge/Source_Code-000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/MohammadRezaGholamizadeh/DotnetReportsEngine.ReadmeGeneration)
[![Sample Code To Get Start](https://img.shields.io/badge/Sample_Code_To_Get_Start-ad1714?style=for-the-badge&logo=github&logoColor=white)](https://github.com/MohammadRezaGholamizadeh/DotnetReportsEngine.ReadmeGeneration/blob/main/DotNetReportsEngine.ReadmeGeneration/DotnetReportsEngine.SampleCode/Program.cs)
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
| `assembly` | `Assembly` | ** **Required.** The Assembly That You Want To Add All Types In It To ReadMe File Generator.|

This Method Add Assembly That You Want To Add All Types In It To ReadMe File Generator.

* AddAssemblies(generator, assemblies)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `assemblies` | `IEnumerable<Assembly>` | ** **Required.** The Assembly That You Want To Add All Types In It To ReadMe File Generator.|

This Method Add Assembly That You Want To Add All Types In It To ReadMe File Generator.

* RenderAllAssembliesToText(generator)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |

This Method Generate Text Format For All Assembly That You Want To Add All Types In It To ReadMe File Generator.

* SetProjectDetail(generator, title, description)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `description` | `String` | ** **Not Required.**                       |

This Method Generate Text Format For Project Detail That You Want To Add It To ReadMe File.

* AddAcknowledgement(generator, acknowledgement)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `acknowledgement` | `Acknowledgement` | ** **Required.**                      |

This Method Generate Text Format For Acknowledgement That You Want To Add It To ReadMe File.

* AddAcknowledgement(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

This Method Generate Text Format For Acknowledgement That You Want To Add It To ReadMe File.

* AddAcknowledgements(generator, acknowledgements)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `acknowledgements` | `IEnumerable<Acknowledgement>` | ** **Required.**                      |

This Method Generate Text Format For Acknowledgement That You Want To Add It To ReadMe File.

* AddAppendix(generator, appendix)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `appendix` | `Appendix` | ** **Required.**                      |

This Method Generate Text Format For Appendix(Additional Information)  That You Want To Add It To ReadMe File.

* AddAppendix(generator, descriptionOrScript)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `descriptionOrScript` | `String` | ** **Required.**                      |

This Method Generate Text Format For Appendix(Additional Information)  That You Want To Add It To ReadMe File.

* AddAppendixes(generator, appendixes)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `appendixes` | `IEnumerable<Appendix>` | ** **Required.**                      |

This Method Generate Text Format For Appendix(Additional Information)  That You Want To Add It To ReadMe File.

* AddAuthor(generator, author)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `author` | `Author` | ** **Required.**                      |

This Method Generate Text Format For Author Info That You Want To Add It To ReadMe File.

* AddAuthor(generator, name, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `name` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Not Required.**                       |

This Method Generate Text Format For Author Info That You Want To Add It To ReadMe File.

* AddAuthors(generator, authors)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `authors` | `IEnumerable<Author>` | ** **Required.**                      |

This Method Generate Text Format For Author Info That You Want To Add It To ReadMe File.

* SetContributingDescription(generator, contributingDescription)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `contributingDescription` | `String` | ** **Required.**                      |

This Method Generate Text Format For Contributing Info That You Want To Add It To ReadMe File.

* AddColor(generator, colorTitle, hex)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `colorTitle` | `String` | ** **Required.**                      |
| `hex` | `String` | ** **Required.**                      |

This Method Generate Text Format For Color Table That You Want To Add It To ReadMe File.

* AddCcolor(generator, colorReference)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `colorReference` | `ColorReference` | ** **Required.**                      |

This Method Generate Text Format For Color Table That You Want To Add It To ReadMe File.

* AddColors(generator, colors)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `colors` | `IEnumerable<ColorReference>` | ** **Required.**                      |

This Method Generate Text Format For Color Table That You Want To Add It To ReadMe File.

* AddDemoLink(generator, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

This Method Generate Text Format For Demo That You Want To Add It To ReadMe File.

* AddDemoLinks(generator, links)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `links` | `IEnumerable<String>` | ** **Required.**                      |

This Method Generate Text Format For Demo That You Want To Add It To ReadMe File.

* AddDeploymentDetail(generator, description, bashCommand)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `description` | `String` | ** **Required.**                      |
| `bashCommand` | `String[]` | ** **Required.**                      |

This Method Generate Text Format For Deployment Detail That You Want To Add It To ReadMe File.

* AddDeploymentDetails(generator, deploymentsDetails)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `deploymentsDetails` | `IEnumerable<Deployment>` | ** **Required.**                      |

This Method Generate Text Format For Deployment Detail That You Want To Add It To ReadMe File.

* AddFAQ(generator, question, answer)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `question` | `String` | ** **Required.**                      |
| `answer` | `String` | ** **Required.**                      |

This Method Generate Text Format For Question and Answer That You Want To Add It To ReadMe File.

* AddFAQs(generator, faqs)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `faqs` | `IEnumerable<FAQ>` | ** **Required.**                      |

This Method Generate Text Format For Question and Answer That You Want To Add It To ReadMe File.

* AddFeature(generator, feature)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `feature` | `String` | ** **Required.**                      |

This Method Generate Text Format For Feature Detail That You Want To Add It To ReadMe File.

* AddFeatures(generator, features)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `features` | `String[]` | ** **Required.**                      |

This Method Generate Text Format For Feature Detail That You Want To Add It To ReadMe File.

* SetFeedBackDetail(generator, feedBackDetail)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `feedBackDetail` | `String` | ** **Required.**                      |

This Method Generate Text Format For FeedBack Info That You Want To Add It To ReadMe File.

* SetGitHub_AboutMe(generator, gitHub_AboutMe)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `gitHub_AboutMe` | `String` | ** **Required.**                      |

This Method Generate Text Format For Your Personal Description Abount YourSelf That You Want To Add It To ReadMe File.

* SetGitHub_Introduction(generator, gitHub_Introduction)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `gitHub_Introduction` | `String` | ** **Required.**                      |

This Method Generate Text Format For Your Personal Description Abount YourSelf That You Want To Add It To ReadMe File.

* AddGitHub_Link(generator, gitHub_links)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `gitHub_links` | `GitHubLink` | ** **Required.**                      |

This Method Generate Text Format For GitHub Link That You Want To Add It To ReadMe File.

* AddGitHub_Link(generator, title, link, logoLinkType, logoLink)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |
| `logoLinkType` | `LogoLinkType` | ** **Required.**                      |
| `logoLink` | `String` | ** **Required.**                      |

This Method Generate Text Format For GitHub Link That You Want To Add It To ReadMe File.

* AddGitHub_Link(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

This Method Generate Text Format For GitHub Link That You Want To Add It To ReadMe File.

* AddGitHub_Links(generator, links)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `links` | `IEnumerable<GitHubLink>` | ** **Required.**                      |

This Method Generate Text Format For GitHub Link That You Want To Add It To ReadMe File.

* SetLicense(generator, license)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `license` | `License` | ** **Required.**                      |

This Method Generate Text Format For License Info That You Want To Add It To ReadMe File.

* SetLicense(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

This Method Generate Text Format For License Info That You Want To Add It To ReadMe File.

* SetLogo(generator, logo)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `logo` | `Logo` | ** **Required.**                      |

This Method Generate Text Format For Logo That You Want To Add It To ReadMe File.

* SetLogo(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

This Method Generate Text Format For Logo That You Want To Add It To ReadMe File.

* AddRelatedProject(generator, title, link)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `link` | `String` | ** **Required.**                      |

This Method Generate Text Format For Related Project Info That You Want To Add It To ReadMe File.

* AddRelatedProject(generator, relatedProject)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `relatedProject` | `RelatedProject` | ** **Required.**                      |

This Method Generate Text Format For Related Project Info That You Want To Add It To ReadMe File.

* AddRelatedProjects(generator, relatedProjects)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `relatedProjects` | `IEnumerable<RelatedProject>` | ** **Required.**                      |

This Method Generate Text Format For Related Project Info That You Want To Add It To ReadMe File.

* AddCustomBashCommand(generator, title, bashCommands)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `bashCommands` | `String[]` | ** **Required.**                      |

This Method Generate Text Format For Custom Bash Command That You Want To Add It To ReadMe File.

* AddCustomBashCommand(generator, bashcommand)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `bashcommand` | `CustomBashCommand` | ** **Required.**                      |

This Method Generate Text Format For Custom Bash Command That You Want To Add It To ReadMe File.

* AddCustomBashCommand(generator, bashCommands)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `bashCommands` | `IEnumerable<CustomBashCommand>` | ** **Required.**                      |

This Method Generate Text Format For Custom Bash Command That You Want To Add It To ReadMe File.

* AddCustomText(generator, title, description)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `description` | `String` | ** **Required.**                      |

This Method Generate Text Format For Custom Text That You Want To Add It To ReadMe File.

* AddCustomText(generator, customText)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `customText` | `CustomText` | ** **Required.**                      |

This Method Generate Text Format For Custom Text That You Want To Add It To ReadMe File.

* AddCustomTexts(generator, customTexts)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `customTexts` | `IEnumerable<CustomText>` | ** **Required.**                      |

This Method Generate Text Format For Custom Text That You Want To Add It To ReadMe File.

* AddBadge(generator, title, badgeLink, redirectLink)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `title` | `String` | ** **Required.**                      |
| `badgeLink` | `String` | ** **Required.**                      |
| `redirectLink` | `String` | ** **Required.**                      |

This Method Generate Text Format For Custom Badge That You Want To Add It To ReadMe File.

* AddBadge(generator, badge)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `badge` | `Badge` | ** **Required.**                      |

This Method Generate Text Format For Custom Badge That You Want To Add It To ReadMe File.

* AddBadges(generator, badges)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `badges` | `IEnumerable<Badge>` | ** **Required.**                      |

This Method Generate Text Format For Custom Badge That You Want To Add It To ReadMe File.

* AddCustomCode(generator, language, CodeBody)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `generator` | `ReadmeGenerator` | ** **Required.**                      |
| `language` | `String` | ** **Required.**                      |
| `CodeBody` | `String` | ** **Required.**                      |

This Method Generate Text Format For Custom Code That You Want To Add It To ReadMe File.