using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var student = new Student("Ricardo", "Macedo", "12345678912", "mace.ads6@gmail.com");
            
        }
    }
}
