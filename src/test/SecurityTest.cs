using FluentAssertions;
namespace SharpyTest
{
    public class SecurityTest
    {
        [Fact]
        public void String2Sha256()
        {
            var input = "abcd";

            var output = Sharpy.Security.sha256(input);

            output.Should().Be("88-D4-26-6F-D4-E6-33-8D-13-B8-45-FC-F2-89-57-9D-20-9C-89-78-23-B9-21-7D-A3-E1-61-93-6F-03-15-89");
        }
    }
}