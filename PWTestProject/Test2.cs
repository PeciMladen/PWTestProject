using Microsoft.Playwright;

namespace PWTestProject;

[TestClass]
public class Test2 : PageTest
{
    [TestMethod]
    public async Task AppOpeningTest()
    {
        await Page.GotoAsync("https://parabank.parasoft.com/");
        var logo = Page.Locator("img[alt='ParaBank']");
        
        await Expect(logo).ToBeVisibleAsync();
    }

    [TestMethod]
    public async Task UserInitialization()
    {
        
        
        var userExists = Page.Locator("h1:has-text('Accounts Overview')");

        try
        {
            await Page.GotoAsync("https://parabank.parasoft.com/");
            var userName = Page.Locator("[name='username']");
            var password = Page.Locator("[name='password']");
            var logIn = Page.Locator("[value='Log In']");
            var secondPageTitle = Page.Locator("h1:has-text('Accounts Overview')");

            await userName.FillAsync("test");
            await password.FillAsync("test");
            await logIn.ClickAsync();

            await Expect(secondPageTitle).ToBeVisibleAsync();
        }
        catch
        { 
            await Page.GetByRole(AriaRole.Link, new() { Name = "Register" }).ClickAsync();    
        await Page.Locator("[id=\"customer\\.firstName\"]").ClickAsync();
        await Page.Locator("[id=\"customer\\.firstName\"]").FillAsync("test");
        await Page.Locator("[id=\"customer\\.firstName\"]").PressAsync("Tab");
        await Page.Locator("[id=\"customer\\.lastName\"]").FillAsync("test");
        await Page.Locator("[id=\"customer\\.lastName\"]").PressAsync("Tab");
        await Page.Locator("[id=\"customer\\.address\\.street\"]").FillAsync("test");
        await Page.Locator("[id=\"customer\\.address\\.street\"]").PressAsync("Tab");
        await Page.Locator("[id=\"customer\\.address\\.city\"]").FillAsync("test");
        await Page.Locator("[id=\"customer\\.address\\.city\"]").PressAsync("Tab");
        await Page.Locator("[id=\"customer\\.address\\.state\"]").FillAsync("test");
        await Page.Locator("[id=\"customer\\.address\\.state\"]").PressAsync("Tab");
        await Page.Locator("[id=\"customer\\.address\\.zipCode\"]").FillAsync("test");
        await Page.Locator("[id=\"customer\\.address\\.zipCode\"]").PressAsync("Tab");
        await Page.Locator("[id=\"customer\\.phoneNumber\"]").FillAsync("test");
        await Page.Locator("[id=\"customer\\.phoneNumber\"]").PressAsync("Tab");
        await Page.Locator("[id=\"customer\\.ssn\"]").FillAsync("test");
        await Page.Locator("[id=\"customer\\.ssn\"]").PressAsync("Tab");
        await Page.Locator("[id=\"customer\\.username\"]").FillAsync("test");
        await Page.Locator("[id=\"customer\\.username\"]").PressAsync("Tab");
        await Page.Locator("[id=\"customer\\.password\"]").FillAsync("test");
        await Page.Locator("[id=\"customer\\.password\"]").PressAsync("Tab");
        await Page.Locator("#repeatedPassword").FillAsync("test");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Register" }).ClickAsync();
        await Expect(Page.Locator("h1")).ToContainTextAsync("Welcome test");
        await Page.GetByRole(AriaRole.Link, new() { Name = "Log Out" }).ClickAsync();
        await Expect(Page.Locator("h2")).ToContainTextAsync("Customer Login");
        }
        
    }

    [TestMethod]
    public async Task LoginTest()
    {
        await Page.GotoAsync("https://parabank.parasoft.com/");
        var userName = Page.Locator("[name='username']");
        var password = Page.Locator("[name='password']");
        var logIn = Page.Locator("[value='Log In']");
        var secondPageTitle = Page.Locator("h1:has-text('Accounts Overview')");

        await userName.FillAsync("test");
        await password.FillAsync("test");
        await logIn.ClickAsync();

        await Expect(secondPageTitle).ToBeVisibleAsync();
    }
}