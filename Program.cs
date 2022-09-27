using bset_project;
using System.Runtime.Serialization.Formatters;

Class1 abuukarquiz = new Class1();


Console.WriteLine("this is a 5 question quiz about soccer ");
Console.WriteLine(" question 1");
Console.WriteLine("what team does messi play for  \n a: psg \n b: realmadrid \n c :barcelona \n d: aresenal");
var answer1 = Console.ReadLine();
List<int> list = new List<int>();

{
    

    if (answer1 == "a")
    {
        list.Add(abuukarquiz.answer1);
        Console.WriteLine("you got the answer correct");
     
    }
    else
    {
        Console.WriteLine("you got the answer wrong");
        list.Add(abuukarquiz.answer6);
    }
    Console.WriteLine(" question 2");
    Console.WriteLine(" what team does cristiano ronaldo play for \n a: everton \n b:man united\n c: tottenham \n d: mancity");
    var answer2 = Console.ReadLine();
    if (answer2 == "b")
    {
        Console.WriteLine("you got the correct answer");

        list.Add(abuukarquiz.answer2);
        
    }
    else
    {
        Console.WriteLine("you got the wrong answer");
        list.Add(abuukarquiz.answer6);
    }

    Console.WriteLine("question 3");
    Console.WriteLine("which team won the 2018 worldcup \n a: sweden \n b: england \n c: belgrium \n d:france");
    var answer3 = Console.ReadLine();
    if (answer3 == "d")
    {
        Console.WriteLine("you got  the correct answer");
        list.Add(abuukarquiz.answer3);
       
    }
    else
    {
        Console.WriteLine(" you got the wrong answer");
        list.Add(abuukarquiz.answer7);
    }

    Console.WriteLine("question 4");
    Console.WriteLine("who won the champions league in 2021 \n a:psg \n b:realmardid \n c:chelsa \n d:liverpool");
    var answer4 = Console.ReadLine();
    if (answer4 == "c")
    {
        Console.WriteLine("you got  the correct answer");
        list.Add(abuukarquiz.answer4);
     
    }
    else
    {
        Console.WriteLine(" you got the wrong answer");
        list.Add(abuukarquiz.answer8);
    }

    Console.WriteLine("question 5");
    Console.WriteLine("who won premier league 2021 \n a:Manchester City \n b:aresnal \n c: Liverpool \n d:Tottenham");
    var answer5 = Console.ReadLine();
    if (answer5 == "a")
    {
        Console.WriteLine("you got  the correct answer");
        list.Add(abuukarquiz.answer5);
       
    }
    else
    {
        Console.WriteLine(" you got the wrong answer");
        list.Add(abuukarquiz.answer10);
    }

}
var score = 0;
var number12 = 5;

foreach (var i in list)
{
    score += i;
    
    
    
}
Console.WriteLine("you got a " + score + " out of " + number12);

