//Brandon Le
//10-19-22
//Mini Challenge 4 - Greater Than or Less Than



bool playAgain = true;
int validNum = 0;
int validNum2 = 0;
string num1;
string num2;
bool userInput = true;
bool userInput2 = true;
string userAnswer;




while (playAgain == true)
{

    Console.WriteLine("Today we are going to compare two numbers!");
    Console.WriteLine("Doesn't that sound like fun?");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Okay enter your first number:");
    num1 = Console.ReadLine();

    Console.WriteLine("Enter the second number:");
    num2 = Console.ReadLine();

    userInput = Int32.TryParse(num1, out validNum);
    userInput2 = Int32.TryParse(num2, out validNum2);

    if((userInput != true) || (userInput2 != true))
    {
        Console.WriteLine("Enter in NUMBERS only. Please try again.");
    }
    else if (validNum > validNum2)
    {
        Console.WriteLine($"{validNum} is greater than {validNum2}");
        Console.WriteLine($"{validNum2} is less than {validNum}");
    }
    else if (validNum < validNum2)
    {
        Console.WriteLine($"{validNum2} is greater than {validNum}");
        Console.WriteLine($"{validNum} is less than {validNum2}");
    }
    else if (num1 == num2)
    {
        Console.WriteLine($"{validNum} is equal to {validNum2}");
    }
    Console.WriteLine("Do you want to play again? (YES/NO)");
    userAnswer = Console.ReadLine().ToUpper();

    if (userAnswer == "YES")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
        Console.WriteLine("It was fun! See you next time :)");
    }


}
