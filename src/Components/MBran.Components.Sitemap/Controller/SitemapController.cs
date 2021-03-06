﻿using MBran.Components.Sitemap.Service;
using MBran.Core;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace MBran.Components.Sitemap.Controller
{
    [RoutePrefix("")]
    public class SiteMapController : RenderMvcController
    {
        private readonly ISitemapService _siteMapService;
        private readonly IXmlSerializerService _xmlSerializer;
        public SiteMapController(ISitemapService siteMapService,
            IXmlSerializerService xmlSerializer)
        {
            _siteMapService = siteMapService;
            _xmlSerializer = xmlSerializer;
        }
        [OutputCache(NoStore = true, Duration = 3600, VaryByParam = "none")]
        public virtual ActionResult Index()
        {
            var viewModel = _siteMapService.GetSiteMap();
            return Content(_xmlSerializer.ToXmlString(viewModel), "text/xml");
        }
    }
}
