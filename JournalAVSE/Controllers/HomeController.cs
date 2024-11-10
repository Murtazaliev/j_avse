﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VURO.UI.Models;
using JournalNOEP_DOMAIN;

namespace VURO.UI.Controllers
{
    public class HomeController : Controller
    {



        private readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }


        public async Task<IActionResult> MyAction(string returnUrl, string Lang)
        {
            MainViewModel.Language = Lang;
            return  LocalRedirect(returnUrl);
        }

        public IActionResult Index()
        {
            MainViewModel mainViewModel = new MainViewModel()
            {
                DataInfoList = _repository.DataInfo.OrderBy(x => x.InfoPageNum)
            };
            return View(mainViewModel);
        }
        public IActionResult PartialHeader()
        {
            MainViewModel mainViewModel = new MainViewModel()
            {
                DataInfoList = _repository.DataInfo.OrderBy(x => x.InfoPageNum)
            };
            return PartialView(mainViewModel);
        }
        public IActionResult Journal(Guid? infoId)
        {
            ViewBag.InfoId = infoId;
            MainViewModel mainViewModel = new MainViewModel()
            {
                DataInfoList = _repository.DataInfo.OrderBy(x => x.InfoPageNum)
            };
            return View(mainViewModel);
        }
        public IActionResult PartialInfoPage(Guid? id)
        {
            DataInfo dataInfo = _repository.DataInfo.FirstOrDefault(x => x.Id == id);
            return View(dataInfo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
