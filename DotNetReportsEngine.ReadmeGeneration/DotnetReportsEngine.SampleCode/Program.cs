using DotnetReportsEngine.SampleCode;
using DotNetReportsEngine.ReadmeGeneration;
using DotNetReportsEngine.ReadmeGeneration.Details;

var ReadmeGenerator =
    new ReadmeGenerator()
        .AddAssembly(typeof(ReadmeGenerator).Assembly)
        .SetProjectDetail("Readme Generator ", "This Package Was Developed For Generating The Base Readme File To Improve The Speed Of Ccreating Standard Readme File and Make It Easy to All Developers To Creating Readme File Automatically . Enjoy It")
        .AddAppendixes(new List<Appendix>()
        {
            new Appendix()
            {
                DescriptionOrScript = "Hi",
            },
            new Appendix()
            {
                DescriptionOrScript = "Hello"
            }
        })
        .AddAuthor("@Mohammadreza Gholamizadeh [Phoenix]", "https://github.com/MohammadRezaGholamizadeh")
        .SetGitHub_AboutMe("I Am Dotnet Software Developer That Always Try To Make All things Easy for Developing")
        .AddGitHub_Links(new List<GitHubLink>()
        {
            new GitHubLink()
            {
                LogoType = LogoLinkType.Github,
                Title = "GitHub",
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
        .RenderAllAssembliesToText()
        ;

Console.Read();