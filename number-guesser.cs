
namespace helloworld
{
    public class program
    {
        static void Main(string[] args)
        {
            //Set app vars
            string appName = "numberguesser";
            string appVersion = "1.0.0";
            string appAuthor = "bremer";
            //change text color

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //write up app info

            Console.WriteLine("{0} : version {1} by {2}", appName, appVersion, appAuthor);
            //resetting color

            Console.ResetColor();
            //asking name and greeting

            Console.WriteLine("what is your name");
            //get user input

            string name = Console.ReadLine();
            Console.WriteLine("hello {0} let's play a game", name);
            while (true)
            {
                //create new random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                //Init guess var
                int guess = 0;

                //ask user for guess
                Console.WriteLine("guess a number between 1 and 10");

                //while  guess is not correct
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    //make sure it is a number
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        //write up app info

                        Console.WriteLine("it is not a number!!Pls enter an actual number");
                        //resetting color

                        Console.ResetColor();
                        continue;
                    }


                    //cast to int and put in guess var
                    guess = Int32.Parse(input); //making answer an integer


                    //match guess to correct number
                    if (correctNumber != guess)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        //write up app info

                        Console.WriteLine("Wrong number,pls try again");
                        //resetting color

                        Console.ResetColor();
                    }
                }
                //output succes message
                Console.ForegroundColor = ConsoleColor.Yellow;
                //write up app info

                Console.WriteLine("you are correct");
                //resetting color
                Console.ResetColor();
            }
        }
    }
