using System;
using System.IO;
using System.Net;
using System.Text;

namespace testconsole
{
   class Program
   {
        static void Main ()
        {
        
            var webRequest = WebRequest.Create(@"https://trulivecampaign.blob.core.windows.net/public/leaderboard.txt");

            using(var response = webRequest.GetResponse())
            using(var content = response.GetResponseStream())
            {
            
                char[] delimiters = new char[] { ',' };
                using (StreamReader reader = new StreamReader(content))
                {
                    Console.WriteLine(@"..//**REACTIONS HALL OF FAME**\\..");
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        string[] parts = line.Split(delimiters);
                        Console.WriteLine("      {0} --> {1} --> {2}", parts);
                    }
                }

            }
        
        }
   }
}