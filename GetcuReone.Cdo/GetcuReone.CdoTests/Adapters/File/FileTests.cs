using GetcuReone.Cdo.File;
using GetcuReone.GetcuTestAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using TestCommon;

namespace GetcuReone.CdoTests.Adapters.File
{
    [TestClass]
    public sealed class FileTests : FactoryTestBase
    {
        private string FilePath { get; set; }
        private string DefaultText { get; set; }

        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();

            FilePath = Path.Combine(Environment.CurrentDirectory, "test.txt");
            DefaultText = "Hey!";

            System.IO.File.WriteAllText(FilePath, DefaultText);
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (System.IO.File.Exists(FilePath))
                System.IO.File.Delete(FilePath);
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Call WriteAllText method.")]
        [Timeout(Timeouts.Millisecond.FiveHundred)]
        public void WriteAllTextTestCase()
        {
            GivenEmpty()
                .When("Call WriteAllText.", () => 
                    GetAdapter<FileAdapter>().WriteAllText(FilePath, DefaultText))
                .Then("Check create proxy.", () => 
                    AssertCreateObjectResult<IFile, string>(FilePath));
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Call WriteAllText method.")]
        [Timeout(Timeouts.Millisecond.FiveHundred)]
        public void WriteAllText_Utf8_TestCase()
        {
            GivenEmpty()
                .When("Call WriteAllText.", () => 
                    GetAdapter<FileAdapter>().WriteAllText(FilePath, DefaultText, Encoding.UTF8))
                .Then("Check create proxy.", () => 
                    AssertCreateObjectResult<IFile, string>(FilePath));
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Call ReadAllText method.")]
        [Timeout(Timeouts.Millisecond.FiveHundred)]
        public void ReadAllTextTestCase()
        {
            GivenEmpty()
                .When("Call ReadAllText.", () => 
                    GetAdapter<FileAdapter>().ReadAllText(FilePath))
                .Then("Check create proxy.", () => 
                    AssertCreateObjectResult<IFile, string>(FilePath));
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Call WriteAllText method.")]
        [Timeout(Timeouts.Millisecond.FiveHundred)]
        public void ReadAllText_Utf8_TestCase()
        {
            GivenEmpty()
                .When("Call ReadAllText.", () => 
                    GetAdapter<FileAdapter>().ReadAllText(FilePath, Encoding.UTF8))
                .Then("Check create proxy.", () => 
                    AssertCreateObjectResult<IFile, string>(FilePath));
        }
    }
}
