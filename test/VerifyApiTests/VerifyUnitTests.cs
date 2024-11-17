namespace VerifyApiTests;

using System;
using VerifyTests;
using Xunit;

public class VerifyUnitTests : IDisposable
{
    public VerifyUnitTests()
        => VerifyPdfPig.Initialize();

    public void Dispose()
    {
        // Do "global" teardown here; Called after every test method.
    }

    [Fact]
    public async Task TestPdf()
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "../../../../../assets", "hi.pdf");

        var settings = new VerifySettings();
        settings.ScrubInlineDateTimes("yyyy-MM-dd HH:mm");
        await VerifyFile(filePath, settings);
    }
}
