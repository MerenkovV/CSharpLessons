using System;
using System.Collections.Generic;

namespace firstOfAll{
    class Program{
        static void Main(){
            // short length = Convert.ToInt16(Console.ReadLine());
            // string?[] names = new string[length];
            // for(short index = 0; index < names.Length; index++){
            //     names[index] = Console.ReadLine();
            // }

            // for(short index = 0; index < names.Length; index++){
            //     Console.WriteLine(names[index] != null ? names[index] : "void");
            // }

            //foreach(string? name in names) Console.WriteLine(name != null ? name : "void");

            //Динамические массивы (хранят любое количество элементов + имеют дополнительные методы):

            List<short> numbers = new List<short> {
                132, 13, 44, 16
            };

            numbers.Add(14);
            numbers.Sort();
            numbers.Reverse();
            numbers.Remove(13);

            foreach (short number in numbers) System.Console.WriteLine(number);


        }
    }
}