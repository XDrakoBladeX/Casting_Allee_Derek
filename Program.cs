namespace Casting_Allee_Derek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This displays the message to the console.
            Console.Write("What is your favoroite number?: ");

            //This reads the user input and stores it as a string variable.
            string userInput = Console.ReadLine();

            //This converts the string variable to an integer. 
            int favoriteNumber = Convert.ToInt32(userInput);
                        
            //This displays the message to the console with the user's favorite number. 
            Console.WriteLine("Your favorite number is " + favoriteNumber + "!");

            //This is just adding a blank line between the sections. 
            Console.WriteLine();

            //This diplays the message to the console. 
            Console.Write("Do you like video games? (enter true or false):");

            //This reads the user input and stores it as a string variable.
            string userInput2 = Console.ReadLine();

            //This creats a boolean vale from the userInput2.
            bool isTrue = Convert.ToBoolean(userInput2);

            //This displays the message to the console with the user's answer.
            Console.WriteLine("It is " + isTrue + " that you like video games!");


        }
    }
}
