using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using ProjectMars.SpecflowPages.Pages;
using ProjectMars.SpecflowPages.Helpers;
using OpenQA.Selenium;

namespace ProjectMars.Feature
{
    [Binding]
    public class Profile : Driver
    {
        SignIn signInPageObj = new SignIn();

        AddLanguage addNewLanguageButtonActionsObj = new AddLanguage();
        AddLanguage addLanguageObj = new AddLanguage();
        AddLanguage addLanguageLevelObj = new AddLanguage();
        AddLanguage addLanguageButtonActions = new AddLanguage();
        AddLanguage verifyToastMessageActionsObj = new AddLanguage();
        AddLanguage profileOpenActionsObj = new AddLanguage();  
        AddLanguage viewAddedLanguageDetailsOnProfilePageObj = new AddLanguage();
        AddLanguage removeAddedLanguageDetailsObj = new AddLanguage();
        AddLanguage updateLanguageActionsObj = new AddLanguage();
        AddLanguage updateLanguageLevelActionsObj = new AddLanguage();
        AddLanguage updateLanguageOptionActionsObj = new AddLanguage();
        AddLanguage languageDeleteActionsObj = new AddLanguage();
        AddLanguage addLanguageCancelButtonActionsObj = new AddLanguage();
        AddLanguage updateLanguageCancelButtonActionsObj = new AddLanguage();
        AddLanguage addLanguageWithLongStringObj = new AddLanguage();

        AddSkill addNewSkillButtonActionsObj = new AddSkill();  
        AddSkill addSkillActionsObj = new AddSkill();
        AddSkill addSkillLevelActionsObj = new AddSkill();
        AddSkill addSkillButtonActionsObj = new AddSkill();
        AddSkill verifyToastMessageSkillActionsObj = new AddSkill();
        AddSkill viewAddedSkillDetailsOnProfilePageObj = new AddSkill();
        AddSkill removeAddedSkillDetailsObj = new AddSkill();
        AddSkill updateSkillActionsObj = new AddSkill();
        AddSkill updateSkillLevelActionsObj = new AddSkill();
        AddSkill updateSkillOptionActionsObj = new AddSkill();
        AddSkill skillDeleteActionsObj = new AddSkill();
        AddSkill addSkillCancelButtonActionsObj = new AddSkill();
        AddSkill updateSkillCancelButtonActionsObj = new AddSkill();

        CreateProfile createProfileActionsObj = new CreateProfile();
       
        string deletedSkill;
        string canceledLanguage;

        [Given(@"I logged into profile page successfully")]
        public void GivenILoggedIntoProfilePageSuccessfully()
        {
            //open the Browser
            string browser = "chrome";
            driver = InitializeDriver(browser);
            signInPageObj.LoginActions(driver);
        }

        [When(@"I click on the Add New button")]
        public void GivenIClickOnTheAddNewButton()
        {
            addNewLanguageButtonActionsObj.AddNewLanguageButtonActions(driver);
        }


        [When(@"I add new '([^']*)' and '([^']*)' to Languages section")]
        public void GivenIAddNewAndToLanguagesSection(string language, string languageLevel)
        {
            if (language == "HugeLanguage")
            {
                language = new string('A', 1000);  // provide huge payload
            }

            addLanguageObj.AddLanguageActions(driver, language);
            addLanguageLevelObj.AddLanguageLevelActions(driver, languageLevel);
        }

        [Then(@"I click on the Add button")]
        public void ThenIClickOnTheAddButton()
        {
            addLanguageButtonActions.AddLanguageButtonActions(driver);
        }

    
        [Then(@"I can see the (added|updated|deleted) '([^']*)' on the toast message with the '([^']*)'")]
        public void ThenICanSeeTheAddedOnTheToastMessageWithThe(string option1,string language, string action)
        {
            verifyToastMessageActionsObj.VerifyToastMessageActions(driver, language, action);
        }


        [Then(@"I should be able to view the (added|updated) '([^']*)' and '([^']*)' on Languages section")]
        public void ThenIShouldBeAbleToViewTheAddedAndOnLanguagesSection(string option2, string language, string languageLevel)
        {
            if (language == "HugeLanguage")
            {
                language = new string('A', 1000); //Using inputh with a 1000 characters
            }

            string addedLanguage = addLanguageObj.GetAddedLanguage(driver);
            string addedLanguageLevel = addLanguageLevelObj.GetAddedLanguageLevel(driver);

            Console.WriteLine("Actual Language: " + addedLanguage);
            Console.WriteLine("Actual Language Level: " + addedLanguageLevel);

            Assert.That(addedLanguage == language, "Language has not been updated");
            Assert.That(addedLanguageLevel == languageLevel, "Language Level has not been updated");
        }

        [When(@"I open the '([^']*)' profile to view added (languages|skills)")]
        public void WhenIOpenTheProfileToViewAddedLanguages(string user, string option3)
        {
            profileOpenActionsObj.ProfileOpenActions(driver, user);
        }


