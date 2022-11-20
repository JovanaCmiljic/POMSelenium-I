using POMSelenium_1.Page;
using WebDriver = POMSelenium_1.Driver.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace POMSelenium_1
{
    public class Tests
    {
        private LoginPage _loginPage;
        private HomePage _homePage;

        [SetUp]

        public void BeforeScenario()
        {
            WebDriver.Initialize();
            _loginPage = new LoginPage();
            _homePage = new HomePage();

        }

        [TearDown]
        public void AfterScenario()
        {
            WebDriver.CleanUp();
        }

        [Test]

        public void TC01_FillInputWithValidData_ShouldAllDataDisplayedInInput()
        {

            Login("standard_user", "secret_sauce");

            _homePage.Photo.Click();
            _homePage.AddToCart.Click();
            _homePage.Back.Click();
            
            
        }
        [Test]
        public void TC02_OpenPopUp_ShouldDisplayed()
        {
            Login("standard_user", "secret_sauce");
            _homePage.Menu.Click();


        }
        public void Login(string name, string pass)
        {
            _loginPage.LoginOnPage(name, pass);
        }
    }
}