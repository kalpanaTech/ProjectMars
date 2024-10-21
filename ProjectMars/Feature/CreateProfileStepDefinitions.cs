using ProjectMars.SpecflowPages.Helpers;
using ProjectMars.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace ProjectMars.Feature
{
    [Binding]
    public class CreateProfileStepDefinitions : Driver
    {
        CreateProfile createProfileActionsObj = new CreateProfile();


        //User create profile
        [Given(@"I provide '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)' and '([^']*)' on Service Listning page")]
        public void GivenIProvideAndOnServiceListningPage(string title, string description, string tags, string serviceType, string locationType, string skillTrade, string skillExchange, string endDate, string activeStatus)
        {
            createProfileActionsObj.CreateProfileActions(driver, title, description, tags, serviceType, locationType, skillTrade, skillExchange, endDate, activeStatus);
        }

    }
}
