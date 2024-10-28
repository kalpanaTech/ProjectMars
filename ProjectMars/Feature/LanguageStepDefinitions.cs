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
    public class LanguageStepDefinitions : Driver
    {
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
        
        string canceledLanguage;

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

        [Then(@"I remove (added|existing) language details")]
        public void ThenIRemoveAddedLanguageDetails(string option5)
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

        [AfterScenario]

        public void CloseTestRun()
        {
           driver.Quit();
        }

    }
}
