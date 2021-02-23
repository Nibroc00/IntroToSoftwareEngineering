using TechTalk.SpecFlow;
using FluentAssertions;
using SharedLib;



namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class MPGsteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public MPGsteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Miles dirven is (.*)")]
        public void GivenMilesDirvenIs(int miles)
        {
            _scenarioContext.Add("miles", miles);
        }

        [Given(@"Gallons used is (.*)")]
        public void GivenGallonsUsedIs(int gallons)
        {
            _scenarioContext.Add("gallons", gallons);
        }

        [When(@"calc_mpg is called")]
        public void WhenCalc_MpgIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("mpg", calc_mpg(_scenarioContext.Get<int>(miles), _scenarioContext.Get<int>(miles)));
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the fuel efficiency should be (.*)")]
        public void ThenTheFuelEfficiencyShouldBe(int result)
        {
            var n1 = _scenarioContext.Get<int>("answer");
            n1.Should().Be(result);
        }

    }
}
