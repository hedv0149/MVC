using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GiftForExam.Models;

namespace GiftForExam.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            GiftREPO giftREPO = new GiftREPO();
            List<Gift> allGifts = giftREPO.GetAll();
            return View(allGifts);
        }
          //this is a coment becouse github is stuppppid 
          //plz githuuuub 
        [HttpGet]
        public IActionResult GirlGift()
        {
            GiftREPO giftREPO = new GiftREPO();
            List<Gift> girlGifts = giftREPO.GetGirlGiftList();
            return View(girlGifts);
        }


        [HttpGet]
        public IActionResult Create()
        {
            GiftModels giftModels = new GiftModels();

            return View(giftModels);
        }

        [HttpPost]
        public IActionResult Create([FromForm] GiftModels gift)
        {
            if (ModelState.IsValid)
            {
                GiftREPO giftREPO = new GiftREPO();
                giftREPO.AddGift(gift);
            }
            return RedirectToAction("Index");
        }
       
    }
}
