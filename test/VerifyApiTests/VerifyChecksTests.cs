namespace VerifyApiTests;

using Xunit;

public class VerifyChecksTests
{
    [Fact]
    public Task Run() => VerifyChecks.Run();
}