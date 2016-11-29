using System;

namespace UnityIocFactoryExample
{
    class HandlerA : IHandler
    {
        public void Print()
        {
            Console.WriteLine("Handler AAA");
        }
    }
}