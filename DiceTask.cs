using System;

namespace TaskDice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guessing game
            Console.WriteLine("Press any letter to start the game!");
            string gameStarter = Console.ReadLine();
            
            Random randy = new Random();
            int diceOne = randy.Next(1,7);
            int diceTwo = randy.Next(1,7);
            int diceThree = randy.Next(1,7);

            Console.WriteLine($"The values are {diceOne}, {diceTwo}, and {diceThree}" );
            int addValues = diceOne + diceTwo + diceThree;
            Console.WriteLine(addValues);
                      
            if(diceOne == diceTwo && diceTwo == diceThree)
            {
                Console.WriteLine("Congrats you have been awarded 6 more points!");
                Console.WriteLine(addValues += 6);
            }
            else if(diceOne==diceTwo || diceOne==diceThree || diceTwo ==diceThree)
            {
                Console.WriteLine("you have been awarded 2 more points!");
                Console.WriteLine(addValues += 2);
            }

            var result = addValues >= 15 ? "Congrats!!! YOU WON" : "OOOOOPS YOUR VALUE IS NOT UP TO 15\nYOU CAN TRY AGAIN LATER";
    
            Console.WriteLine(result);    

        }

    }
}
