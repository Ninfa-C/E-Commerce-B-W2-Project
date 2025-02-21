using System.Xml.Linq;
using E_Commerce_B_W2_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_B_W2_Project.Controllers
{
    public class EpizoneController : Controller
    {
        private static readonly List<ProductBaseModel> productStaticList =
        [
           new ProductBaseModel()
            {
                Id= Guid.NewGuid(),
                Name= "AIR FORCE 1 '07 - Sneakers basse - white",
                Brand= "Nike Sportswear",
                Price=119.99m,
                Description="Tipo di sport: Pallacanestro\r\nPunta: Tonda\r\nTipo di tacco: Senza tacco\r\nChiusura: Lacci\r\nFantasia: Monocromo\r\nDettagli: Aperture\r\nCodice articolo: NI112N022-A11",
               ImgListModel= new List<ImgSrc>()
                {
                   new ImgSrc(){Id= Guid.NewGuid(),ImgUrl= "https://img01.ztat.net/article/spp-media-p1/553c5bd966ed3085afe815aed8fae88a/e3e7c98e73a1467a866815e8ffc1315e.jpg?imwidth=1800"},
                   new ImgSrc (){Id= Guid.NewGuid(), ImgUrl="https://img01.ztat.net/article/spp-media-p1/3beab105f6ee325d99e322e9b0e7dc7e/aaf05e38fce74b32812fd51ed9be421a.jpg?imwidth=1800"},
                },
                Comment = new Random().Next(50, 50000),
                Sales = new Random().Next(30, 250),
                IntPrice = 119,
                IntCents = 99,
                Consegna = DateTime.Now.AddDays(1).ToString("dddd, dd MMMM", new System.Globalization.CultureInfo("it-IT"))
            },
           new ProductBaseModel()
            {
                Id= Guid.NewGuid(),
                Name= "Stivali alti - black",
                Brand= "Derimond",
                Price=149.99m,
                Description="Punta: Tonda\r\nTipo di tacco: Tacco largo\r\nChiusura: Senza chiusura\r\nFantasia: Monocromo\r\nDettagli: Cerniera\r\nCodice articolo: D5H11A0C1-Q11",
               ImgListModel= new List<ImgSrc>()
                {
                   new ImgSrc(){Id= Guid.NewGuid(),ImgUrl= "https://img01.ztat.net/article/spp-media-p1/50f9d30cb5e14ced904baf38ad4136c5/6a65ead4a020452b8ed819e978f122a8.jpg?imwidth=1800&filter=packshot"},
                   new ImgSrc (){Id= Guid.NewGuid(), ImgUrl="https://img01.ztat.net/article/spp-media-p1/06aaf053f253415397bcb0ce18250c3b/fca9b9b79bd44563933689e78dcd2a6c.jpg?imwidth=1800"},
                   new ImgSrc (){Id= Guid.NewGuid(), ImgUrl="https://img01.ztat.net/article/spp-media-p1/ccb7b2ad4ca84d52862f4521b4d5cf10/d315d7d2067942d4a93c810551db1b24.jpg?imwidth=1800"},
                   new ImgSrc(){Id=Guid.NewGuid(), ImgUrl="https://img01.ztat.net/article/spp-media-p1/82fffd7131fd459883ba5895c987ff00/47b02637815d49549944d710ceba8a4a.jpg?imwidth=1800"}

                },
                Comment = new Random().Next(50, 50000),
                Sales = new Random().Next(30, 250),
                IntPrice = 149,
                IntCents = 99,
                Consegna = DateTime.Now.AddDays(1).ToString("dddd, dd MMMM", new System.Globalization.CultureInfo("it-IT"))
            },
           new ProductBaseModel()
            {
                Id= Guid.NewGuid(),
                Name= "Sandali - white",
                Brand= "Anna Field",
                Price=39.99m,
                Description="Punta: Aperta\r\nTipo di tacco: Tacco largo\r\nChiusura: Fibbia\r\nFantasia: Monocromo\r\nDettagli: Elastico interno\r\nCodice articolo: AN611A1BI-A11",
               ImgListModel= new List<ImgSrc>()
                {
                   new ImgSrc(){Id= Guid.NewGuid(),ImgUrl= "https://img01.ztat.net/article/spp-media-p1/8d6ec7fec3094965938e7189d44e67d1/e9d55851ff9a40e598e652146592b650.jpg?imwidth=1800&filter=packshot"},
                   new ImgSrc (){Id= Guid.NewGuid(), ImgUrl="https://img01.ztat.net/article/spp-media-p1/4ec3c9491f47490f9109afb0b467c37f/8ab66506a2ac4a9aa04093d55198fd50.jpg?imwidth=1800"},
                   new ImgSrc (){Id= Guid.NewGuid(), ImgUrl="https://img01.ztat.net/article/spp-media-p1/51dfe6b1212d482b82816e6a4ece5207/777ad5d9c12e495388abd013610ca715.jpg?imwidth=1800"},
                   new ImgSrc(){Id=Guid.NewGuid(), ImgUrl="https://img01.ztat.net/article/spp-media-p1/89e037ef6e354289a0f1a257baead75c/0ec0f54c510b45cd94f29d730eb4450b.jpg?imwidth=1800"}

                },
                Comment = new Random().Next(50, 50000),
                Sales = new Random().Next(30, 250),
                IntPrice = 39,
                IntCents = 99,
                Consegna = DateTime.Now.AddDays(1).ToString("dddd, dd MMMM", new System.Globalization.CultureInfo("it-IT"))
            },
                       new ProductBaseModel()
            {
                Id= Guid.NewGuid(),
                Name= "UNISEX - Stringate - black",
                Brand= "YOURTURN",
                Price=35.99m,
                Description="Punta: Tonda\r\nTipo di tacco: Tacco largo\r\nChiusura: Lacci\r\nFantasia: Monocromo\r\nCodice articolo: YO115M00B-Q11",
               ImgListModel= new List<ImgSrc>()
                {
                   new ImgSrc(){Id= Guid.NewGuid(),ImgUrl= "https://img01.ztat.net/article/spp-media-p1/8efeb57cf73241ad8a6b8c48f4e2587c/3915a4c519894dfc995f73a0fdb3406e.jpg?imwidth=1800&filter=packshot"},
                   new ImgSrc (){Id= Guid.NewGuid(), ImgUrl="https://img01.ztat.net/article/spp-media-p1/ad4565e690934d8e87c5e5246abe8077/4d3d2d01b50b48c5bafa0ed05fe9dd44.jpg?imwidth=1800"},
                   new ImgSrc (){Id= Guid.NewGuid(), ImgUrl="https://img01.ztat.net/article/spp-media-p1/2b6d5326101c4cf99c6bd49cd16ae3d2/abf4ea0eadbf401c8fc6d7f6ac57103a.jpg?imwidth=1800"},
                   new ImgSrc(){Id=Guid.NewGuid(), ImgUrl="https://img01.ztat.net/article/spp-media-p1/40602fb38cfa4bd1ae85e6cc8f5a62b4/da6e8551db604d8b8106f4df0970350d.jpg?imwidth=1800"}

                },
                Comment = new Random().Next(50, 50000),
                Sales = new Random().Next(30, 250),
                IntPrice = 35,
                IntCents = 99,
                Consegna = DateTime.Now.AddDays(1).ToString("dddd, dd MMMM", new System.Globalization.CultureInfo("it-IT"))
            },

        ];


        public IActionResult Index()
        {
            var prodList = new ProductListModel()
            {
                ProductsListModel = productStaticList
            };
            return View(prodList);
        }

        [HttpGet("Details/{id:guid}")]
        public IActionResult Details(Guid id)
        {

            var singleProd = productStaticList.FirstOrDefault(item => item.Id == id);
            if (singleProd == null)
            {
                TempData["Error"] = "Il prodotto cercato non esiste nei nostri archivi!";
                return RedirectToAction("Index");
            }

            return View(singleProd);
        }
        public IActionResult Add() { return View(); }

        [HttpPost]
        public IActionResult AddSave(ProductAddModel item)
        {

            if (!ModelState.IsValid)
            {
                return View(item);
            }
            var newProduct = new ProductBaseModel()
            {
                Id = Guid.NewGuid(),
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                Brand = item.Brand,
                ImgListModel = item.ImgListModel.Select(x => new ImgSrc
                {
                    Id = Guid.NewGuid(),
                    ImgUrl = x
                }).ToList() ?? new List<ImgSrc>(),
                Comment = new Random().Next(50, 50000),
                Sales = new Random().Next(30, 250),
                IntPrice = (int)item.Price,
                IntCents = (int)((item.Price - (int)item.Price) * 100),
                Consegna = DateTime.Now.AddDays(1).ToString("dddd, dd MMMM", new System.Globalization.CultureInfo("it-IT"))
            };

            productStaticList.Add(newProduct);

            return RedirectToAction("Index");
        }

        [HttpGet("Manage/{id:guid}")]
        public IActionResult Manage(Guid id)
        {

            var singleProd = productStaticList.FirstOrDefault(item => item.Id == id);
            if (singleProd == null)
            {
                TempData["Error"] = "Il prodotto cercato non esiste nei nostri archivi!";
                return RedirectToAction("Index");
            }

            var productDetails = new ProductDetailsModel
            {
                Id = singleProd.Id,
                Name = singleProd.Name,
                Brand = singleProd.Brand,
                Price = singleProd.Price,
                Description = singleProd.Description,
                ImgList = singleProd.ImgListModel,

            };

            return View(productDetails);
        }


        [HttpPost("Manage/Save/{id:guid}")]
        public IActionResult SaveEdit(Guid id, ProductDetailsModel item)
        {
            var singleProd = productStaticList.FirstOrDefault(item => item.Id == id);
            if (singleProd == null)
            {
                TempData["Error"] = "Il prodotto cercato non esiste nei nostri archivi!";
                return RedirectToAction("Index");
            }


            singleProd.Name = item.Name;
            singleProd.Description = item.Description;
            singleProd.Price = item.Price;
            singleProd.Brand = item.Brand;

            singleProd.ImgListModel = item.ImgListModel.Select(x => new ImgSrc
            {
                Id = Guid.NewGuid(),
                ImgUrl = x
            }).ToList() ?? new List<ImgSrc>();

            singleProd.IntPrice = (int)item.Price;
            singleProd.IntCents = (int)((item.Price - (int)item.Price) * 100);


            return RedirectToAction("Index");
        }


        [HttpGet("Epizone/Delete/{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            var singleProd = productStaticList.FirstOrDefault(item => item.Id == id);
            if (singleProd == null)
            {
                TempData["Error"] = "Il prodotto cercato non esiste nei nostri archivi!";
                return RedirectToAction("Index");
            }

            var remove = productStaticList.Remove(singleProd);
            if (!remove)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

    }
}
