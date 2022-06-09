using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsLogo.POM
{
    internal class Profilepage
    {

        public void MarsProfilepage(IWebDriver driver)
        {
            // Navigate to profile //
            IWebElement profile = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
            profile.Click();
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


    }
    }


