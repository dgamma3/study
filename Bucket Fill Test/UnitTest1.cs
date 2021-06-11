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
            var strokesRequired  = Program.StrokesRequired(new string[]{"aabba", "aabba", "aaacb"});
            
            Assert.AreEqual(5, strokesRequired);
        }        
        
         [Test]
        public void Test3()
        {
            var strokesRequired  = Program.StrokesRequired(new string[]{ "bbba", "abba", "acaa" , "aaac" });
            
            Assert.AreEqual(4, strokesRequired);
        }
        
             [Test]
        public void Test2()
        {
            var strokesRequired  = Program.StrokesRequired(new string[]{ "aaaba" , "ababa" , "aaaca" });
            
            Assert.AreEqual(5, strokesRequired);
        }
        
    }
}