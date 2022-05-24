using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace ConsoleApp1
{
    [Binding]
    public class Feature4455StepDefinations
    {
        IWebDriver driver;

        [Given(@"Logged into Mars Logo home")]
        public void GivenLoggedIntoMarsLogoHome()
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
        [When(@"Navigate to Mars logo profile")]
        public void WhenNavigateToMarsLogoProfile()
        {
            // Navigate to profile //
            IWebElement profile = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
            profile.Click();

        }

        [When(@"User filled the language details and saved")]
        public void WhenUserFilledTheLanguageDetailsAndSaved()
        {
            // Identify Languages //
            IWebElement language = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[1]/h3"));
            language.Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            // Navigate to Language Textbox//
            IWebElement language_Textbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            language_Textbox.SendKeys("English");
            SelectOptionByValue(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"), "Fluent");
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
        }
        [Then(@"The language details should be added successfully")]
        public void ThenTheLanguageDetailsShouldBeAddedSuccessfully()
        {
            IWebElement language = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.True(language.Displayed);
        }
        [When(@"User filled the skills details and saved")]
        public void WhenUserFilledTheSkillsDetailsAndSaved()
        {
            // Identify Skills //
            IWebElement Skills = driver.FindElement(By.XPath("//*[@id='account-profile-section']//div[3]//div[1]/a[2]"));
            Skills.Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']//section[2]//div[3]/form/div[3]//table/thead/tr/th[3]/div")).Click();
            // Navigate to Skills Textbox//
            IWebElement Skills_Textbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]//div[3]//div[1]/input"));
            Skills_Textbox.Clear();
            Skills_Textbox.SendKeys("Typing");
            SelectOptionByValue(By.XPath("//*[@id='account-profile-section']//div[3]//div[2]/select"), "Expert");
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]//span/input[1]")).Click();

        }

        [Then(@"The skills details should be added successfully")]
        public void ThenTheSkillsDetailsShouldBeAddedSuccessfully()
        {
            IWebElement skills = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.True(skills.Displayed);
        }
        [When(@"User filled the Description details and saved")]
        public void WhenUserFilledTheDescriptionDetailsAndSaved()
        {
            // Identify Description //
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            Description.Click();
            // Navigate to Description Textbox//
            IWebElement description_Textbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            description_Textbox.Clear();
            description_Textbox.SendKeys("ILove dancing,cooking,gym and long walks ,prefer to spend time with friends on the weekends.I consider myself as an all rounder,My biggest strength is multitasking skills");
            driver.FindElement(By.XPath("//*[@id='account-profile-section']//div[3]/div/div/form/div/div/div[2]/button")).Click();


        }

        [Then(@"The Description details should be added successfully")]
        public void ThenTheDescriptionDetailsShouldBeAddedSuccessfully()
        {
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            Assert.True(Description.Displayed);
        }


        [BeforeScenario]
        public void Open_Browser()
        {
            ChromeOptions chromeOptions = new ChromeOptions();

            //Opens Chrome and accept all the SSL certificates        
            chromeOptions.AddArguments("ignore-certificate-errors");
            driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        [AfterScenario]
        public void close_Browser()
        {
            driver.Quit();
        }

        internal void SelectOptionByText(By identifier, string text)
        {

            SelectElement select = new SelectElement(driver.FindElement(identifier));
            Thread.Sleep(1000);
            select.SelectByText(text);



        }
        internal void SelectOptionByValue(By identifier, string text)
        {

            SelectElement select = new SelectElement(driver.FindElement(identifier));
            Thread.Sleep(1000);
            select.SelectByValue(text);
        }
    }

}
