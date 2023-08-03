using CygSoft.Qik;
using CygSoft.Qik.QikConsole;
using CygSoft.Qik.Functions;
using NUnit.Framework;

namespace QikConsoleTests
{
    [TestFixture]
    class PluginFunctionTests
    {
        [Test]
        public void Should_Load_A_Single_Test_Plugin_From_Plugins_Folder()
        {
            //
            // Have a look at the csproj file to understand how the QikFunnyFunctions dll is compiled and copied into the Plugins folder.
            var interpreter = new Interpreter();
            var symbolTerminal = interpreter.Interpret(new FunctionFactory(new PluginLoader()), "@InputVar => underscoreSurround(\"Hello World\");");
            var terminal = new PlaceholderTerminal(symbolTerminal, "@{", "}");

            Assert.AreEqual("__Hello World__", terminal.GetPlaceholderValue("@{InputVar}"));
        }
    }
}