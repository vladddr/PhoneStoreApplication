using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PhoneStoreApplication.MocksData;
using PhoneStoreApplication.ViewModel;

namespace PhoneStoreApplication.Controllers
{
    public class PhoneController : Controller
    {
        public readonly IPhoneMock _phoneMock;
        public readonly IBrandMock _brandMock;

        public PhoneController(IPhoneMock phoneMock, IBrandMock brandMock)
        {
            _phoneMock = phoneMock;
            _brandMock = brandMock;
        }

        [HttpGet]
        public IActionResult Index(string brandName){

            var viewModel = new FilteredPhonesViewModel();

            if(brandName != null)
            {
                viewModel.FilteredPhones = _phoneMock.Phones.Where(p => p.PhoneBrand.BrandName == brandName);
            }
            else
            {
                viewModel.FilteredPhones = _phoneMock.Phones;
            }

            viewModel.PhonesBrands = _brandMock.PhoneBrands.ToList().ConvertAll(b =>
            {
                return new SelectListItem()
                {
                    Text = b.BrandName.ToString(),
                    Value = b.BrandName.ToString(),
                };
            });

            // return all mock phones
            return View(viewModel);
        }
    }
}

