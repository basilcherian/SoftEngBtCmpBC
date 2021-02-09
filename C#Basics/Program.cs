using System;

namespace FirstAttempt
{
    class Program
    {       
        static void Main(string[] args)
        {
            //This is a comment. Will be ignore for compilation
            Console.WriteLine("Hello World!");// Writing a comment
            /* This is an example of 
            a multiline comment and needs to ignored for compilation and execution */
            Car myObj = new Car();
            Console.WriteLine(myObj.color);

            const int myNum = 13;         
            string varName = "Shankar";
            Console.WriteLine(myNum);
            Console.WriteLine(varName);

            double doubValue = 3.55d;
            bool myBool = false;
            string myText = "John";
            Console.WriteLine("Helo " + myText);

            //Adding one variable to another variable
            string FirstName = "John ";
            string LastName = "Doe";
            Console.WriteLine(FirstName + LastName);

            //Adding two numerical values
            int x = 10;
            int y = 20;
            Console.WriteLine(x + y);

            //Declare Many Variables in a single line
            int a = 15, b = 16, g = 44;
            Console.WriteLine(a + b + g);

            int minutesPerHour = 60;

            //Exersice to create variable
            int myNum1 = 50;
            int myNum2 = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool1 = true;          // Boolean
            string myText3 = "Hello";     // String
            //Different Datatypes
            long widthOfGalaxy = 2002020020202030L;
            Console.WriteLine(widthOfGalaxy);


            //SCIENTIFIC NUMBERS
            float scienNumber = 35e3F;
            Console.WriteLine(scienNumber);
            double g4 = 35e4d;
            Console.WriteLine(g4);

            //Boolean
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9


            int myInt33 = 9;
            double myDouble1 = myInt33;       // Automatic casting: int to double

            Console.WriteLine(myInt33);     
            Console.WriteLine(myDouble1);
            /////////////////////////////////////////////
            double myDoubleTypeCast = 3.14d;
            int myIntTypeCast = (int)myDoubleTypeCast;
            Console.WriteLine(myDoubleTypeCast);
            Console.WriteLine(myIntTypeCast);
            //////////////////////
            ///

            int myIntExplicitTypeCasting = 10;
            double myDoubleExplicitTypeCasting = 5.25;
            bool myBoolExplicitTypeCasting = true;

            Console.WriteLine(Convert.ToString(myIntExplicitTypeCasting));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myIntExplicitTypeCasting));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDoubleExplicitTypeCasting));  // convert double to int
            Console.WriteLine(Convert.ToString(myBoolExplicitTypeCasting));   // convert bool to string
            Console.WriteLine(Convert.ToInt32(myBoolExplicitTypeCasting));    //convert bool to int
            
            //Application of C# Operation
            //Add two values
            int sum1 = 100 + 50;
            int sum2 = sum1 + 250;
            int sum3 = sum2 + 34;

            Console.WriteLine(sum3 - sum2);
            Console.WriteLine(sum1 * sum3);
            Console.WriteLine(sum1 / sum3);
            Console.WriteLine(++sum1);

            //Operator Examples
            int xOperator = 5;
            Console.WriteLine(xOperator -= 3);
            Console.WriteLine(xOperator %= 3);
            Console.WriteLine(xOperator |= 3);

            //Examples of Comparison Operator
            xOperator = 5;
            int yOperator = 3;
            Console.WriteLine(xOperator != yOperator);

            //Example of Math Methods
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(16));
            Console.WriteLine(Math.Abs(-4.7));

            //String manipulation
            string txt = "abcdefghijklmnopqrstuvw";
            string bc = "hello there!!";
            string ef = "basil";
            Console.WriteLine(txt.Length);
            //String Convert to Upper case 
            Console.WriteLine(txt.ToUpper());
            //Concat string
            Console.WriteLine(string.Concat(txt,bc));
            Console.WriteLine($"My attempt to use curlies: {bc} and {ef}");

            //Extracting a character out of a string position
            Console.WriteLine(ef[3]);
            //Getting the location a specific character in a string
            Console.WriteLine(ef.IndexOf("a"));

            string myFullName = "Basil Cherian";
            int charPos = myFullName.IndexOf("C");
            Console.WriteLine($"lastName: {myFullName.Substring(charPos)}");

            //Escape Characters to incorporate "" and '' in actual strings
            Console.WriteLine("The so called \"Warriors\"!!");
            Console.WriteLine("My Life\'s awesome");
            Console.WriteLine("The character \\ is known as backslash");


            //Adding numbers and strings
             x = 20;
             y = 20;
             int z = x + y;  // z will be 30 (an integer/number)
            Console.WriteLine(z);

            string x1 = "20";
            string y1 = "20";
            string z1 = x1 + y1;  // z will be 1020 (a string)
            Console.WriteLine(z1);

            //Boolean implementation
            Console.WriteLine(10 > 9);
            Console.WriteLine(10 == 10);

            //The if else statement
            if (1 != 2)
            {
                Console.WriteLine("One Not Equal to Two");
            }

            //The else statement
            if (y < x)
            { Console.WriteLine("x is less than y");     }
            else if (x > y)  { Console.WriteLine("y is greater than x"); }
            else { Console.WriteLine($"Both {x} and {y} are equal"); }

            //Short hand if else operator (ternary)
            int time = 20;
            string result = (time < 18)? "Good Day.": "Good Evening.";
            Console.WriteLine(result);
            //Implementation of Switch statement
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            //End of implementation of Switch statement
            //Switch with default implementation
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            //Implementation of While Loop
            int i = 1;
            while (i < 5)
            { Console.WriteLine(i);
                i++;
            }
            i = 1;
            //Do While Loop Implementation
            do 
            { 
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            //For Loop Implementation
            for(i = 0;i < 20; i++)
            { 
                Console.WriteLine(i);
            }
            //Foreach Loop Implementation
            string[] cars1 = { "Honda", "Maruti", "Nissan", "Audi" };
            foreach (string m in cars1)
            { 
                Console.WriteLine(m); 
            }

            //Break Implementation in For Loop
            for (i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            //Continue Implementation in For Loop
            for (i = 0; i<10; i++)
                { 
                if (i==4)
                { continue; }
                Console.WriteLine(i);
                }

            //Break and Continue in While Loop
             i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    break;
                }
            }
            i = 0;
            while (i < 10)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }


            //Array Implementation

            string[] abc = { "abc", "efg", "hij", "lmn" };
            int[] efg = { 1, 2, 3, 4, 5 };

            Console.WriteLine(abc[2]);
            Console.WriteLine(efg[4]);

            abc[3] = "xyz";
            Console.WriteLine(abc[3]);
            Console.WriteLine(abc.Length);

            for (i = 0; i < abc.Length; i++)
            {
                Console.WriteLine(abc[i]);
            }

            foreach(string l in abc)
            {
                Console.WriteLine(l);
            }

             //Application of READing an User Input
            // Type your username and press enter
            Console.WriteLine("Enter the User Name");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();
            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
            Console.WriteLine("Please Enter Your Age");
            int ageOfCandidate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age is:" + ageOfCandidate);



        }
    }
}

