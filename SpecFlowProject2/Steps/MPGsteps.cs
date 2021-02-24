using TechTalk.SpecFlow;
using FluentAssertions;
using SharedLib;



namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class MPGsteps
    {

        FuelEfficiency f = new FuelEfficiency();
        Tracker t = new Tracker();

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
            
            _scenarioContext.Add("mpg", f.calc_mpg(_scenarioContext.Get<float>("miles"), _scenarioContext.Get<float>("gallons")));
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the fuel efficiency should be (.*)")]
        public void ThenTheFuelEfficiencyShouldBe(float result)
        {
            var n1 = _scenarioContext.Get<float>("mpg");
            n1.Should().Be(result);
        }

//------GasHog---------------------------------------------------------------------------------------

        [Then(@"the car is a gas hog")]
        public void ThenTheCarIsAGasHog()
        {
            var n1 = _scenarioContext.Get<float>("mpg");
        }


//------Tracker-------------------------------------------------------------------------------------------

        [Given(@"we add (.*) miles")]
        public void GivenWeAddMiles(float given)
        {
            t.add_miles(given);
        }

        [Given(@"we add (.*) gallons")]
        public void GivenWeAddGallons(float given)
        {
            t.add_gallons(given);
        }

        [When(@"get_miles is called")]
        public void WhenGet_MilesIsCalled()
        {
            _scenarioContext.Add("miles", t.get_miles());
        }

        [When(@"get_gallons is called")]
        public void WhenGet_GallonsIsCalled()
        {
            _scenarioContext.Add("gallons", t.get_gallons());
        }

    //------Question----------------------------------------------------------------------------------

        [Then(@"miles is (.*) and gallons is (.*)")]
        public void ThenMilesIsAndGallonsIs(float m, float g)
        {
            var n1 = _scenarioContext.Get<float>("miles");
            var n2 = _scenarioContext.Get<float>("gallons");
            n1.Should().Be(m);
            n1.Should().Be(g);
        }

    //------End Question----------------------------------------------------------------------------------

        [Then(@"miles is (.*)")]
        public void ThenMilesIs(float m)
        {
            var n1 = _scenarioContext.Get<float>("miles");
            n1.Should().Be(m);
        }

        [Then(@"gallons is (.*)")]
        public void ThenGallonsIs(float g)
        {
            var n1 = _scenarioContext.Get<float>("gallons");
            n1.Should().Be(g);

        }



    }
}
