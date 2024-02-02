using DotNetReportsEngine.ReadmeGeneration;
using DotNetReportsEngine.ReadmeGeneration.Details;

var ReadmeGenerator =
    new ReadmeGenerator()
        .SetProjectDetail("Readme Generator Test" , "detail")
        .AddAcknowledgement("Awesome README" , "https://github.com/matiassingers/awesome-readme")
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
        .GetText();
Console.Read();