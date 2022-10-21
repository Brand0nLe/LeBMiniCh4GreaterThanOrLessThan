//Brandon Le
//10-20-22
//Mini Challenge 4 - Greater Than or Less Than
//Will ask the user to input two numbers and will validate whether they are 
//greater, less than, or equal to one another. Will also give an error message if numbers
//are not entered into both inputs and has play again option.

bool playAgain = true;
int validNum = 0;
int validNum2 = 0;
string num1;
string num2;
string userAnswer;
bool canParse = false;
bool userInput = true;
bool userInput2 = true;
int realNum;




while (playAgain == true)
{

    Console.WriteLine("Today we are going to compare two numbers!");
    Console.WriteLine("Doesn't that sound like fun?");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Okay enter your first number:");
    num1 = Console.ReadLine();
    canParse = Int32.TryParse(num1, out realNum);
    while(canParse == false)
    {
        Console.WriteLine("INVALID ENTRY. Please enter a number:");
        num1 = Console.ReadLine();
        canParse = Int32.TryParse(num1, out validNum);
    }


        Console.WriteLine("Enter the second number:");
        num2 = Console.ReadLine();
        canParse = Int32.TryParse(num2, out realNum);
        while(canParse == false)
    {
        Console.WriteLine("INVALID ENTRY. Please enter a number:");
        num2 = Console.ReadLine();
        canParse = Int32.TryParse(num2, out validNum);
    }

    userInput = Int32.TryParse(num1, out validNum);
    userInput2 = Int32.TryParse(num2, out validNum2);


    if (validNum > validNum2)
    {   
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"{validNum} is greater than {validNum2}");
        Console.WriteLine($"{validNum2} is less than {validNum}");
        Console.WriteLine("-----------------------------------------");
    }
    else if (validNum < validNum2)
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"{validNum2} is greater than {validNum}");
        Console.WriteLine($"{validNum} is less than {validNum2}");
        Console.WriteLine("-----------------------------------------");
    }
    else if (num1 == num2)
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"{validNum} is equal to {validNum2}");
        Console.WriteLine("-----------------------------------------");
    }

    Console.WriteLine("Do you want to play again? (YES/NO)");
    userAnswer = Console.ReadLine().ToUpper();


        while(userAnswer != "YES" && userAnswer != "NO")
    {
        Console.WriteLine("INVALID ENTRY! Please enter YES or NO.");
        userAnswer = Console.ReadLine().ToUpper();
    }

    if (userAnswer == "YES")
    {
        playAgain = true;
    }
    if (userAnswer == "NO")
    {
        playAgain = false;
        Console.WriteLine("It was fun! See you next time :)");
    }




}
