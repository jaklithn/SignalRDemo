using Demo.Web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.Tests.Services
{
    [TestClass]
    public class SubscriptionTests
    {
        [TestMethod]
        public void CanGenerateSubcsriptions()
        {
           // Arrange
           
            // Act
            var machines= SubscriptionService.GetSubscribedMachines("kalle");

            // Assert
        }
    }
}
