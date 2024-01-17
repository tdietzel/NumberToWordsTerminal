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
   
      if(length == 2)
      {
        Dictionary<int, string> Tens = new Dictionary<int, string>() {
          {2,"twenty"}, {3,"thirty"}, {4,"forty"}, {5,"fifty"}, {6,"sixty"}, {7,"seventy"}, {8,"eighty"}, {9,"ninety"}
        };
        Dictionary<int, string> Teens = new Dictionary<int, string>() {
          {0,"ten"}, {1,"eleven"}, {2,"twelve"}, {3,"thirteen"}, {4,"fourteen"}, {5,"fifteen"}, {6,"sixteen"}, {7,"seventeen"}, {8,"eighteen"}, {9,"nineteen"}
        };
        Dictionary<int, string> Ones = new Dictionary<int, string>() {
          {0,"zero"}, {1,"one"}, {2,"two"}, {3,"three"}, {4,"four"}, {5,"five"}, {6,"six"}, {7,"seven"}, {8,"eight"}, {9,"nine"}
        };
        char[] digitArray = ConversionNum.ToString().ToCharArray();
        int firstDigit = int.Parse(digitArray[0].ToString());
        int secondDigit = int.Parse(digitArray[1].ToString());
        if(firstDigit == 1)
        {
          return Teens[secondDigit];
        }
        else
        {
          return Tens[firstDigit] + " " + Ones[secondDigit];
        }
      }
      else if(length == 1)
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