using GetcuReone.ComboPatterns.Adapter;
using GetcuReone.ComboPatterns.Facade;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.GwtTestFramework;
using System;

namespace TestCommon
{
    public abstract class FactoryTestBase : TestBase, IAbstractFactory, IAdapterCreation, IFacadeCreation
    {
        public virtual TObj CreateObject<TParameter, TObj>(Func<TParameter, TObj> factoryFunc, TParameter parameters)
        {
            if (factoryFunc == null)
                throw new NullReferenceException(nameof(factoryFunc));

            return factoryFunc(parameters);
        }

        public virtual TAdapter GetAdapter<TAdapter>() where TAdapter : IAdapter, new()
        {
            return AdapterBase.Create<TAdapter>(this);
        }

        public TFacade GetFacade<TFacade>() where TFacade : IFacade, new()
        {
            return FacadeBase.Create<TFacade>(this);
        }
    }
}
