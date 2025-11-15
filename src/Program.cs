using System;

namespace JavaLikeCsharp
{
    public class MainClass
    {
        public static void Main(string[] args)   // ← C# 엔트리 포인트
        {
            main(args);  // ← Java-style main 호출
        }

        public static void main(string[] args)   // ← 네가 원하는 Java형 main
        {
            Console.WriteLine("Hello from Java-like-Csharp!");

            Greeter greeter = new Greeter("Java-like-Csharp");
            greeter.sayHello();

            Calculator calc = new Calculator();
            Console.WriteLine("2 + 3 = " + calc.add(2, 3));
        }
    }
}
