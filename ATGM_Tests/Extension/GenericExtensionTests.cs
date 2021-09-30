using ATGM_Extensions;
using System;
using Xunit;

namespace ATGM_Tests.Extension
{
    public class GenericExtensionTests
    {
        [Fact]
        public void GenericMaxReturnsMax()
        {
            int min = -100;
            int max = 200;

            int resp = GenericExtension.Max(min, max);

            Assert.Equal(max, resp);
        }

        [Fact]
        public void GenericMinReturnsMin()
        {
            int min = -100;
            int max = 200;

            int resp = GenericExtension.Min(min, max);

            Assert.Equal(min, resp);
        }

        [Fact]
        public void GenericInReturnsError()
        {
            object nullObject = null;

            var result = Assert.Throws<ArgumentNullException>(() => nullObject.In());

        }
    }
}
