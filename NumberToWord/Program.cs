using System;
using System.Collections.Generic;
using NumberToWords.Models;
using NumberToWord.UserInterfaceModels;

namespace NumberToWord
{
  class Program
  {
    static void Main()
    {
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine(NumberToWord.UserInterfaceModels.WelcomeBanner.Welcome);
      // Console.WriteLine("Welcome to the Numbers To Words App!");
      Console.WriteLine("Please enter a number to convert to a word:");
      Console.WriteLine("--------------");
      string userNum = Console.ReadLine();
      Conversion newConversion = new Conversion(int.Parse(userNum));
      string result = newConversion.Dictionary(int.Parse(userNum));
      Console.WriteLine(result);
      Console.Beep();
      
    }
    static void 
  }
}