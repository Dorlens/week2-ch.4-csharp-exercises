using static System.Console;

// Create a game in which the computer randomly chooses rock, paper, or scissors. 
// Let the user enter a character, r, p, or s, each representing one of the three choices. 
// Then, determine the winner. Save the application as RockPaperScissors.cs.
class RockPaperScissors
{
    
    enum Pick
     {
        rock = 1,
        scissors = 2,
        paper = 3
     }
     static void Main()
    {

        Random random = new Random();

       
        WriteLine("Enter a number (1- Rock , 2- Scissors, 3-Paper)");
         int user = Convert.ToInt32(ReadLine());
         int randomRange = random.Next(1,3);
         WriteLine($"Random number from computer:  {randomRange}");

         WriteLine($"{user} {randomRange}");

            Pick humanPick = (Pick)user;
            Pick compPick = (Pick) randomRange;
         if(user == randomRange)
         {
            WriteLine("Its a tie!");

         }
         else if(humanPick == Pick.rock  && compPick == Pick.paper)
         {
            WriteLine("Computer Win");
         }
         else if(humanPick == Pick.paper && compPick == Pick.rock)
         {

            WriteLine("User wins");
         }
         else if(humanPick == Pick.scissors && compPick == Pick.paper)
         {
            WriteLine("User wins");
         }
         else if(humanPick == Pick.paper && compPick == Pick.scissors)
         {
            WriteLine("Computer wins");
         }
         else if(humanPick == Pick.scissors && compPick == Pick.rock)
         {
            WriteLine("computer wins");
         }
         else 
         {
            WriteLine("user wins");
         }

    }




}