using AwesomeConverter.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AwesomeConverterTests;

[TestClass()]
public class IndexModelTests
{
    [TestMethod()]
    public void OnPostTest()
    {
        // arrange 
        IndexModel indexModel = new ()
        {
            LengthInMiles = 10
        };

        // act 
        indexModel.OnPost();

        // assert 
        Assert.AreEqual(indexModel.LengthInMeters, 16_000);
    }
}