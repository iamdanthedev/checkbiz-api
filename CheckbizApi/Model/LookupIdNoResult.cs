using System.Collections.Generic;

namespace CheckbizApi.Model
{
    public class LookupIdNoResult
    {
        public string ResponseCode { get; set; }
        public int Count { get; set; }
        public List<Contact> Contacts { get; set; }

        public class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Type { get; set; }
            public string Id { get; set; }
            public string Name { get; set; }
            public Geography Geography { get; set; }
            public List<ContactPoint> ContactPoints { get; set; }
        }

        public class Geography
        {
            public string Street { get; set; }
            public string HouseNumber { get; set; }
            public string Entrance { get; set; }
            public string PostCode { get; set; }
            public string PostArea { get; set; }
            public string AddressString { get; set; }
        }

        public class ContactPoint
        {
            public string Label { get; set; }
            public string Main { get; set; }
            public string Type { get; set; }
            public string Value { get; set; }
        }
    }
}