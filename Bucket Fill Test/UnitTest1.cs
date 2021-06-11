using Bucket_Fill;
using NUnit.Framework;

namespace Bucket_Fill_Test
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
            Program.BucketFill(new string[]{"aabba", "aabba", "aaacb"});
        }
    }
}