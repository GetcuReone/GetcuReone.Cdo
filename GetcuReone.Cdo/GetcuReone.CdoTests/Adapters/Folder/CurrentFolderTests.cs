using GetcuReone.Cdo.Folder;
using GetcuReone.GetcuTestAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestCommon;

namespace GetcuReone.CdoTests.Adapters.Folder
{
    [TestClass]
    public sealed class CurrentFolderTests : FactoryTestBase
    {
        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Call ExistsCurrentFolder method.")]
        [Timeout(Timeouts.Millisecond.FiveHundred)]
        public void CallExistsCurrentFolderTestCase()
        {
            GivenEmpty()
                .When("Call ExistsCurrentFolder method.", () => 
                    GetAdapter<CurrentFolderAdapter>().ExistsCurrentFolder())
                .Then("Check create proxy.", () => 
                    AssertCreateObjectResult<IFolder, string>(Environment.CurrentDirectory));
        }
    }
}
