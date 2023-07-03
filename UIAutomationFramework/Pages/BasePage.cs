﻿using System;
using OpenQA.Selenium;
using UIAutomationFramework.EnvironmentConfiguration;
using UIAutomationFramework.Utils;


namespace UIAutomationFramework.Pages
{
	public class BasePage : EnvirontmentSettings
	{
        //Header Elements
        public IWebElement logo => driver.FindElement(By.Id("logo"));
        public IWebElement heading => driver.FindElement(By.CssSelector(".HomePage_pageTitle__UAMbk"));
        public IWebElement praticesDropDown = driver.FindElement(By.Id("dropdown-button"));
        public IList<IWebElement> practiceDropDownOptions => driver.FindElements(By.CssSelector("#dropdown-menu a"));


        //Footer Elements
        public IWebElement address => driver.FindElement(By.XPath("(//footer[@class='Footer_footer__kXlYa']//p)[1]"));
        public IWebElement copyright => driver.FindElement(By.XPath("(//footer[@class='Footer_footer__kXlYa']//p)[2]"));
        public IList<IWebElement> socialMediaElements => driver.FindElements(By.CssSelector(".Footer_socials__7h4n1>a"));

        public void selectPracticesDropDownOption(string optionText)
        {
            praticesDropDown.Click();
            ElementHandler.ClickListElement(practiceDropDownOptions, optionText);
        }

        public void selectPracticesDropDownOption(int index)
        {
            praticesDropDown.Click();
            ElementHandler.ClickListElement(practiceDropDownOptions, index);
        }
    }
}