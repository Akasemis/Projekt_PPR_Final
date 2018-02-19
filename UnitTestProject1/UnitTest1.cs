using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt_PPR;

namespace UnitTestProject1
{
    [TestClass]
    public class czy_mniej_niz_normalny_zarobek
    {
        [TestMethod]
        public void TestMethod1()
        {
            Opiekunowie Opiekun = new Opiekunowie();
            int kwota = -1500;
            Opiekun.modyfikuj_pensje(kwota);
            if (Opiekun.pensja<0)
            {
                throw new System.Exception("Pracownik ma ujemn¹ pensjê!");
            }
        }
    }
}
