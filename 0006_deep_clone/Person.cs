using System.Text;

namespace _0006_deep_clone
{
    public enum ContactType
    {
        Email,
        Phone,
        Address
    }

    public class Contact
    {
        public ContactType ContactType { get; set; } = ContactType.Email;
        public string Value { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"  {ContactType} = {Value}";
        }
    }

    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public List<Contact> Contacts { get; set; } = new();

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine(Name);

            foreach (var contact in Contacts)
                sb.AppendLine(contact.ToString());

            return sb.ToString();
        }
    }
}
