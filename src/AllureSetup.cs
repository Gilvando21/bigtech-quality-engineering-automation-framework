using NUnit.Framework;
using Allure.Net.Commons;

[SetUpFixture]
public class AllureSetup
{
    [OneTimeSetUp]
    public void GlobalSetup()
    {
        Environment.SetEnvironmentVariable("ALLURE_RESULTS_DIRECTORY", "../allure-results");
    }
}