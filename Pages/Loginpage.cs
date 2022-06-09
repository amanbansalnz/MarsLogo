using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsLogo.POM
{
    internal class Loginpage
    {
        public void Loginsteps(IWebDriver driver)
        {
            //Opens Chrome and accept all the SSL certificates        
            chromeOptions.AddArguments("ignore-certificate-errors");
            driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


        }
    }
}

