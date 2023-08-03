using CygSoft.Qik.QikConsole;
using NUnit.Framework;
using System.Linq;
using Moq;

namespace QikConsoleTests
{
    [TestFixture]
    class ProjectFileTests
    {
        [Test]
        public void Should_Write_To_Project_File()
        {
            // Assert.True()
            // var project = new Project();
            
            // project.ScriptPath = "kv_script_file.qik";

            // project.PreExecutionScripts.Add("C:\\Users\\RobB\\Desktop\\pre_script_a.ps1");
            // project.PreExecutionScripts.Add("C:\\Users\\RobB\\Desktop\\pre_script_b.ps1");

            // project.PostExecutionScripts.Add("C:\\Users\\RobB\\Desktop\\post_script_a.ps1");
            // project.PostExecutionScripts.Add("C:\\Users\\RobB\\Desktop\\post_script_b.ps1");

            // project.Fragments.Add(new Fragment { Id = "fragment_A", Path = "C:\\Users\\RobB\\Desktop\\fragment_A.txt"});
            // project.Fragments.Add(new Fragment { Id = "fragment_B", Path = "C:\\Users\\RobB\\Desktop\\fragment_B.txt" });

            // project.Documents.Add(new Document 
            // { 
            //     OutputFilePaths = new string[2] { "/documents/document1.txt", "/desktop/document2.txt" },
            //     Structure = new string [1] { "fragment_A" }
            // });

            // project.Documents.Add(new Document 
            // { 
            //     OutputFilePaths = new string[1] { "/documents/document2.txt" },
            //     Structure = new string [2] {"fragment_A", "fragment_B" }
            // });

            // var writer = new ProjectFile();
            // writer.Write(project, FileHelpers.ResolvePath("project.json"));

            // var writtenProject = writer.Read(FileHelpers.ResolvePath("project.json"));

            // FileHelpers.DeleteFile("project.json");

            // Assert.IsNotNull(writtenProject);

            // Assert.IsTrue(writtenProject.Fragments.Count() == 2, "Unexpected number of fragments read from project file");

            // var fragmentA = project.Fragments[0];
            // var fragmentB = project.Fragments[1];

            // Assert.IsTrue(fragmentA.Id == "fragment_A", "Unexpected fragment id read from project file");
            // Assert.IsTrue(fragmentB.Id == "fragment_B", "Unexpected fragment id read from project file");

            // Assert.IsTrue(fragmentA.Path == "C:\\Users\\RobB\\Desktop\\fragment_A.txt", "Unexpected fragment path read from project file");
            // Assert.IsTrue(fragmentB.Path == "C:\\Users\\RobB\\Desktop\\fragment_B.txt", "Unexpected fragment path read from project file");

            // Assert.IsTrue(project.ScriptPath == "kv_script_file.qik", "Unexpected processor script path read from project file");

            // Assert.IsTrue(writtenProject.Documents.Count() == 2);

            // var documentA = writtenProject.Documents[0];

            // Assert.IsTrue(documentA.OutputFilePaths[0] == "/documents/document1.txt", "Unexpected document output file read from project file");
            // Assert.IsTrue(documentA.OutputFilePaths[1] == "/desktop/document2.txt", "Unexpected output file read from project file");

            // Assert.IsTrue(documentA.Structure[0] == "fragment_A", "Unexpected structure id read from project file");
            
            // var documentB = writtenProject.Documents[1];

            // Assert.IsTrue(documentB.OutputFilePaths[0] == "/documents/document2.txt", "Unexpected document output file read from project file");
            // Assert.IsTrue(documentB.Structure[0] == "fragment_A", "Unexpected structure id read from project file");
            // Assert.IsTrue(documentB.Structure[1] == "fragment_B", "Unexpected structure id read from project file");

            // var preScriptA = project.PreExecutionScripts[0];
            // var preScriptB = project.PreExecutionScripts[1];

            // var postcriptA = project.PostExecutionScripts[0];
            // var postcriptB = project.PostExecutionScripts[1];

            // Assert.IsTrue(preScriptA == "C:\\Users\\RobB\\Desktop\\pre_script_a.ps1", "Unexpected script read from project file");
            // Assert.IsTrue(preScriptB == "C:\\Users\\RobB\\Desktop\\pre_script_b.ps1", "Unexpected script path read from project file");

            // Assert.IsTrue(postcriptA == "C:\\Users\\RobB\\Desktop\\post_script_a.ps1", "Unexpected script read from project file");
            // Assert.IsTrue(postcriptB == "C:\\Users\\RobB\\Desktop\\post_script_b.ps1", "Unexpected script read from project file");
        }   
    }
}
