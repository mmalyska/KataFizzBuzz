using Xunit;

namespace Test
{
    public class Tests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void Given_number_return_number(int number, string expected)
        {
            var result = FizzBuzzer.Calculate(number);

            Assert.Equal(expected, result);
        }
    }

    public class FizzBuzzer
    {
        public static string Calculate(int number)
        {
            return number.ToString();
        }
    }
}
