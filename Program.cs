using System;

namespace testcode
{
    class Program
    {
        static void Main(string[] args)
        {
                string name;
                int birthyear;

                Console.WriteLine("What year were you born?: ");

                birthyear = Convert.ToInt32(Console.ReadLine());

                int gretchenage = 1583;
             
             
             Console.WriteLine($"hello my name is gretchen and I am an ember spirit, I have been alive for {gretchenage} years.");
             Console.WriteLine("Please let me know your name ");

             name = Console.ReadLine();
             Console.WriteLine("");
             Console.WriteLine($"Nice to meet you {name}");
             Console.WriteLine("");
             Console.WriteLine("I was born in the underworld and was abandoned by my parents at a young age,");
             Console.WriteLine("a friendly fire demon took me as his appretice. I can sumon fire sprites and specialise in the art of fire bending.");
             Console.WriteLine($"I started a revolution of the lesser demons against the stronger spirits in {birthyear} which led to");
             Console.WriteLine("my banishement to the overworld by Mulgrath, the hellfire guardian");
             Console.WriteLine("Since then i have been living in the shadows, travelling from city to city trying to find a place to stay");
             Console.WriteLine("you are the first human bean that has not shown me aggression, i appreciate this. May you give me a purpose and let me serve you?");
             Console.WriteLine("Ask anything of me and it will be done");
             
             Console.WriteLine("please.....help me");
             Console.WriteLine("");
             Console.WriteLine("");
             Console.WriteLine("");
             Console.WriteLine("");
             Console.WriteLine("your answer please");
            
             string answer1 = Console.ReadLine();

             if   (answer1 == "yes") {

             Console.WriteLine($"Thank you very much {name} I appreciate this so much, you wont regret it!");
             }
             else {
             Console.WriteLine($"WHY {name}! Why have you forsaken me to this life of misery! ");
             }
           
			 Console.WriteLine("We must begin my training as soon as possible so that i may protect you from the evil");
			 Console.WriteLine("spirits that roam this earth");
			 Console.WriteLine("");
			 Console.WriteLine("");
			 Console.WriteLine($"What do you say {name}. What should I train today, Strength, Speed or Agility?");
             


            

                
            
        }
    }
}