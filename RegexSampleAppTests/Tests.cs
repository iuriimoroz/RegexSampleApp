using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexSampleApp;

namespace RegexSampleAppTests
{
    [TestClass]
    public class Tests
    {
        Person ValidTestPerson = new Person("Bill", "Jonson", "45", "07/08/1974", "(067)-254-4587");
        Person InvalidTestPerson = new Person("Bi11", "J0nson", "Fourty Five", "24/08/1974", "0672544587");
        [TestMethod]
        public void CheckValidPersonFirstName()
        {
            Assert.IsTrue(Regex.IsMatch(ValidTestPerson.FirstName, @"^[A-Za-z]*$"), "First name was not in correct format.");
        }
        [TestMethod]
        public void CheckInvalidPersonFirstName()
        {
            Assert.IsFalse(Regex.IsMatch(InvalidTestPerson.FirstName, @"^[A-Za-z]*$"), "First name was in correct format.");
        }
        [TestMethod]
        public void CheckValidPersonLastName()
        {
            Assert.IsTrue(Regex.IsMatch(ValidTestPerson.LastName, @"^[A-Za-z]*$"), "Last name was not in correct format.");
        }
        [TestMethod]
        public void CheckInvalidPersonLastName()
        {
            Assert.IsFalse(Regex.IsMatch(InvalidTestPerson.LastName, @"^[A-Za-z]*$"), "Last name was in correct format.");
        }
        [TestMethod]
        public void CheckValidPersonAge()
        {
            Assert.IsTrue(Regex.IsMatch(ValidTestPerson.Age, @"^[0-9]*$"), "Age was not in correct format.");
        }
        [TestMethod]
        public void CheckInvalidPersonAge()
        {
            Assert.IsFalse(Regex.IsMatch(InvalidTestPerson.Age, @"^[0-9]*$"), "Age was in correct format.");
        }
        [TestMethod]
        public void CheckValidBirthDate()
        {
            Assert.IsTrue(Regex.IsMatch(ValidTestPerson.BirthDate, @"(((0[1-9]|1[0-2])\/(0|1)[0-9]|2[0-9]|3[0-1])\/((19|20)\d\d))$"), "Birth date was not in correct format.");
        }
        [TestMethod]
        public void CheckInvalidBirthDate()
        {
            Assert.IsFalse(Regex.IsMatch(InvalidTestPerson.BirthDate, @"(((0[1-9]|1[0-2])\/(0|1)[0-9]|2[0-9]|3[0-1])\/((19|20)\d\d))$"), "Birth date in correct format.");
        }
        [TestMethod]
        public void CheckValidPhoneNumber()
        {
            Assert.IsTrue(Regex.IsMatch(ValidTestPerson.PhoneNumber, @"\(\d{3}\)- *\d{3}- *-?\d{4}"), "Phone number was not in correct format.");
        }
        [TestMethod]
        public void CheckInvalidPhoneNumber()
        {
            Assert.IsFalse(Regex.IsMatch(InvalidTestPerson.PhoneNumber, @"\(\d{3}\)- *\d{3}- *-?\d{4}"), "Phone number was in correct format.");
        }
    }
}
