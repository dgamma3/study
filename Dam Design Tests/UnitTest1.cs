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
        public void wall_position_greater_than_wall_height_1()
        {
            Program.DamnDesign(new []{1,10}, new []{1,5});
        }

        [Test]
        public void wall_position_greater_than_wall_height_2()
        {
            Program.DamnDesign(new []{1,20}, new []{1,10});
        }
        
        
        [Test]
        public void wall_position_greater_than_wall_height_3()
        {
            Program.DamnDesign(new []{5,20}, new []{1,5});
        }

          
        [Test]
        public void wall_position_greater_than_wall_height_4()
        {
            Program.DamnDesign(new []{3,7}, new []{3,3});
        }

        
        [Test]
        public void wall_position_same_than_wall_height_1()
        {
            Program.DamnDesign(new []{1,10}, new []{1,10});
            
        }
        
        [Test]
        public void wall_position_same_than_wall_height_2()
        {
            Program.DamnDesign(new []{5,10}, new []{5,10});
            
        }
        
        [Test]
        public void wall_position_same_than_wall_height_3()
        {
            Program.DamnDesign(new []{10,15}, new []{10,15});
            
        }

        [Test]
        public void from_sample_a()
        {
          var  result = Program.DamnDesign(new []{1,3,7}, new []{4,3,3});
          
          Assert.AreEqual(5, result);
            
        }
        
        [Test]
        public void from_sample_b()
        {
            var  result = Program.DamnDesign(new []{1,10}, new []{1,5});
          
            Assert.AreEqual(7, result);
            
        }
        
        [Test]
        public void from_sample_c()
        {
            var  result = Program.DamnDesign(new []{1,2,4,7}, new []{4,6,8,11});
          
            Assert.AreEqual(10, result);
            
        }
    }
}