﻿using AutomationFramework.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomationFramework.ProjectLib

{
    [Binding]
    public class PageObjectManager
    {
        private IWebDriver _driver { get; }  
        private LoginPage _loginPage;
        private DicomPage _dicomPage;
        private HomePage _homepage;

        public PageObjectManager(IWebDriver webDriver)
        {
            _driver = webDriver;
        }
       
        public LoginPage GetLoginPage() => _loginPage == null ? new LoginPage(_driver) : _loginPage;
        public DicomPage GetDicomPage() => _dicomPage == null ? new DicomPage(_driver) : _dicomPage;
        public HomePage GetHomePage() => _homepage == null ? new HomePage(_driver) : _homepage;

    }    
}
