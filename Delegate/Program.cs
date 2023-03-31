namespace Delegate
{
    //Delegate is a function pointer
    // it is reference type
    //it should have same signature as that of function pointed to
    //its purpose is to encapsulate method in a class
    //more than one function
    // Delegates improves the purformance of application

    public delegate void Calculation(int a, int b); 
    class Program
    {
        public static void Add(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is {0}",result);
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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Individual objects can also be made for each method

            Calculation calculation = new Calculation(Program.Add);
            calculation.Invoke(4,5);
            calculation = Sub;
            calculation.Invoke(12,7);
            calculation =Mul;
            calculation.Invoke(7,8);
            calculation = Div;
            calculation.Invoke(9,8);
        }
    }
}