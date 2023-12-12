using System;
namespace WeekTwoSpace
{
    public class labOneExcersize
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Which method would you like to call between 1-7? ");
                int methodNumber = Convert.ToInt32(Console.ReadLine());
                switch (methodNumber)
                {
                    case 1:
                        {
                            circleRadius();
                            break;
                        }
                    case 2:
                        {
                            triangleArea();
                            break;
                        }
                    case 3:
                        {
                            evenOrOdd();
                            break;
                        }
                    case 4:
                        {
                            intDisplay();
                            break;
                        }
                    case 5:
                        {
                            asciiFormat();
                            break;
                        }
                    case 6:
                        {
                            doubleToInt();
                            break;
                        }
                    case 7:
                        {
                            leapYear();
                            break;
                        }
                }
            

            }
        }

        static void circleRadius()
        {
            int circleRadiusInput;

            Console.WriteLine("Enter the radius of the circle ");
            circleRadiusInput = Convert.ToInt32(Console.ReadLine());

            double circle_radius_squared = Math.Pow(circleRadiusInput, 2);
            double area = ((Math.PI) * circle_radius_squared);
            double circumference = (2 * (Math.PI) * circleRadiusInput);

            Console.WriteLine("With the input of " + circleRadiusInput + " the area of the circle is then " + area + ", also the circumference is " + circumference);
            
        }
            
        static void triangleArea()
        {
            int baseWidth;
            int height;

            Console.WriteLine("Enter the base-width of the triangle ");
            baseWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle ");
            height = Convert.ToInt32(Console.ReadLine());

            double areaTriangle = (.5 * baseWidth * height);

            Console.WriteLine("With the base width input of " + baseWidth + " and the height input of " + height + ", the area of the triagle is " + areaTriangle);
        }

        static void evenOrOdd()
        {
            int evenOrOddInput, remainder;

            Console.WriteLine("Enter thea number to see if it's even or odd ");
            evenOrOddInput = Convert.ToInt32(Console.ReadLine());

            remainder = evenOrOddInput % 2;

            if (remainder == 0)
                Console.WriteLine("{0} is an Even Number, ", evenOrOddInput);
            else
                Console.WriteLine("{0} is an Odd Number, ", evenOrOddInput);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }


        static void intDisplay()
        {
            int intInput;

            Console.WriteLine("Enter a single digit integer ");
            intInput = Convert.ToInt32(Console.ReadLine());

            decimal convertedInput = Convert.ToDecimal(intInput);

            Console.WriteLine("You entered " + intInput + ", the new value is {0:F1}", convertedInput);
            Console.ReadKey();
        }

        static void asciiFormat()
        {
            char stringInput;

            Console.WriteLine("Enter a character ");
            stringInput = Convert.ToChar(Console.ReadLine());

            int asciiInt = (int)stringInput;

            Console.WriteLine("You entered " + stringInput + ", we will convert it to ascii " + asciiInt);
            Console.ReadKey();
        }

        static void doubleToInt()
        {
            double doubleInput;

            Console.WriteLine("Enter a double ");
            doubleInput = Convert.ToDouble(Console.ReadLine());

            int intInputCase6 = Convert.ToInt32(doubleInput);

            Console.WriteLine("You entered double " + doubleInput + ", we will convert it to int " + intInputCase6);
            Console.ReadKey();
        }

        static void leapYear()
        {
            //prompt for year input
            int yearInput;

            Console.WriteLine("Enter a four digit year ");
            yearInput = Convert.ToInt32(Console.ReadLine());

            //If the year is evenly divisible by 4, go to step 2. Otherwise, go to step 5.

            //Step 1
            if(yearInput % 4 == 0)
            {
                //Step 2                      //Step 3
                if((yearInput % 100 != 0) || (yearInput % 400 == 0))
                {
                    //Step 4
                    Console.WriteLine("This is a leap year");
                }
                //else
                //{
                //    //Step 5
                //    Console.WriteLine("This is not leap year");
                //}
            }
            else
            {
                //Step 5
                Console.WriteLine("This is not leap year");
            }
        }

    }
}
