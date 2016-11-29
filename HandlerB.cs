using System;

namespace UnityIocFactoryExample
{
    class HandlerB : IHandler
    {
        public void Print()
        {
            Console.WriteLine("Handler BBB");
        }
    }
}