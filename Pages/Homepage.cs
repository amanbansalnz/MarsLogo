using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsLogo.POM
{
    internal class Homepage
    {
        public void MarslogoHomepage(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[@id='home']//a[contains(.,'Sign In')]")).Click();
            // Identify username //
            IWebElement username = driver.FindElement(By.Name("email"));
            username.SendKeys("suhanishu29@gmail.com");
            // Identify Password //
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("nishka4455");
            // click on Loginbutton //
            IWebElement Loginbutton = driver.FindElement(By.XPath("//button[contains(.,'Login')]"));
            Loginbutton.Click();
            IWebElement marsLogo = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/a"));
            Assert.True(marsLogo.Displayed);
        }
    }
}
