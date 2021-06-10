using ANZ;
using NUnit.Framework;

namespace Balanced_Parantheses_Test
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
            var result = Result.minimumSwaps("(()))(");
            Assert.AreEqual(result, 1);
        } 
        [Test]
        public void Test4()
        {
            var result = Result.minimumSwaps("((((((");
            //var result = Result.minimumSwaps("((((((");
            Assert.AreEqual(result, 1);
        }   
        [Test]
        public void Test2()
        {
            var result =Result.minimumSwaps("()())");
            Assert.AreEqual(result, -1);

        }
    }
}