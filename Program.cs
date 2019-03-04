using System;
using System.Collections.Generic;

namespace random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
                List<int> numbers = new List<int> {
                    random.Next(10),
                    random.Next(10),
                    random.Next(10),
                    random.Next(10),
                    random.Next(10),
                };

                for(int i = 0; i < numbers.Count; i++){
                //Contains method built into C# 
                    if(numbers.Contains(i)){
                        Console.WriteLine($"Numbers List Contains {numbers[i]}");

                    }else{
                    Console.WriteLine($"Numbers List Does not contain {numbers[i]}"); 
                }
        }
    }
}
}
