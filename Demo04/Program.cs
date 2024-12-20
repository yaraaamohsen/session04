using System.Data.Common;
using System.Transactions;

namespace Demo04
{
    // 1. Classes       -> Function
    // 2. Struct        -> Function
    // 3. Interfaces    -> Function
    // 4. Enum

    class NewData
    {
        public int Sum;
        public int Mul;
    }
    internal class Program
    {
        //Roslyn(Compiler) --> call Entry Point(Static + void + Main)

        #region shwayet Functions
        static void PrintShape()
        {
            // Body 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("^_^");
            }
        }

        static void PrintShape(int Count)
        {
            // Body 
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("^_^");
            }
        }

        static void PrintShape(int Count = 3, string Pattern = "Hello From Default Value")
        {
            // Body 
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"{Pattern}");
            }
        }

        static int SumNumbers(int Number01, int Number02)
        {
            return Number01 + Number02;
        }

        //static void Swap(int X, int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;   
        //}

        static void Swap(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

        //static int SumArray(int[] Arr)
        //{
        //    int sum = 0;
        //    for (int i = 0;i < Arr.Length; i++)
        //    {
        //        sum += Arr[i];
        //    }
        //    return sum;
        //}

        //static int SumArray(ref int[] Arr)
        //{
        //    int sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        sum += Arr[i];
        //    }
        //    return sum;
        //}

        static int SumArrayByRef(ref int[] Arr)
        {
            int sum = 0;
            Arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            return sum;
        }

        //static int[] SumMul( int X, int Y)
        //{
        //    int[] Result = { X + Y, X * Y };
        //    return Result;
        //}

        //static NewData SumMul(int X, int Y)
        //{
        //    NewData Data = new NewData();
        //    Data.Sum = X + Y;
        //    Data.Mul = X * Y;
        //    return Data;
        //}

        static int SumArray(params int[] Arr)
        {
            int sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            return sum;
        }
        static void SumMul(int X, int Y, out int Sum, out int Mul)
        {
            Sum = X + Y;
            Mul = X * Y;
        }
        #endregion

        static void Main(string[] args)
        {
            #region One D Array
            //int[] Numbers;
            //// Declare For Reference (Pointer) From Type 'Array Of Integer'
            //// Numbers: Can Refer To Object From Type 'Array of Integer'
            //// Numbers: Refer To Null
            //// 8 Bytes will Be Allocated At Stack
            //// 0 Bytes Will Be Allocated At HEAP

            //Numbers = new int[5];
            //// Allocated Number Of Bytes Required For Objject(4 Bytes * 5 = 20 Bytes )
            //// Intialized Allocated Bytes With Default Value
            //// Call User-Defined Constructor If Exists
            //// Assign Object To Reference "Numbers"

            //Console.WriteLine(Numbers[0]); //   ===> default Value -> 0
            //Numbers[0] = 5;
            //Numbers[1] = 10;
            //Numbers[2] = 9;
            //Numbers[3] = 3;
            //Numbers[4] = 4;

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);

            //int[] Numbers1 = { 5, 8, 3, 7, 3 }; // => Syntax Sugar

            //int[] Numbers = new int[5];
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter Numbers[{i}]: ");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //    Console.Write(Numbers[i] + " ");
            //}

            //Console.WriteLine(Numbers.Length); // 5
            //Console.WriteLine(Numbers.Rank); // 1 - Dimension - One D Array 
            #endregion

            #region Two D Array (Rectangle Array)
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

            //for(int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"Enter Marks Of [{i} , {j}]");
            //        Marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{Marks[i , j]} ");
            //    }
            //    Console.WriteLine("");
            //}

            #endregion

            #region Two D Array (Juddge Array)
            //int[][] Marks = new int[3][];

            //Marks[0] = new int[] {1, 2, 3};
            //Marks[1] = new int[] {5, 2};
            //Marks[2] = new int[] {7, 8, 5};

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write(Marks[i][j] + " ");
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write($"{Marks[i][j]} ");
            //        Marks[i][j] = int.Parse(Console.ReadLine());
            //    }
            //} 
            #endregion

            #region Function Prototype
            // Function : Block of Code That have Name If U Need To Excute The Code
            // U Need To Call Function By The Name
            // Dry Code
            // Reusability

            // Function
            // 1. Signature
            // 1.1. Name
            // 1.2. Return Type
            // 1.3. Parameters (Inputs)
            // 2. Body (Code)

            // Calling For Function
            //Program.PrintShape();

            //Program P = new Program();
            //P.PrintShape();

            //PrintShape(1, "-_"); // Passing By Order
            //PrintShape(Pattern: "Hello", Count: 3); // Passing By Name
            //PrintShape(); // Calling By Default Value


            // Methods
            // 1. Class Member Method (Static method)
            // 2. Object Member Method (non static Method)

            //int Sum = SumNumbers(1, 2);

            //Console.WriteLine(Sum);

            #endregion

            #region Passing Parameter Value Type
            // Passing Parameter Value Type
            // 1. Passing By Value
            //int A = 4, B = 5;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");
            //Console.WriteLine("After Swap");
            //Swap(A, B); // Passing by Value
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");


            // 2. Passing By Ref
            //int A = 4, B = 5;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");
            //Console.WriteLine("After Swap");
            //Swap(ref A, ref B); // Passing by Value
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}"); 
            #endregion

            #region Passing Parameter Reference Type
            // Passing Parameter Reference Type
            // 1. Passing By Value

            //// EX01
            //int[] Number = {1, 2, 3};
            //int result = SumArray(Number); // Passing By Value
            //Console.WriteLine(result);

            ////EX02
            //int[] Number = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Number)); // Passing By Value
            //Console.WriteLine(Number[0]);

            //2.Passing By Reference

            //// EX01
            //int[] Number = { 1, 2, 3 };
            //int result = SumArray(ref Number); // Passing By Reference
            //Console.WriteLine(result);
            //Console.WriteLine(Number[0]);

            ////EX02
            //int[] Number = { 1, 2, 3 };
            //Console.WriteLine(ref SumArray(Number)); // Passing By Reference
            //Console.WriteLine(Number[0]);

            #endregion

            #region passing By out

            //int A = 3, B = 5, Sum, Mul;
            //SumMul(A, B, out Sum, out Mul);
            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul); 
            #endregion

            #region params
            int[] Numbers = { 4, 5, 6, 2, 1 };
            Console.WriteLine(SumArray(Numbers)); // byb3t el Reference 
            Console.WriteLine(SumArray(4, 5, 6, 2, 1)); // 3shan ktbt params  
            #endregion
        }
    }
}
