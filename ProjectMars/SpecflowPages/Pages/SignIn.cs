using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.SpecflowPages.Pages
{
    public class SignIn
    {
        private readonly By signInButtonLocator = By.XPath("//A[@class='item'][text()='Sign In']");
        IWebElement signInButton;

        private readonly By emailTextBoxLocator = By.XPath("//input[@placeholder='Email address' and @name='email']");
        IWebElement emailTextBox;

        private readonly By passwordTextBoxLocator = By.XPath("//input[@placeholder='Password' and @name='password']");
        IWebElement passwordTextBox;

        private readonly By loginButtonLocator = By.XPath("//button[@class = 'fluid ui teal button'][text() = 'Login']");
        IWebElement loginButton;

        public void LoginActions(IWebDriver driver)
        {
            //Launch profile page
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.Manage().Window.Maximize();

            try
            {
                signInButton = driver.FindElement(signInButtonLocator);
                signInButton.Click();
            }
            catch (Exception ex) 
            {
                Assert.Fail("Sign In Button not located:" + ex.Message);
            }

            try
            {
                emailTextBox = driver.FindElement(emailTextBoxLocator);
                emailTextBox.SendKeys("kalpanadissanayake211@gmail.com");
            }
            catch (Exception ex)
            {
                Assert.Fail("Email Text Box not located:" + ex.Message);
            }

            try
            {
                passwordTextBox = driver.FindElement(passwordTextBoxLocator);
                passwordTextBox.SendKeys("19DMkalpana##");
            }
            catch (Exception ex)
            {
                Assert.Fail("Password Text Box not located:" + ex.Message);
            }

            try
            {
                loginButton = driver.FindElement(loginButtonLocator);
                loginButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Login Button not located:" + ex.Message);
            }

        }
    }
}
