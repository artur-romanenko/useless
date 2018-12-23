using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Useless.Tests
{
    [TestClass]
    public class SingeMeTests
    {
        [TestMethod]
        public void ShouldGiveNiceGreeting()
        {
            // Arrange
            var person = "Despicable Me";
            var me = SingleMe.Me;

            // Act
            var greeting = me.Greet(person);

            // Assert
            Assert.AreEqual($"Aloha, {person}!", greeting, "Bad greeting");
        }
    }
}
