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

            output.Should().Be("iNQmb9TmM40TuEX88olXnSCciXgjuSF9o+Fhk28DFYk=");
        }
    }
}