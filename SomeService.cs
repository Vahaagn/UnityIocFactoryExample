namespace UnityIocFactoryExample
{
    class SomeService : ISomeService
    {
        private IFactory _factory;
        public SomeService(IFactory factory)
        {
            _factory = factory;
        }

        public void Print(FactoryType type)
        {
            _factory.Produce(type);
        }
    }
}