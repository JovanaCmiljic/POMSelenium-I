using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = POMSelenium_1.Driver.WebDriver;

namespace POMSelenium_1.Page
{
    public class HomePage
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement Photo => driver.FindElement(By.ClassName("inventory_item_img"));
        public IWebElement AddToCart => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement Back => driver.FindElement(By.Id("back-to-products"));
        public IWebElement Menu => driver.FindElement(By.Id("react-burger-menu-btn"));
        public IWebElement LogOut => driver.FindElement(By.Id("logout_sidebar_link"));
        

        public void EnterPhoto()
        {
            Photo.Click();
        }
        public void EnterAddToCart()
        {
            AddToCart.Click();
        }
        public void EnterBack() 
        { 
           Back.Click();
        }
        public void EnterMenu() 
        { 
           Menu.Click();
        }
        public void EnterLogOut() 
        { 
           LogOut.Click();
        }

    }
}
