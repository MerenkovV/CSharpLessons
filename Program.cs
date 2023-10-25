using System;

namespace firstOfAll{
    class Program{
        static void Main(){
            bool loiading = false;
            int number = 100;
            Console.WriteLine(number);
            Console.WriteLine("Hey");
            Console.WriteLine("Loading? - " + loiading);

            int num_1, num_2;
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine('+');
            num_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine('=');
            Console.WriteLine(num_1+num_2);
        }
    }
}