using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models.Catalog;
using LibraryData;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class CatalogController : Controller
    {
        private ILibraryAssests _assests;
        public CatalogController(ILibraryAssests assests)
        {
            _assests = assests;
        }

        public IActionResult Index()
        {
            var assetModel = _assests.GetAll();

            var listingResult = assetModel.
                Select(result => new AssetIndexListingModel
                {
                    Id = result.Id,
                    Title = result.Title,
                    ImageUrl = result.ImageUrl,
                    AuthorOrDirectory = _assests.GetAuthorOrDirector(result.Id),
                    DeweyCallNumber = _assests.GetDeweyIndex(result.Id),
                    Type = _assests.GetType(result.Id)
                }).ToList();

            var model = new AssetIndexModel
            {
                Assets = listingResult
            };
            return View(model);
        }
    }
}
