using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repository.UnitTest
{
    [TestClass]
    public sealed class ConfigTests
    {
        [TestMethod]
        public void LabConnectionStringTest_預期回傳連線字串()
        {
            var expected = @"Server=.;Database=Lab;Integrated Security=True;";

            var actual = Config.LabConnectionString;

            Assert.AreEqual(expected, actual);
        }
    }
}