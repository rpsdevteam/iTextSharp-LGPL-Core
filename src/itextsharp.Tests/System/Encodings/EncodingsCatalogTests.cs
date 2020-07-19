using itextsharp.System.Encodings;
using Xunit;

namespace itextsharp.Tests.System.Encodings
{
    public class EncodingsCatalogTests
    {
        [Theory]
        [InlineData(932)]
        [InlineData(936)]
        [InlineData(1251)]
        public void GetEncoding_returnsEncoding(int codepage)
        {
            var encoding = EncodingsCatalog.GetEncoding(codepage);
            Assert.NotNull(encoding);
        }
    }
}
