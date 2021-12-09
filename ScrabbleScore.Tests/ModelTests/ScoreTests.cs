using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void GetPointsForLetter_ReturnsPointsForLetter_Int()
    {
      Assert.AreEqual(1, Score.GetPointsForLetter('a'));
      Assert.AreEqual(10, Score.GetPointsForLetter('z'));
    }
  }
}