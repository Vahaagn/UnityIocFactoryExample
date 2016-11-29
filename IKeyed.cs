namespace UnityIocFactoryExample
{
    interface IKeyed<in TKey, out TInterface>
    {
        TInterface this[TKey key] { get; }
    }
}