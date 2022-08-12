using InstagramTest;
using Microsoft.Playwright;

using var pw = await Playwright.CreateAsync();
await using var browser = await pw.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
{
	Headless = true
});

var page = await browser.NewPageAsync();
await page.GotoAsync("https://www.instagram.com/");

var title = await page.TitleAsync();
await page.TypeAsync("input[name=username]", "Username"); 
await page.TypeAsync("input[name=password]", "Password"); 
await page.ClickAsync("button[type='submit']");
await page.WaitForTimeoutAsync(5000);

await page.GotoAsync("https://www.instagram.com/sample_username"); 

var numberOfPost = await page.Locator("span[class='_ac2a']").Nth(0).InnerTextAsync();
var numberOfFollower = await page.Locator("span[class='_ac2a']").Nth(1).InnerTextAsync();
var numberOfFollows = await page.Locator("span[class='_ac2a']").Nth(2).InnerTextAsync();
var bioDescription = await page.Locator("div[class='_aacl _aacp _aacu _aacx _aad6 _aade']").Nth(3).InnerTextAsync();
var accountName = await page.Locator("span[class='_aacl _aacp _aacw _aacx _aad7 _aade']").Nth(0).InnerTextAsync(); ;



var excelHelper = new ExcelHelper();
excelHelper.CreateExcelFile(new ProfileDto
{
	AccountName = accountName,
	NumberOfPost = numberOfPost,
	NumberOfFollower = numberOfFollower,
	NumberOfFollows = numberOfFollows,
	BioDescription = bioDescription
});


Console.WriteLine("Account Information Exported to Excel!");
Console.ReadKey();
