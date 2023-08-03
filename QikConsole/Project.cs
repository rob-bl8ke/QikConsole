using System.Collections.Generic;

namespace CygSoft.Qik.QikConsole
{
    public class Project
    {
        public string ScriptPath { get; set; }
        
        public List<string> PreExecutionScripts { get; set; } = new List<string>();
        public List<string> PostExecutionScripts { get; set; } = new List<string>();

        public List<Fragment> Fragments { get; set; } = new List<Fragment>();
        public List<Document> Documents { get; set; } = new List<Document>();
    }

    public class Fragment
    {
        public string Id { get; set; }
        public string Path { get; set; }
    }

    public class Input
    {
        public string Symbol { get; set; }
        public string Value { get; set; }
    }

    public class Document
    {
        public string[] OutputFilePaths { get; set; }
        public string[] Structure { get; set; }
    }
}
