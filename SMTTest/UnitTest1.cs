using Bunit;
using SMTApp.Common;

namespace SMTTest
{
    public class UnitTest1:TestContext
    {
        [Fact]
        public void GetDetailsTest()
        {
            List<string> result = CommonMethods.GetFilePaths("Building1", "room1")??new();
            var expectedResult= "/Building1/room1/Payments.txt";
            Assert.Contains<string>(expectedResult, result);
        }
        [Fact]
        public void GetBillsTest()
        {
            List<string> result = CommonMethods.GetBillPaths("Building1", "room1")??new();
            var expectedResult= "/Building1/room1/Ebill.jpg";
            Assert.Contains<string>(expectedResult, result);
        }
        [Fact]
        public void GetTenantTest()
        {
            string result = CommonMethods.GetTenantImagePaths("Building1", "room1");
            var expectedResult= "/Building1/room1/_Tenant.jpg";
            Assert.Equal(expectedResult, result);
        }
    }
}