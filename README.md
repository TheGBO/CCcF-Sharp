# CCcF

NOTE: this is the C# version, but it can be easily implemented in any language like JS, Python, Java or C/C++

Get it on Nuget : https://www.nuget.org/packages/CCcF-Sharp

## Quick Example

```
Settings (text without double colon ignored by the parser)

- Age::68

- Name::Stringson Jouniour the Third

- FavouriteFood::pizza
```

```cs
using System;
using System.Text;

using CCcF;

public class Program {
    static void Main(string[] args)
    {
        string cccf = File.ReadAllText("./example.cccf");

        CCcFParser parser = new CCcFParser(cccf);
        Console.WriteLine(parser.GetInt("Age")); //68
        Console.WriteLine(parser.GetString("Name")); //Stringson Jounior the Third
        Console.WriteLine(parser.GetString("FavouriteFood")); //piza
    }
}


```


CCcF Stands for : ColonColon cool Fields
it's a file format specification that i made to make easier and faster to work with configuration files, but it can be used for anything that has data

### pros
- Easy to parse due to the regex
- Can be implemented in any language
### cons
- Limited to strings, complex types like arrays or object aren't implemented yet
- No Serialization yet
- 

## Why?
- Meant to be easy to read
- Very good for configuration/settings files
- Light Weight and well formatted

## Example of uses

- Storing game settings
- Sending it via network as data format (like json)

# TODO:
- [ ] Creating files
- [ ] Add Array support
- [ ] Serialization support