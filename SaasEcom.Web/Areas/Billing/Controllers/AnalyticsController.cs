﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaasEcom.Web.Areas.Billing.Filters;

namespace SaasEcom.Web.Areas.Billing.Controllers
{
    [Authorize(Roles = "admin")]
    [SectionFilter(Section = "analytics")]
    public class AnalyticsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}