        [Then(@"the people seeking for languages can see what '([^']*)' and '([^']*)' I hold")]
        public void ThenThePeopleSeekingForLanguagesCanSeeWhatAndIHold(string language, string languageLevel)
        {
            viewAddedLanguageDetailsOnProfilePageObj.ViewAddedLanguageDetailsOnProfilePage(driver, language, languageLevel);

            if (language == "HugeLanguage")
            {
                language = new string('A', 1000);
            }

            string addedLanguageProfilePage = viewAddedLanguageDetailsOnProfilePageObj.GetAddedLanguageProfilePage(driver);
            string addedLanguageLevelProfilePage = viewAddedLanguageDetailsOnProfilePageObj.GetAddedLanguageLevelProfilePage(driver);

            Assert.That(addedLanguageProfilePage == language, "Language is not showing to other users");
            Assert.That(addedLanguageLevelProfilePage == languageLevel, "Language Level is not showing to other users");

        }

        [Then(@"I remove added language details")]
        public void ThenIRemoveAddedLanguageDetails()
        {
            removeAddedLanguageDetailsObj.RemoveAddedLanguageDetails(driver);
        }


        [Given(@"I update existing '([^']*)' and '([^']*)' on Languages section")]
        public void GivenIUpdateExistingAndOnLanguagesSection(string language, string languageLevel)
        {
            updateLanguageActionsObj.UpdateLanguageActions(driver, language);
            updateLanguageLevelActionsObj.UpdateLanguageLevelActions(driver, languageLevel);
            
        }

        [Then(@"I click on the Update button")]
        public void ThenIClickOnTheUpdateButton()
        {
            updateLanguageOptionActionsObj.UpdateLanguageOptionActions(driver);
        }

        [When(@"I delete the added language")]
        public void WhenIDeleteTheAddedLanguage()
        {
            languageDeleteActionsObj.LanguageDeleteActions(driver);
        }
        
        [Then(@"I click on the cancel button")]
        public void ThenIClickOnTheCancelButton()
        {
            addLanguageCancelButtonActionsObj.AddLanguageCancelButtonActions(driver);
        }

        [Then(@"I can see the existing last added '([^']*)' on Languages section")]
        public void ThenICanSeeTheExistingLastAddedOnLanguagesSection(string language)
        {
            string existingLastLanguage = addLanguageCancelButtonActionsObj.GetExistingLastLanguage(driver);

            Console.WriteLine(" Language: " + language);
            Console.WriteLine("Existing Language: " + existingLastLanguage);

            Assert.That(language != existingLastLanguage, "Add language cancellation failed");
        }


        [Given(@"I click on the update cancellation buttion")]
        public void GivenIClickOnTheUpdateCancellationButtion()
        {
            updateLanguageCancelButtonActionsObj.UpdateLanguageCancelButtonActions(driver);
        }

        [Then(@"I can see the relevent '([^']*)' and '([^']*)' not updated on Languages section")]
        public void ThenICanSeeTheReleventAndNotUpdatedOnLanguagesSection(string language, string languageLevel)
        {
            string existingLastLanguage = updateLanguageCancelButtonActionsObj.GetExistingLastLanguage(driver);
            string existingLastLanguageLevel = updateLanguageCancelButtonActionsObj.GetExistingLastLanguageLevel(driver);

            Console.WriteLine("Language: " + language);
            Console.WriteLine("Existing Language: " + existingLastLanguage);

            Assert.That(language != existingLastLanguage, "Language update cancellation failed");
            Assert.That(languageLevel != existingLastLanguageLevel, "Language update cancellation failed");
        }

        [Given(@"I add a '([^']*)' and '([^']*)' to Languages section")]
        public void GivenIAddALongLanguageAndToLanguagesSection(string longLanguage, string languageLevel)
        {
            addLanguageWithLongStringObj.AddLanguageWithLongString(driver, longLanguage, languageLevel);
        }


        [When(@"I click on the Add New Skill button")]
        public void GivenIClickOnTheAddNewSkillButton()
        {
            addNewSkillButtonActionsObj.AddNewSkillButtonActions(driver);
        }


        [When(@"I add new '([^']*)' and '([^']*)' to Skills section")]
        public void GivenIAddNewAndToSkillsSection(string skill, string skillLevel)
        {
            if (skill == "HugeSkill")
            {
                skill = new string('A', 1000);  // provide huge payload
            }

            addSkillActionsObj.AddSkillActions(driver, skill);
            addSkillLevelActionsObj.AddSkillLevelActions(driver, skillLevel);
        }

        [Then(@"I click on the Add Skill button")]
        public void ThenIClickOnTheAddSkillButton()
        {
            addSkillButtonActionsObj.AddSkillButtonActions(driver);
        }

        [Then(@"I can see the (added|updated|deleted) '([^']*)' on the skill related toast message with the '([^']*)'")]
        public void ThenICanSeeTheAddedOnTheSkillRelatedToastMessageWithThe(string options4, string skill, string action1)
        {
            verifyToastMessageSkillActionsObj.VerifyToastMessageSkillActions(driver, skill, action1);
        }


