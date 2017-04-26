using System;
using System.IO;
using System.Net;

namespace Sandbox
{
  class Program
  {
    static void Main(string[] args)
    {
      var internetFile = new StreamReader(new WebClient().OpenRead("http://kamanpoole.github.io/CS2450_Spring2015/BoxData.txt"));
      var line = internetFile.ReadLine();
      while (line != null)
      {
          Console.WriteLine(line);
          line = internetFile.ReadLine();
      }
      Console.ReadKey();
    }
  }
}
