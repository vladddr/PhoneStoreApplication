using PhoneStoreApplication.Enumerations;
using OperatingSystem = PhoneStoreApplication.Enumerations.OperatingSystem;

namespace PhoneStoreApplication.Models
{
    public class Phone
    {
        public string PhoneNaming { get; set; }

        public OperatingSystem OperatingSystem { get; set; }

        public decimal Price { get; set; }

        public ScreenType ScreenType { get; set; }

        public short RAM { get; set; }

        public short MainCamera { get; set; }

        public string ImageUrl { get; set; }

        public PhoneBrand PhoneBrand { get; set; }
    }
}
