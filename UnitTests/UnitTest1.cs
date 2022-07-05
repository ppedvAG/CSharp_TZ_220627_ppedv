using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab06f_Fahrzeugpark;

namespace UnitTests
{
    [TestClass]
    public class PKW_Test
    {
        [TestMethod]
        public void Beschleunige_PKW_ueber_MaxG()
        {
            Lab06f_Fahrzeugpark.PKW pkw = new Lab06f_Fahrzeugpark.PKW("BMW", 230, 4000, 3);

            pkw.StarteMotor();
            pkw.Beschleunige(pkw.MaxGeschwindigkeit + 1);

            Assert.AreEqual(pkw.MaxGeschwindigkeit, pkw.AktGeschwindigkeit);
        }

        [TestMethod]
        public void Bremse_PKW_unter_0()
        {
            Lab06f_Fahrzeugpark.PKW pkw = new Lab06f_Fahrzeugpark.PKW("BMW", 230, 4000, 3);

            pkw.StarteMotor();
            pkw.Beschleunige(200);
            pkw.Beschleunige(-201);

            Assert.AreEqual(0, pkw.AktGeschwindigkeit);
        }
    }
}