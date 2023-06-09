﻿namespace Delegate
{
    //Delegate is a function pointer
    // it is reference type
    //it should have same signature as that of function pointed to
    //its purpose is to encapsulate method in a class
    //more than one function
    // Delegates improves the purformance of application

    // Single cast delegates

    //public delegate void Cal(int a, int b);

    //
    //public delegate void Calculation(int a, int b);

    //Multpile delegates

    //public delegate void showDelegate();
    //public delegate void hideDelegate(int num);

    //Multi Cast delegates

    public delegate void Calculation(int a, int b);

    class Program
    {
        // mulptiple delegate starts here
        //public static void Square(int num) 
        //{
        //    int squares = num * num;
        //    Console.WriteLine("Square of {0} is {1}",num,squares);
        //}
        //public static void Cube(int num)
        //{
        //    int squares = num * num * num;
        //    Console.WriteLine("Cube of {0} is {1}", num, squares);
        //}
        //public static void show()
        //{
        //    Console.WriteLine("Show delegate Object");
        //}

        // mulptiple delegate ends here


        // Multi Cast delegate starts here


        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is {0}", result);
        }
        public static void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction result is {0}", result);
        }
        public static void Mul(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result is {0}", result);
        }
        public static void Div(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is {0}", result);
        }


        // Multi Cast delegate starts here



        //public static void Add(int a,int b)
        //{
        //    int result = a + b;
        //    Console.WriteLine("Addition result is {0}",result);
        //}
        //public static void Sub(int a, int b)
        //{
        //    int result = a - b;
        //    Console.WriteLine("Subtraction result is {0}", result);
        //}
        //public static void Mul(int a, int b)
        //{
        //    int result = a * b;
        //    Console.WriteLine("Multiplication result is {0}", result);
        //}
        //public static void Div(int a, int b)
        //{
        //    int result = a / b;
        //    Console.WriteLine("Division result is {0}", result);
        //}

        ////for Single cast delegate
        //public static void Addition(int a,int b)
        //{
        //    int result = a + b;
        //    Console.WriteLine(result);
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Individual objects can also be made for each method

            //Calculation calculation = new Calculation(Addition);
            //calculation.Invoke(4,5);
            //calculation = Sub;
            //calculation.Invoke(12,7);
            //calculation =Mul;
            //calculation.Invoke(7,8);
            //calculation = Div;
            //calculation.Invoke(9,8);


            //single cast delegate
            //Only one method should be passed to delegate objects to avoid any other method to be pointed


            //showDelegate showDelegate = new showDelegate(show);
            //showDelegate.Invoke();


            //Multiple delegates
            //hideDelegate hideDelegate = new hideDelegate(Square);
            //hideDelegate.Invoke(2);
            //hideDelegate = Cube;
            //hideDelegate.Invoke(3);

            //calculation.Invoke(9,8);


            //Multi Cast
            Calculation calculation = new Calculation(Add);
            calculation += Sub;
            calculation += Mul;
            calculation -= Div;
            calculation.Invoke(100, 50);
        }
    }
}