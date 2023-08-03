using System.IO;
using NUnit.Framework;

namespace QikConsoleTests
{
    [TestFixture]
    class IsDirectoryTests
    {
        [Test]
        public void IsDirectoryTest()
        {
            // non-existing file, FileAttributes not conclusive, rely on type of FileSystemInfo
            const string nonExistentFile = @"C:\TotallyFakeFile.exe";

            var nonExistentFileDirectoryInfo = new DirectoryInfo(nonExistentFile);
            Assert.IsTrue(nonExistentFileDirectoryInfo.IsDirectory());

            var nonExistentFileFileInfo = new FileInfo(nonExistentFile);
            Assert.IsFalse(nonExistentFileFileInfo.IsDirectory());

            // non-existing directory, FileAttributes not conclusive, rely on type of FileSystemInfo
            const string nonExistentDirectory = @"C:\FakeDirectory";

            var nonExistentDirectoryInfo = new DirectoryInfo(nonExistentDirectory);
            Assert.IsTrue(nonExistentDirectoryInfo.IsDirectory());

            var nonExistentFileInfo = new FileInfo(nonExistentDirectory);
            Assert.IsFalse(nonExistentFileInfo.IsDirectory());

            // Existing, rely on FileAttributes
            const string existingDirectory = @"C:\Windows";

            var existingDirectoryInfo = new DirectoryInfo(existingDirectory);
            // Assert.IsTrue(existingDirectoryInfo.IsDirectory());

            var existingDirectoryFileInfo = new FileInfo(existingDirectory);
            // Assert.IsTrue(existingDirectoryFileInfo.IsDirectory());

            // Existing, rely on FileAttributes
            const string existingFile = @"C:\Windows\notepad.exe";

            var existingFileDirectoryInfo = new DirectoryInfo(existingFile);
           // Assert.IsFalse(existingFileDirectoryInfo.IsDirectory());

            // var existingFileFileInfo = new FileInfo(existingFile);
            // Assert.IsFalse(existingFileFileInfo.IsDirectory());
        }
    }
}