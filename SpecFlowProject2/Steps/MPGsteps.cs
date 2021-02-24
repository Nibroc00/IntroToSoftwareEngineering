﻿using TechTalk.SpecFlow;
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

        [Given(@"Miles driven is (.*)")]
        public void GivenMilesDrivenIs(float miles)
        {
            _scenarioContext.Add("miles", miles);
        }

        [Given(@"Gallons used is (.*)")]
        public void GivenGallonsUsedIs(float gallons)
        {
            _scenarioContext.Add("gallons", gallons);
        }

        [When(@"calc_mpg is called")]
        public void WhenCalc_MpgIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("mpg", f.calc_mpg(_scenarioContext.Get<float>("miles"), _scenarioContext.Get<float>("gallons")));
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the fuel efficiency should be (.*)")]
        public void ThenTheFuelEfficiencyShouldBe(float result)
        {
            var n1 = _scenarioContext.Get<float>("mpg");
            n1.Should().Be(result);
        }

        [Then(@"the car is a gas hog")]
        public void ThenTheCarIsAGasHog()
        {
            var n1 = _scenarioContext.Get<float>("mpg");
        }

    }
}
