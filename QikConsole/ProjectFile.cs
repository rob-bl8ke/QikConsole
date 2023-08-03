using System.Text;
using System.Text.Json;
using System.IO;

namespace CygSoft.Qik.QikConsole
{
    public interface IProjectFile
    {
        void Write(Project project, string path);
        Project Read(string path);
    }

    public class ProjectFile : IProjectFile
    {
        public void Write(Project project, string path)
        {
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = true };
            var result = new StringBuilder();

            result.Append(JsonSerializer.Serialize<Project>(project, options));

            WriteTextFile(path, result.ToString());
        }

        public Project Read(string path)
        {
            var text = ReadTextFile(path);
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var project = JsonSerializer.Deserialize<Project>(text, options);
            return project;
        }

        private string ReadTextFile(string filePath)
        {
            string contents = null;
            
            using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    contents = sr.ReadToEnd();
                }
            }
            return contents;
        }

        private void WriteTextFile(string path, string contents)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.Write(contents);
                streamWriter.Flush();
            }
        }
    }
}
