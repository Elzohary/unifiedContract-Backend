using System;

namespace UnifiedContract.Domain.ValueObjects
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string FormattedAddress { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public Address() { }

        public Address(string street, string city, string state, string postalCode, string country)
        {
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
            FormattedAddress = $"{street}, {city}, {state} {postalCode}, {country}";
        }

        public override string ToString()
        {
            return FormattedAddress;
        }
    }
} 