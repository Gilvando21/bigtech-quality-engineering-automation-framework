using NUnit.Framework;
using Microsoft.Playwright;
using System.Threading.Tasks;

namespace BigTech.Automation.Framework.UI
{
    public class SimuladorUITest
    {
        [Test]
        public async Task CT04_UI_Simulacao()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://example.com");

            Assert.Pass();
        }
    }
}