using GetcuReone.Cdo.Adapters.Folder;
using GetcuReone.Cdo.Adapters.Xml;
using GetcuReone.CdoTests.Adapters.Xml.Env;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TestCommon;

namespace GetcuReone.CdoTests.Adapters.Xml
{
    [TestClass]
    public sealed class XmlTests : FactoryTestBase
    {
        private string TestObjFilePath { get; set; }

        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();

            TestObjFilePath = Path.Combine(Environment.CurrentDirectory, "Adapters", "Xml", "Env", "XmlTestObj.xml");
        }

        [TestMethod]
        [TestCategory(TC.Projects.GR_Cdo)]
        [Description("XmlTestObj serialize.")]
        [Timeout(Timeouts.Milisecond.FiveHundred)]
        public void XmlTestObjSerializeTestCase()
        {
            string filePath = GetAdapter<CurrentFolderAdapter>().GetFullName("test_file.xml");
            var testObj = new XmlTestObj
            {
                Value = "TestData",
            };

            GivenEmpty()
                .When("Serialize.", () =>
                {
                    using (var fileStream = System.IO.File.OpenWrite(filePath))
                        GetAdapter<XmlAdapter>().Serialize(testObj, fileStream);
                })
                .Then("Check result.", () => 
                {
                    using(var fileStream = System.IO.File.OpenRead(filePath))
                    {
                        var formatter = new XmlSerializer(typeof(XmlTestObj));
                        var result = (XmlTestObj)formatter.Deserialize(fileStream);

                        Assert.AreEqual(testObj.Value, result.Value, "Expected another value.");
                    }
                });

            System.IO.File.Delete(filePath);
        }

        [TestMethod]
        [TestCategory(TC.Projects.GR_Cdo)]
        [Description("Array XmlTestObj serialize.")]
        [Timeout(Timeouts.Milisecond.FiveHundred)]
        public void ArrayXmlTestObjSerializeTestCase()
        {
            string filePath = GetAdapter<CurrentFolderAdapter>().GetFullName("test_file.xml");
            var testObj = new List<XmlTestObj> 
            {
                new XmlTestObj { Value = "TestData" },
            };

            GivenEmpty()
                .When("Serialize.", () =>
                {
                    using (var fileStream = System.IO.File.OpenWrite(filePath))
                        GetAdapter<XmlAdapter>().Serialize(testObj, fileStream);
                })
                .Then("Check result.", () =>
                {
                    using (var fileStream = System.IO.File.OpenRead(filePath))
                    {
                        var formatter = new XmlSerializer(typeof(List<XmlTestObj>));
                        var result = (List<XmlTestObj>)formatter.Deserialize(fileStream);

                        Assert.AreEqual(1, result.Count, "Expected another Count list.");
                        Assert.AreEqual(testObj[0].Value, result[0].Value, "Expected another value.");
                    }
                });

            System.IO.File.Delete(filePath);
        }

        [TestMethod]
        [TestCategory(TC.Projects.GR_Cdo)]
        [Description("XmlTestObj deserialize.")]
        [Timeout(Timeouts.Milisecond.FiveHundred)]
        public void XmlTestObjDeserializeTestCase()
        {
            GivenEmpty()
                .When("Serialize.", () =>
                {
                    using (var fileStream = System.IO.File.OpenRead(TestObjFilePath))
                        return GetAdapter<XmlAdapter>().Deserialize<XmlTestObj, FileStream>(fileStream);
                })
                .Then("Check result.", result =>
                {
                    Assert.AreEqual("TestData", result.Value, "Expected another value.");
                });
        }
    }
}
