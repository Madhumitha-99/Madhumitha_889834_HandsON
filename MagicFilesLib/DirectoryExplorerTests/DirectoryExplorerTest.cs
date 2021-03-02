using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using MagicFilesLib;
namespace DirectoryExplorerTests
{
    [TestFixture]    
    public class DirectoryExplorerTest
    {
        private IDirectoryExplorer _direxp;
        private readonly string _file1 = "file1.txt";
        private readonly string _file2 = "file2.txt";
        [OneTimeSetUp]
        public void Init()
        {
            _direxp =  Mock.Of<IDirectoryExplorer>();
            Mock.Get(_direxp).Setup(x => x.GetFiles(It.IsAny<string>())).Returns((string x) => new List<string> { _file1, _file2 });
        }
        [Test]
        [TestCase(@"C:\")]
        public void FilesTest(string filepath)
        {
            ICollection<string> files = _direxp.GetFiles(filepath);
            Assert.IsNotNull(files);
            Assert.IsTrue(files.Count == 2);
            Assert.IsTrue(files.Contains(_file2));

        }
    }
}
