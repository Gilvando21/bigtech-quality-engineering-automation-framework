
using NUnit.Framework;
using Microsoft.Playwright;

namespace UI;

public class SimuladorUITest
{
    [Test]
    public async Task UI_OpenBrowser_RecordVideo()
    {
        using var playwright = await Playwright.CreateAsync();

        var browser = await playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 200
            });

        var context = await browser.NewContextAsync(new BrowserNewContextOptions
        {
            RecordVideoDir = "videos/"
        });

        var page = await context.NewPageAsync();

        await page.GotoAsync("https://example.com");

        await page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "screenshots/test.png"
        });

        Assert.IsTrue(await page.TitleAsync() != null);

        await browser.CloseAsync();
    }
}
