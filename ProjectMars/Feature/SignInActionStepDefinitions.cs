using ProjectMars.SpecflowPages.Helpers;
using ProjectMars.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace ProjectMars.Feature
{
    [Binding]
    public class SignInActionStepDefinitions : Driver
    {
        SignIn signInPageObj = new SignIn();

        [Given(@"I logged into profile page successfully")]
        public void GivenILoggedIntoProfilePageSuccessfully()
        {
            //open the Browser
            string browser = "chrome";
            driver = InitializeDriver(browser);
            signInPageObj.LoginActions(driver);
        }

    }
}
 