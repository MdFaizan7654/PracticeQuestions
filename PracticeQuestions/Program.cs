using System;

namespace PracticeQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Find the Number is Even Or Odd

            //int num, reminder;
            //Console.WriteLine("Please enter your number...");
            //num = int.Parse(Console.ReadLine());

            //reminder = num % 2;
            //if(reminder == 0)
            //{
            //    Console.WriteLine($"The given number = {num} is even number...");
            //}
            //else
            //{
            //    Console.WriteLine($"The given number = {num} is odd nuber...");
            //}
            //Console.ReadLine();

            #endregion Find the Number is Even Or Odd

            #region Find the Number is Positive or Negative

            //Console.Write("Please Enter Your Number = ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //if (num > 0)
            //{
            //    Console.WriteLine($"The given number {num} is Positive");
            //}
            //else
            //{
            //    Console.WriteLine($"The given number {num} is Negative");
            //}
            //Console.ReadLine();
            #endregion Find the Number is Positive or Negative

            #region Find the Number is Prime Or Not

            //int num,i, ctr = 0;
            //Console.Write("Please Enter your Number = ");
            //Console.WriteLine();
            //num = int.Parse(Console.ReadLine());

            //for (i = 2; i <= num / 2 ;  i++)
            //{
            //    if(num % 2 == 0)
            //        ctr++;
            //}
            //if(ctr == 0 && ctr != 1)
            //{
            //    Console.WriteLine($"The given number {num} is Prime Number.");
            //}
            //else
            //{
            //    Console.WriteLine($"The given number {num} is not Prime Number.");
            //}
            //Console.ReadLine();
            #endregion Find the Number is Prime Or Not

            #region Check if the given Number is Palindrome or Not
            //Console.WriteLine("Please Enter your number = ");
            //int num = int.Parse(Console.ReadLine());

            //int reminder, sum = 0;
            //int temp = num;            

            //while(num > 0)
            //{
            //    reminder = num % 10;
            //    sum = (sum * 10) + reminder;
            //    num = num / 10;
            //}
            //if(temp == sum)
            //{
            //    Console.WriteLine($"The given Number {sum} is Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine($"The given Number {sum} is not Palindrome");
            //}
            //Console.ReadLine();
            #endregion Check if the given Number is Palindrome or Not

            #region Check if the given String is Palindrome or Not

            //Console.WriteLine("Please enter any string...");
            //string name = Console.ReadLine();
            //string reverse = string.Empty;

            //for (int i = name.Length-1; i >= 0 ; i--)
            //{
            //    reverse += name[i];

            //    if(name == reverse)
            //    {
            //        Console.WriteLine("String is Palindrome");
            //    }
            //    else
            //    {
            //        Console.WriteLine("String is not Palindrome");
            //    }
            //}
            //Console.ReadLine();
            #endregion Check if the given String is Palindrome or Not

            #region Check if the given Number is Armstrong or Not
            //Console.WriteLine("Please Enter your Name = ");
            //int num = int.Parse(Console.ReadLine());

            //int reminder, sum = 0;
            //int temp = num;

            //while (num > 0)
            //{
            //    reminder = num % 10;
            //    sum = sum + (reminder * reminder * reminder);
            //    num = num / 10;
            //}
            //if(temp == sum)
            //{
            //    Console.WriteLine($"The given number {sum} is Armstrong Number...");
            //}
            //else
            //{
            //    Console.WriteLine($"The given number {sum} is not Armstrong Number...");
            //}
            //Console.ReadLine();
            #endregion Check if the given Number is Armstrong or Not

            #region Find a Maximum of Two Numbers
            //int num1, num2,reminder;

            //Console.WriteLine("PLease Enter Your First Number = ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("PLease Enter Your Second Number = ");
            //num2 = int.Parse(Console.ReadLine());

            //if(num1 > num2)
            //{
            //    reminder = num1;
            //}
            //else
            //{
            //    reminder = num2;
            //}
            //Console.WriteLine($"The Maximum is {reminder}");
            //Console.ReadLine();

            #endregion Find a Maximum of Two Numbers

            #region Find a Minimum of Two Numbers
            //int num1, num2, num3;

            //Console.WriteLine("Please Enter Your First Number");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter Your Second Number");
            //num2 = int.Parse(Console.ReadLine());

            //if (num1 < num2)
            //{
            //    num3 = num1;
            //}
            //else
            //{
            //    num3 = num2;
            //}
            //Console.WriteLine($"The Minimum Number is {num3}");
            //Console.ReadLine();
            #endregion Find a Minimum of Two Numbers

            #region Find a Maximum of Three  Numbers
            //int num1,num2,num3,num4;

            //Console.Write("Please Enter Your First Number = ");
            //num1=int.Parse(Console.ReadLine());
            //Console.Write("Please Enter Your Second Number = ");
            //num2 = int.Parse(Console.ReadLine());
            //Console.Write("Please Enter Your Third Number = ");
            //num3 = int.Parse(Console.ReadLine());

            //if(num1 > num2)
            //{
            //    num4 = num1;
            //}
            //else if(num2 > num3)
            //{
            //    num4 = num2;
            //}
            //else
            //{
            //    num4 = num3;
            //}
            //Console.WriteLine();
            //Console.WriteLine($"The Maximum of Three Number is {num4}");
            //Console.ReadLine();
            #endregion Find a Maximum of Three  Numbers

            #region Find a Minimum of Three  Numbers
            //int num1, num2, num3, num4;

            //Console.Write("Please Enter Your First Number = ");
            //num1=int.Parse(Console.ReadLine());
            //Console.Write("Please Enter Your Second Number = ");
            //num2 = int.Parse(Console.ReadLine());
            //Console.Write("Please Enter Your Third Number = ");
            //num3 = int.Parse(Console.ReadLine());

            //if (num1 < num2)
            //{
            //    num4 = num1;
            //}
            //else if (num2 < num3)
            //{
            //    num4 = num2;
            //}
            //else
            //{
            //    num4 = num3;
            //}
            //Console.WriteLine();
            //Console.WriteLine($"The Minimum Number of Three is {num4}");
            //Console.ReadLine();
            #endregion Find a Minimum of Three  Numbers

            #region Find a Factorial of a Number
            //int num, i, fact = 1;

            //Console.Write("Please Enter Your Number = ");
            //num = int.Parse(Console.ReadLine());

            //for (i = 1;  i <= num; i++)
            //{
            //    fact = fact * i;
            //}

            //Console.WriteLine($"Factorial of {num} is {fact}");
            //Console.ReadLine();
            #endregion Find a Factorial of a Number

            #region Swap Two Numbers
            //int num1, num2, result;
            //Console.Write("Please Enter your first Number = ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("Please Enter your first Number = ");
            //num2 = int.Parse(Console.ReadLine());

            //result = num1;
            //num1 = num2;
            //num2 = result;

            //Console.WriteLine("After Swaping the number...");
            //Console.WriteLine();
            //Console.WriteLine($"First number: {num1}");
            //Console.WriteLine($"Second number: {num2}");
            //Console.ReadLine();
            #endregion Swap Two Numbers

            #region Print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user
            //int num1, num2, result1, result2, result3, result4, result5;

            //Console.Write("Please Enter your first Number = ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("Please Enter your first Number = ");
            //num2 = int.Parse(Console.ReadLine());

            //result1 = num1 + num2;
            //result2 = num1 - num2;
            //result3 = num1 * num2;
            //result4 = num1 / num2;
            //result5 = num1 % num2;

            //Console.WriteLine("{0} + {1} = {2} ", num1, num2, result1);
            //Console.WriteLine("{0} - {1} = {2} ", num1, num2, result2);
            //Console.WriteLine("{0} x {1} = {2} ", num1, num2, result3);
            //Console.WriteLine("{0} / {1} = {2} ", num1, num2, result4);
            //Console.WriteLine("{0} mod {1} = {2} ", num1, num2, result5);
            //Console.ReadLine();
            #endregion Print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user

            #region Max and Min Number in Array

            //int[] number = { 10, 20, 30, 100, 70, 4, 80, 99, 88,110 };

            //int max = number[0];
            //int min = number[0];
            //int i;

            //for (i = 1; i <= number.Length-1; i++)
            //{ 
            //    if (number[i] > max)
            //    {
            //        max = number[i];
            //    }
            //    if (number[i] < min)
            //    {
            //        min = number[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //Console.ReadLine();

            #endregion Max and Min Number in Array

            #region Find third largest Number in an array

            //int[] arr = { 1, 8, 4, 5, 12, 2, 5, 6, 7, 1, 90, 100, 56, 8, 34 };
            //int f = arr[0];
            //int s = arr[0];
            //int t = arr[0];

            //foreach (int i in arr)
            //{
            //    if (i > f)
            //    {
            //        t = s;
            //        s = f;
            //        f = i;
            //    }
            //    if (i > s && i != f)
            //    {
            //        t = s;
            //        s = i;
            //    }
            //    if (i > t && i != s && i != f)
            //    {
            //        t = i;
            //    }
            //}
            //Console.WriteLine($"First highest: {f}, Second highest: {s}, Third highest: {t}");
            //Console.ReadLine();
            #endregion Find third largest Number in an array

            #region Find a Fibonacci of a Number

            int n1 = 0 ,n2 = 1 ;
            int n3, i, length;

            Console.Write("Enter the number of elements to Print : ");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if(length < 2)
            {
                Console.WriteLine("Please enter a number greater than 2 ");
            }
            else
            {
                Console.Write(n1 + " " + n2 + "");
                for (i = 2; i < length; i++)
                {
                    n3 = n1 + n2;
                    Console.Write(" " + n3);
                    n1 = n2;
                    n2 = n3;
                }
            }
            
            Console.ReadLine();
            #endregion Find a Fibonacci of a Number

            #region Find GCD of Two Numbers

            #endregion Find GCD of Two Numbers

            

            Console.ReadLine();
        }
    }
}
