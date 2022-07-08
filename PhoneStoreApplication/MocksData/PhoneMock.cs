using PhoneStoreApplication.Models;

namespace PhoneStoreApplication.MocksData
{
    public class PhoneMock : IPhoneMock
    {
        private readonly BrandMock _brandMock = new BrandMock();

        public IEnumerable<Phone> Phones => new List<Phone>()
        {
            new Phone
            {
                PhoneNaming = "IPhone 12 Pro Max",
                PhoneBrand =  _brandMock.PhoneBrands.First(),
                Price = 12000,
                MainCamera = 24,
                RAM = 8,
                OperatingSystem = Enumerations.OperatingSystem.IOS,
                ScreenType = Enumerations.ScreenType.Retina
            },

            new Phone
            {
                PhoneNaming = "Miaomi Mi 9",
                PhoneBrand =  _brandMock.PhoneBrands.Last(),
                Price = 8000,
                MainCamera = 24,
                RAM = 8,
                OperatingSystem = Enumerations.OperatingSystem.Android,
                ScreenType = Enumerations.ScreenType.Amoled
            }
        };
    }
}
