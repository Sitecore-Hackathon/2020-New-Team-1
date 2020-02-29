﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore;
using Sitecore.Mvc.Presentation;
using SitecoreMarketplace.Project.Web.Areas.SitecoreMarketplace.Views;


namespace SitecoreMarketplace.Project.Web.Areas.SitecoreMarketplace.Controllers
{
    public class TopNavigationController : Controller
    {
        public ActionResult TopNavigation()
        {

            if (string.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
            {
                return View("TopNavigation");
            }

            var item = RenderingContext.Current.Rendering.Item;

            TopNavigationModel model = new TopNavigationModel();
            model.SearchPlaceholder = item.Fields["Search Placeholder"].Value;
            model.CtaText = item.Fields["CTA Text"].Value;
            
            return View("TopNavigation", model);
        }
    }
}