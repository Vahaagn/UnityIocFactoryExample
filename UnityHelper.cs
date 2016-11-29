using Microsoft.Practices.Unity;

namespace UnityIocFactoryExample
{
    static class UnityHelper
    {
        public static void RegisterKeyed<TInterface, TConcrete, TKey>(this IUnityContainer container, TKey key) where TConcrete : TInterface
        {
            IKeyed<TKey, TInterface> existing = null;

            var isRegistered = container.IsRegistered<IKeyed<TKey, TInterface>>();
            if (isRegistered)
            {
                existing = container.Resolve<IKeyed<TKey, TInterface>>();
            }

            if (existing == null)
            {
                existing = new Keyed<TKey, TInterface>();
                container.RegisterInstance(existing);
            }

            ((Keyed<TKey, TInterface>) existing).Add<TConcrete>(key, container);
        }
    }
}