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
      Dictionary<int, string> TeenMillion = new Dictionary<int, string>{
        {1, "eleven million"}, {2,"twelve million"},{3, "thirteen million"}, {4, "fourteen million"}, {5, "fifteen million"}, {6, "sixteen million"}, {7, "seventeen million"}, {8, "eighteen million"}, {9, "nineteen million"}
      };
      Dictionary<int, string> TenMillions = new Dictionary<int, string>{
        {1, "ten million"}, {2,"twenty million"},{3, "thirty million"}, {4, "forty million"}, {5, "fifty million"}, {6, "sixty million"}, {7, "seventy million"}, {8, "eighty million"}, {9, "ninety million"}
      };
      Dictionary<int, string> Millions = new Dictionary<int, string>{
        {0, ""}, {1, "one million"}, {2,"two million"},{3, "three million"}, {4, "four million"}, {5, "five million"}, {6, "six million"}, {7, "seven million"}, {8, "eight million"}, {9, "nine million"}
      };  
      Dictionary<int, string> TeenThousand = new Dictionary<int, string>{
        {0, "ten thousand"}, {1, "eleven thousand"}, {2,"twelve thousand"},{3, "thirteen thousand"}, {4, "fourteen thousand"}, {5, "fifteen thousand"}, {6, "sixteen thousand"}, {7, "seventeen thousand"}, {8, "eighteen thousand"}, {9, "nineteen thousand"}
      };
      Dictionary<int, string> TenThousands = new Dictionary<int, string>(){
        {0, ""}, {1, "ten thousand"}, {2, "twenty thousand"}, {3, "thirty thousand"}, {4, "forty thousand"}, {5, "fifty thousand"}, {6, "sixty thousand"}, {7, "seventy thousand"}, {8, "eighty thousand"}, {9, "ninety thousand"}
      };
      Dictionary<int, string> Thousands = new Dictionary<int, string>(){
        {0, ""}, {1, "one thousand"}, {2, "two thousand"}, {3, "three thousand"}, {4,"four thousand"}, {5, "five thousand"}, {6, "six thousand"}, {7,"seven thousand"}, {8, "eight thousand"}, {9, "nine thousand"}
      };
      Dictionary<int, string> Hundreds = new Dictionary<int, string>(){
        {0, ""}, {1, "one hundred"}, {2, "two hundred"}, {3,"three hundred"}, {4, "four hundred"}, {5, "five hundred"}, {6, "six hundred"}, {7, "seven hundred"}, {8, "eight hundred"}, {9, "nine hundred"}
      };
      Dictionary<int, string> Tens = new Dictionary<int, string>() {
        {0, ""}, {2,"twenty"}, {3,"thirty"}, {4,"forty"}, {5,"fifty"}, {6,"sixty"}, {7,"seventy"}, {8,"eighty"}, {9,"ninety"}
      };
      Dictionary<int, string> Teens = new Dictionary<int, string>() {
        {0,"ten"}, {1,"eleven"}, {2,"twelve"}, {3,"thirteen"}, {4,"fourteen"}, {5,"fifteen"}, {6,"sixteen"}, {7,"seventeen"}, {8,"eighteen"}, {9,"nineteen"}
      };
      Dictionary<int, string> Ones = new Dictionary<int, string>() {
        {0,""}, {1,"one"}, {2,"two"}, {3,"three"}, {4,"four"}, {5,"five"}, {6,"six"}, {7,"seven"}, {8,"eight"}, {9,"nine"}
      };
      int length = CheckNumLength();
      if (length == 9)
      {
        char[] digitArray = ConversionNum.ToString().ToCharArray();
        int firstDigit = int.Parse(digitArray[0].ToString());
        int secondDigit = int.Parse(digitArray[1].ToString());
        int thirdDigit = int.Parse(digitArray[2].ToString());
        int fourthDigit = int.Parse(digitArray[3].ToString());
        int fifthDigit = int.Parse(digitArray[4].ToString());
        int sixthDigit = int.Parse(digitArray[5].ToString());
        int seventhDigit = int.Parse(digitArray[6].ToString());
        int eighthDigit = int.Parse(digitArray[7].ToString());
        int ninthDigit = int.Parse(digitArray[8].ToString());
        
        if (secondDigit == 1 && thirdDigit >= 3 && fifthDigit == 1 && sixthDigit >= 3 && eighthDigit == 1 && ninthDigit >= 3)
        {
          return Hundreds[firstDigit] + " " + TeenMillion[thirdDigit] + " " + Hundreds[fourthDigit] + " " + TeenThousand[sixthDigit] + " " + Hundreds[seventhDigit] + " " + Teens[ninthDigit];
        }
        else if (secondDigit == 1 && thirdDigit >= 3 && fifthDigit == 1 && sixthDigit >= 3 && eighthDigit != 1)
        {
          return Hundreds[firstDigit] + " " + TeenMillion[thirdDigit] + " " + Hundreds[fourthDigit] + " " + TeenThousand[sixthDigit] + " " + Hundreds[seventhDigit] + " " + Tens[eighthDigit] + " " + Ones[ninthDigit];
        }
        else if (secondDigit == 1 && thirdDigit >= 3 && fifthDigit != 1 || sixthDigit <= 3 && eighthDigit != 1)
        {
          return Hundreds[firstDigit] + " " + TeenMillion[thirdDigit] + " " + Hundreds[fourthDigit] + " " + Tens[fifthDigit] + " " + Thousands[sixthDigit] + " " + Hundreds[seventhDigit] + " " + Tens[eighthDigit] + " " + Ones[ninthDigit];
        }
        else if (secondDigit != 1 && fifthDigit == 1 && sixthDigit >= 3 && eighthDigit != 1)
        {
          return Hundreds[firstDigit] + " " + Tens[secondDigit] + " " + Millions[thirdDigit] + " " + Hundreds[fourthDigit] + " " + TeenThousand[sixthDigit] + " " + Hundreds[seventhDigit] + " " + Tens[eighthDigit] + " " + Ones[ninthDigit];
        }
        else if (secondDigit != 1 && fifthDigit != 1 && eighthDigit == 1 && ninthDigit >= 3)
        {
          return Hundreds[firstDigit] + " " + Tens[secondDigit] + " " + Millions[thirdDigit] + " " + Hundreds[fourthDigit] + " " + Tens[fifthDigit] + " " + Thousands[sixthDigit] + " " + Hundreds[seventhDigit] + " " + Teens[ninthDigit];
        }
        else if (secondDigit == 0 && thirdDigit == 0 && fourthDigit == 0 && fifthDigit == 0 && sixthDigit == 0 && seventhDigit == 0 && eighthDigit == 0 && ninthDigit == 0)
        {
          return Hundreds[firstDigit] + " " + TenMillions[secondDigit];
        }
        else
        {
          return Hundreds[firstDigit] + " " + Tens[secondDigit] + " " + Millions[thirdDigit] + " " + Hundreds[fourthDigit] + " " + Tens[fifthDigit] + " " + Thousands[sixthDigit] + " " + Hundreds[seventhDigit] + " " + Tens[eighthDigit] + " " + Ones[ninthDigit];
        }
      }
      else if (length == 8)
      {
        char[] digitArray = ConversionNum.ToString().ToCharArray();
        int firstDigit = int.Parse(digitArray[0].ToString());
        int secondDigit = int.Parse(digitArray[1].ToString());
        int thirdDigit = int.Parse(digitArray[2].ToString());
        int fourthDigit = int.Parse(digitArray[3].ToString());
        int fifthDigit = int.Parse(digitArray[4].ToString());
        int sixthDigit = int.Parse(digitArray[5].ToString());
        int seventhDigit = int.Parse(digitArray[6].ToString());
        int eighthDigit = int.Parse(digitArray[7].ToString());
        
        if (firstDigit == 1 && secondDigit >= 3 && fourthDigit == 1 && fifthDigit >= 3 && seventhDigit == 1 && eighthDigit >= 3)
        {
          return TeenMillion[secondDigit] + " " + Hundreds[thirdDigit] + " " + TeenThousand[fifthDigit] + " " + Hundreds[sixthDigit] + " " + Teens[eighthDigit];
        }
        else if (firstDigit == 1 && secondDigit >= 3 && fourthDigit == 1 && fifthDigit >= 3 && seventhDigit != 1)
        {
          return TeenMillion[secondDigit] + " " + Hundreds[thirdDigit] + " " + TeenThousand[fifthDigit] + " " + Hundreds[sixthDigit] + " " + Tens[seventhDigit] + " " + Ones[eighthDigit];
        }
        else if (firstDigit == 1 && secondDigit >= 3 && fourthDigit != 1 || fifthDigit <= 3 && seventhDigit != 1)
        {
          return TeenMillion[secondDigit] + " " + Hundreds[thirdDigit] + " " + Tens[fourthDigit] + " " + Thousands[fifthDigit] + " " + Hundreds[sixthDigit] + " " + Tens[seventhDigit] + " " + Ones[eighthDigit];
        }
        else if (firstDigit != 1 && fourthDigit == 1 && fifthDigit >= 3 && seventhDigit != 1)
        {
          return Tens[firstDigit] + " " + Millions[secondDigit] + " " + Hundreds[thirdDigit] + " " + TeenThousand[fifthDigit] + " " + Hundreds[sixthDigit] + " " + Tens[seventhDigit] + " " + Ones[eighthDigit];
        }
        else if (firstDigit != 1 && fourthDigit != 1 && seventhDigit == 1 && eighthDigit >= 3)
        {
          return Tens[firstDigit] + " " + Millions[secondDigit] + " " + Hundreds[thirdDigit] + " " + Tens[fourthDigit] + " " + Thousands[fifthDigit] + " " + Hundreds[sixthDigit] + " " + Teens[eighthDigit];
        }
        else if (secondDigit == 0 && thirdDigit == 0 && fourthDigit == 0 && fifthDigit == 0 && sixthDigit == 0 && seventhDigit == 0 && eighthDigit == 0)
        {
          return TenMillions[firstDigit];
        }
        else
        {
          return Tens[firstDigit] + " " + Millions[secondDigit] + " " + Hundreds[thirdDigit] + " " + Tens[fourthDigit] + " " + Thousands[fifthDigit] + " " + Hundreds[sixthDigit] + " " + Tens[seventhDigit] + " " + Ones[eighthDigit];
        }
      }
      else if (length == 7)
      {
        char[] digitArray = ConversionNum.ToString().ToCharArray();
        int firstDigit = int.Parse(digitArray[0].ToString());
        int secondDigit = int.Parse(digitArray[1].ToString());
        int thirdDigit = int.Parse(digitArray[2].ToString());
        int fourthDigit = int.Parse(digitArray[3].ToString());
        int fifthDigit = int.Parse(digitArray[4].ToString());
        int sixthDigit = int.Parse(digitArray[5].ToString());
        int seventhDigit = int.Parse(digitArray[6].ToString());
        
        if(thirdDigit == 1 && fourthDigit >= 3 && sixthDigit != 1)
        {
          return Millions[firstDigit] + " " + Hundreds[secondDigit] + " " + TeenThousand[fourthDigit] + " " + Hundreds[fifthDigit] + " " + Tens[sixthDigit] + " " + Ones[seventhDigit];
        }
        else if (thirdDigit == 1 && fourthDigit >= 3 && sixthDigit == 1)
        {
          return Millions[firstDigit] + " " + Hundreds[secondDigit] + " " + TeenThousand[fourthDigit] + " " + Hundreds[fifthDigit] + " " + Teens[seventhDigit];
        }
        else if (sixthDigit == 1)
        {
          return Millions[firstDigit] + " " + Hundreds[secondDigit] + " " + Tens[thirdDigit] + " " + Thousands[fourthDigit] + " " + Hundreds[fifthDigit] + " " + Teens[seventhDigit];
        }
        else if (secondDigit == 0 && thirdDigit == 0 && fourthDigit == 0 && fifthDigit == 0 && sixthDigit == 0 && seventhDigit == 0)
        {
          return Millions[firstDigit];
        }
        else
        {
          return Millions[firstDigit] + " " + Hundreds[secondDigit] + " " + Tens[thirdDigit] + " " + Thousands[fourthDigit] + " " + Hundreds[fifthDigit] + " " + Tens[sixthDigit] + " " + Ones[seventhDigit];
        }
      }
      else if (length == 6)
      {
        char[] digitArray = ConversionNum.ToString().ToCharArray();
        int firstDigit = int.Parse(digitArray[0].ToString());
        int secondDigit = int.Parse(digitArray[1].ToString());
        int thirdDigit = int.Parse(digitArray[2].ToString());
        int fourthDigit = int.Parse(digitArray[3].ToString());
        int fifthDigit = int.Parse(digitArray[4].ToString());
        int sixthDigit = int.Parse(digitArray[5].ToString());
        
        if(secondDigit == 1 && thirdDigit >= 3 && fifthDigit != 1)
        {
          return Hundreds[firstDigit] + " " + TeenThousand[thirdDigit] + " " + Hundreds[fourthDigit] + " " + Tens[fifthDigit] + " " + Ones[sixthDigit];
        }
        else if (secondDigit == 1 && thirdDigit >= 3 && fifthDigit == 1)
        {
          return Hundreds[firstDigit] + " " + TeenThousand[thirdDigit] + " " + Hundreds[fourthDigit] + " " + Teens[fifthDigit];
        }
        else if (fifthDigit == 1)
        {
          return Hundreds[firstDigit] + " " + Tens[secondDigit] + " " + Thousands[thirdDigit] + " " + Hundreds[fourthDigit] + " " + Teens[sixthDigit];
        }
        else if (secondDigit == 0 && thirdDigit == 0 && fourthDigit == 0 && fifthDigit == 0 && sixthDigit == 0)
        {
          return Hundreds[firstDigit] + " thousand";
        }
        else
        {
          return Hundreds[firstDigit] + " " + Tens[secondDigit] + " " + Thousands[thirdDigit] + " " + Hundreds[fourthDigit] + " " + Tens[fifthDigit] + " " + Ones[sixthDigit];
        }
      }
      else if (length == 5)
      {
        char[] digitArray = ConversionNum.ToString().ToCharArray();
        int firstDigit = int.Parse(digitArray[0].ToString());
        int secondDigit = int.Parse(digitArray[1].ToString());
        int thirdDigit = int.Parse(digitArray[2].ToString());
        int fourthDigit = int.Parse(digitArray[3].ToString());
        int fifthDigit = int.Parse(digitArray[4].ToString());

        if(firstDigit == 1 && secondDigit >= 3 && fourthDigit != 1)
        {
          return TeenThousand[secondDigit] + " " + Hundreds[thirdDigit] + " " + Tens[fourthDigit] + " " + Ones[fifthDigit];
        }
        else if (firstDigit == 1 && secondDigit >= 3 && fourthDigit == 1)
        {
          return TeenThousand[secondDigit] + " " + Hundreds[thirdDigit] + " " + Teens[fourthDigit];
        }
        else if (fourthDigit == 1)
        {
          return TenThousands[firstDigit] + " " + Thousands[secondDigit] + " " + Hundreds[thirdDigit] + " " + TeenThousand[fifthDigit];
        }
        else
        {
          return Tens[firstDigit] + " " + Thousands[secondDigit] + " " + Hundreds[thirdDigit] + " " + Tens[fourthDigit] + " " + Ones[fifthDigit];
        }
      }
      else if (length == 4)
      {
        char[] digitArray = ConversionNum.ToString().ToCharArray();
        int firstDigit = int.Parse(digitArray[0].ToString());
        int secondDigit = int.Parse(digitArray[1].ToString());
        int thirdDigit = int.Parse(digitArray[2].ToString());
        int fourthDigit = int.Parse(digitArray[3].ToString());

        if(thirdDigit == 1)
        {
          return Thousands[firstDigit] + " " + Hundreds[secondDigit] + " " + Teens[fourthDigit];
        }
        else
        {
          return Thousands[firstDigit] + " " + Hundreds[secondDigit] + " " + Tens[thirdDigit] + " " + Ones[fourthDigit];
        }
      }
      else if(length == 3)
      {
        char[] digitArray = ConversionNum.ToString().ToCharArray();
        int firstDigit = int.Parse(digitArray[0].ToString());
        int secondDigit = int.Parse(digitArray[1].ToString());
        int thirdDigit = int.Parse(digitArray[2].ToString());

        if(secondDigit == 1)
        {
          return Hundreds[firstDigit] + " " + Teens[thirdDigit];
        }
        else
        {
          return Hundreds[firstDigit] + " " + Tens[secondDigit] + " " + Ones[thirdDigit];
        }
      }
      else if(length == 2)
      {
        char[] digitArray = ConversionNum.ToString().ToCharArray();
        int firstDigit = int.Parse(digitArray[0].ToString());
        int secondDigit = int.Parse(digitArray[1].ToString());

        if(firstDigit == 1) 
        {
          return Teens[secondDigit];
        }
        else if (firstDigit == 0)
        {
          return "Zero";
        }
        else
        {
          return Tens[firstDigit] + " " + Ones[secondDigit];
        }
      }
      else if(length == 1)
      {
        return Ones[userNum];
      }
      else
      {
        return "I cant count that high yet!";
      }
    }
  } 
}

// FIXED... 234785 returns ||| two hundred thirty four thousand seven hundredeighty five
// FIXED... 96782 returns ||| ninety thousand six thousand seven hundred eighty two
// FIXED... 76258399 returns ||| seventy six million two hundred eighteen thousand three hundred ninety nine
// error handling for if the user doesnt type 'yes' or 'no'