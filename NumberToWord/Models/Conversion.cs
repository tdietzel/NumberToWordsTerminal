using NumberToWords.Models;

namespace NumberToWords.Models
{
  public class Conversion
  {
    public int ConversionNum {get;}

    public Conversion(int userNum)
    {
      ConversionNum = userNum;
    }
  } 
}