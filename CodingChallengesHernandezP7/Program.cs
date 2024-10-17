using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
class Challenges
{

    public static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to my Coding challenge program. I will be making a variety of functions for you to use.");
        Start();


    }
    public static void Start()
    {
        

        //Welcome the user to my program//
        Console.WriteLine("Please choose a function \n To see a list of all functions, please type 'Functions'");
        var response = Console.ReadLine();
        if (response == "Functions")
        {
            Console.WriteLine("Plus\nConvert\nAddOne\nPower Of Curcuit\nAgeCalc\nTriARea\nTrue Or False");
            Start();
        }
        else if (response == "Plus")
        {
            // CHALLENGE 1 //

            Console.WriteLine("Excellent, now we are going to use the number adder today called sum. Please give me two numbers");
            var number1 = Console.ReadLine();
            int numberToUse1 = int.Parse(number1);
            Console.WriteLine("Got it, give me your 2nd number.\n");
            var number2 = Console.ReadLine();
            int numberToUse2 = int.Parse(number2);
            Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + Sum(numberToUse1, numberToUse2));
            Sum(numberToUse1, numberToUse2);
        }
        else if (response == "Convert")
        {
            // CHALLENGE 2 //

            Console.WriteLine("Beautiful, now we are going to convert a minute to the amount of seconds in one. \n Please input a minute number");
            var number3 = Console.ReadLine();
            int numberToUse3 = int.Parse(number3);
            Console.WriteLine(" If I convert " + number3 + " minutes to seconds. I got " + Convert(numberToUse3) + " Seconds. ");
        }
        else if (response == "AddOne")
        {
            // CHALLENGE 3 //

            Console.WriteLine("Perfect, now we are going to use the increments in order to add +1 to the number \n Please type a number to add 1 to.");
            var number4 = Console.ReadLine();
            int numberToUse4 = int.Parse(number4);
            Console.WriteLine(" If " + number4 + " is incremented by 1, the result is " + (numberToUse4 + 1) + ".");
        }
        else if (response == "Power Of Curcuit")
        {
            // CHALLENGE 4 //

            Console.WriteLine("Okay now we are going to take a value for voltage and multiply it by a current value to calculate power \n Please type in a value for voltage.");
            var voltage = Console.ReadLine();
            int voltageToUse = int.Parse(voltage);
            Console.WriteLine("Okay, Now we need a value for current to multiply\n Please enter a value for current.");
            var current = Console.ReadLine();
            int currentToUse = int.Parse(current);
            Console.WriteLine("If " + voltage + " is multiplied by " + current + ", the result is " + CircuitPower(voltageToUse, currentToUse) + ".");
        }
        else if (response == "AgeCalc")
        {
            // CHALLENGE 5 //

            Console.WriteLine("Good, now we are going to converts a age in years to the in days \n Please Input a age in years.");
            var years = Console.ReadLine();
            int yearsToUse = int.Parse(years);

            Console.WriteLine("If I convert " + years + " years to days. I get " + CalcAge(yearsToUse) + ".");
        }
        else if (response == "TriARea")
        {
            // CHALLENGE 6 //

            Console.WriteLine("Nice, now we are going to take the base and the height to get the area. \n Please type in the base.");
            var baseo = Console.ReadLine();
            float baseToUse = float.Parse(baseo);
            Console.WriteLine("Okay Now we need the height of the triangle \n Please enter a value height.");
            var height = Console.ReadLine();
            float heightToUse = float.Parse(height);
            Console.WriteLine("If " + baseo + " is multiplied by " + height + " and halved, the result is " + triArea(baseToUse, heightToUse) + ".");
        }
        else if (response == "True Or False")
        {
            // CHALLENGE 7 //

            Console.WriteLine("Perfect, now we are going to find out whether whatever number used is true or false just for this program. \n Please enter a random number.");
            var number5 = Console.ReadLine();
            int number5ToUse = int.Parse(number5);
            Console.WriteLine("If " + number5 + " is used " + ", the result is " + lessThanOrEqualToZero(number5ToUse) + ".");
        }
        else
        {
            Console.WriteLine("This is not a valid Function.");
            
        }
        Start();

    }




    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }
    public static int Convert(int minutes)
    {
        return minutes * 60;
    }
    public static int increment(int number)
    {
        return number + 1;
    }
    public static int CircuitPower(int voltage, int current)
    {
        return voltage * current;
    }
    public static int CalcAge(int years)
    {
        return years * 365;
    }
    private static float triArea(float baseo, float height )
    {
        return height * baseo / 2;
    }
    public static bool lessThanOrEqualToZero(int number5)
    {
        return number5 <= 0;
        
    }
}



