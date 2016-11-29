namespace UnityIocFactoryExample
{
    class Factory : IFactory
    {
        private IKeyed<FactoryType, IHandler> _handlers;

        public Factory(IKeyed<FactoryType, IHandler> handlers)
        {
            _handlers = handlers;
        }

        public void Produce(FactoryType type)
        {
            var handler = _handlers[type];
            handler.Print();
        }
    }
}