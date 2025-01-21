using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization.Metadata;
using Microsoft.VisualBasic;
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
        Console.WriteLine("Please choose a function\n To exit out of this program, type in 'Finito'\n Here are all functions available.");

        Console.WriteLine("Plus\nConvert\nAddOne\nPower Of Curcuit\nAgeCalc\nTriARea\nTrue Or False\nSum True or False\n2IntTF\nSomething\nReverse Bool\nHours To Sec\nPolygonAngle\nnameString" +
                "\nTrueTrueTrue\nCalcPoint\nCalcPerimeter\nHelloName\nanimals\nBallPoint\nMonthName\nMINMAX\nAdSum\nCalcEx\nMultByLength\nHammingDist\n");
        var response = Console.ReadLine();



        if (response == "Plus")
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
        else if (response == "TriArea")
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
        else if (response == "Sum True or False")
        {
            // CHALLENGE 8 //

            Console.WriteLine("Perfect, now we are going to find out whether sum you put in will be true or false. \n Please enter a random number.");
            var number5 = Console.ReadLine();
            int number5ToUse = int.Parse(number5);
            Console.WriteLine(" Okay Please enter another number.");
            var number6 = Console.ReadLine();
            int number6ToUse = int.Parse(number6);
            Console.WriteLine("If " + number5 + " is used " + ", the result is " + lessThan100(number5ToUse, number6ToUse) + ".");
        }
        else if (response == "2IntTF")
        {
            // CHALLENGE 9 //

            Console.WriteLine("Okay, now we are going to find out whether two integers you enter will be true or false. \n Please enter a random number.");
            var number5 = Console.ReadLine();
            int number5ToUse = int.Parse(number5);
            Console.WriteLine("Okay, Please enter another number.");
            var number6 = Console.ReadLine();
            int number6ToUse = int.Parse(number6);
            Console.WriteLine("If " + number5 + " and " + number6 + " is used the result is " + IsEqual(number5ToUse, number6ToUse) + ".");
        }
        else if (response == "Something")
        {
            // CHALLENGE 10 //

            Console.WriteLine("Okay, now we are going to use the something simulator\n Please enter a random sentence.");
            string responsej = Console.ReadLine();
            Console.WriteLine(GiveMeSomething(responsej) + ".");

        }
        else if (response == "Reverse Bool")
        {
            // CHALLENGE 11 //


            Console.WriteLine("We are going to reverse any boolean value\n Please enter either true or false.");
            var responseh = Console.ReadLine();
            bool responseToUse = bool.Parse(responseh);
            Console.WriteLine(Reverse(responseToUse) + ".");

        }
        else if (response == "Hours To Sec")
        {
            // CHALLENGE 12 //

            Console.WriteLine("Beautiful, now we are going to convert hours to seconds. \n Please a number for hour.");
            var hours = Console.ReadLine();
            float hoursToUse = float.Parse(hours);
            Console.WriteLine(" If I convert " + hours + " hours to seconds. I get " + howmanySeconds(hoursToUse) + " seconds. ");
        }
        else if (response == "PolygonAngle")
        {
            // CHALLENGE 13 //
            Console.WriteLine("Okay, now we are going find the total sum of internal angles from a certain amount of sides. \n Please input a number of sides.");
            bool cow = false;
            while (!cow)
            {
                var InputSides = Console.ReadLine();
                int sides = int.Parse(InputSides);
                if (sides >= 3)
                {
                    Console.WriteLine(" If this number is used " + InputSides + " . The polygon's angles are " + SumPolygon(sides) + ".");
                    cow = true;
                }
                else
                {
                    Console.WriteLine("This isn't valid as a polygon can't have less than 3 sides. ");
                }
            }



        }
        else if (response == "nameString")
        {
            // CHALLENGE 14 //

            Console.WriteLine("Okay going to fix a code using a string name plus the string edabit. \n Please enter an input.");
            string nameString = Console.ReadLine();
            Console.WriteLine(" If " + nameString + " is used. I get " + nameStringH(nameString) + " . ");
        }
        else if (response == "TrueTrueTrue")
        {
            // Challenge 15 //
            Console.WriteLine("Nice, now we are going to use the operator to determine if two boolean values are true. Please type in true or false.");
            var Response5 = Console.ReadLine();
            bool bool1 = bool.Parse(Response5);
            Console.WriteLine("Now enter the second input for the second half to figure out if its right.");
            var Response2 = Console.ReadLine();
            bool bool2 = bool.Parse(Response2);
            Console.WriteLine(And(bool1, bool2));
            Console.WriteLine(" And(" + bool1 + "," + bool2 + ")  -> " + And(bool1, bool2));


        }
        else if (response == "CalcPoint")
        {
            // Challenge 16 //
            Console.WriteLine("Okay, we now are going to calculate the number of 3-pointers and 2-pointers scored to find the final points, Please enter a number op two-pointers.");
            var number7 = Console.ReadLine();

            int numberToUse7 = int.Parse(number7);

            Console.WriteLine("Now enter the second number of 3 pointers.");

            var number8 = Console.ReadLine();

            int numberToUse8 = int.Parse(number8);

            Console.WriteLine(" points ( " + number7 + ", " + number8 + ") --> " + CalcPoint(numberToUse7, numberToUse8));
        }
        else if (response == "CalcPerimeter")
        {
            // Challenge 18 //
            Console.WriteLine("Okay, we now are going to calculate the perimeter of a rectangle based on length and width, Please enter a number for length.");
            var number9 = Console.ReadLine();

            int numberToUse9 = int.Parse(number9);

            Console.WriteLine("Now enter the second number of width.");

            var number10 = Console.ReadLine();

            int numberToUse10 = int.Parse(number10);

            Console.WriteLine(" Perimeter ( " + number9 + ", " + number10 + ") --> " + CalcPerimeter(numberToUse9, numberToUse10));
        }
        else if (response == "HelloName")
        {
            Console.WriteLine("Nice, now we are going to add Hello to the end of whatever you input. Please input a name of other word.");
            string number11 = Console.ReadLine();
            Console.WriteLine(" HelloName (" + number11 + ") --> " + ("Hello " + number11));
        }
        else if (response == "animals")
        {
            // Challenge 19 //
            Console.WriteLine("Okay, we now are going to calculate the number of legs of random animals, Please enter a number for the legs of chickens.");
            var number12 = Console.ReadLine();

            int numberToUse12 = int.Parse(number12);

            Console.WriteLine("Now enter the legs for cows.");

            var number13 = Console.ReadLine();

            int numberToUse13 = int.Parse(number13);

            Console.WriteLine("Now enter the legs for the pigs.");

            var number14 = Console.ReadLine();

            int numberToUse14 = int.Parse(number14);

            Console.WriteLine(" animals ( " + number12 + ", " + number13 + ", " + number14 + ", ) --> " + animals(numberToUse12, numberToUse13, numberToUse14));
        }
        else if (response == "BallPoint")
        {
            // Challenge 20 //
            Console.WriteLine("Okay, we now are going to calculate the number of wins you can get when enter a number of draws and losses. PLease enter a number of wins.");
            var number15 = Console.ReadLine();

            int numberToUse15 = int.Parse(number15);

            Console.WriteLine("Now enter the number of draws.");

            var number16 = Console.ReadLine();

            int numberToUse16 = int.Parse(number16);

            Console.WriteLine("Now enter the losses.");

            var number17 = Console.ReadLine();

            int numberToUse17 = int.Parse(number17);

            Console.WriteLine(" FootballPoints ( " + number15 + ", " + number16 + ", " + number17 + ", ) --> " + FootballPoint(numberToUse15, numberToUse16, numberToUse17));


        }
        else if (response == "MonthName")
        {
            // Challenge 21 //
            Console.WriteLine(" We now are going to use the months calculation. PLease enter a number 1 to 12. ");
            int monthInt = 1;

            bool valid1 = false;
            while (!valid1)
            {
                var superS = Console.ReadLine();
                if (int.TryParse(superS, out _))
                {
                    int car = int.Parse(superS);
                    if (car > 0 && car <= 12)

                    {
                        valid1 = true;
                        monthInt = car;
                    }
                    else
                    {
                        Console.WriteLine(" This is not 1 to 12, try again.");
                    }
                }
                else
                {
                    Console.WriteLine(" This is not 1 to 12, try again.");

                }

            }
            Console.WriteLine(" Challenge 1 MonthName(" + monthInt + ") is: " + MonthName(monthInt));


        }
        else if (response == "MINMAX")
        {
            // Challenge 22 //
            Console.WriteLine(" We now are going to find the min and max numbers from the numbers you input. Please enter a number. ");
            var monthInt = new List<int>();

            bool valid1 = false;
            while (!valid1)
            {
                var superS = Console.ReadLine();
                if (int.TryParse(superS, out _))
                {
                    int car = int.Parse(superS);



                    valid1 = true;
                    monthInt.Add(car);


                }
                else
                {
                    Console.WriteLine(" Not a number try again.");

                }


            }
            bool malice1 = false;
            while (!malice1)
            {
                Console.WriteLine(" Please enter another number, or enter 'done' to end");
                var superS = Console.ReadLine();
                if (superS == "done")
                {
                    malice1 = true;
                }
                else
                {
                    if (int.TryParse(superS, out _))
                    {
                        int car = int.Parse(superS);



                        valid1 = true;
                        monthInt.Add(car);


                    }
                    else
                    {
                        Console.WriteLine(" Not a number try again.");

                    }
                }



            }
            Console.WriteLine(" MinMax(" + arrayString(monthInt.ToArray()) + ") -> " + arrayString(MinMax(monthInt.ToArray())));

        }

        else if (response == "AdSum")
        {
            Console.WriteLine(" We now are going to find the absolute value of numbers that you input. Please enter a number.");
            var monthInt = new List<int>();

            bool valid1 = false;
            while (!valid1)
            {
                var superS = Console.ReadLine();
                if (int.TryParse(superS, out _))
                {
                    int car = int.Parse(superS);



                    valid1 = true;
                    monthInt.Add(car);


                }
                else
                {
                    Console.WriteLine(" Not a number try again.");

                }


            }
            bool malice1 = false;
            while (!malice1)
            {
                Console.WriteLine(" Please enter another number, or enter 'done' to end");
                var superS = Console.ReadLine();
                if (superS == "done")
                {
                    malice1 = true;
                    }
                else
                {
                    if (int.TryParse(superS, out _))
                    {
                        int car = int.Parse(superS);



                        valid1 = true;
                        monthInt.Add(car);


                    }
                    else
                    {
                        Console.WriteLine(" Not a number try again.");

                    }
                }



            }
            Console.WriteLine(" AdSum(" + arrayString(monthInt.ToArray()) + ") -> " + AdSum(monthInt.ToArray()));
        }
        else if (response == "CalcEx")
        {
            Console.WriteLine("We now are going to use the exponent calc. Please enter a base.");
            int monthInt = 1;
            int expInt = 1;

            bool valid1 = false;
            while (!valid1)
            {
                var superS = Console.ReadLine();
                if (int.TryParse(superS, out _))
                {

                    int car = int.Parse(superS);
                    valid1 = true;
                    monthInt = car;
                }
                else
                {
                    Console.WriteLine(" Not right, try again.");

                }

            }
            Console.WriteLine("Now give me a exponent number.");
            bool valid5 = false;
            while (!valid5)
            {
                var superS = Console.ReadLine();
                if (int.TryParse(superS, out _))
                {

                    int car = int.Parse(superS);
                    valid5 = true;
                    expInt = car;
                }
                else
                {
                    Console.WriteLine(" Not right, try again.");

                }

            }
            Console.WriteLine(" CalcEx(" + monthInt + ", " + expInt + ") -> " + CalcEx(monthInt, expInt));
        }
        else if (response == "MultByLength")
        {
            Console.WriteLine("We now are going to multiply by length. Please enter numbers.");
            var number19 = Console.ReadLine();

            int numberToUse19 = int.Parse(number19);

            Console.WriteLine("Now another one.");

            var number20 = Console.ReadLine();

            int numberToUse20 = int.Parse(number20);

            Console.WriteLine(" MultByLength( " + number19 + ", " + number20 + ",) --> " + MultByLength(numberToUse19, numberToUse20));
        }
        else if (response == "HammingDist")
        {
            Console.WriteLine("We now are going to compute the hamming distance from two strings. Please enter the first string.");

            string first = Console.ReadLine();
            string second = "";

            Console.WriteLine("Now give me another string of letters and the same amount of letters.");
            bool valid5 = false;
            while (!valid5)
            {
                string superS = Console.ReadLine();
                if (superS.Length == first.Length)
                {

                    second = superS;
                    valid5 = true;
                }
                else
                {
                    Console.WriteLine(" No, try again with same amount of characters.");

                }
            }
                Console.WriteLine($"HammingDist({first}, {second}) --> {HammingDist(first, second)}");

        }

        else if (response == "Finito")
        {
            return;
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
    public static bool lessThan100(float number5, float number6)
    {
        return number5 + number6 < 100;
    }
    public static bool IsEqual(int number5, int number6)
    {
        return number5 == number6;
    }
    public static string GiveMeSomething(string input)
    {
        return ("something " + input);
    }
    public static bool Reverse(bool input)
    {
        return !input;
    }
    public static float howmanySeconds(float hours)
    {
        return hours * 3600;
    }
    public static int SumPolygon(int sides)
    {
        return (sides - 2) * 180;
    }
    public static string nameStringH(string nameString)
    {
        return nameString + " Edabit";
    }
    public static bool And(bool t, bool f)
    {
        if (t && f)
        {
            return true;

        }
        else
        {
            return false;
        }
    }
    public static int CalcPoint(int number7, int number8)
    {
        return number7 * 2 + number8 * 3;
    }
    public static int CalcPerimeter(int number9, int number10)
    {
        return (number9 + number10) * 2;
    }
    public static string HelloName(string number11)
    {
        return " Hello " +  number11;
    }
    public static int animals(int number12, int number13, int number14)
    {
        return number12 * 2 + number13 * 4 + number14 * 4;
    }
    public static int FootballPoint(int number15, int number16, int number17)
    {
        return number15 * 3 + number16 * 1 + number17 * 0;
    }
    public static string MonthName(int M)
    {
        return DateAndTime.MonthName(M);
    }
    public static int[] MinMax(int[] MM)
    {
        var returnList = new List<int>();
        returnList.Add(MM.Min());
        returnList.Add(MM.Max());

        return returnList.ToArray();
    }
    public static int AdSum(int[] input)
    {
        int re = 0;
        foreach(int i in input)
        {
            re += Math.Abs(i);

        }
        return re;
    }
    public static string arrayString(int[] input)
    {
        string thing = "";
        bool more = true;
        foreach (int i in input)
        {
            if (more)
            {
                more = false;
            }
            else
            {
                thing = thing + ", ";
            }
            thing = thing + i.ToString();

        }
        return thing;
    }
    public static float CalcEx(float baseH, float exp)
    {
        return MathF.Pow(baseH, exp);
    }
    public static Tuple<int, int> MultByLength(int number19, int number20)
    {
        var tuple = new Tuple<int, int>(number19 * 2, number20 * 2);
        return tuple;
    }
    public static int HammingDist(string k, string t)
    {
        char[] kchar = k.ToCharArray();
        char[] tchar = t.ToCharArray();
        int dist = 0;
        for (int i = 0; i < kchar.Length; i++)
        {
            if (kchar[i] != tchar[i])
            {
                dist++;
            }
            
        }
        return dist;
    }
}



