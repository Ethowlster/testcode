using System;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Net;
using System.Text;


namespace sideproject
{
   class Program
   {
       static void Main(string[] args)
       {
           string repeat = "";
           Console.WriteLine("What's your name");
           var name = Console.ReadLine();
           Console.WriteLine("");
           Console.WriteLine("When the word NOW pops up press enter as fast as you can");
            
            play(name,repeat);
        }
            
        public static void play(string name2,string repeat2)
        {
           Random rnd = new Random();
           int wait = rnd.Next(1000,10000);
            
            string repeat = repeat2;
            if (repeat == "y") {
            Console.WriteLine("OK, let's go again!!");
            Console.WriteLine("");
           Console.WriteLine("When the word NOW pops up press enter as fast as you can");
            Console.WriteLine("");
            }
            else {
            Console.WriteLine("");
            }
            Console.WriteLine("press enter to begin");
           Console.ReadLine();
           Stopwatch stopwatch = new Stopwatch();

           Sleep(wait);

           stopwatch.Start();
           Console.WriteLine("NOW");
           string reflex = Console.ReadLine();

           stopwatch.Stop();
           double result = Math.Round(Convert.ToDouble(stopwatch.Elapsed.TotalSeconds), 3);
           string result2 = Convert.ToString(result);
           Console.WriteLine("");
           Console.WriteLine("");
           Console.WriteLine($"your time was ............... {result}");

           if (result <= 0.25){
               Console.WriteLine("");
               Console.WriteLine("");
               Console.WriteLine($"Excellent reflexes {name2}");
               Console.WriteLine("");
            }
            else if (result <= 0.3){
               Console.WriteLine("");
               Console.WriteLine("");
               Console.WriteLine($"your reflexes are good {name2}");
               Console.WriteLine("");
            }
            else if (result <= 0.35){
               Console.WriteLine("");
               Console.WriteLine("");
               Console.WriteLine($"your reflexes are about average {name2}");
               Console.WriteLine("");

           } else {
               Console.WriteLine("");
               Console.WriteLine("");
               Console.WriteLine($"{name2}, that was a little disappointing. you should probably try again.");
               Console.WriteLine("");
            }

           Console.WriteLine("What would you like to do now?");
           Console.WriteLine("");
           Console.WriteLine("1 - Play again");
           Console.WriteLine("2 - See the leaderboard");
           Console.WriteLine("3 - I'm done, get me out of here");
           Console.WriteLine("Choose your option 1,2 or 3...");
           string answer = Console.ReadLine();

           if (answer == "1"){
                repeat2 = "y";
                play(name2,repeat2);
            }
            else if (answer == "2") {
                repeat2 = "y";
                HallOfFame(name2,repeat2,result2);
            }
            else {
                Console.WriteLine("");
                Console.WriteLine($"Thanks for playing {name2}!");
                Console.WriteLine("Bye for now!");
                Console.WriteLine(@"          _");
                Console.WriteLine(@"        _| |");
                Console.WriteLine(@"      _| | |");
                Console.WriteLine(@"     | | | |");
                Console.WriteLine(@"     | | | | __");
                Console.WriteLine(@"     | | | |/  \");
                Console.WriteLine(@"     |       /\ \");
                Console.WriteLine(@"     |      /  \/");
                Console.WriteLine(@"     |      \  /\");
                Console.WriteLine(@"     |       \/ /");
                Console.WriteLine(@"      \        /");
                Console.WriteLine(@"       |     /");
                Console.WriteLine(@"       |    |");
           }
        }
            
        public static void Sleep(int wait)
            {
                Thread.Sleep(wait);
            }
        
        public static void HallOfFame (string name2,string repeat2, string result2)
        {
        string repeat = repeat2;
        string name = name2;
        string result3 = result2;
        string[,] leaderboard = new string[10,3];
            
            var webRequest = WebRequest.Create(@"https://trulivecampaign.blob.core.windows.net/public/leaderboard.txt");

            using(var response = webRequest.GetResponse())
            using(var content = response.GetResponseStream())
            {
            
                char[] delimiters = new char[] { ',' };
                int num = 0;

                using (StreamReader reader = new StreamReader(content))
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(@"..//**REACTIONS HALL OF FAME**\\..");
                    Console.WriteLine("");
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        string[] parts = line.Split(delimiters);
                        leaderboard[num,0] = parts[0];
                        leaderboard[num,1] = parts[1];
                        leaderboard[num,2] = parts[2];
                        num++;
                        
                        Console.WriteLine("      {0} --> {1} --> {2}", parts);
                    }
                }

            }

            leaderboard[0,1]=name2;
            leaderboard[0,2]=result2;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do now?");
            Console.WriteLine("");
            Console.WriteLine("1 - Play again");
            Console.WriteLine("2 - See the leaderboard (again)");
            Console.WriteLine("3 - I'm done, get me out of here");
            Console.WriteLine("Choose your option 1,2 or 3...");
           string answer = Console.ReadLine();

           if (answer == "1"){
                repeat2 = "y";
                play(name2,repeat2);
            }
            else if (answer == "2") {
                repeat2 = "y";
                HallOfFame(name2,repeat2,result3);
            }
            else {
                Console.WriteLine("");
                Console.WriteLine($"Thanks for playing {name2}!");
                Console.WriteLine("Bye for now!");
                Console.WriteLine(@"     _");
                Console.WriteLine(@"   _| |");
                Console.WriteLine(@" _| | |");
                Console.WriteLine(@"| | | |");
                Console.WriteLine(@"| | | | __");
                Console.WriteLine(@"| | | |/  \");
                Console.WriteLine(@"|       /\ \");
                Console.WriteLine(@"|      /  \/");
                Console.WriteLine(@"|      \  /\");
                Console.WriteLine(@"|       \/ /");
                Console.WriteLine(@"\        /");
                Console.WriteLine(@" |     /");
                Console.WriteLine(@" |    |");
           }
        }
    }
}