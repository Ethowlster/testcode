using System;

namespace testcode {
 class Program {
  static void Main (string[] args) {
   string name;
   int birthyear;

   Console.WriteLine("What year were you born?: ");
   birthyear = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("");

    int gretchenstrength = 0;
    int gretchenspeed = 0;
    int gretchenagility = 0;
    bool isaskeda = false;
    bool isaskedb = false;
    bool isaskedc = false;

    Console.WriteLine("~Meeting the Monster~");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("You wake up in a dark alley, your head lolls onto your shoulder and you hear a loud crack.");
    Console.WriteLine("There is a low humming sound coming from a dustbin nearby. Do you investigate?");
    Console.WriteLine("");
    string investigate = Console.ReadLine();
    Console.WriteLine("");
   if (investigate == "yes") {
    Console.WriteLine("as you lift your body off the grimey floor you can feel your muscles screaming in pain.");
    Console.WriteLine("When you reach the bin you lift the lid off warily....");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("BANG");
   } else {
    Console.WriteLine("you decide not to look in the bin and instead rest your body for a few more minutes.");
    Console.WriteLine("after a while you realise that the humming has stopped, it was annoying anyway");
    Console.WriteLine("");
    Console.WriteLine("You close your eyes for a second, when you here a loud bang behind you.");
   }
    Console.WriteLine("Your head whips around in the direction from where the sound came");
    Console.WriteLine("");
    Console.WriteLine(@" .-.");
    Console.WriteLine(@"(o o)");
    Console.WriteLine(@"| O \");
    Console.WriteLine(@" \   \");
    Console.WriteLine(@"  `~~~'");
    Console.WriteLine("BOO");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("you are astounded as a red cloud with glowing yellow eyes appears to be floating in front of you.");
    Console.WriteLine("");
    Console.WriteLine("hello my name is gretchen.");
    Console.WriteLine("Please let me know your name, it asks politely ");
    name = Console.ReadLine();
    char question;
    Console.WriteLine("");
    Console.WriteLine($"Nice to meet you {name}");
    Console.WriteLine("");
    Console.WriteLine("You have so many questions but don't know where to start.");
    Console.WriteLine("A. What are you?");
    Console.WriteLine("B. How'd you get here?");
    Console.WriteLine("C. Do you have powers?");
    Console.WriteLine("What do you ask?");
    question = Convert.ToChar(Console.ReadLine());

   string answer1;
           switch (Char.ToLower(question)) {
            case 'a':
            isaskeda = true;
            Console.WriteLine("");
            Console.WriteLine("A fire spirit, I was born in the underworld");
            Console.WriteLine("");
            break;
            case 'b':
            isaskedb = true;
            Console.WriteLine("");
            Console.WriteLine($"I started a revolution of the lesser demons against the stronger spirits in {birthyear} which led to");
            Console.WriteLine("my banishement to the overworld by Mulgrath, the hellfire guardian");
            Console.WriteLine("");
            break;
            default:
            isaskedc = true;
            Console.WriteLine("");
            Console.WriteLine("I can sumon fire sprites and specialise in the art of fire bending.");
            Console.WriteLine("");
            break;
        }
   if (isaskeda || true && isaskedb || true && isaskedc || true) {
        Console.WriteLine(" you are the first human bean that has not shown me aggression, i appreciate this.");
        Console.WriteLine(" May you give me a purpose and let me serve you?");
        Console.WriteLine(" please.....help me");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine(" your answer please (yes/no)");

        answer1 = Console.ReadLine();
        Console.WriteLine("");
        if (answer1 == "yes") {

            Console.WriteLine($"Thank you very much {name} I appreciate this so much, you wont regret it!");
            Console.WriteLine(" We must begin my training as soon as possible so that i may protect you from the evil");
            Console.WriteLine("spirits that roam this earth");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("you wonder what this creature is reffering to. For some reason you feel");
            Console.WriteLine("somewhat responible for this little floating ball. If you look at it at an angle");
            Console.WriteLine("it looks kind of cute.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"What do you say {name}. What should I train today, Strength, Speed or Agility?");

            string answer3 = Console.ReadLine();
            if (answer3 == "strength" || answer3 == "Strength") {
                Random rnd = new Random();
                gretchenstrength = gretchenstrength + rnd.Next(0, 7);
                Console.WriteLine("");
                Console.WriteLine($"Nice! My Strength is now {gretchenstrength}");
            }
            else if (answer3 == "speed" || answer3 == "Speed") {
                Random rnd = new Random();
                gretchenspeed = gretchenspeed + rnd.Next(0, 7);
                Console.WriteLine("");
                Console.WriteLine($"Nice! My Speed is now {gretchenspeed}");
            } else {
                Random rnd = new Random();
                gretchenagility = gretchenagility + rnd.Next(0, 7);
                Console.WriteLine("");
                Console.WriteLine($"Nice! My Agility is now {gretchenagility}");
            }

        } else {
            Console.WriteLine($"WHY {name}! Why have you forsaken me to this life of misery! What did I do wrong?");
            Console.WriteLine("ANSWER ME!");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("I dont think that is a good enough excuse... I'm going to follow you anyway.");
            Console.WriteLine("You are confused to how this situation came to be but for some reason you feel");
            Console.WriteLine("somewhat responible for this little floating ball. If you look at it at an angle");
            Console.WriteLine("it looks kind of cute.");
        }

   } else {

   }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("~A Companion~");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("5 days have passed and you are on the 11:58 train to nowhere. Since you met gretchen, your life");
        Console.WriteLine("has been turned upside down. He has opened your eyes to a whole new world.");
        Console.WriteLine("Things that you would've scoffed at before, you now believe fervently.");
        Console.WriteLine("The spherical creature is resting in your shirts chest pocket");
        Console.WriteLine("you can feel its warm surface vibrating as it absobrs the energy surrounding it.");
        Console.WriteLine("you close your eyes and try to focus on the sounds of the tracks");
        Console.WriteLine("every clink of the wheels brings you a peace of mind that you haven't felt for a while.");
        Console.WriteLine("you enjoy the moment");
        Console.WriteLine("");
        Console.WriteLine("you realise that you were asleep, you feel rejuvenated,");
        Console.WriteLine("your head feels heavy and you hear a womans voice");
        Console.WriteLine("");
        Console.WriteLine("the...n...t..st...is..cry...alace.");
        Console.WriteLine("your brain hasnt fully woken up yet but you feel like she is saying something important");
        Console.WriteLine("you can feel your mind slowly falling back into the dark, peaceful void");
        Console.WriteLine("");
        Console.WriteLine("AAAAAHHHHH");
        Console.WriteLine("");
        Console.WriteLine("your eyes jolt open as you grasp at your chest.");
        Console.WriteLine("there is a searing pain..... heat induced");
        Console.WriteLine("What do you do?");
        Console.WriteLine("1.RUN");
        Console.WriteLine("2.grab your pocket and PULL");
        string descision1 = Console.ReadLine();
    if (descision1 == "1") {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("you lift yourself off of your seat and dash towards the bleeping doors,");
        Console.WriteLine("the doors slam shut just as you slip through the gap.");
        Console.WriteLine("your attention is hauled back towards the unbelievable pain");
        Console.WriteLine("reaching towards your pocket you feel the heat fade");
        Console.WriteLine("a voice pierces your mind");
       

        
   } else {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("your hand firmly grabs the ball of evil in your pocket and ");
        Console.WriteLine("rips it from its resting place");
        Console.WriteLine("as your grip untightens the creatures eyes begin to open and you can feel your anger melting away,");
        Console.WriteLine("leaving your seat and the train behind you hear a noise from the ball");
        Console.WriteLine("");
        Console.WriteLine("");
        
        
   }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("uuurrrgggghhhh");
        Console.WriteLine("");
        Console.WriteLine("now that was refreshing");
        Console.WriteLine("");
        Console.WriteLine($"how are you feeling {name}");
        string feeling1 = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("hahaha");
        Console.WriteLine("");
        Console.WriteLine($"You should hear yourself.... '{feeling1}' he repeats in a mocking tone");
        Console.WriteLine("");
        Console.WriteLine("aaaannnnnyway");
        Console.WriteLine("");
        Console.WriteLine("Now that you're up, what we doing?");
        Console.WriteLine("1. IDK lets just walk around and see what happens");
        Console.WriteLine("2. Lets find out where we are first");
        string wedoing1 = Console.ReadLine();
    if (wedoing1 == "1") {
        Console.WriteLine("");
        Console.WriteLine("");
    }
   }
  }
 }