using Ueb08a_Parkhaus;

namespace Ueb08a_ParkhausTest
{
    [TestClass]
    public class TestAuto
    {
        [TestMethod]
        public void Test_Auto_Konstruktor()
        {
            var auto = new Auto();
            Assert.IsTrue(auto != null, "kein Speicher vorhanden");
        }

        [TestMethod]
        public void Test_Auto_Konstruktor_mit_Werten()
        {
            var auto = new Auto() { Kennzeichen = 607609, Name="Opel"};
            Assert.IsTrue(auto.Kennzeichen == 123456);
        }
    }
}