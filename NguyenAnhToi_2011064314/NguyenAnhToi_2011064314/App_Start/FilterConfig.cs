﻿using System.Web;
using System.Web.Mvc;

namespace NguyenAnhToi_2011064314
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
