// using Microsoft.Playwright;

// namespace playwright;

// public class Tests
// {
//     [SetUp]
//     public void Setup()
//     {
//     }

//     [Test]
//     public async Task Test1()
//     {
//         using var playwright = await Playwright.CreateAsync();

//         //browser
//         await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
//         {
//             Headless = false
//         });

//         //page
//         var page = await browser.NewPageAsync();
//         await page.GotoAsync(url: "http//www.eaapp.somee.com");
//         await page.ClickAsync(selector: "text=Login");
//         await page.ScreenshotAsync(new PageScreenshotOptions
//         {
//             Path = "EAApp.jpg"
//         });
//         await page.FillAsync(selector: "#UserName", value: "admin");
//         await page.FillAsync(selector: "#Password", value: "password");
//         await page.ClickAsync(selector: "text=Log in");
//         var isExist = await page.Locator(selector: "text='Employee Details'").IsVisibleAsync();
//     }
// }