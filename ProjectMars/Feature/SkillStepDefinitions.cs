using NUnit.Framework;
using ProjectMars.SpecflowPages.Helpers;
using ProjectMars.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace ProjectMars.Feature
{
    [Binding]
    public class SkillStepDefinitions : Driver
    {
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

        string deletedSkill;

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

        [Then(@"I remove (added|existing) skill details")]
        public void ThenIRemoveAddedSkillDetails(string option6)
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
    }
}
