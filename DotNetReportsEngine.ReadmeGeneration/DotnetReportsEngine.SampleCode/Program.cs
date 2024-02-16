using DotNetReportsEngine.ReadmeGeneration;
using DotNetReportsEngine.ReadmeGeneration.Details;

var generatedReadme =
    new ReadmeGenerator()
        .AddAssembly(typeof(ReadmeGenerator).Assembly)
        .SetProjectDetail("Readme Generator ", "This Package Was Developed For Generating The Base Readme File To Improve The Speed Of Creating Standard Readme File and Make It Easy to All Developers To Creating Readme File Automatically . Enjoy It")
        .SetLogo(new Logo()
        {
            Title = "Logo",
            LogoLink = "https://raw.githubusercontent.com/MohammadRezaGholamizadeh/DotnetReportsEngine.ReadmeGeneration/main/DotNetReportsEngine.ReadmeGeneration/DotNetReportsEngine.ReadmeGeneration/ReadmeLogo.ico"
        })
        .AddAuthor("@Mohammadreza Gholamizadeh [Phoenix]", "https://github.com/MohammadRezaGholamizadeh")
        .SetGitHub_AboutMe("I MohammadReza Gholamizadeh. I`m Dotnet Software Developer That Always Try To Make All things Easy for Developing. Please Star the Project And Package to Cover.")
        .AddGitHub_Links(new List<GitHubLink>()
        {
            new GitHubLink()
            {
                Title = "Source Code",
                LogoType = LogoLinkType.Github,
                Link = "https://github.com/MohammadRezaGholamizadeh/DotnetReportsEngine.ReadmeGeneration"
            },
            new GitHubLink()
            {
                LogoType = LogoLinkType.Github,
                Title = "MohammadReza Gholamizadeh GitHub",
                Link = "https://github.com/MohammadRezaGholamizadeh",
            },
            new GitHubLink()
            {
                LogoType = LogoLinkType.Nuget,
                Title = "Nuget",
                Link = "https://www.nuget.org/profiles/MohammadrezaGholamizadeh_Phoenix"
            }
        })
        .SetLicense(new License()
        {
            Title = "AGPL-3.0 license",
            LicenseLink = "https://github.com/MohammadRezaGholamizadeh/DotnetReportsEngine.ReadmeGeneration?tab=AGPL-3.0-1-ov-file#"
        })
        .AddCustomText(new CustomText()
        {
            Title = "Way To Register All Types That You Want To Introduce In Readme File",
            Description = "### For This You Must To Use [ RenderInReadmeFile ] Attribute On Every Class That You Want To Introduce In Readme File. Like This : "
        })
        .AddCustomCode("C#",
        "namespace DotnetReportsEngine.SampleCode" + Environment.NewLine +
        "{" + Environment.NewLine +
        "    [RenderInReadmeFile]" + Environment.NewLine +
        "    public class DotnetReportResourcesss" + Environment.NewLine +
        "    {")
        .RenderAllAssembliesToText()
        .GetText();

File.WriteAllText(@$"D:\All Projects\DotnetReportsEngine.ReadmeGeneration\README.md", generatedReadme);

Console.Read();