using DotnetReportsEngine.SampleCode;
using DotNetReportsEngine.ReadmeGeneration;
using DotNetReportsEngine.ReadmeGeneration.Details;

var s = typeof(DotnetReportResourcesss).GetMethods().Where(_ => _.IsPublic && _.DeclaringType == typeof(DotnetReportResourcesss));
var ReadmeGenerator =
    new ReadmeGenerator()
        .AddAssembly(typeof(Program).Assembly)
        .SetProjectDetail("Readme Generator Test", "detail")
        .AddAcknowledgement("Awesome README", "https://github.com/matiassingers/awesome-readme")
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
        .AddAuthor("Mohammadreza", "google.com")
        .AddColor("Black", "00b48a")
        .SetContributingDescription("This is Test For Text")
        .AddDemoLink("")
        .AddFAQ("Hello", "To You")
        .AddFeatures("Hi1", "Hi2")
        .RenderAllAssembliesToText();
Console.Read();