namespace DotNetReportsEngine.ReadmeGeneration
{
    public class ReadmeGenerator
    {
        internal string Text = string.Empty;
        internal ReadmeResource Resource => new ReadmeResource();

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
