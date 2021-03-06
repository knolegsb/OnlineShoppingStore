﻿using OnlineShoppingStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository repository;

        public NavController(IProductRepository repo)
        {
            repository = repo;
        }

        //public PartialViewResult Menu(string category = null, bool horizontalLayout = false)
        //{
        //    ViewBag.SelectedCategory = category;

        //    IEnumerable<string> categories = repository.Products.Select(x => x.Category).Distinct().OrderBy(x => x);

        //    string viewName = horizontalLayout ? "Menuhorizontal" : "Menu";
        //    return PartialView(viewName, categories);
        //}

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = repository.Products.Select(x => x.Category).Distinct().OrderBy(x => x);

            //string viewName = horizontalLayout ? "Menuhorizontal" : "Menu";
            return PartialView("FlexMenu", categories);
        }
    }
}