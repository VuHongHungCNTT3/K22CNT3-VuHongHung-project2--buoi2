﻿using System.Web;
using System.Web.Mvc;

namespace K22CNT2_VuHongHung_project2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
