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
      Conversion();
    }
    static void Conversion()
    {
      Console.WriteLine("Please enter a number to convert to a word:");
      Console.WriteLine("------------------");
      string userNum = Console.ReadLine();
      Conversion newConversion = new Conversion(int.Parse(userNum));
      string result = newConversion.Dictionary(int.Parse(userNum));
      Console.WriteLine(result);
      Console.Beep();
      Navigate();
    }
    static void Navigate()
    {
      Console.WriteLine("Would you like another number? Enter 'yes to proceed, or 'no' to exit");
      string userInput = Console.ReadLine();
      if (userInput == "yes" || userInput == "Yes")
      {
        Conversion();
      }
      else if (userInput == "no" || userInput == "No")
      {
        Console.WriteLine(NumberToWord.UserInterfaceModels.GoodbyeBanner.Goodbye);
      }
    }
  }
}