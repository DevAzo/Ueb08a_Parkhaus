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
        }

        [TestMethod]
        public void Test_Auto_Konstruktor_mit_Werten()
        {
            var auto = new Auto() { Kennzeichen = 607609, Name="Opel"};
        }
    }
}