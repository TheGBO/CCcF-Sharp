using System;
using System.Text;

using CCcF;

public class Program {
    static void Main(string[] args)
    {
        string cccf = @"
        Settings (text without double colon is a comment)

        - Score::21

        - Name::amonjos

        - Game::Among us

        ";

        CCcFParser parser = new CCcFParser(cccf);
        Console.WriteLine(parser.GetInt("Score"));
        Console.WriteLine(parser.GetString("Name"));
    }
}


