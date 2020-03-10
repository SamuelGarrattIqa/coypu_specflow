using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace UiTest.Lib.Extensions
{
  static class HttpResponseMessageExtensions
  {
    public static void VerifyResponse(this HttpResponseMessage response, string description, Uri uri)
    {
      if (!response.IsSuccessStatusCode)
      {
        string errorMessage = $"Unsuccessful response creating {description} at {uri}. {(int)response.StatusCode} ({response.ReasonPhrase}).";
        Console.WriteLine(errorMessage);
        throw new Exception(errorMessage);
      }
    }

    public static void VerifyResponse(this HttpResponseMessage response, string description, Uri uri, string jsonString)
    {
      if (!response.IsSuccessStatusCode)
      {
        string errorMessage = $"Unsuccessful response creating {description} at {uri}. {(int)response.StatusCode} ({response.ReasonPhrase}). " +
          $"Request body was {jsonString}";
        Console.WriteLine(errorMessage);
        throw new Exception(errorMessage);
      }
    }
  }
}
