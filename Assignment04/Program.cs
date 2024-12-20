using System.Threading.Channels;

namespace Assignment04
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            if (n <= 1) { return false; }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) { return false; }

            }
            return true;
        }
        static void Swap(int X, int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        static void SwapByRef(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        static int SumArray(int[] Arr)
        {
            int sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            return sum;
        }
        static int SumArrayByRef(ref int[] Arr)
        {
            int sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            return sum;
        }
        static void SumSub(int X, int Y, out int Sum, out int Sub)
        {
            Sum = X + Y;
            Sub = X - Y;
        }
        static void MinMaxArray(ref int[] Arr)
        {
            int max = Arr.Max();
            int min = Arr.Min();
            Console.WriteLine($"Max Value: {max}");
            Console.WriteLine($"Min Value: {min}");
        }
        static int Factorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);

            }
        }
        static string ChangeChar(char Letter, string Str)
        {
            int result = Str.Length;
            Console.WriteLine(result);
            if (Str.Length == 0)
            {
                return Str;
            }
            Str = Letter + Str.Substring(1);
            return Str;
        }

        static void Main(string[] args)
        {
            #region Task From Session
            //int[,] Marks = new int[3, 3];

            //Marks[0, 0] = 58;
            //Marks[0, 1] = 88;
            //Marks[0, 2] = 98;

            //Marks[1, 0] = 88;
            //Marks[1, 1] = 88;
            //Marks[1, 2] = 99;

            //Marks[2, 0] = 100;
            //Marks[2, 1] = 88;
            //Marks[2, 2] = 98;

            //foreach (var mark in Marks)
            //{
            //    Console.WriteLine(mark);
            //} 
            #endregion

            #region 1. Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.
            //// By Value: CLR Generate Two Stack Frames One For Main(A,B) And Another One For Swap(X,Y,Temp), After Excute The Stack Frame(Swap Function) Removed With Thier Value Temp X,Y So A,B Doesn't Effect 
            //int A = 3, B = 4;
            //Swap(A, B);
            //Console.WriteLine(A); // 3
            //Console.WriteLine(B); // 4

            //// By Ref: CLR Generate Two Stack Frames One For Main(A[X],B[Y]) As We send Thier References Not Values So X,Y As An Alias Name For A,B And Another One For Swap(Temp), After Excute The Stack Frame(Swap Function) Removed With Temp Value And A,B Effected
            //int A = 3, B = 4;
            //SwapByRef(ref A, ref B);
            //Console.WriteLine(A); // 4
            //Console.WriteLine(B); // 3

            #endregion

            #region 2. Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example.
            int[] Integers = { 3, 4, 6, 7 };
            //// By Value: Value Send To Arr To Create A new Stack Frame
            //Console.WriteLine(SumArray(Integers)); //20

            //// By Ref: Address Of integers Send To Arr, So Arr Is As Alias Name For integers.
            //Console.WriteLine(SumArrayByRef(ref Integers)); //20
            #endregion

            #region 3. Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int X = 3, Y = 4;

            //SumSub(X, Y, out int Sum, out int Sub);
            //Console.WriteLine($"Sum Is: {Sum}");
            //Console.WriteLine($"Substraction Is: {Sub}");
            #endregion

            #region 4. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.WriteLine("Enter Any Digit: ");
            //string UserInput = Console.ReadLine();
            //int[] DigitArr = new int[UserInput.Length];
            ////Console.WriteLine(DigitArr.Length);
            //for (int i = 0; i < DigitArr.Length; i++)
            //{
            //    DigitArr[i] = UserInput[i] - '0';
            //    //Console.WriteLine($"{DigitArr[i]}    {UserInput[i]}");
            //}
            //int Sum = 0;
            //foreach (int Digit in DigitArr)
            //{
            //    Sum += Digit;
            //}
            //Console.WriteLine(Sum);
            #endregion

            #region 5. Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Enter An Integer: ");
            //string UserInput = Console.ReadLine();
            //bool IsInteger = int.TryParse(UserInput, out int Digit);
            //if (IsInteger && IsPrime(Digit))
            //{
            //    Console.WriteLine($"{Digit} Is Prime Number");
            //}
            //else if (IsInteger)
            //{
            //    Console.WriteLine($"{Digit} Is Not Prime Number");
            //}
            #endregion

            #region 6. Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] Nums = { 3, 5, 7, 8, 3 };
            //MinMaxArray(ref Nums);

            #endregion

            #region 7. Create an iterative(non - recursive) function to calculate the factorial of the number specified as parameter
            //Console.WriteLine(Factorial(4));
            #endregion

            #region 8. Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            //Console.WriteLine(ChangeChar('a', "yara"));
            #endregion

            #region 9. Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.WriteLine("Enter An Integer: ");
            //int Digit = int.Parse(Console.ReadLine());
            //for (int i = 0; i < Digit; i++)
            //{
            //    for(int j = 0; j < Digit; j++)
            //    {
            //        if(i == j)
            //        {
            //            Console.Write(1);
            //        }
            //        else
            //        {
            //            Console.Write(0);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 10. Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] Numbers = { 3, 5, 7, 5, 11 };
            //Console.WriteLine(SumArray(Numbers));
            #endregion

            #region 11. Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] Values = { 1, 2, 3, 4, 5, 6 };
            //int[] Values2 = { 12, 11, 10, 9, 8, 7 };
            //if(Values.Length == Values2.Length)
            //{
            //    int[] Values3 = Values2.Concat(Values).ToArray();
            //    Array.Sort(Values3);
            //    for (int i = 0; i < Values3.Length; i++)
            //    {
            //        Console.Write($"{Values3[i]} ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("2 Arrays Are Not Equal");
            //}


            #endregion

            #region 12. Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] arr = { 1, 2, 2, 2, 2, 4, 4, 4, 3, 3, 6, 7, 8, 8 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int count = 1; 
            //    if (!(arr[i] == -1))
            //    {
            //        for (int j = i + 1; j < arr.Length; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                count++;
            //                arr[j] = -1;
            //            }
            //        }
            //        Console.WriteLine($"{arr[i]}: {count}");
            //    }
            //}

            #endregion

            #region 13. Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] arr = { 1, 2, 4, 3, 6, 7, 8 };
            //int max = arr.Max();
            //int min = arr.Min();
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            #endregion

            #region 14. Write a program in C# Sharp to find the second largest element in an array.
            //int[] arr = { 5, 7, 3, 1, 5, 4, 9 };
            //Array.Sort(arr);
            //Console.WriteLine(arr[arr.Length-2]);

            #endregion

            #region 15. Consider an Array of Integer values with size N, having values as (7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3)
            //Console.WriteLine("Enter The Array Count: ");
            //int Count = int.Parse(Console.ReadLine());

            //int[] arr = new int[Count];
            //Console.WriteLine("Enter the elements of the array: ");

            //for (int i = 0; i < Count; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            ////int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

            //int MaxDistance = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {

            //            int distance = j - i - 1;
            //            if (distance > MaxDistance)
            //            {
            //                MaxDistance = distance;
            //            }
            //            Console.WriteLine($"{arr[i]} -- {arr[j]} distance = {distance}");

            //        }
            //    }
            //}
            //Console.WriteLine(MaxDistance);
            #endregion

            #region 17. Given a list of space separated words, reverse the order of the words.
            /*Input: this is a test		Output: test a is this
            Input: all your base		Output: base your all
            Input: Word                 Output: Word
            Note : 
            Check the Split Function (Member in String Class) Output will be a Single Console.WriteLine Statement
            */

            //string str = "this is a test";
            //string[] strArr = str.Split(' ');
            //Array.Reverse(strArr);
            //string Reversed = string.Join(" ", strArr);
            //Console.WriteLine(Reversed);

            #endregion

            #region 18. Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.
            //Console.WriteLine("Enter the number of rows:");
            //int rows = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number of columns:");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] firstArray = new int[rows, cols];
            //int[,] secondArray = new int[rows, cols];

            //Console.WriteLine("Enter the elements for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter element at position ({i},{j}): ");
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}

            //Console.WriteLine("Second Array");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 19. Write a Program to Print One Dimensional Array in Reverse Order
            //int[] NumbersArray = { 5, 6, 7, 4, 5, 2, 1, 6 };
            //Array.Reverse(NumbersArray);
            //foreach (var item in NumbersArray)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
        }
    }
}