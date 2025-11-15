using System;

namespace JavaLikeCsharp
{
    public class Greeter
    {
        private string name;

        public Greeter(string name)
        {
            this.name = name;
        }

        public void sayHello()
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
