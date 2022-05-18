
using VerifyPassword;

namespace PasswordTesting
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("solaris",false)]
        [InlineData("sol34SOL", true)]

        public void PasswordTesting(string target,bool expected)
        {
            var actual = Password.Verify(target);

            Assert.Equal(expected, actual);
        }
    }
}