using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.SpecflowPages.Helpers;
using ProjectMars.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.SpecflowPages.Utils
{
    //[Parallelizable]
    [TestFixture]
    public class Start : Driver
    {
        [SetUp]
        public void SetUpStatus()
        {
            //open Chrome Browser
            driver = new ChromeDriver();

            //Login page object initialization and definition
            SignIn signInObj = new SignIn();
            signInObj.LoginActions(driver);
        }
        [Test, Order(1), Description("This test will be verified the Language Adding process")]
        
        public void AddLanguage_Start()
        {
            AddLanguage addNewLanguageButtonActionsObj = new AddLanguage();
            addNewLanguageButtonActionsObj.AddNewLanguageButtonActions(driver);

            AddLanguage addLanguagePageObj = new AddLanguage();
            addLanguagePageObj.AddLanguageActions(driver, "");

            AddLanguage addLanguageLevelObj = new AddLanguage();
            addLanguageLevelObj.AddLanguageLevelActions(driver, "");
           
            AddLanguage addLanguageOptionObj = new AddLanguage();
            addLanguageOptionObj.AddLanguageButtonActions(driver);

            AddLanguage verifyToastMessageActionsObj = new AddLanguage();
            verifyToastMessageActionsObj.VerifyToastMessageActions(driver, "", "");

            AddLanguage profileOpenActionsObj = new AddLanguage();
            profileOpenActionsObj.ProfileOpenActions(driver, "");

            AddLanguage viewAddedLanguageDetailsOnProfilePageObj = new AddLanguage();
            viewAddedLanguageDetailsOnProfilePageObj.ViewAddedLanguageDetailsOnProfilePage(driver, "", "");
        }

        [Test, Order(2), Description("This test will be verified the Language Updating process")]

        public void UpdateLanguage_Start()
        {
            AddLanguage updateLanguageActionsObj = new AddLanguage();
            updateLanguageActionsObj.UpdateLanguageActions(driver, "");

            AddLanguage updateLanguageLevelActionsObj = new AddLanguage();
            updateLanguageLevelActionsObj.UpdateLanguageLevelActions(driver, "");

            AddLanguage updateLanguageOptionActionsObj = new AddLanguage();
            updateLanguageOptionActionsObj.UpdateLanguageOptionActions(driver);
        }

        [Test, Order(3), Description("This test will be verified the Language Deleting process")]
        public void DeleteLanguage_Start()
        {
            AddLanguage languageDeleteActionsObj = new AddLanguage();
            languageDeleteActionsObj.LanguageDeleteActions(driver);
        }

        [Test, Order(3), Description("This test will be verified the Language Deleting process")]
        public void CancelLanguage_Start()
        {
            AddLanguage addLanguageCancelButtonActionsObj = new AddLanguage();
            addLanguageCancelButtonActionsObj.AddLanguageCancelButtonActions(driver);
        }

        [Test, Order(4), Description("This test will be verified the update language cancellation process")]
        public void UpdateLanguageCancellation_Start()
        {
            AddLanguage updateLanguageCancelButtonActionsObj = new AddLanguage();
            updateLanguageCancelButtonActionsObj.UpdateLanguageCancelButtonActions(driver);
        }


        [Test, Order(5), Description("This test will be verified the Skill Add process")]
        public void AddSkill_Start()
        {
            AddSkill addNewSkillButtonActionsObj = new AddSkill();
            addNewSkillButtonActionsObj.AddNewSkillButtonActions(driver);

            AddSkill addSkillActionsObj = new AddSkill();
            addSkillActionsObj.AddSkillActions(driver, "");

            AddSkill addSkillLevelActionsObj = new AddSkill();
            addSkillLevelActionsObj.AddSkillLevelActions(driver, "");

            AddSkill addSkillButtonActionsObj = new AddSkill();
            addSkillButtonActionsObj.AddSkillButtonActions(driver);

            AddSkill verifyToastMessageSkillActionsObj = new AddSkill();
            verifyToastMessageSkillActionsObj.VerifyToastMessageSkillActions(driver, "", "");

            AddSkill viewAddedSkillDetailsOnProfilePageObj = new AddSkill();
            viewAddedSkillDetailsOnProfilePageObj.ViewAddedSkillDetailsOnProfilePage(driver, "", "");


        }

        [Test, Order(6), Description("This test will be verified the Skill Updating process")]

        public void UpdateSkill_Start()
        {
            AddSkill updateSkillActionsObj = new AddSkill();
            updateSkillActionsObj.UpdateSkillActions(driver, "");

            AddSkill updateSkillLevelActionsObj = new AddSkill();
            updateSkillLevelActionsObj.UpdateSkillLevelActions(driver, "");

            AddSkill updateSkillOptionActionsObj = new AddSkill();
            updateSkillOptionActionsObj.UpdateSkillOptionActions(driver);
        }

        [Test, Order(7), Description("This test will be verified the Skill Deleting process")]
        public void DeleteSkill_Start()
        {
            AddSkill skillDeleteActionsObj = new AddSkill();
            skillDeleteActionsObj.SkillDeleteActions(driver);
        }

        [Test, Order(8), Description("This test will be verified the Add Skill cancellation process")]
        public void CancelSkill_Start()
        {
            AddSkill addSkillCancelButtonActionsObj = new AddSkill();
            addSkillCancelButtonActionsObj.AddSkillCancelButtonActions(driver);
        }

        [Test, Order(9), Description("This test will be verified the update skill cancellation process")]
        public void UpdateSkillCancellation_Start()
        {
            AddSkill updateSkillCancelButtonActionsObj = new AddSkill();
            updateSkillCancelButtonActionsObj.UpdateSkillCancelButtonActions(driver);

        }



        //[Test, Order(7), Description("This test will be verified the creating profile process")]
        // public void CreateProfile_Start()
        // {
        //    CreateProfile createProfileActionsObj = new CreateProfile();
        //   createProfileActionsObj.CreateProfileActions(driver, "", "", "", "", "", "", "", "", "" );
        // }



        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
