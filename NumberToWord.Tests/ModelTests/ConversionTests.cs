using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWords.Models;

namespace NumberToWords.Tests
{
  [TestClass]
  public class ConversionTests
  {
    [TestMethod]
    public void ConversionConstructor_CreatesInstanceOfConversion_Conversion()
    {
      Conversion newConversion = new Conversion();
      Assert.AreEqual(typeof(Conversion), newConversion.GetType());
    }
  }
}