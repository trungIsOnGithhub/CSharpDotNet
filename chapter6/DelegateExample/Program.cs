// Usage 1: Call Method Instead of using .

// kind of Function Pointer in C++: but safer, built for Method

// reference to memory address of a method

using System;

namespace DelegateExample
{
    class ClassExample
    {
        private int properties;

        static public void MethodToCall(string text)
        {
            Console.WriteLine($"Method has been called, message: {text}");
        }
    }
}

// define as a data type
delegate void DelegatorOfMethodToCall(string text);
// and use it as if a data type

class Program
{
    public static void Main(string[] args)
    {
        DelegateExample.ClassExample.MethodToCall("Trung Đẹp Zai!!");

        DelegatorOfMethodToCall fun = new(DelegateExample.ClassExample.MethodToCall);

        fun("Trung Vui Tính!!");
    }
}

// "What's the point of that?"  - It provides flexibility
/* Example:  a queue of methods that need to be called in order??
            multiple actions to perform parallel, delegate even has built-in support for async
            Example of loose coupling between components
*/