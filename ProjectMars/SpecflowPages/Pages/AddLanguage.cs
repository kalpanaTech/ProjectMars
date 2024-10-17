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

        private readonly By searchIconLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/i");
        IWebElement searchIcon;

        private readonly By categoryProgrammingLocator = By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[7]");
        IWebElement categoryProgramming;

        private readonly By subCategoryQALocator = By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[11]");
        IWebElement subCategoryQA;

        private readonly By userSearchBoxLocator = By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input");
        IWebElement userSearchBox;

        private readonly By firstSearchResultLocator = By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]/div/span");
        IWebElement firstSearchResult;

        private readonly By searchedUserProfiletLocator = By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div/div[1]/a[1]");
        IWebElement searchedUserProfile;

        private readonly By languagesTabProfilePageLocator = By.XPath("//A[@class = 'item' and @data-tab = 'second'][text() = 'Languages']");
        IWebElement languagesTabProfilePage;

        private readonly By addedLanguageProfilePageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/table/tbody/tr[last()]/td[1]");
        IWebElement addedLanguageProfilePage;

        private readonly By addedLanguageLevelProfilePageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/table/tbody/tr[last()]/td[2]");
        IWebElement addedLanguageLevelProfilePage;

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

        private readonly By existingLastLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        IWebElement existingLastLanguage;

        private readonly By existingLastLanguageLevelLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]");
        IWebElement existingLastLanguageLevel;

        private readonly By addLanguageCancelButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]");
        IWebElement addLanguageCancelButton;

        private readonly By updateLanguageCancelButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[2]");
        IWebElement updateLanguageCancelButton;

        
        private readonly By profileLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]");
        IWebElement profile;


        public void AddNewLanguageButtonActions(IWebDriver driver)
        {

            Wait.WaitToBeClickable(driver, languagesTabLocator, 2);
            try
            {
                driver.Navigate().Refresh();
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
        }
        public void AddLanguageActions(IWebDriver driver, string language)
        {
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

        public void AddLanguageLevelActions(IWebDriver driver, string languageLevel)
        {

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
                else if(languageLevel == "Native/Bilingual")
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




        public void AddLanguageButtonActions(IWebDriver driver)
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
        }

        public void VerifyToastMessageActions(IWebDriver driver, string language, string action)
        {

            Wait.WaitToBeClickable(driver, toastMessageLocator, 2);
            try
            {
                toastMessage = driver.FindElement(toastMessageLocator);

                string messageText = toastMessage.Text;

                if (action == "Add" || action == "AddExistingLanguageLevel")
                {

                    if (messageText == language + " has been added to your languages")
                    {
                        Console.WriteLine("Toast message text is correct: " + messageText);
                    }
                    else
                    {
                        Console.WriteLine("Toast message text is incorrect. Expected: Success, but found: " + messageText);
                    }
                }
                else if (action == "Update")
                {
                    if (messageText == language + " has been updated to your languages")
                    {
                        Console.WriteLine("Toast message text is correct: " + messageText);
                    }
                    else
                    {
                        Console.WriteLine("Toast message text is incorrect. Expected: Success, but found: " + messageText);
                    }
                }
                else if (action == "Delete")
                {
                    if (messageText == language + " has been deleted from your languages")
                    {
                        Console.WriteLine("Toast message text is correct: " + messageText);
                    }
                    else
                    {
                        Console.WriteLine("Toast message text is incorrect. Expected: Success, but found: " + messageText);
                    }
                }
                else if (action == "AddExistingLanguage")
                {
                    if (messageText == "This language is already exist in your language list.")
                    {
                        Console.WriteLine("Toast message text is correct: " + messageText);
                    }
                    else
                    {
                        Console.WriteLine("Toast message text is incorrect. Expected: Success, but found: " + messageText);
                    }
                }

                else if (action == "AddNull")
                {
                    if (messageText == "Please enter language and level")
                    {
                        Console.WriteLine("Toast message text is correct: " + messageText);
                    }
                    else
                    {
                        Console.WriteLine("Toast message text is incorrect. Expected: Success, but found: " + messageText);
                    }
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(" Language Add Toast message not located:" + ex.Message);
            }
        }
        public string GetAddedLanguage(IWebDriver driver)
        {

            Wait.WaitToBeVisible(driver, addedLanguageLocator, 2);
            IWebElement addedLanguage = driver.FindElement(addedLanguageLocator);
            return addedLanguage.Text;
        }

        public string GetAddedLanguageLevel(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, addedLanguageLevelLocator, 2);
            IWebElement addedLanguageLevel = driver.FindElement(addedLanguageLevelLocator);
            return addedLanguageLevel.Text;
        }

        public void ProfileOpenActions(IWebDriver driver, string user)
        {
            Wait.WaitToBeClickable(driver, searchIconLocator, 2);
            try
            {
                searchIcon = driver.FindElement(searchIconLocator);
                searchIcon.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Search Icon not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, categoryProgrammingLocator, 2);
            try
            {
                categoryProgramming = driver.FindElement(categoryProgrammingLocator);
                categoryProgramming.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Category Programming not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, subCategoryQALocator, 2);
            try
            {
                subCategoryQA = driver.FindElement(subCategoryQALocator);
                subCategoryQA.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Sub Category QA not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, userSearchBoxLocator, 2);
            try
            {
                userSearchBox = driver.FindElement(userSearchBoxLocator);
                userSearchBox.SendKeys(user);
            }
            catch (Exception ex)
            {
                Assert.Fail(" User Search Box not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, firstSearchResultLocator, 5);
            try
            {
                firstSearchResult = driver.FindElement(firstSearchResultLocator);
                firstSearchResult.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(" First Search Result not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, searchedUserProfiletLocator, 5);
            try
            {
                searchedUserProfile = driver.FindElement(searchedUserProfiletLocator);
                searchedUserProfile.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(" Searched User Profile not located:" + ex.Message);
            }
        }

        public void ViewAddedLanguageDetailsOnProfilePage(IWebDriver driver, string language, string languageLevel)
        {
            Wait.WaitToBeClickable(driver, languagesTabProfilePageLocator, 2);
            try
            {
                languagesTabProfilePage = driver.FindElement(languagesTabProfilePageLocator);
                languagesTabProfilePage.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(" Languages Tab of the Profile Page is not located:" + ex.Message);
            }
        }

        public string GetAddedLanguageProfilePage(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, addedLanguageProfilePageLocator, 2);
            IWebElement addedLanguageProfilePage = driver.FindElement(addedLanguageProfilePageLocator);
            return addedLanguageProfilePage.Text;
        }

        public string GetAddedLanguageLevelProfilePage(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, addedLanguageLevelProfilePageLocator, 2);
            IWebElement addedLanguageLevelProfilePage = driver.FindElement(addedLanguageLevelProfilePageLocator);
            return addedLanguageLevelProfilePage.Text;
        }

        public void RemoveAddedLanguageDetails(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, profileLocator, 2);
            try
            {
                profile = driver.FindElement(profileLocator);
                profile.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(" Profile Tab of the Profile Page is not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, languagesTabLocator, 2);
            try
            {
                driver.Navigate().Refresh();
                languagesTab = driver.FindElement(languagesTabLocator);
                languagesTab.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Language Tab not located:" + ex.Message);
            }

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
        }

        public void UpdateLanguageActions(IWebDriver driver, string language)
        {
            driver.Navigate().Refresh();

            Wait.WaitToBeClickable(driver, updateIconLocator, 5);
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

        public void UpdateLanguageOptionActions(IWebDriver driver)
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
        }

        public void LanguageDeleteActions(IWebDriver driver)
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

        }

        public string GetExistingLastLanguage(IWebDriver driver)
        {
            driver.Navigate().Refresh();

            Wait.WaitToBeVisible(driver, existingLastLanguageLocator, 6);
            IWebElement existingLastLanguage = driver.FindElement(existingLastLanguageLocator);
            return existingLastLanguage.Text;
        }
        public string GetExistingLastLanguageLevel(IWebDriver driver)
        {

            Wait.WaitToBeVisible(driver, existingLastLanguageLevelLocator, 2);
            IWebElement existingLastLanguageLevel = driver.FindElement(existingLastLanguageLevelLocator);
            return existingLastLanguageLevel.Text;
        }
        public void AddLanguageCancelButtonActions(IWebDriver driver)
        {

            Wait.WaitToBeClickable(driver, addLanguageCancelButtonLocator, 2);
            try
            {
                addLanguageCancelButton = driver.FindElement(addLanguageCancelButtonLocator);
                addLanguageCancelButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Add Language Cancel Button not located:" + ex.Message);
            }
        }
        public void UpdateLanguageCancelButtonActions(IWebDriver driver)
        {

            Wait.WaitToBeClickable(driver, updateLanguageCancelButtonLocator, 2);
            try
            {
                updateLanguageCancelButton = driver.FindElement(updateLanguageCancelButtonLocator);
                updateLanguageCancelButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Update Language Cancel Button not located:" + ex.Message);
            }
        }

        public void AddLanguageWithLongString(IWebDriver driver, string longLanguage, string languageLevel)
        {
            string longLanguageName = new string('A', 1000);  // 1000 'A' characters


          
        }


    }
}
