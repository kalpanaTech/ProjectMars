using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
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
    public class CreateProfile
    {
        private readonly By sharSkillLocator = By.XPath("//a[@class = 'ui basic green button'][text() = 'Share Skill']");
        IWebElement shareSkill;

        private readonly By titleTextBoxLocator = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input");
        IWebElement titleTextBox;

        private readonly By descriptionTextBoxLocator = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea");
        IWebElement descriptionTextBox;

        private readonly By categoryDropdownLocator = By.XPath("//select[@name = 'categoryId' and @class = 'ui fluid dropdown']");
        IWebElement categoryDropdown;

        private readonly By programmingCategorySelectLocator = By.XPath("//option[@value = '6'][text() = 'Programming & Tech']");
        IWebElement programmingCategorySelect;

        private readonly By subCategoryDropdownLocator = By.XPath("//select[@name = 'subcategoryId' and @class = 'ui fluid dropdown']");
        IWebElement subCategoryDropdown;

        private readonly By qaSubCategorySelecetLocator = By.XPath("//option[@value = '4'][text() = 'QA']");
        IWebElement qaSubCategorySelecet;

        private readonly By tagLocator = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input");
        IWebElement tag;

        private readonly By tagFieldLocator = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div[1]/div/div");
        IWebElement tagField;

        private readonly By hourlyBasisServiceTypeLocator = By.XPath("//input[@name = 'serviceType' and @value = '0']");
        IWebElement hourlyBasisServiceType;

        private readonly By oneOffServiceTypeLocator = By.XPath("//input[@name = 'serviceType' and @value = '1']");
        IWebElement oneOffServiceType;

        private readonly By onSiteLocationTypeLocator = By.XPath("//input[@name = 'locationType' and @value = '0']");
        IWebElement onSiteLocationType;

        private readonly By onLineLocationTypeLocator = By.XPath("//input[@name = 'locationType' and @value = '1']");
        IWebElement onLineLocationType;

        private readonly By endDatePickerLocator = By.XPath("//input[@name = 'endDate' and @placeholder = 'End date']");
        IWebElement endDatePicker;

        private readonly By skillExchangeTradeLocator = By.XPath("//input[@name = 'skillTrades' and @value = 'true']");
        IWebElement skillExchangeTrade;

        private readonly By creditTradeLocator = By.XPath("//input[@name = 'skillTrades' and @value = 'false']");
        IWebElement creditTrade;

        private readonly By skillExchangeTagLocator = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input");
        IWebElement skillExchangeTag; 

        private readonly By activeLocator = By.XPath("//input[@name = 'isActive' and @value = 'true']");
        IWebElement active;

        private readonly By hiddenLocator = By.XPath("//input[@name = 'isActive' and @value = 'false']");
        IWebElement hidden;

        private readonly By saveButtonLocator = By.XPath("//input[@type = 'button' and @value = 'Save']");
        IWebElement saveButton;

        public void CreateProfileActions(IWebDriver driver, string title, string description, string tags, string serviceType, string locationType, string skillTrade, string skillExchange, string endDate, string activeStatus)

        {
            Wait.WaitToBeClickable(driver, sharSkillLocator, 2);
            try
            {
                shareSkill = driver.FindElement(sharSkillLocator);
                shareSkill.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Share Skill not located:" + ex.Message);
            }


            Wait.WaitToBeClickable(driver, titleTextBoxLocator, 2);
            try
            {
                titleTextBox = driver.FindElement(titleTextBoxLocator);
                titleTextBox.SendKeys(title);
            }
            catch (Exception ex)
            {
                Assert.Fail("Title TextBox not located:" + ex.Message);
            }


            Wait.WaitToBeClickable(driver, descriptionTextBoxLocator, 2);
            try
            {
                descriptionTextBox = driver.FindElement(descriptionTextBoxLocator);
                descriptionTextBox.SendKeys(description);
            }
            catch (Exception ex)
            {
                Assert.Fail("Description TextBox not located:" + ex.Message);
            }


            Wait.WaitToBeClickable(driver, categoryDropdownLocator, 2);
            try
            {
                categoryDropdown = driver.FindElement(categoryDropdownLocator);
                categoryDropdown.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Category dropdown not located:" + ex.Message);
            }


            Wait.WaitToBeClickable(driver, programmingCategorySelectLocator, 2);
            try
            {
                programmingCategorySelect = driver.FindElement(programmingCategorySelectLocator);
                programmingCategorySelect.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Category Programming not located:" + ex.Message);
            }


            Wait.WaitToBeClickable(driver, subCategoryDropdownLocator, 2);
            try
            {
                subCategoryDropdown = driver.FindElement(subCategoryDropdownLocator);
                subCategoryDropdown.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Sub Category dropdown not located:" + ex.Message);
            }


            Wait.WaitToBeClickable(driver, qaSubCategorySelecetLocator, 2);
            try
            {
                qaSubCategorySelecet = driver.FindElement(qaSubCategorySelecetLocator);
                qaSubCategorySelecet.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Sub Category QA not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, tagLocator, 2);
            try
            {
                tag = driver.FindElement(tagLocator);
                tag.SendKeys(tags);
                tag.SendKeys(Keys.Enter);
            }
            catch (Exception ex)
            {
                Assert.Fail("tag not located:" + ex.Message);
            }


            Wait.WaitToBeClickable(driver, tagFieldLocator, 2);
            try
            {
                tagField = driver.FindElement(tagFieldLocator);
                tagField.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(" Tag Field not located:" + ex.Message);
            }


            Wait.WaitToBeClickable(driver, hourlyBasisServiceTypeLocator, 5);
            try
            {
                if (serviceType == "Hourly Basis")
                {
                    hourlyBasisServiceType = driver.FindElement(hourlyBasisServiceTypeLocator);
                    hourlyBasisServiceType.Click(); 
                }
                else
                {
                    oneOffServiceType = driver.FindElement(oneOffServiceTypeLocator);
                    oneOffServiceType.Click(); 
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Service Type not located:" + ex.Message);
            }


            Wait.WaitToBeClickable(driver, onSiteLocationTypeLocator, 2);
            try
            {
                if (serviceType == "On site")
                {
                    onSiteLocationType = driver.FindElement(onSiteLocationTypeLocator);
                    onSiteLocationType.Click();
                }
                else
                {
                    onLineLocationType = driver.FindElement(onLineLocationTypeLocator);
                    onLineLocationType.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Location Type not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, endDatePickerLocator, 2);
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                endDatePicker = driver.FindElement(endDatePickerLocator);

                js.ExecuteScript("arguments[0].setAttribute('value', '" + endDate + "')", endDatePicker);

            }
            catch (Exception ex)
            {
                Assert.Fail("End Date Picker not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, skillExchangeTradeLocator, 2);
            try
            {
                if (skillTrade == "Skill Exchange")
                {
                    skillExchangeTrade = driver.FindElement(skillExchangeTradeLocator);
                    skillExchangeTrade.Click();
                }
                else
                {
                    creditTrade = driver.FindElement(creditTradeLocator);
                    creditTrade.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Skill Trade not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, skillExchangeTagLocator, 2);
            try
            {
                skillExchangeTag = driver.FindElement(skillExchangeTagLocator);
                skillExchangeTag.SendKeys(skillExchange);
                skillExchangeTag.SendKeys(Keys.Enter);
            }
            catch (Exception ex)
            {
                Assert.Fail("Skill Exchange not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, activeLocator, 2);
            try
            {
                if (activeStatus == "Active")
                {
                    active = driver.FindElement(activeLocator);
                    active.Click();
                }
                else
                {
                    hidden = driver.FindElement(hiddenLocator);
                    hidden.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Active status not located:" + ex.Message);
            }


            Wait.WaitToBeClickable(driver, saveButtonLocator, 2);
            try
            {
                saveButton = driver.FindElement(saveButtonLocator);
                saveButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Save Button not located:" + ex.Message);
            }

        }

    }   
}
