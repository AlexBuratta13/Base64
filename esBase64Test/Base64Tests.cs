using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaBase64;

namespace esBase64Test
{
    [TestClass]
    public class Base64Tests
    {
        [TestMethod]
        public void Base64Test()
        {
            string risposta = LibraryB64.Base64();
            Assert.AreEqual("YWxleA==", risposta);
        }
    }
}
