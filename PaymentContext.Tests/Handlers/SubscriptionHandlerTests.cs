using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumenSubscriptionHandlerTeststTests
    {
        // Red, Green, Refactor

        [TestMethod]
        public void DeveRetornarErrorQuandoCNPJ_Invalido()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }

    }
}
