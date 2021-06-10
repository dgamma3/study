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
            var result = Result.minimumSwaps("()");
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Test2()
        {
            var result = Result.minimumSwaps("()()");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test3()
        {
            var result = Result.minimumSwaps("((");
            Assert.AreEqual(1,result);
        }
        
        [Test]
        public void Test4()
        {
            var result = Result.minimumSwaps("((((");
            Assert.AreEqual(result, 2);
        }
        
        [Test]
        public void Test5()
        {
            var result = Result.minimumSwaps("()((");
            Assert.AreEqual(result, 1);
        }
        
        [Test]
        public void Test6()
        {
            var result = Result.minimumSwaps("((()");
            Assert.AreEqual(result, 1);
        }
        
        
        [Test]
        public void Test7()
        {
            var result = Result.minimumSwaps(")(");
            Assert.AreEqual( 1,result);
        }
        
        [Test]
        public void Test8()
        {
            var result = Result.minimumSwaps("(()))(");
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Test9()
        {
            var result = Result.minimumSwaps("((((((");
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void Test10()
        {
            var result = Result.minimumSwaps("()())");
            Assert.AreEqual(result, -1);
        }
        
        [Test]
        public void Test11()
        {
            var result = Result.minimumSwaps(")))()()()()(((");
            Assert.AreEqual(result, 3);
        }      
        
        [Test]
        public void Test12()
        {
            var result = Result.minimumSwaps(")()(((((()((()))()((");
            Assert.AreEqual(result, 4);
        }

    }
}