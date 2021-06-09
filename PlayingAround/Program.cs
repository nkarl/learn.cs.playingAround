using System;
using System.Collections;
using System.Collections.Generic;

namespace PlayingAround
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            const string greeting = "Hello, World!";
            Console.WriteLine(greeting);

            // This is an example of ArrayList, it's seems flexible and can be used on the fly for any data types.
            var array = new List<string> {greeting};
            Console.WriteLine(array[0]);
            Console.WriteLine(greeting.GetType());
            Console.WriteLine((array[0])?.GetType());
            Console.WriteLine($"content of <greeting> is equal to content of <array[0]>: {greeting.Equals(array[0])}");
            Console.WriteLine(
                $"Type of <greeting, {greeting.GetType()}> is same as type of <array[0], {array[0]?.GetType()}>: {(greeting.GetType() == array[0]?.GetType())}");
        }
    }
}