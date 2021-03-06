﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace MBran.Components.Sitemap.Models
{
    [XmlRoot("urlset", Namespace = "http://www.sitemaps.org/schemas/sitemap/0.9")]
    public class SitemapXml : ISitemapXml<SiteMapXmlItem>
    {
        [XmlElement("url")]
        public List<SiteMapXmlItem> Items { get; set; }
    }
}