        [Then(@"I should be able to view the (added|updated) '([^']*)' and '([^']*)' on Skills section")]
        public void ThenIShouldBeAbleToViewTheAddedAndOnSkillsSection(string option, string skill, string skillLevel)
        {
            if (skill == "HugeSkill")
            {
                skill = new string('A', 1000);  // provide huge payload
            }

            string addedSkill = addSkillActionsObj.GetAddedSkill(driver);
            string addedSkillLevel = addSkillLevelActionsObj.GetAddedSkillLevel(driver);

            Console.WriteLine("Actual Language: " + addedSkill);

            Assert.That(addedSkill == skill, "Skill has not been updated");
            Assert.That(addedSkillLevel == skillLevel, "Skill Level has not been updated");
        }

        [Then(@"the people seeking for skills can see what '([^']*)' and '([^']*)' I hold")]
        public void ThenThePeopleSeekingForSkillsCanSeeWhatAndIHold(string skill, string skillLevel)
        {
            viewAddedSkillDetailsOnProfilePageObj.ViewAddedSkillDetailsOnProfilePage(driver, skill, skillLevel);

            if (skill == "HugeSkill")
            {
                skill = new string('A', 1000);  // provide huge payload
            }

            string addedSkillProfilePage = viewAddedSkillDetailsOnProfilePageObj.GetAddedSkillProfilePage(driver);
            string addedSkillLevelProfilePage = viewAddedSkillDetailsOnProfilePageObj.GetAddedSkillLevelProfilePage(driver);

            Assert.That(addedSkillProfilePage == skill, "Skill is not showing to other users");
            Assert.That(addedSkillLevelProfilePage == skillLevel, "Skill Level is not showing to other users");
        }

        [Then(@"I remove added skill details")]
        public void ThenIRemoveAddedSkillDetails()
        {
            removeAddedSkillDetailsObj.RemoveAddedSkillDetails(driver);
        }


        [Given(@"I update existing '([^']*)' and '([^']*)' on Skills section")]
        public void GivenIUpdateExistingAndOnSkillsSection(string skill, string skillLevel)
        {
            updateSkillActionsObj.UpdateSkillActions(driver, skill);
            updateSkillLevelActionsObj.UpdateSkillLevelActions(driver, skillLevel);
            
        }

        [Then(@"I click on the skill update button")]
        public void ThenIClickOnTheSkillUpdateButton()
        {
            updateSkillOptionActionsObj.UpdateSkillOptionActions(driver);
        }


        [When(@"I delete the added skill")]
        public void WhenIDeleteTheAddedSkill()
        {
            skillDeleteActionsObj.SkillDeleteActions(driver);
        }

        [Then(@"I click on the skill add cancel button")]
        public void ThenIClickOnTheSkillAddCancelButton()
        {
            addSkillCancelButtonActionsObj.AddSkillCancelButtonActions(driver);
        }

        [Then(@"I can see the existing last added '([^']*)' on the Skill section")]
        public void ThenICanSeeTheExistingLastAddedOnTheSkillSection(string skill)
        {
            string existingLastSkill = addSkillCancelButtonActionsObj.GetExistingLastSkill(driver);

            Console.WriteLine("Skill: " + skill);
            Console.WriteLine("Existing Skill: " + existingLastSkill);

            Assert.That(skill != existingLastSkill, "Add skill cancellation failed");
        }


        [Given(@"I click on the update skill cancellation button")]
        public void GivenIClickOnTheUpdateSkillCancellationButtion()
        {
            updateSkillCancelButtonActionsObj.UpdateSkillCancelButtonActions(driver);
        }

        [Then(@"I can see the relevent '([^']*)' and '([^']*)' not updated on Skills section")]
        public void ThenICanSeeTheReleventAndNotUpdatedOnSkillsSection(string skill, string skillLevel)
        {
            string existingLastSkill = updateSkillCancelButtonActionsObj.GetExistingLastSkill(driver);
            string existingLastSkillLevel = updateSkillCancelButtonActionsObj.GetExistingLastSkillLevel(driver);

            Console.WriteLine("Skill: " + skill);
            Console.WriteLine("Existing Skill: " + existingLastSkill);

            Assert.That(skill != existingLastSkill, "Skill update cancellation failed");
            Assert.That(skill != existingLastSkillLevel, "Skill update cancellation failed");
        }


        //User create profile
        //[Given(@"I provide '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)' and '([^']*)' on Service Listning page")]
        // public void GivenIProvideAndOnServiceListningPage(string title, string description, string tags, string serviceType, string locationType, string skillTrade, string skillExchange, string endDate, string activeStatus)
        //  {
        //     createProfileActionsObj.CreateProfileActions(driver, title, description, tags, serviceType, locationType, skillTrade, skillExchange, endDate, activeStatus);
        // }


        [AfterScenario]

        public void CloseTestRun()
        {
           driver.Quit();
        }

    }
}
