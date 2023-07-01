﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace UIAutomationFramework.Scripts
{
    [TestFixture]
    public class TGHeaderTests : BaseTest
    {
        [Test]
        public void ValidateTGLogo()
        {
            Thread.Sleep(1000);
            Assert.True(logo.Displayed);
        }

        [Test]
        public void ValidateTGHeader()
        {
            IWebElement heading = driver.FindElement(By.CssSelector(".HomePage_pageTitle__UAMbk"));
            Assert.True(heading.Displayed);
            Assert.AreEqual(heading.Text, "Welcome to TechGlobal School\nTraining");
        }
    }
}