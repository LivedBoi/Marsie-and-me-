using System.Xml.Schema;

Random dice = new Random();


int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int[] rolls = {roll1, roll2, roll3};

int total = 0;


if(roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
    {
        int triples = 6;
        
        if(roll1 == roll2 && roll2 == roll3)
       { 
        Console.WriteLine("Plus 6 added to score");
        
       
       }
        int doubles = 2;
    
        Console.WriteLine("Plus 2 added to score");
        
    
        total = triples & doubles; 
        
    }
    
total = roll1 + roll2 + roll3;
    




Console.WriteLine($"roll 1:\t {roll1} \nroll 2:\t {roll2} \nroll 3:\t {roll3}\n\n Total Score = {total}");

