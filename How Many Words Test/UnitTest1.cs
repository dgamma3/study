using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Program = How_Many_Words.Program;

namespace How_Many_Words_Test
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
            var howMany = Program.howMany("he is a good programmer, he won 865 competitions, but sometimes he dont. What do you think? All test-cases should pass. Done-done?");
            Assert.AreEqual(21,howMany);
        }
        
        [Test]
        public void Test2()
        {
            var howMany = Program.howMany("jds dsaf lkdf kdsa fkldsf, adsbf ldka ads? asd bfdal ds bf[l. akf dhj ds 878  dwa WE DE 7475 dsfh ds  RAMU 748 dj.");
            Assert.AreEqual(21,howMany);
        }
    }
}