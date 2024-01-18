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
    [TestMethod]
    public void CheckNumLength_ReturnsNumLength_Int()
    {
      Conversion newConversion = new Conversion(234);
      int result = newConversion.CheckNumLength();
      Assert.AreEqual(3, result);
    }
    [TestMethod]
    public void Dictionary_ReturnsOneDigitNumToWord_String()
    {
      int userNum = 7;
      Conversion newConversion = new Conversion(userNum);
      string result = newConversion.Dictionary(userNum);
      Assert.AreEqual("seven", result);
    }
    [TestMethod]
    public void Dictionary_ReturnsTwoDigitsNumToWord_String()
    {
      int userNum = 29;
      Conversion newConversion = new Conversion(userNum);
      string result = newConversion.Dictionary(userNum);
      Assert.AreEqual("twenty nine", result);
    }
    [TestMethod]
    public void Dictionary_ReturnsThreeDigitsNumToWord_String()
    {
      int userNum = 119;
      Conversion newConversion = new Conversion(userNum);
      string result = newConversion.Dictionary(userNum);
      Assert.AreEqual("one hundred nineteen", result);
    }
    [TestMethod]
    public void Dictionary_ReturnsFourDigitsNumToWord_String()
    {
      int userNum = 9356;
      Conversion newConversion = new Conversion(userNum);
      string result = newConversion.Dictionary(userNum);
      Assert.AreEqual("nine thousand three hundred fifty six", result);
    }
    [TestMethod]
    public void Dictionary_ReturnsFiveDigitsNumToWord_String()
    {
      int userNum = 13456;
      Conversion newConversion = new Conversion(userNum);
      string result = newConversion.Dictionary(userNum);
      Assert.AreEqual("thirteen thousand four hundred fifty six", result);
    }
    [TestMethod]
    public void Dictionary_ReturnsSixDigitsNumToWord_String()
    {
      int userNum = 116456;
      Conversion newConversion = new Conversion(userNum);
      string result = newConversion.Dictionary(userNum);
      Assert.AreEqual("one hundred sixteen thousand four hundred fifty six", result);
    }
    [TestMethod]
    public void Dictionary_ReturnsSevenDigitsNumToWord_String()
    {
      int userNum = 1219813;
      Conversion newConversion = new Conversion(userNum);
      string result = newConversion.Dictionary(userNum);
      Assert.AreEqual("one million two hundred nineteen thousand eight hundred thirteen", result);
    }
    [TestMethod]
    public void Dictionary_ReturnsEightDigitsNumToWord_String()
    {
      int userNum = 13519217;
      Conversion newConversion = new Conversion(userNum);
      string result = newConversion.Dictionary(userNum);
      Assert.AreEqual("thirteen million five hundred nineteen thousand two hundred seventeen", result);
    }
  }
}

// ones {1:one, 2:two}
// ten {1: ten, 2: twenty...}
// hundreds {1: one-hundred, 2: two-hundred}

// 13,519,217
// 43,569,237