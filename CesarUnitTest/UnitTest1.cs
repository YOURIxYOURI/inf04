namespace CesarUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task CesarDecodeTest1()
        {
            var codedLines = File.ReadAllLines("data.txt");

            List<string> expected = new List<string> {
                "HELLO, HOW ARE XOU?",
                "I LOVE LEARNING NEW THINGS.",
                "CAN XOU SOLVE THIS PUYPLE?",
                "THE WEWQEER IS BEAUTIFUL TODAX.",
                "GOOD LUCK WITH XOUR PROJECT!"
            };

            Assert.AreEqual(expected, cesarDecode(codedLines, 3));
        }
    }
}

