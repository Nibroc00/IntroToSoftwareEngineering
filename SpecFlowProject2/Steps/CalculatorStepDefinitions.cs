using FluentAssertions;
using TechTalk.SpecFlow;


namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 


            _scenarioContext.Add("num1", number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _scenarioContext.Add("num2", number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic
            var n1 = _scenarioContext.Get<int>("num1");
            var n2 = _scenarioContext.Get<int>("num2");

            _scenarioContext.Add("answer", n1 + n2);
        }


        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            //TODO: implement act (action) logic
            var n1 = _scenarioContext.Get<int>("num1");
            var n2 = _scenarioContext.Get<int>("num2");

            _scenarioContext.Add("answer", n1 - n2);
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            var n1 = _scenarioContext.Get<int>("num1");
            var n2 = _scenarioContext.Get<int>("num2");

            _scenarioContext.Add("answer", n1 * n2);
        }

        [Given("the original number is (.*)")]
        public void GivenTheOriginalNumberIs(int number)
        {
            _scenarioContext.Add("answer", number);
        }


        [When(@"operation (.*) is done to the number (.*)")]
        public void WhenOperationIsDoneToTheNumber(string oper, int number)
        {
            var n1 = _scenarioContext.Get<int>("answer");
            _scenarioContext.Remove("answer");
            switch (oper)
            {
                case "+":
                    _scenarioContext.Add("answer", n1 + number);
                    break;
                case "-":
                    _scenarioContext.Add("answer", n1 - number);
                    break;
                case "*":
                    _scenarioContext.Add("answer", n1 * number);
                    break;
                case "/":
                    _scenarioContext.Add("answer", n1 / number);
                    break;
                case "%":
                    _scenarioContext.Add("answer", n1 % number);
                    break;
                default:
                    break;
            };


        }



        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            var n3 = _scenarioContext.Get<int>("answer");
            n3.Should().Be(result);

        }
    }
}
