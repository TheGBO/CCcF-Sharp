using System;
using System.IO;

using CCcF;

public class Program {
    static void Main(string[] args)
    {
        string cccf = File.ReadAllText("./example.cccf");

        CCcFParser parser = new CCcFParser(cccf);
        Console.WriteLine(parser.GetInt("Age"));
        Console.WriteLine(parser.GetString("Name"));
        Console.WriteLine(parser.GetString("FavouriteFood"));
    }
}



