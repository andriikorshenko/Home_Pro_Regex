using System.Net;
using System.Text.RegularExpressions;

namespace Task_002
{
    internal class Parser
    {
        private WebClient client = new WebClient();     
        private readonly string _htmlCode;
        private string _path = @"D:/tet.txt";

        List<string> _list = new List<string>
        {
            @"\b([a-z0-9._-]+@[a-z0-9.-]+)\b",
            @"((\+38)\(?\d{3}\)?[\s\.-]?(\d{7}|\d{3}[\s\.-]\d{2}[\s\.-]\d{2}|\d{3}-\d{4}))",
            @"href\s*=\s*(?:[""'](?<1>[^""']*)[""']|(?<1>[^>\s]+))"
        };

        public Parser(string link)
        {            
            _htmlCode = client.DownloadString(link);                            
        }

        public void ParseAllEmailsPhonesAndReferences()
        {
            using (StreamWriter _stream = new StreamWriter(_path, true))
            {
                for (int i = 0; i < _list.Count; i++)
                {
                    Regex _regex = new Regex(_list[i]);
                    MatchCollection matches = _regex.Matches(_htmlCode);                    

                    if (matches.Count > 0)
                    {
                        foreach (Match item in matches)
                        {
                            Console.WriteLine(item.Value);

                            _stream.WriteLine(item.Value);
                        }
                    }
                    else Console.WriteLine($"\nNo data inside for regex combination : {_list[i]}!\n");
                }
            }            
        }
    }
}
