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

        AddLanguage addLanguageObj = new AddLanguage();
        AddLanguage addLanguageLevelObj = new AddLanguage();
        AddLanguage addLanguageOptionObj = new AddLanguage();

        AddLanguage profileOpenActionsObj = new AddLanguage();  

        AddLanguage viewAddedLanguageDetailsOnProfilePageObj = new AddLanguage();

        AddLanguage updateLanguageActionsObj = new AddLanguage();
        AddLanguage updateLanguageLevelActionsObj = new AddLanguage();
        AddLanguage updateLanguageOptionActionsObj = new AddLanguage();

        AddLanguage languageDeleteActionsObj = new AddLanguage();

        AddSkill addSkillActionsObj = new AddSkill();
        AddSkill addSkillLevelActionsObj = new AddSkill();
        AddSkill addSkillOptionActionsObj = new AddSkill();

        AddSkill viewAddedSkillDetailsOnProfilePageObj = new AddSkill();

        AddSkill updateSkillActionsObj = new AddSkill();
        AddSkill updateSkillLevelActionsObj = new AddSkill();
        AddSkill updateSkillOptionActionsObj = new AddSkill();

        AddSkill skillDeleteActionsObj = new AddSkill();

        CreateProfile createProfileActionsObj = new CreateProfile();

        string deletedLanguage;
        string deletedSkill;

        [Given(@"I logged into profile page successfully")]
        public void GivenILoggedIntoProfilePageSuccessfully()
        {
            //open Chrome Browser
            driver = new ChromeDriver();
            signInPageObj.LoginActions(driver);
        }

        [Given(@"I add new '([^']*)' and '([^']*)' to Languages section")]
        public void GivenIAddNewAndToLanguagesSection(string language, string languageLevel)
        {
            addLanguageObj.AddLanguageActions(driver, language);
            addLanguageLevelObj.AddLanguageLevelActions(driver, languageLevel);
            addLanguageOptionObj.AddLanguageOptionActions(driver, language);
        }


        [Then(@"I should be able to view the (added|updated) '([^']*)' and '([^']*)' on Languages section")]
        public void ThenIShouldBeAbleToViewTheAddedAndOnLanguagesSection(string option, string language, string languageLevel)
        {

            string addedLanguage = addLanguageObj.GetAddedLanguage(driver);
            string addedLanguageLevel = addLanguageLevelObj.GetAddedLanguageLevel(driver);

            Assert.That(addedLanguage == language, "Language has not been updated");
            Assert.That(addedLanguageLevel == languageLevel, "Language Level has not been updated");
        }

        [When(@"I open the '([^']*)' profile to view added (languages|skills)")]
        public void WhenIOpenTheProfileToViewAddedLanguages(string user, string options)
        {
            profileOpenActionsObj.ProfileOpenActions(driver, user);
        }


        [Then(@"the people seeking for languages can see what '([^']*)' and '([^']*)' I hold")]
        public void ThenThePeopleSeekingForLanguagesCanSeeWhatAndIHold(string language, string languageLevel)
        {
            viewAddedLanguageDetailsOnProfilePageObj.ViewAddedLanguageDetailsOnProfilePage(driver, language, languageLevel);

            string addedLanguageProfilePage = viewAddedLanguageDetailsOnProfilePageObj.GetAddedLanguageProfilePage(driver);
            string addedLanguageLevelProfilePage = viewAddedLanguageDetailsOnProfilePageObj.GetAddedLanguageLevelProfilePage(driver);

            Assert.That(addedLanguageProfilePage == language, "Language is not showing to other users");
            Assert.That(addedLanguageLevelProfilePage == languageLevel, "Language Level is not showing to other users");

        }


        [Given(@"I update existing '([^']*)' and '([^']*)' on Languages section")]
        public void GivenIUpdateExistingAndOnLanguagesSection(string language, string languageLevel)
        {
            updateLanguageActionsObj.UpdateLanguageActions(driver, language);
            updateLanguageLevelActionsObj.UpdateLanguageLevelActions(driver, languageLevel);
            updateLanguageOptionActionsObj.UpdateLanguageOptionActions(driver, language);
        }

        [When(@"I delete an existing language")]
        public void WhenIDeleteAnExistingLanguage()
        {
            languageDeleteActionsObj.GetDeletedLanguage(driver);
            languageDeleteActionsObj.LanguageDeleteActions(driver, deletedLanguage);
        }

        [Then(@"the deleted language should not be similar to existing language")]
        public void ThenTheDeletedLanguageShouldNotBeSimilarToExistingLanguage()
        {
          
            string existingLanguage = languageDeleteActionsObj.GetExistingLanguage(driver);

            Assert.That(deletedLanguage != existingLanguage, "Language has not been deleted");
        }

        [Given(@"I add new '([^']*)' and '([^']*)' to Skills section")]
        public void GivenIAddNewAndToSkillsSection(string skill, string skillLevel)
        {
            addSkillActionsObj.AddSkillActions(driver, skill);
            addSkillLevelActionsObj.AddSkillLevelActions(driver, skillLevel);
            addSkillOptionActionsObj.AddSkillOptionActions(driver, skill);
        }

        [Then(@"I should be able to view the (added|updated) '([^']*)' and '([^']*)' on Skills section")]
        public void ThenIShouldBeAbleToViewTheAddedAndOnSkillsSection(string option, string skill, string skillLevel)
        {
            string addedSkill = addSkillActionsObj.GetAddedSkill(driver);
            string addedSkillLevel = addSkillLevelActionsObj.GetAddedSkillLevel(driver);

            Assert.That(addedSkill == skill, "Skill has not been updated");
            Assert.That(addedSkillLevel == skillLevel, "Skill Level has not been updated");
        }

        [Then(@"the people seeking for skills can see what '([^']*)' and '([^']*)' I hold")]
        public void ThenThePeopleSeekingForSkillsCanSeeWhatAndIHold(string skill, string skillLevel)
        {
            viewAddedSkillDetailsOnProfilePageObj.ViewAddedSkillDetailsOnProfilePage(driver, skill, skillLevel);

            string addedSkillProfilePage = viewAddedSkillDetailsOnProfilePageObj.GetAddedSkillProfilePage(driver);
            string addedSkillLevelProfilePage = viewAddedSkillDetailsOnProfilePageObj.GetAddedSkillLevelProfilePage(driver);

            Assert.That(addedSkillProfilePage == skill, "Skill is not showing to other users");
            Assert.That(addedSkillLevelProfilePage == skillLevel, "Skill Level is not showing to other users");
        }


        [Given(@"I update existing '([^']*)' and '([^']*)' on Skills section")]
        public void GivenIUpdateExistingAndOnSkillsSection(string skill, string skillLevel)
        {
            updateSkillActionsObj.UpdateSkillActions(driver, skill);
            updateSkillLevelActionsObj.UpdateSkillLevelActions(driver, skillLevel);
            updateSkillOptionActionsObj.UpdateSkillOptionActions(driver, skill);
        }

        [When(@"I delete an existing skill")]
        public void WhenIDeleteAnExistingSkill()
        {
            skillDeleteActionsObj.GetDeletedSkill(driver);
            skillDeleteActionsObj.SkillDeleteActions(driver, deletedSkill);
        }

        [Then(@"the deleted skill should not be similar to existing skill")]
        public void ThenTheDeletedSkillShouldNotBeSimilarToExistingSkill()
        {
            string existingSkill = skillDeleteActionsObj.GetExistingSkill(driver);

            Assert.That(deletedSkill != existingSkill, "Skill has not been deleted");
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
