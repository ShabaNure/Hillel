using LK22;

namespace StringManipulatorTests
{

    public class StringManipulatorTest
    {
        StringManipulator stringManipulator = new StringManipulator();
        [Fact]
        public void ConcatenateStringsTest()
        {
            var result = stringManipulator.ConcatenateStrings("FirstStr", "SecondStr");
            Assert.Equal("FirstStrSecondStr", result);
        }
        [Fact]
        public void GetStringLengthTest() 
        {
            var result = stringManipulator.GetStringLength("StrLenght");
            Assert.Equal(9, result);
        }
        [Fact]
        public void ReverseStringTest() 
        {
            var result = stringManipulator.ReverseString("Hello");
            Assert.Equal("olleH", result);
        }
        [Fact]
        public void IsPalindromeTest()
        {
            var result = stringManipulator.IsPalindrome("level");
            Assert.True(result);
        }
    }
}