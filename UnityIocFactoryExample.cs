using System;
using Microsoft.Practices.Unity;

namespace UnityIocFactoryExample
{
    class UnityIocFactoryExample
    {
        static void Main(string[] args)
        {
            var program = new UnityIocFactoryExample();
            program.Run();
            
            Console.ReadKey();
        }

        private readonly IUnityContainer _container;

        private UnityIocFactoryExample()
        {
            _container = new UnityContainer();
        }

        private void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IFactory, Factory>();
            container.RegisterType<ISomeService, SomeService>();

            container.RegisterKeyed<IHandler, HandlerA, FactoryType>(FactoryType.A);
            container.RegisterKeyed<IHandler, HandlerB, FactoryType>(FactoryType.B);
        }

        public void Run()
        {
            RegisterTypes(_container);

            var service = _container.Resolve<ISomeService>();
            service.Print(FactoryType.B);
            service.Print(FactoryType.A);
        }
    }
}
