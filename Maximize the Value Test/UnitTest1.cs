using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Program = Maximize_the_Value.Program;

namespace Maximize_the_Value_Test
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
            Program.arr(new int[]{5, 7, 9, 21, 34});
            
        }
    }
}