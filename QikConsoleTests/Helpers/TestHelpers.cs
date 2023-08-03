using CygSoft.Qik;
using CygSoft.Qik.Functions;
using Moq;

namespace QikConsoleTests
{
    public class TestHelpers
    {
        internal static IPluginLoader StubPluginLoader { get => new Mock<IPluginLoader>().Object; }
    }
}
