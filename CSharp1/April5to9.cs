using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class April5To9
    {
        static void Main(string[] args)
        {

            ///////////////////////4/5/2021///////////////////////////////
            //Write a C# Sharp program to print Hello and your name in a separate line. 
            Console.WriteLine("Hello,");
            Console.WriteLine("Rachel Mantei");

            //Write a C# Sharp program to print the sum of two numbers. 

            Console.WriteLine("\nEnter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum of your two numbers is: " + sum);

            //Write a C# Sharp program to swap two numbers.
            int input1, input2, third;
            Console.WriteLine("\nEnter a number");
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            input2 = Convert.ToInt32(Console.ReadLine());
            third = input1;
            input1 = input2;
            input2 = third;
            Console.WriteLine("Your first number is now " + input1 + "\n" + "And your second number is: " + input2);


            //Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user
            int one, two, three, multiply;
            Console.WriteLine("\nEnter three numbers");
            one = Convert.ToInt32(Console.ReadLine());
            two = Convert.ToInt32(Console.ReadLine());
            three = Convert.ToInt32(Console.ReadLine());
            multiply = one * two * three;
            Console.WriteLine("The three numbers multipled is: " + multiply);





            /////////////////////4/6/2021//////////////////////////
            //Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
            int first, second, m, a, s, d;
            Console.WriteLine("\nEnter two numbers");
            first = Convert.ToInt32(Console.ReadLine());
            second = Convert.ToInt32(Console.ReadLine());
            a = first + second;
            s = first - second;
            d = first / second;
            m = first * second;
            Console.WriteLine("Numbers added, subtracted, divided and multiplied are: \n" + a + "\n" + s + "\n" + d + "\n" + m);

            //Write a C# Sharp program that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. 
            int o, t, th, p, q;
            Console.WriteLine("\nEnter three numbers: ");
            o = Convert.ToInt32(Console.ReadLine());
            t = Convert.ToInt32(Console.ReadLine());
            th = Convert.ToInt32(Console.ReadLine());
            p = (o + t) * th;
            q = (o * t) + (t * th);
            Console.WriteLine("Your first number plus your second number * your third number is: " + p + "\nYour first number times your second number added to your second number times your third number is: " + q);


            //Write a C# program that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. 
            //You should do it two times: Use Console. Write and then use {0}. 
            int once;
            Console.WriteLine("\nEnter a number");
            once = Convert.ToInt32(Console.ReadLine());
            /*  Console.Write(once); *///cannot put them all in one console write, break it up
                                       //Console.Write("");
                                       //Console.Write(once);
                                       //Console.Write("");
                                       //Console.Write(once);
                                       //Console.Write("");
                                       //Console.Write(once);
                                       //Console.WriteLine("\n");

            //Console.Write(once);
            //Console.Write(once);
            //Console.Write(once);
            //Console.Write(once);
            //Console.WriteLine("\n");

            //Have to use {0}
            Console.WriteLine("{0}{0}{0}{0} ", once);
            Console.WriteLine("{0} {0} {0} {0} ", once);


            //Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. 
            int temp, fah, kel;
            double fahr = 1.8; //cast because number is a double
            int fahrenheit = (int)fahr;
            Console.WriteLine("\nEnter a temp in celcius: ");
            temp = Convert.ToInt32(Console.ReadLine());
            fah = (temp * 9 / 5 + 32);
            kel = (temp + 273);
            Console.WriteLine("\nYour temp in fahrenheit is: " + fah + "\nYour temp in kelvin is: " + kel);



            ////////04/07/2021//////////
            ///Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back
            Console.WriteLine("Write a sentence: ");
            string length = Console.ReadLine();
            //grab the first letter [0]
            //length.First 
            string input = length[0] + length + length[0];
            Console.WriteLine(input);

            //Write a C# program to check two given integers and return true if one is negative and one is positive.
            int integer, integer2;
            //bool word = true;
            Console.WriteLine("Enter two numbers (negative or positive): ");
            integer = Convert.ToInt32(Console.ReadLine());
            integer2 = Convert.ToInt32(Console.ReadLine());
            //if (integer > 0 && integer2 < 0)
            //{
            //    return (word);
            //}
            Console.WriteLine((integer > 0 && integer2 < 0) || (integer < 0 && integer2 > 0));


            //Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
            int n1, n2, sumOf, triple;
            Console.WriteLine("Enter two different numbers to find the sum(or the same number to find the triple of their sum): ");
            n2 = Convert.ToInt32(Console.ReadLine());
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 == n2)
            {
                triple = (n1 + n2) * 3;
                Console.WriteLine("The sum tripled equals: " + triple);
            }
            else
            {
                sumOf = n1 + n2;
                Console.WriteLine("The sum equals: " + sumOf);
            }

            //Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number. 
            int absolute;
            Console.WriteLine("Enter two neg or pos #'s: ");
            int ab = Convert.ToInt32(Console.ReadLine());
            int solute = Convert.ToInt32(Console.ReadLine());
            if (ab >= solute)
            {
                absolute = (ab - solute) * 2;
                Console.WriteLine("The difference doubled equals: " + absolute);
            }
            else
            {
                absolute = (ab - solute) * -1;
                Console.WriteLine("The difference equals: " + absolute);
            }
            //else if(ab > solute)
            //{
            //    absolute = (ab - solute);
            //    Console.WriteLine("The difference equals: " + absolute);
            //}
            //else
            //{
            //    absolute = (ab - solute);
            //    Console.WriteLine("The difference equals: " + absolute);
            //}


            //Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
            int z, y;
            //int sums = 20;
            Console.WriteLine("Enter two numbers to check if it's equal to 20 or 20 itself: ");
            z = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(z == 20 || y == 20 || (z + y == 20));



            //////////04/08/2021//////////
            ///Write a C# program to convert a given string into lowercase
            string sentence;
            Console.WriteLine("Write a sentence: ");
            sentence = Console.ReadLine().ToLower();
            Console.WriteLine(sentence);


            //Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
            //int odd, numbers;

            Console.Write("\n");
            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            //if (numbers = odd % 2)
            //{

            //}
            //else
            //{

            //}



            /////////04/09/2021/////////
            //Write a C# program and compute the sum of the digits of an integer. STOPPED AT 28
            int comp, e;
            Console.WriteLine("\nEnter a number: ");
            comp = Convert.ToInt32(Console.ReadLine());
            e = 0; //start at 0
            while (comp != 0)
            {
                e = e + comp % 10;
                comp = comp / 10;
            }
            Console.WriteLine("Sum of digits of number: " + e);
            //do
            //{
            //    e += comp % 10;
            //    comp /= 10;
            //} while (comp != 0);


            //Write a C# program to reverse the words of a sentence. 
            //ex. The fish is in water / water in is fish The
            //need to .Reverse sometime
            Console.WriteLine("Write a sentence: ");
            string str = Console.ReadLine();

            Console.WriteLine(String.Join(" ", str.Split(' ').Reverse()));


            //Write a C# program to compute the sum of the first 500 prime numbers.
            //long prime;
            //int f;
            //int five = 2;
            //for (int i = 1; i < 500; i++)
            //{
            //    if (isPrime(five))
            //    {
            //        prime += five;
            //    }
            //    five++;
            //}


            //Write a C# program to find the longest word in a string.
            //Console.WriteLine("Enter random words: ");
            //string line = Console.ReadLine();
            //string[] longs = line.Split(new[] { "" }, StringSplitOptions.None);
            //string lon = "";
            //int w = 0;
            //foreach (String s in longs)
            //{
            //    if (s.Length > w)
            //    {
            //        lon = s;
            //        w = s.Length;
            //    }
            //    Console.WriteLine(lon);
            //}


            //Write a C# program to convert a hexadecimal number to decimal number.
            Console.WriteLine("Convert any hexadecimal number to decimal: ");
            string hex = Console.ReadLine();
            //if (hex < 10 && hex > 0)
            //{

            //}
            //else
            //{

            //}

            int decimals = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Converts to \n" +
                "Decimal number: " + decimals);


            ////////////04/11/2021/////////////
            //Write a C# program to multiply corresponding elements of two arrays of integers

            //int array1, array2;
            int[] array1 = { 4, 5, 16, 9 };
            int[] array2 = { 2, 3, 1, -4 };
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i] * array2[i]);
            }
            Console.WriteLine("");

            ////////////04/11/2021/////////////
            //Write a C# program to multiply corresponding elements of two arrays of integers

            //int array1, array2;

            for (int i = 0; i < array1.Length; i++)
            {
                int[] arrayone = { 4, 5, 16, 9 };
                int[] arraytwo = { 2, 3, 1, -4 };
                int[] array3;

                array3.Add(array1[i] * array2[i]);

                Console.WriteLine(array3);

                //Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7. 
                int numb;
                Console.WriteLine("Enter an integer: ");
                numb = Convert.ToInt32(Console.ReadLine());
                if (numb % 7 || numb % 3)
                {
                    return true;
                }

                //Write a C# program to check if a string starts with a specified word.
                string string1;
                Console.WriteLine("Write a sentence: ");
                string1 = Console.ReadLine();
                if ("Hello" = string1.Length[0])
                {
                    return true;
                }

            }
        }
    }
}