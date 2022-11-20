using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = POMSelenium_1.Driver.WebDriver;

namespace POMSelenium_1.Page
{
    public class LoginPage
    {

        private IWebDriver driver = WebDriver.Instance;



        public IWebElement UserName => driver.FindElement(By.Id("user-name"));

        public IWebElement Password => driver.FindElement(By.Id("password"));

        public IWebElement LoginButton => driver.FindElement(By.Id("login-button"));

        public void LoginOnPage(string name, string password)
        {
            UserName.SendKeys(name);
            Password.SendKeys(password);
            LoginButton.Click();
        }

    }
}
