using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMars.SpecflowPages.Helpers;
using ProjectMars.SpecflowPages.Utilities;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.SpecflowPages.Pages
{
    public class AddLanguage
    {
        private readonly By languagesTabLocator = By.XPath("//A[@class = 'item active'][text() = 'Languages']");
        IWebElement languagesTab;

        private readonly By addNewButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
        IWebElement addNewButton;

        private readonly By addLanguageTextBoxLocator = By.XPath("//input[@placeholder = 'Add Language' and @type = 'text']");
        IWebElement addLanguageTextBox;

        private readonly By languageLevelDropdownLocator = By.XPath("//select[@class = 'ui dropdown' and @name = 'level']");
        IWebElement languageLevelDropdown;

        private readonly By languageLevelBasicLocator = By.XPath("//option[@value = 'Basic'] [text() = 'Basic']");
        IWebElement languageLevelBasic;

        private readonly By languageLevelConversationalLocator = By.XPath("//option[@value = 'Conversational'] [text() = 'Conversational']");
        IWebElement languageLevelConversational;

        private readonly By languageLevelFluentLocator = By.XPath("//option[@value = 'Fluent'] [text() = 'Fluent']");
        IWebElement languageLevelFluent;

        private readonly By languageLevelNativeLocator = By.XPath("//option[@value = 'Native/Bilingual'] [text() = 'Native/Bilingual']");
        IWebElement languageLevelNative;

        private readonly By addLanguageButtonLocator = By.XPath("//input[@value = 'Add' and  @class = 'ui teal button']");
        IWebElement addLanguageButton;

        private readonly By toastMessageLocator = By.XPath("//div[@class = 'ns-box-inner']");
        IWebElement toastMessage;

        private readonly By addedLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        IWebElement addedLanguage;

        private readonly By addedLanguageLevelLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]");
        IWebElement addedLanguageLevel;

        private readonly By updateIconLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i");
        IWebElement updateIcon;

        private readonly By lastAddedLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input");
        IWebElement lastAddedLanguage;

        private readonly By lastAddedLanguageLevelDropdownLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select");
        IWebElement lastAddedLanguageLevelDropdown;

        private readonly By lastAddedlanguageLevelBasicLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[2]");
        IWebElement lastAddedlanguageLevelBasic;

        private readonly By lastAddedlanguageLevelConversationalLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[3]");
        IWebElement lastAddedlanguageLevelConversational;

        private readonly By lastAddedlanguageLevelFluentLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[4]");
        IWebElement lastAddedlanguageLevelFluent;

        private readonly By lastAddedlanguageLevelNativeLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[5]");
        IWebElement lastAddedlanguageLevelNative;

        private readonly By updateButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]");
        IWebElement updateButton;

        private readonly By deleteButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i");
        IWebElement deleteButton;

        private readonly By deletedLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        IWebElement deletedLanguage;

        private readonly By existingLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        IWebElement existingLanguage;


        public void AddLanguageActions(IWebDriver driver, string language)
        {
            Wait.WaitToBeClickable(driver, languagesTabLocator, 2);
            try
            {
                languagesTab = driver.FindElement(languagesTabLocator);
                languagesTab.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Language Tab not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, addNewButtonLocator, 2);
            try
            {
                addNewButton = driver.FindElement(addNewButtonLocator);
                addNewButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Add New Button not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, addLanguageTextBoxLocator, 2);
            try
            {
                addLanguageTextBox = driver.FindElement(addLanguageTextBoxLocator);
                addLanguageTextBox.SendKeys(language);
            }
            catch (Exception ex)
            {
                Assert.Fail(" Add Language Text Box not located:" + ex.Message);
            }
        }



        public void AddLanguageLevelActions(IWebDriver driver, string languageLevel) {

            Wait.WaitToBeClickable(driver, languageLevelDropdownLocator, 2);
            try
            {
                languageLevelDropdown = driver.FindElement(languageLevelDropdownLocator);
                languageLevelDropdown.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Language Level Dropdown not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, languageLevelBasicLocator, 2);
            try
            {
                if (languageLevel == "Fluent")
                {
                    languageLevelFluent = driver.FindElement(languageLevelFluentLocator);
                    languageLevelFluent.Click();
                }
                else if (languageLevel == "Conversational")
                {
                    languageLevelConversational = driver.FindElement(languageLevelConversationalLocator);
                    languageLevelConversational.Click();
                }
                else if (languageLevel == "Basic")
                {
                    languageLevelBasic = driver.FindElement(languageLevelBasicLocator);
                    languageLevelBasic.Click();
                }
                else
                {
                    languageLevelNative = driver.FindElement(languageLevelNativeLocator);
                    languageLevelNative.Click();
                }


            }
            catch (Exception ex)
            {
                Assert.Fail(" Language Level not located:" + ex.Message);
            }
        }




        public void AddLanguageOptionActions(IWebDriver driver, string language)
        {


            Wait.WaitToBeClickable(driver, addLanguageButtonLocator, 2);
            try
            {
                addLanguageButton = driver.FindElement(addLanguageButtonLocator);
                addLanguageButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(" Add Language Button not located:" + ex.Message);
            }

            // verify the toast message
            Wait.WaitToBeClickable(driver, toastMessageLocator, 1);
            try
            {
                toastMessage = driver.FindElement(toastMessageLocator);

                string messageText = toastMessage.Text;

                
                if (messageText == language + " has been added to your languages")
                {
                    Console.WriteLine("Toast message text is correct: " + messageText);
                }
                else
                {
                    Console.WriteLine("Toast message text is incorrect. Expected: Success, but found: " + messageText);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(" Language Add Toast message not located:" + ex.Message);
            }

        }



        public string GetAddedLanguage(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, addedLanguageLocator, 2);
            IWebElement addedLanguage = driver.FindElement(addedLanguageLocator); 
            return addedLanguage.Text;
        }

        public string GetAddedLanguageLevel(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, addedLanguageLevelLocator, 2);
            IWebElement addedLanguageLevel = driver.FindElement(addedLanguageLevelLocator);
            return addedLanguageLevel.Text;
        }



        public void UpdateLanguageActions(IWebDriver driver, string language)
        {
            Wait.WaitToBeClickable(driver, updateIconLocator, 2);
            try
            {
                updateIcon = driver.FindElement(updateIconLocator);
                updateIcon.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Update Icon not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, lastAddedLanguageLocator, 2);
            try
            {
                lastAddedLanguage = driver.FindElement(lastAddedLanguageLocator);
                lastAddedLanguage.Clear();
                lastAddedLanguage.SendKeys(language);
            }
            catch (Exception ex)
            {
                Assert.Fail("Last added language not located:" + ex.Message);
            }


        }

        public void UpdateLanguageLevelActions(IWebDriver driver, string languageLevel)
        {
            Wait.WaitToBeClickable(driver, lastAddedLanguageLevelDropdownLocator, 2);
            try
            {
                lastAddedLanguageLevelDropdown = driver.FindElement(lastAddedLanguageLevelDropdownLocator);
                lastAddedLanguageLevelDropdown.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Last Added Language Level Dropdown not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, lastAddedlanguageLevelBasicLocator, 2);
            try
            {
                if (languageLevel == "Fluent")
                {
                    lastAddedlanguageLevelFluent = driver.FindElement(lastAddedlanguageLevelFluentLocator);
                    lastAddedlanguageLevelFluent.Click();
                }
                else if (languageLevel == "Conversational")
                {
                    lastAddedlanguageLevelConversational = driver.FindElement(lastAddedlanguageLevelConversationalLocator);
                    lastAddedlanguageLevelConversational.Click();
                }
                else if (languageLevel == "Basic")
                {
                    lastAddedlanguageLevelBasic = driver.FindElement(lastAddedlanguageLevelBasicLocator);
                    lastAddedlanguageLevelBasic.Click();
                }
                else
                {
                    lastAddedlanguageLevelNative = driver.FindElement(lastAddedlanguageLevelNativeLocator);
                    lastAddedlanguageLevelNative.Click();
                }


            }
            catch (Exception ex)
            {
                Assert.Fail(" Last Added Language Level not located:" + ex.Message);
            }
        }

        public void UpdateLanguageOptionActions(IWebDriver driver, string language)
        {
            Wait.WaitToBeClickable(driver, updateButtonLocator, 2);
            try
            {
                updateButton = driver.FindElement(updateButtonLocator);
                updateButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Update Button not located:" + ex.Message);
            }

            // verify the toast message
            Wait.WaitToBeClickable(driver, toastMessageLocator, 1);
            try
            {
                toastMessage = driver.FindElement(toastMessageLocator);

                string messageText = toastMessage.Text;


                if (messageText == language + " has been updated to your languages")
                {
                    Console.WriteLine("Toast message text is correct: " + messageText);
                }
                else
                {
                    Console.WriteLine("Toast message text is incorrect. Expected: Success, but found: " + messageText);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(" Language Update Toast message not located:" + ex.Message);
            }
        }

        public string GetDeletedLanguage(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, deletedLanguageLocator, 2);
            IWebElement deletedLanguage = driver.FindElement(deletedLanguageLocator);
            return deletedLanguage.Text;
        }

        public void LanguageDeleteActions(IWebDriver driver, string deletedLanguageText)
        {
            Wait.WaitToBeClickable(driver, deleteButtonLocator, 2);
            try
            {
                deleteButton = driver.FindElement(deleteButtonLocator);
                deleteButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Delete Button not located:" + ex.Message);
            }

            // verify the toast message
            Wait.WaitToBeClickable(driver, toastMessageLocator, 1);
            try
            {
                toastMessage = driver.FindElement(toastMessageLocator);

                string messageText = toastMessage.Text;


                if (messageText == deletedLanguageText + " has been deleted from your languages")
                {
                    Console.WriteLine("Toast message text is correct: " + messageText);
                }
                else
                {
                    Console.WriteLine("Toast message text is incorrect. Expected: Success, but found: " + messageText);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(" Language Delete Toast message not located:" + ex.Message);
            }

        }
        public string GetExistingLanguage(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, existingLanguageLocator, 4);
            IWebElement existingLanguage = driver.FindElement(existingLanguageLocator);
            return existingLanguage.Text;
        }


    }
    }
