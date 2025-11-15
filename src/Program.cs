using System;

namespace JavaLikeCsharp
{
    public class MainClass
    {
        public static void main(string[] args)
        {
            // Java-style main wrapper
            Console.WriteLine("Hello from Java-like-Csharp!");

            Greeter greeter = new Greeter("Java-like-Csharp");
            greeter.sayHello();

            Calculator calc = new Calculator();
            Console.WriteLine("2 + 3 = " + calc.add(2, 3));
        }
    }
}
