
using static System.Console;

// The Saffir-Simpson Hurricane Scale classifies hurricanes into five categories numbered 1 through 5. 
// Write an application named Hurricane that outputs a hurricane’s category based on the user’s input of the wind
//  speed. Category 5 hurricanes have sustained winds of at least 157 miles per hour. The minimum sustained wind 
//  speeds for categories 4 through 1 are 130, 111, 96, and 74 miles per hour, respectively. Any storm with 
//  winds of less than 74 miles per hour is not a hurricane.
class Hurricane
{

    static void Main()
    {
        

            WriteLine("What category is your hurricane: ");
            int answer = Convert.ToInt32(ReadLine());

             

            switch(answer)
            {
                case 1:
                     WriteLine("wind speed is at  74 miles per hour");
                  break;
               case 2:
                    WriteLine("Wind speed is at 96 miles per hour ");
                  break;
                case 3:
                    WriteLine("wind speed is at 111 miles per hour");
                  break;
                case 4:
                    WriteLine("Wind speed is at 130 miles per hour");
                  break;
                case 5:
                    WriteLine("Wind speed is at  157 miles per hour");
                  break;
                default:
                   WriteLine("Invalid input (winds that is  less than 74 miles per hour is not a hurricane.)" );
                   break;

                  

            }
                  // OR I CAN DO A IF/Else STATEMENT ---------------------------------------------------

                  if(answer == 1)
                  {
                      WriteLine("Wind speed is at 74 miles per hour");
                  }
                  else if(answer == 2)
                  {
                       WriteLine("Wind speed is at 96 miles per hour");
                  }
                  else if (answer == 3)
                  {
                        WriteLine("Wind speed is at 111 miles per hour");
                  }
                  else if (answer == 4)
                  {
                        WriteLine("Wind speed is at 130 miles per hour");

                  }
                  else if (answer == 5)
                  {
                        WriteLine("Wind speed is at 157 miles per hour");
                  }
                  else
                  {
                        WriteLine("Invalid input (winds that is less than 74 miles per hour is not a hurricane.) ");
                  }
      }


}
