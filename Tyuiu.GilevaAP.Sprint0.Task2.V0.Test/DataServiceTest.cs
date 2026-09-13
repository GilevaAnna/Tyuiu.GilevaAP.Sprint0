using Tyuiu.GilevaAP.Sprint0.Task2.V0.lib;
namespace Tyuiu.GilevaAP.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Анна";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Анна", res);
        }
    }
}
