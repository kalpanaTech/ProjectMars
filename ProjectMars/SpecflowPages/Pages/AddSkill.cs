using NUnit.Framework;
using NUnit.Framework.Interfaces;
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
    public class AddSkill
    {
        private readonly By skillsTabLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]");
        IWebElement skillsTab;

        private readonly By addNewSkillButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");
        IWebElement addNewSkillButton;

        private readonly By addSkillTextBoxLocator = By.XPath("//input[@placeholder = 'Add Skill' and @type = 'text']");
        IWebElement addSkillTextBox;

        private readonly By skillLevelDropdownLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select");
        IWebElement skillLevelDropdown;

        private readonly By skillLevelBeginnerLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]");
        IWebElement skillLevelBeginner;

        private readonly By skillLevelIntermediateLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]");
        IWebElement skillLevelIntermediate;

        private readonly By skillLevelExpertLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]");
        IWebElement skillLevelExpert;

        private readonly By addSkillButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]");
        IWebElement addSkillButton;
       
        private readonly By toastMessageLocator = By.XPath("//div[@class = 'ns-box-inner']");
        IWebElement toastMessage;

        private readonly By addedSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        IWebElement addedSkill;

        private readonly By addedSkillLevelLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]");
        IWebElement addedSkillLevel;

        private readonly By skillsTabProfilePageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]");
        IWebElement skillsTabProfilePage;

        private readonly By addedSkillProfilePageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/table/tbody/tr[last()]/td[1]");
        IWebElement addedSkillProfilePage;

        private readonly By addedSkillLevelProfilePageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/table/tbody/tr[last()]/td[2]");
        IWebElement addedSkillLevelProfilePage;




        private readonly By updateSkillIconLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i");
        IWebElement updateSkillIcon;                             

        private readonly By lastAddedSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input");
        IWebElement lastAddedSkill;


        private readonly By lastAddedSkillLevelDropdownLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select");
        IWebElement lastAddedSkillLevelDropdown;

        private readonly By lastAddedSkillLevelBeginnerLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[2]");
        IWebElement lastAddedSkillLevelBeginner; 

        private readonly By lastAddedSkillLevelIntermediateLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[3]");
        IWebElement lastAddedSkillLevelIntermediate;

        private readonly By lastAddedSkillLevelExpertLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[4]");
        IWebElement lastAddedSkillLevelExpert;

        private readonly By updateSkillButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]");
        IWebElement updateSkillButton;


        private readonly By deleteSkillButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i");
        IWebElement deleteSkillButton;

        private readonly By deletedSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        IWebElement deletedSkill;

        private readonly By existingSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        IWebElement existingSkill;



        public void AddSkillActions(IWebDriver driver, string skill)

        {
            Wait.WaitToBeClickable(driver, skillsTabLocator, 2);
            try
            {
                skillsTab = driver.FindElement(skillsTabLocator);
                skillsTab.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Skills Tab not located:" + ex.Message);
            }


            Wait.WaitToBeClickable(driver, addNewSkillButtonLocator, 2);
            try
            {
                addNewSkillButton = driver.FindElement(addNewSkillButtonLocator);
                addNewSkillButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Add New Skill Button not located:" + ex.Message);
            }


            Wait.WaitToBeClickable(driver, addSkillTextBoxLocator, 2);
            try
            {
                addSkillTextBox = driver.FindElement(addSkillTextBoxLocator);
                addSkillTextBox.SendKeys(skill);
            }
            catch (Exception ex)
            {
                Assert.Fail("Add Skill TextBox not located:" + ex.Message);
            }
        }



        public void AddSkillLevelActions(IWebDriver driver, string skillLevel)
        {

            Wait.WaitToBeClickable(driver, skillLevelDropdownLocator, 2);
            try
            {
                skillLevelDropdown = driver.FindElement(skillLevelDropdownLocator);
                skillLevelDropdown.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Skill Level Dropdown not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, skillLevelBeginnerLocator, 2);
            try
            {
                if (skillLevel == "Beginner")
                {
                    skillLevelBeginner = driver.FindElement(skillLevelBeginnerLocator);
                    skillLevelBeginner.Click();
                }
                else if (skillLevel == "Intermediate")
                {
                    skillLevelIntermediate = driver.FindElement(skillLevelIntermediateLocator);
                    skillLevelIntermediate.Click();
                }
                else
                {
                    skillLevelExpert = driver.FindElement(skillLevelExpertLocator);
                    skillLevelExpert.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(" Skill Level not located:" + ex.Message);
            }
        }

        public void AddSkillOptionActions(IWebDriver driver, string skill)
        {


            Wait.WaitToBeClickable(driver, addSkillButtonLocator, 2);
            try
            {
                addSkillButton = driver.FindElement(addSkillButtonLocator);
                addSkillButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(" Add Skill Button not located:" + ex.Message);
            }

            // verify the toast message
            Wait.WaitToBeClickable(driver, toastMessageLocator, 1);
            try
            {
                toastMessage = driver.FindElement(toastMessageLocator);

                string messageText = toastMessage.Text;


                if (messageText == skill + " has been added to your skills")
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
                Assert.Fail(" Skill Add Toast message not located:" + ex.Message);
            }


        }

        public string GetAddedSkill(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, addedSkillLocator, 2);
            IWebElement addedSkill = driver.FindElement(addedSkillLocator);
            return addedSkill.Text;
        }

        public string GetAddedSkillLevel(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, addedSkillLevelLocator, 2);
            IWebElement addedSkillLevel = driver.FindElement(addedSkillLevelLocator);
            return addedSkillLevel.Text;
        }

        public void ViewAddedSkillDetailsOnProfilePage(IWebDriver driver, string skill, string skillLevel)
        {
            Wait.WaitToBeClickable(driver, skillsTabProfilePageLocator, 2);
            try
            {
                skillsTabProfilePage = driver.FindElement(skillsTabProfilePageLocator);
                skillsTabProfilePage.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Skills Tab of the Profile Page is not located:" + ex.Message);
            }
        }

        public string GetAddedSkillProfilePage(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, addedSkillProfilePageLocator, 2);
            IWebElement addedSkillProfilePage = driver.FindElement(addedSkillProfilePageLocator);
            return addedSkillProfilePage.Text;
        }

        public string GetAddedSkillLevelProfilePage(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, addedSkillLevelProfilePageLocator, 2);
            IWebElement addedSkillLevelProfilePage = driver.FindElement(addedSkillLevelProfilePageLocator);
            return addedSkillLevelProfilePage.Text;
        }

        public void UpdateSkillActions(IWebDriver driver, string skill)
        {
            Wait.WaitToBeClickable(driver, skillsTabLocator, 2);
            try
            {
                skillsTab = driver.FindElement(skillsTabLocator);
                skillsTab.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Skills Tab not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, updateSkillIconLocator, 2);
            try
            {
                updateSkillIcon = driver.FindElement(updateSkillIconLocator);
                updateSkillIcon.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Update Skill Icon not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, lastAddedSkillLocator, 2);
            try
            {
                lastAddedSkill = driver.FindElement(lastAddedSkillLocator);
                lastAddedSkill.Clear();
                lastAddedSkill.SendKeys(skill);
            }
            catch (Exception ex)
            {
                Assert.Fail("Last added skill not located:" + ex.Message);
            }

        }

        public void UpdateSkillLevelActions(IWebDriver driver, string skillLevel)
        {
            Wait.WaitToBeClickable(driver, lastAddedSkillLevelDropdownLocator, 2);
            try
            {
                lastAddedSkillLevelDropdown = driver.FindElement(lastAddedSkillLevelDropdownLocator);
                lastAddedSkillLevelDropdown.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Last Added Skill Level Dropdown not located:" + ex.Message);
            }

            Wait.WaitToBeClickable(driver, lastAddedSkillLevelBeginnerLocator, 2);
            try
            {
                if (skillLevel == "Beginner")
                {
                    lastAddedSkillLevelBeginner = driver.FindElement(lastAddedSkillLevelBeginnerLocator);
                    lastAddedSkillLevelBeginner.Click();
                }
                else if (skillLevel == "Intermediate")
                {
                    lastAddedSkillLevelIntermediate = driver.FindElement(lastAddedSkillLevelIntermediateLocator);
                    lastAddedSkillLevelIntermediate.Click();
                }
                else
                {
                    lastAddedSkillLevelExpert = driver.FindElement(lastAddedSkillLevelExpertLocator);
                    lastAddedSkillLevelExpert.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(" Skill Level not located:" + ex.Message);
            }

        }

        public void UpdateSkillOptionActions(IWebDriver driver, string skill )
        {
            Wait.WaitToBeClickable(driver, updateSkillButtonLocator, 2);
            try
            {
                updateSkillButton = driver.FindElement(updateSkillButtonLocator);
                updateSkillButton.Click();
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


                if (messageText == skill + " has been updated to your skills")
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
                Assert.Fail(" Skill Update Toast message not located:" + ex.Message);
            }
        }

        // Method to get the skill that will be deleted
        public string GetDeletedSkill(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, skillsTabLocator, 2);
            try
            {
                skillsTab = driver.FindElement(skillsTabLocator);
                skillsTab.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Skills Tab not located:" + ex.Message);
            }

            Wait.WaitToBeVisible(driver, deletedSkillLocator, 2);
            IWebElement deletedSkill = driver.FindElement(deletedSkillLocator);
            return deletedSkill.Text;
        }

        // Method to handle the skill delete action and verify the toast message
        public void SkillDeleteActions(IWebDriver driver, string deletedSkillText)
        {

            Wait.WaitToBeClickable(driver, deleteSkillButtonLocator, 2);
            try
            {
                deleteSkillButton = driver.FindElement(deleteSkillButtonLocator);
                deleteSkillButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Delete Skill Button not located:" + ex.Message);
            }

            //verify the toast message
            Wait.WaitToBeClickable(driver, toastMessageLocator, 1);
            try
            {
            toastMessage = driver.FindElement(toastMessageLocator);

            string messageText = toastMessage.Text;


            if (messageText == deletedSkillText + " has been deleted from your skills")
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
             Assert.Fail(" Skill Delete Toast message not located:" + ex.Message);
            }
        }

        // Method to get the existing skill to verify it against the deleted skill
        public string GetExistingSkill(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, existingSkillLocator, 2);
            IWebElement existingSkill = driver.FindElement(existingSkillLocator);
            return existingSkill.Text;
        }

    }
}
