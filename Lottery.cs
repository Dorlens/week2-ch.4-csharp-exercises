using static System.Console;

// Create a lottery game application named Lottery. Generate three random numbers,
// each between 1 and 4. Allow the user to guess three numbers. Compare each of the 
// 183 user’s guesses to the three random numbers, and display a message that includes the
// user’s guess, the randomly determined three-digit number, and the amount of money
// the user has won 

class Lottery
{

        enum LotteryPick
        {

            num1 = 1,
            num2 = 2,
            num3 = 3,
            num4 = 4

        }

    static void Main()
    {
            Random random = new Random();

            int randomRange1 = random.Next(1,5);
            int randomRange2 = random.Next(1,5);
            int randomRange3 = random.Next(1,5);

            WriteLine("Enter your First Number (1-4): ");
            int userPick1 = Convert.ToInt32(ReadLine());

            WriteLine("Enter your Second number(1-4):  ");
            int userPick2 = Convert.ToInt32(ReadLine());

            WriteLine("Enter your Third Number (1-4): ");
            int userPick3 = Convert.ToInt32(ReadLine());

            LotteryPick humanPick1 = (LotteryPick) userPick1;
            LotteryPick humanPick2 = (LotteryPick) userPick2;
            LotteryPick humanPick3 = (LotteryPick) userPick3;

            LotteryPick compPick1 = (LotteryPick) randomRange1;
            LotteryPick compPick2 = (LotteryPick) randomRange2;
            LotteryPick compPick3 = (LotteryPick) randomRange3;
            
            WriteLine("The lottery picks are {0}, {1} , {2}" , randomRange1, randomRange2,randomRange3 );
            
            WriteLine("Your picks are {0}, {1}, {2}" ,userPick1, userPick2, userPick3);

            if(humanPick1 == compPick1 && humanPick2 == compPick2 && humanPick3 ==compPick3)
             {
                WriteLine("You won $10");
             }
            else if((humanPick1 == compPick1 && humanPick2 == compPick3 && humanPick3 == compPick2)||
                 (humanPick1 == compPick2 && humanPick2 == compPick1 && humanPick3 == compPick3) ||
                 (humanPick1 == compPick2 && humanPick2 == compPick3 && humanPick3 == compPick1) ||
                 (humanPick1 == compPick3 && humanPick2 == compPick1 && humanPick3 == compPick2) ||
                 (humanPick1 == compPick3 && humanPick2 == compPick2 && humanPick3 == compPick1) ||
                 (humanPick1 == compPick1 && humanPick2 == compPick2 && humanPick3 == compPick3))
                 {
                    WriteLine("you won $10 invest back in the lottery");
                 }
            else if ((humanPick1 == compPick1 && humanPick2 == compPick2)||
                 (humanPick1 == compPick1 && humanPick2 == compPick3) ||
                 (humanPick1 == compPick2 && humanPick2 == compPick3) ||
                 (humanPick1 == compPick1 && humanPick3 == compPick2) ||
                 (humanPick1 == compPick2 && humanPick3 == compPick3) ||
                 (humanPick2 == compPick1 && humanPick3 == compPick2) ||
                 (humanPick2 == compPick1 && humanPick3 == compPick3) ||
                 (humanPick2 == compPick2 && humanPick3 == compPick3))
                 {
                    WriteLine("You won $100! go buy you something nice ");
                 }
            else if ((humanPick1 == compPick1 || humanPick1 == compPick2 || humanPick1 == compPick3) &&
                     (humanPick2 == compPick1 || humanPick2 == compPick2 || humanPick2 == compPick3) &&
                     (humanPick3 == compPick1 || humanPick3 == compPick2 || humanPick3 == compPick3))
                     {
                          WriteLine("You won $1000");
                     }
            else if (humanPick1 == compPick1 && humanPick2 == compPick2 && humanPick3 == compPick3)
                    {
                        WriteLine("You matched all three numbers in the exact order! You won $10,000");
                    }
            else
                 {
                    WriteLine("you have no matches");
                 }
    }
            

                
            
             

}




