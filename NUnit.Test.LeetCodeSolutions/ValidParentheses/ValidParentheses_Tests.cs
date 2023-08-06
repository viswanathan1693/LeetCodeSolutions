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
        private bool _valid;
        public ValidParentheses_Tests(string inputString, bool valid)
        {
            _inputString = inputString;
            _valid = valid;

        }

        [SetUp]
        public void Setup()
        {            
        }

        [Test]
        public void Should_be_valid_for_given_input()
        {
            var result = ValidParentheses.IsValid(_inputString);

            Assert.That(result, Is.EqualTo(_valid));
        }

    }
}
