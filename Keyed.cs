using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;

namespace UnityIocFactoryExample
{
    class Keyed<TKey, TInterface> : IKeyed<TKey, TInterface>
    {
        private IDictionary<TKey, Func<TInterface>> _values;

        public Keyed()
        {
            _values = new Dictionary<TKey, Func<TInterface>>();
        }

        public TInterface this[TKey key]
        {
            get { return _values[key].Invoke(); }
        }

        public void Add<TConcrete>(TKey key, IUnityContainer container) where TConcrete : TInterface
        {
            container.RegisterType<TInterface, TConcrete>(key.ToString());
            _values.Add(key, () => container.Resolve<TInterface>(key.ToString()));
        }
    }
}