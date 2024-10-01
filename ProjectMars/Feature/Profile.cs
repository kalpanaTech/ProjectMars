using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using ProjectMars.SpecflowPages.Pages;
using ProjectMars.SpecflowPages.Helpers;

namespace ProjectMars.Feature
{
    [Binding]
    public class Profile : Driver
    {
        SignIn signInPageObj = new SignIn();
        AddLanguage addLanguageObj = new AddLanguage();
        AddLanguage addLanguageLevelObj = new AddLanguage();
        AddLanguage addLanguageOptionObj = new AddLanguage();

        AddLanguage updateLanguageActionsObj = new AddLanguage();
        AddLanguage updateLanguageLevelActionsObj = new AddLanguage();
        AddLanguage updateLanguageOptionActionsObj = new AddLanguage();

        AddLanguage languageDeleteActionsObj = new AddLanguage();

        string deletedLanguage;

        [Given(@"I logged into profile page successfully")]
        public void GivenILoggedIntoProfilePageSuccessfully()
        {
            //open Chrome Browser
            driver = new ChromeDriver();
            signInPageObj.LoginActions(driver);
        }

        [Given(@"I add new '([^']*)' and '([^']*)'")]
        public void GivenIAddNewAnd(string language, string languageLevel)
        {
            addLanguageObj.AddLanguageActions(driver, language);
            addLanguageLevelObj.AddLanguageLevelActions(driver, languageLevel);
            addLanguageOptionObj.AddLanguageOptionActions(driver, language);
        }

        [Then(@"I should be able to view the (added|updated) '([^']*)' and '([^']*)'")]
        public void ThenIShouldBeAbleToViewTheAddedAnd(string option, string language, string languageLevel)
        {

            string addedLanguage = addLanguageObj.GetAddedLanguage(driver);
            string addedLanguageLevel = addLanguageLevelObj.GetAddedLanguageLevel(driver);

            Assert.That(addedLanguage == language, "Language has not been updated");
            Assert.That(addedLanguageLevel == languageLevel, "Language Level has not been updated");
        }


        [Given(@"I update existing '([^']*)' and '([^']*)'")]
        public void GivenIUpdateExistingAnd(string language, string languageLevel)
        {
            updateLanguageActionsObj.UpdateLanguageActions(driver, language);
            updateLanguageLevelActionsObj.UpdateLanguageLevelActions(driver, languageLevel);
            updateLanguageOptionActionsObj.UpdateLanguageOptionActions(driver, language);
        }

        [When(@"I delete an existing language")]
        public void WhenIDeleteAnExistingLanguage()
        {
            languageDeleteActionsObj.GetDeletedLanguage(driver);
            languageDeleteActionsObj.LanguageDeleteActions(driver);
        }

        [Then(@"the deleted language should not be similar to existing language")]
        public void ThenTheDeletedLanguageShouldNotBeSimilarToExistingLanguage()
        {
          
            string existingLanguage = languageDeleteActionsObj.GetExistingLanguage(driver);

            Assert.That(deletedLanguage != existingLanguage, "Language has not been deleted");
        }

        [AfterScenario]

        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
