using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneBook;

namespace PhoneBookTests
{
    [TestClass]
    public class PhoneBookTest
    {
        [TestMethod()]
        public void PhoneBookConstructorTest()
        {
            PhoneBook.PhoneBook phoneBook = new PhoneBook.PhoneBook();
            Assert.IsNotNull(phoneBook, "Test konstruktora");
        }

        [TestMethod()]
        public void AddNewContactTest()
        {
            PhoneBook.PhoneBook phoneBook = new PhoneBook.PhoneBook();
            Contact contact = new Contact("Rysiek", "123123123");
            phoneBook.AddContact(contact);
            Assert.IsTrue(phoneBook != null, "Dodano poprawnie kontakt");
        }

        public void AddNewContactValidationWhenContactIsTooShortOrToLongTest()
        {
            PhoneBook.PhoneBook phoneBook = new PhoneBook.PhoneBook();
            Contact contact = new Contact("Rysiek", "1231231232");
            phoneBook.AddContact(contact);
            Assert.IsFalse(contact.Number.Length < 9 || contact.Number.Length > 9, "Contact is not valid");
        }

        [TestMethod()]
        public void DisplayContactTest()
        {
            PhoneBook.PhoneBook phoneBook = new PhoneBook.PhoneBook();
            Contact contact = new Contact("Rysiek", "123123123");
            phoneBook.DisplayContact(contact.Number);
            Assert.IsNotNull(contact.Number != null, contact.Number);
        }
    }
}
