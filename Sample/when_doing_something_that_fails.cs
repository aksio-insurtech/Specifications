using Xunit;
using Aksio.Specifications;

namespace Sample
{
    public class when_doing_something_that_fails
    {
        void Establish() {}

        void Because() {}

        [Fact] void should_be_true() => false.ShouldBeTrue();
    }
}