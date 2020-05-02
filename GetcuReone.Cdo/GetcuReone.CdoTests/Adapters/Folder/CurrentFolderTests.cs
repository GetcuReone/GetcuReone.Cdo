using GetcuReone.Cdo.Adapters.Folder;
using GetcuReone.Services.Folder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestCommon;

namespace GetcuReone.CdoTests.Adapters.Folder
{
    [TestClass]
    public sealed class CurrentFolderTests : FactoryTestBase
    {
        [TestMethod]
        [TestCategory(TC.Projects.GR_Cdo)]
        [Description("Call ExistsCurrentFolder method.")]
        [Timeout(Timeouts.Milisecond.FiveHundred)]
        public void CallExistsCurrentFolderTestCase()
        {
            GivenEmpty()
                .When("Call ExistsCurrentFolder method.", () => GetAdapter<CurrentFolderAdapter>().ExistsCurrentFolder())
                .Then("Check create proxy.", () => AssertCreateObjectResult<IFolder, string>(Environment.CurrentDirectory));
        }
    }
}
