
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task test1()
        {
            string tested = "ttttt1111ase";
            int expected = 2;

            var test = StringTools.countVowel(tested);

            Assert.AreEqual(expected, test);
        }
        [TestMethod]
        public async Task test2()
        {
            string tested = "ttttt1111ase";
            int expected = 3;

            var test = StringTools.countVowel(tested);

            Assert.AreEqual(expected, test);

        }
    }
}
