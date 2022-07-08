using Microsoft.AspNetCore.Mvc;
using PhoneStoreApplication.MocksData;

namespace PhoneStoreApplication.Controllers
{
    public class PhoneController : Controller
    {
        public readonly IPhoneMock _phoneMock;

        public PhoneController(IPhoneMock phoneMock)
        {
            _phoneMock = phoneMock;
        }

        [HttpGet]
        public IActionResult Index(){
            
            // return all mock phones
            return View(_phoneMock.Phones);
        }
    }
}

