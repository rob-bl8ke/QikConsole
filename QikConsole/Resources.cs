using System.IO;

namespace CygSoft.Qik.QikConsole
{
    public class Resources
    {
        public string GetWelcomeHeader()
        {
            using Stream stream = this.GetType().Assembly.
                            GetManifestResourceStream($"QikConsole.welcome.txt");
            using StreamReader sr = new StreamReader(stream);

            return sr.ReadToEnd();
        }
    }
}
