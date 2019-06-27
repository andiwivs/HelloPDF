using GemBox.Document;
using NUnit.Framework;

namespace ApprovalTests
{
    [TestFixture]
    public class TextConversionTests
    {
        // based on sample code @ https://www.gemboxsoftware.com/document/examples/c-sharp-read-pdf/305

        [OneTimeSetUp]
        public void BeforeAnyTest()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
        }

        [Test]
        public void Approval()
        {
            var v2content = ReadPdfContent(@"C:\Dummy Docs\mock v2 report.pdf");
            var v3content = ReadPdfContent(@"C:\Dummy Docs\mock v3 report.pdf");

            Assert.AreEqual(v2content, v3content);
        }

        private string ReadPdfContent(string pdfPath)
        {
            DocumentModel document = DocumentModel.Load(pdfPath);
            return document.Content.ToString();
        }
    }
}
