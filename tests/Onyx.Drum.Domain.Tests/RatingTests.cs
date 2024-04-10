using Onyx.Drum.Domain.Catalog;

namespace Onyx.Drum.Domain.Tests;

[TestClass]
public class RatingTests
{
    [TestMethod]
    public void Can_Create_New_Rating()
    {
        // Arrange
        var rating = new Rating(5, "John Doe", "Great!");

        // Act (nothing to act on)

        // Assert
        Assert.AreEqual(5, rating.Stars);
        Assert.AreEqual("John Doe", rating.UserName);
        Assert.AreEqual("Great!", rating.Review);


    }

    // Create test for rating with 0 stars
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Rating_With_Zero_Stars_Throws_Exception()
    {
        // Arrange - should thorw an argument exception
        var rating = new Rating(0, "John Doe", "Great!");

    }
}