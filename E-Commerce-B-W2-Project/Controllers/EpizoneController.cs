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
                },
                Comment = new Random().Next(50, 50000),
                Sales = new Random().Next(30, 250),
                IntPrice = 149,
                IntCents = 99,
                Consegna = DateTime.Now.AddDays(1).ToString("dddd, dd MMMM", new System.Globalization.CultureInfo("it-IT"))
            }
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
        public IActionResult Details(Guid id) {

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


    }
}
