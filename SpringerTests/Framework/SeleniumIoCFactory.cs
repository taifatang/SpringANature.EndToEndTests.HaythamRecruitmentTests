﻿using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace SpringerTests.Framework
{
    [Binding]
    public class SeleniumIoCFactory
    {
        private readonly IObjectContainer _objectContainer;

        public SeleniumIoCFactory(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario(Order = 0)]
        public void InitializeWebDriver()
        {
            var webDriver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
        }
    }
}
