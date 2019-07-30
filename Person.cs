namespace RegexSampleApp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string BirthDate { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string firstName, string lastName, string age, string birthDate, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
        }
    }
}
