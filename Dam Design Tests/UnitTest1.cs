using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Program = Dam_Design.Program;

namespace Dam_Design_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program.DamnDesign(new []{1,10}, new []{1,5});
        }
    }
}