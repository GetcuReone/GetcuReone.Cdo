using GetcuReone.ComboPatterns.Adapter;
using GetcuReone.ComboPatterns.Facade;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.GwtTestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TestCommon.Entities;

namespace TestCommon
{
    [TestClass]
    public abstract class FactoryTestBase : TestBase, IAbstractFactory, IAdapterCreation, IFacadeCreation
    {
        protected List<CreateObjectResult> CreateObjectResults { get; private set; }

        [TestInitialize]
        public virtual void Initialize()
        {
            CreateObjectResults = new List<CreateObjectResult>();
        }

        public virtual TObj CreateObject<TParameter, TObj>(Func<TParameter, TObj> factoryFunc, TParameter parameters)
        {
            if (factoryFunc == null)
                throw new NullReferenceException(nameof(factoryFunc));

            var obj = factoryFunc(parameters);

            CreateObjectResults.Add(new CreateObjectResult
            {
                Obj = obj,
                Param = parameters,
            });

            return obj;
        }

        public virtual TAdapter GetAdapter<TAdapter>() where TAdapter : IAdapter, new()
        {
            return AdapterBase.Create<TAdapter>(this);
        }

        public TFacade GetFacade<TFacade>() where TFacade : IFacade, new()
        {
            return FacadeBase.Create<TFacade>(this);
        }

        protected void AssertCreateObjectResult<TObj, TParam>(TParam param)
        {
            var coResults = CreateObjectResults.Where(item => item.Obj is TObj & item.Param is TParam).ToList();

            if (coResults.Count == 0)
                Assert.Fail($"CreateObjectResult not found. Param <{param}>.");

            foreach (var item in CreateObjectResults)
            {
                if (item.Param == null && param == null)
                    return;
                else if (param.Equals(item.Param))
                    return;
            }

            Assert.Fail($"Call CreateObject with param '{param}' not found.");
        }
    }
}
