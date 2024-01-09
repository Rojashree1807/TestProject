using SignInLib;
namespace TestProjectOne
{
    [TestClass]
    public class SignInTest
    {
        [TestMethod]
        public void SuccessMethod()
        {
            string expResult = "valid user";
            Assert.AreEqual(expResult,SignIn.Authenticate("Sam","Sam@1256"));
        }
        [TestMethod]
        public void FailMethod()
        {
            string expResult = "invalid user credentials";
            Assert.AreEqual(expResult,SignIn.Authenticate("ravi","raj@124"));
        }
        [TestMethod]
        public void AnonymousMethod()
        {
            string expResult = "You must provide username and password";
            Assert.AreEqual(expResult,SignIn.Authenticate(null,null));
        }
    }
}