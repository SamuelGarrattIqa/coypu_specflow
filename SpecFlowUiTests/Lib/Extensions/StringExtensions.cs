using System;
using System.Collections.Generic;
using System.Text;

namespace UiTest.Lib.Extensions
{
  static class StringExtensions
  {
    /// <summary>
    /// Checks JSON string and raises 
    /// </summary>
    /// <param name="JSONString"></param>
    public static void VerifyUnexpectedCharacters(this string JSONString)
    {
      if (JSONString.Contains("\\"))
      {
        string errorMessage = $"JSONString contains \\ when it should not";
        Console.WriteLine(errorMessage);
        throw new Exception(errorMessage);
      }
    }
    
  }
}
