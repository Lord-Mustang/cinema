using Microsoft.VisualStudio.TestTools.UnitTesting;
using cinema;

namespace cinema_unit_tests
{
    [TestClass]
    public class MovieTest
    {
        [TestMethod]
        public void TestMovie()
        {
            //Arrange

            //Act
            Movie movie = new Movie("Shrek");
            //Assert
            Assert.IsNotNull(movie);
        }
    }
}