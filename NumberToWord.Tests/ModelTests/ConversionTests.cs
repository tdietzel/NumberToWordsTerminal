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
      Conversion newConversion = new Conversion(357);
      Assert.AreEqual(typeof(Conversion), newConversion.GetType());
    }
    [TestMethod]
    public void GetConversionNum_ReturnsConversionNum_Int()
    {
      int userNum = 357;
      Conversion newConversion = new Conversion(userNum);
      int result = newConversion.ConversionNum;
      Assert.AreEqual(userNum, result);
    }
    [TestMethod]
    public void SetConversionNum_SetsConversionNum_Int()
    {
      Conversion newConversion = new Conversion(5);
      int newNum = 10;
      newConversion.ConversionNum = newNum;
      Assert.AreEqual(newNum, newConversion.ConversionNum);
    }
  }
}