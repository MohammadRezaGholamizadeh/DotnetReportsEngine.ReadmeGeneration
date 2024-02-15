namespace DotNetReportsEngine.ReadmeGeneration
{
    public class ReadmeGenerator
    {
        public ReadmeGenerator()
        {
            Resource = new ReadmeResource();
        }
        public string Text = string.Empty;
        public ReadmeResource Resource { get; set; }

        internal string AppendText(string text)
        {
            Text += text;
            return Text;
        }

        public ReadmeResource GetResources()
        {
            return Resource;
        }

        public string GetText()
        {
            return Text;
        }

    }
}
