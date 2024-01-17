using NumberToWords.Models;
using System.Collections.Generic;

namespace NumberToWords.Models
{
  public class Conversion
  {
    public int ConversionNum {get; set;}

    public Conversion(int userNum)
    {
      ConversionNum = userNum;
    }

    public int CheckNumLength()
    {
      char[] digitArray = ConversionNum.ToString().ToCharArray();
      return digitArray.Length;
    }
    public string Dictionary(int userNum) {
      int length = CheckNumLength();
       if(length == 1)
      {
        Dictionary <int, string> Ones = new Dictionary<int, string>() {
          {0,"zero"}, {1,"one"}, {2,"two"}, {3,"three"}, {4,"four"}, {5,"five"}, {6,"six"}, {7,"seven"}, {8,"eight"}, {9,"nine"}
        };
        return Ones[userNum];
      }
      else
      {
        return "";
      }
    }
  } 
}