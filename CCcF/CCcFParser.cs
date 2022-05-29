using System;
using System.Text.RegularExpressions;

namespace CCcF
{
    public class CCcFParser {
        private string content;

        public CCcFParser(string content){
            this.content = content;
        }

        public CCcFParser(){
            this.content = "";
        }

        public void SetContentFromFile(string filePath){
            this.content = File.ReadAllText(filePath);
        }

        public string GetString(string field){
            Match match = Regex.Match(this.content, field+@"::(.*)");
            string toParse = match.Groups[1].Value;
            return toParse;
        }

        public int GetInt(string field){
            return int.Parse(GetString(field));
        }

        public float GetFloat(string field){
            return float.Parse(GetString(field));
        }

        public double GetDouble(string field){
            return double.Parse(GetString(field));
        }
    }
}