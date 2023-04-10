using LeetCodeSolutions;

namespace NUnit.Test.LeetCodeSolutions
{
    [TestFixture("()",true)]
    [TestFixture("[]", true)]
    [TestFixture("{}", true)]
    [TestFixture("()[]{}", true)]
    [TestFixture("{()[]{}}", true)]
    [TestFixture("[)", false)]
    public class ValidParentheses_Tests
    {
        private string _inputString;
        private bool _validParentheses;
        public ValidParentheses_Tests(string inputString, bool validParentheses)
        {
            _inputString = inputString;
            _validParentheses = validParentheses;

        }

        [SetUp]
        public void Setup()
        {            
        }

        [Test]
        public void Should_be_valid_for_given_input()
        {
            var result = ValidParentheses.IsValid(_inputString);

            Assert.That(result, Is.EqualTo(_validParentheses));
        }

    }
}
